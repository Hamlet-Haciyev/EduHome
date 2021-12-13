using Eduhome.Data;
using Eduhome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class TeacherController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TeacherController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            VmTeacher vmTeacher = new VmTeacher();
            vmTeacher.Teachers = _appDbContext.Teachers.ToList();
            vmTeacher.Teacher_Socials = _appDbContext.Teacher_Socials.ToList();
            vmTeacher.TeacherToSocials = _appDbContext.TeacherToSocials.ToList();
            return View(vmTeacher);
        }
    }
}
