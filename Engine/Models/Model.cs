using System;

namespace Engine.Models
{
    public class Model
    {
        public Types TypeID { get; }
        public string Name { get; }
        public virtual string Description { get; protected set; }

        public Model(Types typeID, string name, string description )
        {
            TypeID = typeID;
            Name = name;
            Description = description;
        }

    }
}
