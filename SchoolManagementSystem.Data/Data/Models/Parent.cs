using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Models
{
    public class Parent
    {
        public int Id { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
