using Eduhome.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.ViewModel
{
    public class VmTeacher
    {
        public List<Teacher> Teachers { get; set; }
        public List<Teacher_Social> Teacher_Socials { get; set; }
        public List<TeacherToSocial> TeacherToSocials { get; set; }

    }
}
