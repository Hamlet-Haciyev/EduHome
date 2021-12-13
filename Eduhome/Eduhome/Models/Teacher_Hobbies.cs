using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Eduhome.Models
{
    public class Teacher_Hobbie
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Hobbie")]
        public int Hobbie_Id { get; set; }
        public Hobbie Hobbie { get; set; }

        [ForeignKey("Teacher")]
        public int Teacher_Id { get; set; }
        public Teacher Teacher { get; set; }

    }
}
