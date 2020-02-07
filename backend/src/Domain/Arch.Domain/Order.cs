using System.Collections.Generic;
using Arch.Domain.Core;

namespace Arch.Domain
{
    public class Order: Entity
    {
        ICollection<OrderItem> OrderItems {get;set;}
    }
}