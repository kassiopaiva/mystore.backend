using System;

namespace MyStore.Core
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; } = Guid.NewGuid();
        public DateTime CreationDate { get; protected set; } = DateTime.UtcNow;
        public bool Deleted { get; protected set; } = false;

        public abstract bool Valid();
    }
}
