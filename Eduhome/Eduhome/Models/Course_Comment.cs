using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Course_Comment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(50)]
        public string Subject { get; set; }
        [MaxLength(4000)]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("Course")]
        public int Course_Id { get; set; }
        public Course Course { get; set; }

        [ForeignKey("Course_Comment")]
        public int Comment_Id { get; set; }
        public Course_Comment Parent_Comment { get; set; }

    }
}
