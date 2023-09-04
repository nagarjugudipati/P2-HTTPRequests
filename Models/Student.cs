using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HTTPRequests.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string Name { get; set; }
        public string Class { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }

    }
}