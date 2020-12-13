using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Encounter
    {
        public TypeID ActorTypeID { get; protected set; }

        public int ChanceOfEncountering { get; protected set; }

        public Encounter(TypeID actorTypeID, int chanceOfEncountering)
        {
            ActorTypeID = actorTypeID;
            ChanceOfEncountering = chanceOfEncountering;
        }
    }
}
