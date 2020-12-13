using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Item : Model
    {

        public int Price { get; }

        public Item(Types typeID, string name, string description, int price) : base(typeID, name, description)
        {
            Price = price;
        }

        public Item Clone()
        {
            return new Item(TypeID, Name, Description, Price);
        }

    }
}
