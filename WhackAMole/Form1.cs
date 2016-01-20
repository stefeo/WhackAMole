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
        int moleVariation;
        int plr1Score;
        int plr2Score;
        int moleAmount;
        int plr1Miss;
        int plr2Miss;

        bool mole0 = false;
        bool mole1 = false;
        bool mole2 = false;
        bool mole3 = false;
        bool plr1Enabled = true;
        bool plr2Enabled = true;

        Random rndNum = new Random();

        public Form1()
        {
            InitializeComponent();
            gameTimer.Start();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        { 
             //check to see if a key is pressed and set is KeyDown value to true if it has 
             switch (e.KeyCode) 
             { 
                 case Keys.M:
                    if (mole1 == true)
                    {
                        mole1 = false;
                        plr1Score++;
                    }
                    else
                    {
                        plr1Miss++;
                    }
                     break; 
                 case Keys.N:
                    if (mole0 == true)
                    {
                        mole0 = false;
                        plr1Score++;
                    }
                    else
                    {
                        plr1Miss++;
                    }
                    break; 
                 case Keys.B:
                    if (mole3 == true)
                    {
                        mole3 = false;
                        plr1Score++;
                    }
                    else
                    {
                        plr1Miss++;
                    }
                    break; 
                 case Keys.Space:
                    if (mole2 == true)
                    {
                        mole2 = false;
                        plr1Score++;
                    }
                    else
                    {
                        plr1Miss++;
                    }
                    break;
                case Keys.V:
                    break;
                case Keys.C:
                    break;
                case Keys.X:
                    break;
                case Keys.Z:
                    break;
                 default: 
                     break; 
             }  
 
         }


        public void SpawnMole(int moleSpot)
        {
            switch (moleSpot)
            {
                case 0:
                    if (mole0 == false)
                    {
                        label1.BackColor = Color.Red;
                        mole0 = true;
                        //spawn mole in place 0
                    }
                    break;
                case 1:
                    if (mole1 == false)
                    {
                        label2.BackColor = Color.Red;
                        mole1 = true;
                        //spawn mole in place 1
                    }
                    break;
                case 2:
                    if (mole2 == false)
                    {
                        label3.BackColor = Color.Red;
                        mole2 = true;
                        //spawn mole in place 2
                    }
                    break;
                case 3:
                    if (mole3 == false)
                    {
                        label4.BackColor = Color.Red;
                        mole3 = true;
                        //spawn mole in place 3
                    }
                    break;
            }
        }
        public void SpawnMole2(int moleSpot, int moleVariation)
        {
            SpawnMole(moleSpot);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mole0 == false)
            {
                label1.BackColor = Color.Black;
            }
            if (mole1 == false)
            {
                label2.BackColor = Color.Black;
            }
            if (mole2 == false)
            {
                label3.BackColor = Color.Black;
            }
            if (mole3 == false)
            {
                label4.BackColor = Color.Black;
            }
            mole = rndNum.Next(0, moleChance);
            if (mole == 1)
            {
                moleAmount++;
                moleSpot = rndNum.Next(0, 5);
                SpawnMole(moleSpot);
            }
            if (mole == 2)
            {
                moleAmount += 2;
                moleSpot = rndNum.Next(0, 4);
                moleVariation = rndNum.Next(0, 3);

            }
        }
    }
}
