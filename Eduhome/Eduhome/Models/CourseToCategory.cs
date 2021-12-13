using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class CourseToCategory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Course_Categories")]
        public int Category_Id { get; set; }
        public Course_Categories Course_Categories { get; set; }

        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course Course { get; set; }

    }
}
