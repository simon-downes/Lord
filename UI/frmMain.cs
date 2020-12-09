using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;
using Engine.Models;

namespace UI
{
    public partial class frmMain : Form
    {

        private GameSession _gameSession;

        public frmMain()
        {
            InitializeComponent();

            SetActiveGameSession(new GameSession());

            lblPlayerName.DataBindings.Add("Text", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.Name));
            lblPlayerDescription.DataBindings.Add("Text", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.Description));
            lblGold.DataBindings.Add("Text", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.Gold));
            lblXP.DataBindings.Add("Text", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.ExperiencePoints));

            lblMaxHitPoints.DataBindings.Add("Text", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.MaxHitPoints));
            cpbHitPoints.DataBindings.Add("Maximum", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.MaxHitPoints));
            cpbHitPoints.DataBindings.Add("Value", _gameSession.CurrentPlayer, nameof(_gameSession.CurrentPlayer.CurrentHitPoints));

            lblWeapon.DataBindings.Add("Text", _gameSession.CurrentPlayer.Weapon, nameof(_gameSession.CurrentPlayer.Weapon.Name));


        }

        private void SetActiveGameSession( GameSession gameSession )
        {
            // clear any previous game messages
            txtMessages.Text = "";
            
            _gameSession = gameSession;
            _gameSession.LocationChanged += locationChanged;

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            _gameSession.MoveNorth();
        }

        private void btnEast_Click(object sender, EventArgs e)
        {
            _gameSession.MoveEast();
        }

        private void btnSouth_Click(object sender, EventArgs e)
        {
            _gameSession.MoveSouth();
        }

        private void btnWest_Click(object sender, EventArgs e)
        {
            _gameSession.MoveWest();
        }

        void locationChanged(object sender, EventArgs e)
        {
            lblLocationName.Text = _gameSession.CurrentLocation.Location.Name;
            lblLocationDesc.Text = _gameSession.CurrentLocation.Location.Description;

            (bool north, bool south, bool east, bool west) = _gameSession.Exits();

            btnNorth.Visible = north;
            btnSouth.Visible = south;
            btnEast.Visible = east;
            btnWest.Visible = west;
        }

    }
}
