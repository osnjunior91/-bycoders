using System;

namespace Bycoders.Lib.Bycoders.Lib.Domain.Models
{
    public abstract class Entity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
