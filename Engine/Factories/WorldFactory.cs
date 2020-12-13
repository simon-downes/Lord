using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Engine.Models;

namespace Engine.Factories
{
    internal static class WorldFactory
    {
        internal static World Immensea()
        {

            World immensea = new World(TypeID.Immensea, "Immensea", "A world of immense possibilities");

            immensea.addLocation(0, 0, new Location(TypeID.Honeywood, "Honeywood", "A quaint little township"));
            
            immensea.addLocation(1, 0, new Location(TypeID.Forest, "Dark Forest", "Ooooh, spoooky..."));

            immensea.LocationAt(1, 0).AddEncounter(TypeID.Rat, 100);

            immensea.addLocation(0, 1, new Location(TypeID.Meadow, "Meadow", "A meadow abuzz with the sounds of nature"));

            immensea.addLocation(1, 1, new Location(TypeID.Wildlands, "The Wildlands", "A barren wasteland of tundra..."));

            immensea.addLocation(2, 1, new Location(TypeID.Mountains, "The Erie Mountains", "It's cold and there are wolves..."));

            return immensea;

        }

    }
}
