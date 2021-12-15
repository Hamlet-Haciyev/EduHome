using Eduhome.Data;
using Eduhome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "User, Moderator")]

    public class BannerController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public BannerController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            List<Banner> banners = _appDbContext.Banners.ToList();

            return View(banners);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Banner model)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Banners.Add(model);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult Update(int id)
        {

            return View(_appDbContext.Banners.Find(id));
        }

        [HttpPost]
        public IActionResult Update(Banner model)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Banners.Update(model);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            //if (id == null)
            //{
            //    HttpContext.Session.SetString("NotNullId", "It can't be null");
            //    return RedirectToAction("Index");

            //}
            Banner banner = _appDbContext.Banners.Find(id);

            //if (banner == null)
            //{
            //    HttpContext.Session.SetString("NullData", "Can not found the Data");
            //    return RedirectToAction("Index");
            //}
            _appDbContext.Remove(banner);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
