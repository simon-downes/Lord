using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class World : Model
    {

        protected Dictionary<Tuple<int, int>, WorldLocation> _locations = new Dictionary<Tuple<int, int>, WorldLocation>();

        public World(TypeID typeID, string name, string description) : base(typeID, name, description)
        {
            

        }

        internal void addLocation(int x, int y, Location location)
        {
            WorldLocation worldLocation = new WorldLocation(x, y, location);
            _locations.Add(Tuple.Create(x, y), worldLocation);
        }

        public WorldLocation LocationAt(int x, int y)
        {
            Tuple<int, int> key = Tuple.Create(x, y);

            return _locations.ContainsKey(key) ? _locations[key] : null;
        }

    }
}
