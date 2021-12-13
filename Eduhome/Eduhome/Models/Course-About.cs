using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Course_About
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(2000)]
        public string Content { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course Course { get; set; }

    }
}
