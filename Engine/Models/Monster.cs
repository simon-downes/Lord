using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : Actor
    {

        public int RewardExperiencePoints { get; private set; }

        public Monster(TypeID typeID, string name, string description, int maxHitPoints, int rewardGold, int rewardXP) : base(typeID, name, description, maxHitPoints, rewardGold)
        {
            RewardExperiencePoints = rewardXP;
        }

        public Monster Clone()
        {
            return new Monster(TypeID, Name, Description, MaxHitPoints, Gold, RewardExperiencePoints);
        }

    }
}
