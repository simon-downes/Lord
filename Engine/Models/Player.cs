using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Engine.Models
{
    public class Player : Actor, INotifyPropertyChanged
    {
        // backing properties that allow the use of INotifyPropertyChanged and data bindings in the UI
        private int _currentHitPoints;
        private int _maxHitPoints;
        private int _level;
        private int _gold;
        private int _experiencePoints;

        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            set
            {
                _currentHitPoints = Math.Max(0, Math.Min(value, _maxHitPoints));
                OnPropertyChanged(nameof(CurrentHitPoints));
            }
        }

        public int MaxtHitPoints
        {
            get { return _maxHitPoints; }
            set
            {
                _maxHitPoints = Math.Max(0, value);
                OnPropertyChanged(nameof(MaxtHitPoints));
            }
        }

        public int Gold
        {
            get { return _gold; }
            set
            {
                _gold = Math.Max(0, value);
                OnPropertyChanged(nameof(Gold));
            }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set
            {
                // can't lose XP
                _experiencePoints = Math.Max(_experiencePoints, value);
                OnPropertyChanged(nameof(ExperiencePoints));
            }
        }

        public int Level
        {
            get { return _level; }
            set
            {
                // can't lose levels
                _level = Math.Max(_level, value);
                OnPropertyChanged(nameof(Level));
                OnPropertyChanged(nameof(Description));
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

        public Player(string name) : base((int) Types.Player, name, "")
        {
            // new Level 1 player so set base stats
            Level = 1;
            ExperiencePoints = 0;
            MaxtHitPoints = 10;
            Gold = 10;

            // full health to start with
            CurrentHitPoints = MaxtHitPoints;

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
