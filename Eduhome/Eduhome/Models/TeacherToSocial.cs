using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class TeacherToSocial
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Teacher_Social")]
        public int Teacher_Social_Id { get; set; }
        public Teacher_Social Teacher_Social { get; set; }

        [ForeignKey("Teacher")]
        public int Teacher_Id { get; set; }
        public Teacher Teacher { get; set; }

        [MaxLength(250)]
        public string Link { get; set; }
    }
}
