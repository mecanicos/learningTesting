using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Domain
{
    public class City : Entity
    {
        public string Name { get; set; }
        public State State { get; set; }
    }
}
