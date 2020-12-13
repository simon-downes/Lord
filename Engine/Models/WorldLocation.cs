using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Engine.Models
{
    public class WorldLocation
    {

        public int X { get; }
        public int Y { get; }
        public Location Location { get; }

        public Dictionary<TypeID, Encounter> Encounters { get; set; } = new Dictionary<TypeID, Encounter>();

        public WorldLocation( int x, int y, Location location)
        {
            X = x;
            Y = y;
            Location = location;
        }

        public void AddEncounter( TypeID actorTypeID, int chanceOfEncountering )
        {
            Encounters[actorTypeID] = new Encounter(actorTypeID, chanceOfEncountering);
        }

        public TypeID GetEncounter()
        {
            if( Encounters.Count == 0 )
            {
                return 0;
            }

            // total of all chances of encounters
            int totalChances = Encounters.Sum(x => x.Value.ChanceOfEncountering);

            // random number
            int randomNumber = RandomNumberGenerator.NumberBetween(1, totalChances);

            // Loop through the encounter list, 
            // adding the encounter's percentage chance of appearing to the runningTotal variable.
            // When the random number is lower than the runningTotal,
            // that is the encounter to return.
            int runningTotal = 0;

            foreach (KeyValuePair<TypeID, Encounter> item in Encounters)
            {
                runningTotal += item.Value.ChanceOfEncountering;

                if (randomNumber <= runningTotal)
                {
                    return item.Key;
                }
            }

            return Encounters.Keys.Last();

        }

    }
}
