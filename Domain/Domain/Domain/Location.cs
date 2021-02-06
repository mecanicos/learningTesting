using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class Location : Entity
    {
        public string Address { get; set; }
        public string Number { get; set; }
        public string Block { get; set; }
        public double Floor { get; set; }
        public string Stair { get; set; }
        public string Door { get; set; }
        public City City { get; set; }
    }
}
