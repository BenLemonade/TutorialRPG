﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace BasicRPG
{
    public partial class BasicRPG : Form
    {
        private Player _player;

        public BasicRPG()
        {
            InitializeComponent();

            _player = new Player(10, 10, 20, 0 ,1);

            lblHitPoints.Text = _player.CurrentHitPoints.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblExperience.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
        }
    }
}
