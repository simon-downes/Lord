using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Encounter
    {
        public int ActorTypeID { get; set; }
        public int ChanceOfEncountering { get; set; }

        public Encounter(int actorTypeID, int chanceOfEncountering)
        {
            ActorTypeID = actorTypeID;
            ChanceOfEncountering = chanceOfEncountering;
        }
    }
}
