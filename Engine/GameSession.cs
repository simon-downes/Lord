using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

using Engine.Factories;
using Engine.Models;

namespace Engine
{
    public class GameSession
    {

        private WorldLocation _currentLocation;

        public World CurrentWorld { get; }

        public Player CurrentPlayer { get; }

        public WorldLocation CurrentLocation {
            get { return _currentLocation; }
            private set
            {
                _currentLocation = value;
                OnLocationChanged();
            }
        }

        public GameSession(): this(new Player("Commander Jameson"))
        {

        }

        public GameSession( Player player )
        {
            CurrentWorld = WorldFactory.Immensea();
            CurrentPlayer = player;
            CurrentLocation = CurrentWorld.LocationAt(0, 0);
        }

        public Tuple<bool, bool, bool, bool> Exits()
        {
            // return a tuple expression which directions the player can travel from the current location
            return Tuple.Create(
                CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y + 1) != null, // north
                CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y - 1) != null, // south
                CurrentWorld.LocationAt(CurrentLocation.X + 1, CurrentLocation.Y) != null, // east
                CurrentWorld.LocationAt(CurrentLocation.X - 1, CurrentLocation.Y) != null  // west
            );
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y + 1);
        }

        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X, CurrentLocation.Y - 1);
        }

        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X + 1, CurrentLocation.Y);
        }

        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.X - 1, CurrentLocation.Y);
        }

        public event EventHandler LocationChanged;

        protected virtual void OnLocationChanged()
        {
            EventHandler handler = LocationChanged;
            handler?.Invoke(this, null);
        }

    }
}
