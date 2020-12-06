using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    class Item : Model
    {

        public int Price { get; }

        public Item(int id, string name, string description, int price) : base(id, name, description)
        {
            Price = price;
        }

        public Item Clone()
        {
            return new Item(TypeId, Name, Description, Price);
        }

    }
}
