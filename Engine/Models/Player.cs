using System;
using System.Collections.Generic;
using System.Text;

namespace Engine.Models
{
    public class Player : Actor
    {
        // backing properties that allow the use of INotifyPropertyChanged and data bindings in the UI
        
        private int _level;
        private int _experiencePoints;
        private Weapon _weapon;

        public int Level
        {
            get { return _level; }
            protected set
            {
                // can't lose levels
                _level = Math.Max(_level, value);
                OnPropertyChanged(nameof(Level));
                OnPropertyChanged(nameof(Description));
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            protected set
            {
                // can't lose XP
                _experiencePoints = Math.Max(_experiencePoints, value);
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public Weapon Weapon {
            get { return _weapon; }
            set {
                _weapon = value;
                OnPropertyChanged(nameof(Weapon));
            }
        }

        public override string Description
        {
            get
            {
                // shameless ripped from Elite (obvs)
                string[] ratings = {
                    "Harmless",
                    "Mostly Harmless",
                    "Poor",
                    "Average",
                    "Above Average",
                    "Competent",
                    "Dangerous",
                    "Deadly",
                    "Elite",
                };
                
                // player rating is based on their level rounded down to the nearest 10
                int rating = (int) (Math.Floor(Level / 10.0d) * 10);

                return String.Format("Level {0} Warrior ({1})", Level, ratings[rating]);
            }
        }

        public Player(string name) : base((int) Types.Player, name, "", 10, 10)
        {
            // new Level 1 player so set base stats
            _level = 1;
            _experiencePoints = 0;
        }

    }
}
