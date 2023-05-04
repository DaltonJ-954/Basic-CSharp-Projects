using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NBA.Greats.Models
{
    public class PlayerBio
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string DateOfBirth { get; set; }
        public int Age { get; set; }
        public string College { get; set; }
        public string? BirthPlace { get; set; }
    }
}
