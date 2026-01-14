using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Models.Common
{
    public class PhoneNumber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Number { get; set; } = null!;


        [ForeignKey(nameof(School))]
        public int SchoolId { get; set; }
        public School School { get; set; } = null!;
    }
}
