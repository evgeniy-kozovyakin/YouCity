﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DProject.Models
{
    public class City
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Proposition> Propositions { get; set; }
    }
}
