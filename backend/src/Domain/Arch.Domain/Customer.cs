using System;
using Arch.Domain.Core;
using Arch.Domain.ValueObjects;

namespace Arch.Domain
{
    public class Customer: Entity
    {
        public Name Name { get; set; }
        public Address Address { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    }
}