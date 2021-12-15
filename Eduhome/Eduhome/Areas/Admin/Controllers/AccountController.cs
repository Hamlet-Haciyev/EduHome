using Eduhome.Data;
using Eduhome.Models;
using Eduhome.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager,RoleManager<IdentityRole> roleManager)
        {
            _appDbContext = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(VmRegister vmRegister)
        {
            if (ModelState.IsValid)
            {
                CustomUser customUser = new CustomUser()
                {
                     Name = vmRegister.Name,
                     Surname = vmRegister.Surname,
                     Email = vmRegister.Email,
                     UserName = vmRegister.Email,
                     CreatedDate = DateTime.Now
                };
                var result = await _userManager.CreateAsync(customUser, vmRegister.Password);

                if (result.Succeeded)
                {
                    await _signInManager.SignInAsync(customUser, false);
                    return RedirectToAction("Index", "Banner");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                    return View(vmRegister);
                }
            }
            return View(vmRegister);
        }
        [AllowAnonymous]
        public  IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public  async Task<IActionResult> Login(VmRegister vmRegister)
        {
            var result = await _signInManager.PasswordSignInAsync(vmRegister.Email,vmRegister.Password,false,false);

            if (ModelState.IsValid)
            {
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Banner");
                }
                else
                {
                    ModelState.AddModelError("", "Username or password is not correct");
                    return View(vmRegister);

                }
            }

            return View(vmRegister);
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }

        public IActionResult Users()
        {
            VmUser vmUser = new VmUser();
            vmUser.CustomUsers = _appDbContext.CustomUsers.ToList();
            vmUser.Roles = _appDbContext.Roles.ToList();
            vmUser.UserRoles = _appDbContext.UserRoles.ToList();

            return View(vmUser);
        }
        public IActionResult UpdateUser(string id)
        {
            CustomUser user = _appDbContext.CustomUsers.Find(id);
            ViewBag.Roles = _appDbContext.Roles.ToList();
            return View(user);
        }
        [HttpPost]
        public async Task<IActionResult> UpdateUser(CustomUser customUser)
        {
            if (ModelState.IsValid)
            {
                CustomUser User1 = _appDbContext.CustomUsers.Find(customUser.Id);
                User1.Name = customUser.Name;
                User1.Surname = customUser.Surname;

                IdentityUserRole<string> userRole = _appDbContext.UserRoles.FirstOrDefault(u => u.UserId == customUser.Id);

                if (userRole!=null)
                {
                    string oldRole = _appDbContext.Roles.Find(userRole.RoleId).Name;
                    await _userManager.RemoveFromRoleAsync(User1, oldRole);
                }

                IdentityRole identityRole = _appDbContext.Roles.Find(customUser.RoleId);

                await _userManager.AddToRoleAsync(User1, identityRole.Name);
                _appDbContext.SaveChanges();
                return RedirectToAction("Users");
            }
            return View(customUser);
        }
        public IActionResult Roles()
        {
            List<IdentityRole> roles = _appDbContext.Roles.ToList();
            return View(roles);
        }
        public IActionResult RoleCreate()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> RoleCreate(IdentityRole model)
        {
            await _roleManager.CreateAsync(model);
            return RedirectToAction("Roles");
        }

    }
}
