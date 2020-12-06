using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class WorldLocation
    {

        public int X { get; }
        public int Y { get; }
        public Location Location { get; }

        public WorldLocation( int x, int y, Location location)
        {
            X = x;
            Y = y;
            Location = location;
        }

    }
}
