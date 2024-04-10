using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace githubprac
{
    public partial class frmDwagon : Form
    {
        string playerName;
        string dragonName;

        public frmDwagon()
        {
            //comment from github
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text != "" && txtDragonName.Text != "")

            {

                playerName = txtPlayerName.Text;
                dragonName = txtDragonName.Text;

                rtbLog.Text = "Player Name: " + playerName +
                              "\nDragon Name: " + dragonName;

            }
            else
            {
                rtbLog.Text = "You must enter a player name and a dragon name.";
            }
        }
    }
}
