﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontaktbuch
{
    internal class Kontakt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Email {get; set; }

        public override string ToString()
        {
            return $"{Name} {LastName} - {Phone} - {Email};";
        }
    }
}
