using System;

namespace Core.Entities
{
    public abstract class  BaseEntity
    {
        public Guid Id { get; set; }

        public string PartitionKey { get; set; }
    }
}