using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<CourseToCategory> CourseToCategory { get; set; }
        public List<CourseToTag> CourseToTag { get; set; }

        public List<Course_About> Course_About { get; set; }
        public List<Course_Comment> Course_Comment { get; set; }
        public List<Features> Features { get; set; }



    }
}
