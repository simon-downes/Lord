using System;

namespace Engine.Models
{
    public class Model
    {
        public TypeID TypeID { get; }
        public string Name { get; }
        public virtual string Description { get; protected set; }

        public Model(TypeID typeID, string name, string description )
        {
            TypeID = typeID;
            Name = name;
            Description = description;
        }

    }
}
