using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Features
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartsDate { get; set; }
        public DateTime Duration { get; set; }
        public DateTime ClassDuration { get; set; }
        [MaxLength(20)]
        public string SkillLevel { get; set; }
        [MaxLength(20)]
        public string Language { get; set; }
        public int Student_Count { get; set; }
        [MaxLength(15)]
        public string Assesments { get; set; }
        public int Course_Price { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course Course { get; set; }
    }
}
