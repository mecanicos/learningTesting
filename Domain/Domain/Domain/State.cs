using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class State : Entity
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public Country Country { get; set; }
    }
}
