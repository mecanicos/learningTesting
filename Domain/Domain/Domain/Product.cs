using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public decimal UnitPrice { get; set; }
        public Commerce Commerce { get; set; }
    }
}
