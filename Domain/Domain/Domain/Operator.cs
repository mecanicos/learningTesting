using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public abstract class Operator : Entity
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
    }
}
