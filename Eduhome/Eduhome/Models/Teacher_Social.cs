using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Teacher_Social
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
       
        [MaxLength(30)]
        public string Icon { get; set; }
        public List<TeacherToSocial> TeacherToSocials { get; set; }
    }
}
