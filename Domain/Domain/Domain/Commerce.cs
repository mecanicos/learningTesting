using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class Commerce : Operator
    {
        public string Description { get; set; }
        public string Nif { get; set; }
        public string Telepone { get; set; }
        public Location Location { get; set; }
    }
}
