using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Teacher_Skill
    {
        [Key]
        public int Id { get; set; }
        public byte Percent { get; set; }

        [ForeignKey("Skill")]
        public int Skill_Id { get; set; }
        public Skill Skill { get; set; }

        [ForeignKey("Teacher")]
        public int Teacher_Id { get; set; }
        public Teacher Teacher { get; set; }
    }
}
