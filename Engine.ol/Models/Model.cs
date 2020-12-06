using System;

namespace Engine.Models
{
    public class Model
    {
        public int TypeId { get; }
        public string Name { get; }
        public virtual string Description { get; protected set; }

        public Model( int typeId, string name, string description )
        {
            TypeId = typeId;
            Name = name;
            Description = description;
        }

    }
}
