using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Engine.Models
{
    public class Location : Model
    {

        public Image Image{ get; }

        public Location(Types typeID, string name, string description, Image img = null) : base(typeID, name, description)
        {
            Image = img;
        }

    }
}
