using Arch.Domain.Core;

namespace Arch.Domain
{
    public class OrderItem: Entity
    {
        public Product Product { get; set; }
        public double Amount { get; set; }
    }
}