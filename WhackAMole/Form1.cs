using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhackAMole
{
    public partial class Form1 : Form
    {
        //Variables
        int mole;
        int moleChance = 60;
        int moleSpot;
        int plr1Score;
        int plr2Score;

        Random rndNum = new Random();

        public Form1()
        {
            InitializeComponent();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            mole = rndNum.Next(0, moleChance);
            if (mole == 1)
            {
                moleSpot = rndNum.Next(0, 4);
                SpawnMole(moleSpot);
            }
        }
        public void SpawnMole(int moleSpot)
        {
            switch (moleSpot)
            {
                case 0:
                    MolePop(0);
                    break;
                case 1:
                    MolePop(1);
                    break;
                case 2:
                    MolePop(2);
                    break;
                case 3:
                    MolePop(3);
                    break;
            }
        }
        public void MolePop(int moleValue)
        {
            switch (moleValue)
            {

            }
        }
    }
}
