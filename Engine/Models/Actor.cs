using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Drawing;

namespace Engine.Models
{
    abstract public class Actor : Model, INotifyPropertyChanged
    {
        // backing properties that allow the use of INotifyPropertyChanged and data bindings in the UI
        private int _currentHitPoints;
        private int _maxHitPoints;
        private int _gold;

        //public Image Image { get; protected set; }

        public int CurrentHitPoints
        {
            get { return _currentHitPoints; }
            protected set
            {
                _currentHitPoints = Math.Max(0, Math.Min(value, _maxHitPoints));
                OnPropertyChanged(nameof(CurrentHitPoints));
            }
        }

        public int MaxHitPoints
        {
            get { return _maxHitPoints; }
            protected set
            {
                _maxHitPoints = Math.Max(0, value);
                OnPropertyChanged(nameof(MaxHitPoints));
            }
        }

        public int Gold
        {
            get { return _gold; }
            protected set
            {
                _gold = Math.Max(0, value);
                OnPropertyChanged(nameof(Gold));
            }
        }
        protected Actor(TypeID typeID, string name, string description, int maxHitPoints, int gold ): base(typeID, name, description )
        {
            _currentHitPoints = maxHitPoints;
            _maxHitPoints = maxHitPoints;
            _gold = gold;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
