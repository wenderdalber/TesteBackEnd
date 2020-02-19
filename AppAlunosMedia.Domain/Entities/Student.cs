using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AppAlunosMedia.Domain.Entities
{
    public class Student
    {
        [Key]
        public int RA { get; set; }
        public string Name { get; set; }
        public string Period { get; set; }
        public string Course { get; set; }
        public int Note { get; set; }
        public string Status { get; set; }
    }
}
