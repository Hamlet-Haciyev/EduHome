using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseToTag
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Course_Tag")]
        public int Tag_Id { get; set; }
        public Course_Tag Course_Tag { get; set; }

        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course Course { get; set; }
    }
}
