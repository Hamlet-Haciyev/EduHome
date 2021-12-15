using Eduhome.Data;
using Eduhome.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles ="Admin, Moderator")]
    public class TeacherController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeacherController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Teacher> Teachers = _appDbContext.Teachers.OrderByDescending(t=>t.Id)
                .Include(t => t.Teacher_Hobbies).ThenInclude(h => h.Hobbie).ToList();

            return View(Teachers);
        }
        public IActionResult Create()
        {
            List<Hobbie> Hobbies = _appDbContext.Hobbies.ToList();
                
            ViewBag.Hobbies = Hobbies;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                if (teacher.ImageFile.ContentType == "image/jpeg" || teacher.ImageFile.ContentType == "image/png")
                {
                    if (teacher.ImageFile.Length <= 2097152)
                    {
                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + teacher.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            teacher.ImageFile.CopyTo(stream);
                        }
                        teacher.Image = fileName;

                        _appDbContext.Teachers.Add(teacher);
                        _appDbContext.SaveChanges();

                        if (teacher.Teacher_Hobbies_Id != null && teacher.Teacher_Hobbies_Id.Count > 0)
                        {
                            foreach (var item in teacher.Teacher_Hobbies_Id)
                            {
                                Teacher_Hobbie teacher_Hobbie = new Teacher_Hobbie();
                                teacher_Hobbie.Hobbie_Id = item;
                                teacher_Hobbie.Teacher_Id = teacher.Id;

                                _appDbContext.Teacher_Hobbies.Add(teacher_Hobbie);
                                _appDbContext.SaveChanges();
                            }
                        }


                        return RedirectToAction("Index");

                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only less than 2 mb.");
                        return View(teacher);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                    return View(teacher);
                }
            }
            return View(teacher);
        }

        public IActionResult Update(int? id)
        {
            Teacher teacher = _appDbContext.Teachers.Include(t=>t.Teacher_Hobbies).ThenInclude(th=>th.Hobbie).FirstOrDefault(t => t.Id == id);
            teacher.Teacher_Hobbies_Id = _appDbContext.Teacher_Hobbies.Where(th => th.Teacher_Id == id).Select(h => h.Hobbie_Id).ToList();
            ViewBag.Hobbies = _appDbContext.Hobbies.ToList();
            return View(teacher);
        }
        [HttpPost]
        public IActionResult Update(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                if (teacher.ImageFile != null)
                {
                    if (teacher.ImageFile.ContentType == "image/jpeg" || teacher.ImageFile.ContentType == "image/png")
                    {
                        if (teacher.ImageFile.Length <= 2097152)
                        {
                            if (!string.IsNullOrEmpty(teacher.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", teacher.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmss") + "-" + teacher.ImageFile.FileName;
                            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                            using (var stream = new FileStream(filePath, FileMode.Create))
                            {
                                teacher.ImageFile.CopyTo(stream);
                            }
                            teacher.Image = fileName;
                       
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2 mb.");
                            ViewBag.Hobbies = _appDbContext.Hobbies.ToList();
                            return View(teacher);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg, .jpg and .png");
                        ViewBag.Hobbies = _appDbContext.Hobbies.ToList();
                        return View(teacher);
                    }
                }


                _appDbContext.Teachers.Update(teacher);
                _appDbContext.SaveChanges();


                List<Teacher_Hobbie> teacher_Hobbies = _appDbContext.Teacher_Hobbies.Where(th => th.Teacher_Id == teacher.Id).ToList();

                foreach (var item in teacher_Hobbies)
                {
                    _appDbContext.Teacher_Hobbies.Remove(item);
                }
                _appDbContext.SaveChanges();

                if (teacher.Teacher_Hobbies_Id != null && teacher.Teacher_Hobbies_Id.Count > 0)
                {
                    foreach (var item in teacher.Teacher_Hobbies_Id)
                    {
                        Teacher_Hobbie teacher_Hobbie = new Teacher_Hobbie();
                        teacher_Hobbie.Hobbie_Id = item;
                        teacher_Hobbie.Teacher_Id = teacher.Id;

                        _appDbContext.Teacher_Hobbies.Add(teacher_Hobbie);
                    }
                    _appDbContext.SaveChanges();

                }


                return RedirectToAction("Index");
            }

            return View(teacher);
        }


        public IActionResult Delete(int? id)
        {
            Teacher teacher =_appDbContext.Teachers.Find(id);


            if (!string.IsNullOrEmpty(teacher.Image))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", teacher.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }


            _appDbContext.Teachers.Remove(teacher);
            _appDbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
