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
        int plr1Miss = 0;
        int plr2Miss = 0;
        int plr1Timer;
        int plr2Timer;

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
                    if (mole1 == true && plr1Enabled == true)
                    {
                        mole1 = false;
                        plr1Score++;
                    }
                    else
                    {
                        if (plr1Enabled == false)
                        {
                            plr1Miss--;
                        }
                        plr1Miss++;
                        //play the silly sound
                    }
                     break; 
                 case Keys.N:
                    if (mole0 == true && plr1Enabled == true)
                    {
                        mole0 = false;
                        plr1Score++;
                    }
                    else
                    {
                        if (plr1Enabled == false)
                        {
                            plr1Miss--;
                        }
                        plr1Miss++;
                    }
                    break; 
                 case Keys.B:
                    if (mole3 == true && plr1Enabled == true)
                    {
                        mole3 = false;
                        plr1Score++;
                    }
                    else
                    {
                        if (plr1Enabled == false)
                        {
                            plr1Miss--;
                        }
                        plr1Miss++;
                    }
                    break; 
                 case Keys.Space:
                    if (mole2 == true && plr1Enabled == true)
                    {
                        mole2 = false;
                        plr1Score++;
                    }
                    else
                    {
                        if (plr1Enabled == false)
                        {
                            plr1Miss--;
                        }
                        plr1Miss++;
                    }
                    break;
                case Keys.V:
                    if (mole0 == true && plr2Enabled == true)
                    {
                        mole0 = false;
                        plr2Score++;
                    }
                    else
                    {
                        if (plr2Enabled == false)
                        {
                            plr2Miss--;
                        }
                        plr2Miss++;
                    }
                    break;
                case Keys.C:
                    if (mole1 == true && plr2Enabled == true)
                    {
                        mole1 = false;
                        plr2Score++;
                    }
                    else
                    {
                        if (plr2Enabled == false)
                        {
                            plr2Miss--;
                        }
                        plr2Miss++;
                    }
                    break;
                case Keys.X:
                    if (mole2 == true && plr2Enabled == true)
                    {
                        mole2 = false;
                        plr2Score++;
                    }
                    else
                    {
                        if (plr2Enabled == false)
                        {
                            plr2Miss--;
                        }
                        plr2Miss++;
                    }
                    break;
                case Keys.Z:
                    if (mole3 == true && plr2Enabled == true)
                    {
                        mole3 = false;
                        plr2Score++;
                    }
                    else
                    {
                        if (plr2Enabled == false)
                        {
                            plr2Miss--;
                        }
                        plr2Miss++;
                    }
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

            label5.Text = "Player1 Score: " + plr1Score;
            label6.Text = "Player2 Score: " + plr2Score;
            label7.Text = "Player1 Misses: " + plr1Miss;
            label8.Text = "Player2 Misses: " + plr2Miss;

            plr1Timer++;
            plr2Timer++;

            if (plr1Timer >= 180)
            {
                plr1Enabled = true;
            }
            else
            {
                plr1Enabled = false;
            }
            if (plr2Timer >= 180)
            {
                plr2Enabled = true;
            }
            else
            {
                plr2Enabled = false;
            }

            if (plr1Miss >= 3)
            {
                plr1Miss = 0;
                plr1Timer = 0;
            }
            if (plr2Miss >= 3)
            {
                plr2Miss = 0;
                plr2Timer = 0;
            }
        }
    }
}
