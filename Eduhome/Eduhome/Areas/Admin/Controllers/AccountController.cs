using Eduhome.Data;
using Eduhome.Models;
using Eduhome.ViewModel;
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

        public AccountController(AppDbContext context, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _appDbContext = context;
            _userManager = userManager;
            _signInManager = signInManager;
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
        public  IActionResult Login()
        {
            return View();
        }
    }
}
