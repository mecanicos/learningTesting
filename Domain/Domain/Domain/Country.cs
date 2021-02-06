using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class Country : Entity
    {
        public string Name { get; set; }
        public string Prefix { get; set; }
        public string Code { get; set; }
    }
}
