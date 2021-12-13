using Eduhome.Data;
using Eduhome.Models;
using Eduhome.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Controllers
{
    public class TeacherDetailsController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TeacherDetailsController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            VmTeacherDetail vmTeacherDetail = new VmTeacherDetail();

            Teacher teacher = _appDbContext.Teachers.Include(o => o.TeacherToSocials)
                .Include(o => o.Teacher_Hobbies)
                .Include(o => o.Teacher_Skills)
                .FirstOrDefault(t=>t.Id==1);
            List<Skill> skills = _appDbContext.Skills.ToList();
            List<Hobbie> hobbies = _appDbContext.Hobbies.ToList();
            List<Teacher_Social> teacher_Socials = _appDbContext.Teacher_Socials.ToList();

            vmTeacherDetail.Teacher = teacher;
            vmTeacherDetail.Skills = skills;
            vmTeacherDetail.Hobbies = hobbies;
            vmTeacherDetail.Teacher_Socials = teacher_Socials;



            return View(vmTeacherDetail);
        }
    }
}
