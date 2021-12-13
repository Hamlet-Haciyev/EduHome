using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModel
{
    public class VmTeacherDetail
    {
        public List<Skill> Skills { get; set; }
        public Teacher Teacher { get; set; }
        public List<Hobbie> Hobbies { get; set; }
        public List<Teacher_Social> Teacher_Socials { get; set; }
    }
}
