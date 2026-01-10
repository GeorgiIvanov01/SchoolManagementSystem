using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Data.Models
{
    public class School
    {
        public Guid Id { get; set; }

        public required string Name { get; set; }
        public required Info ContactInfo { get; set; }

        public required SchoolType Type { get; set; }

        public required List<string> Profiles { get; set; }

    }
}
