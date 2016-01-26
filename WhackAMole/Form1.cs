using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace WhackAMole
{
    public partial class Form1 : Form
    {

        //variables
        #region
        //Variables
        //sounds
        SoundPlayer hit = new SoundPlayer(Properties.Resources.smw_kick);
        SoundPlayer hit1 = new SoundPlayer(Properties.Resources.smw_stomp);
        SoundPlayer miss = new SoundPlayer(Properties.Resources.smw_stomp_koopa_kid);
        SoundPlayer intro = new SoundPlayer(Properties.Resources.smw_course_clear);
        SoundPlayer end = new SoundPlayer(Properties.Resources.smb3_game_over__1_);
        //ints
        int counter;
        int mole;
        int moleChance = 15;
        int moleSpot;
        int plr1Score;
        int plr2Score;
        int plr1Miss = 0;
        int plr2Miss = 0;
        int plr1Timer = 120;
        int plr2Timer = 120;
        int countdownTimer = 0;
        int endGameCounter;
        int moleAnimationCounter;
        int moleAnimationCounter1;
        int moleAnimationCounter2;
        int moleAnimationCounter3;
        //bools
        bool mole0 = false;
        bool mole1 = false;
        bool mole2 = false;
        bool mole3 = false;
        bool plr1Enabled = true;
        bool plr2Enabled = true;
        //sizes with their corresponing locations for the game start animation
        Size size1 = new Size(900, 1500);
        Point location1 = new Point(57, -510);
        Size size2 = new Size(810, 1350);
        Point location2 = new Point(102, -435);
        Size size3 = new Size(720, 1200);
        Point location3 = new Point(147, -360);
        Size size4 = new Size(630, 1050);
        Point location4 = new Point(192, -285);
        Size size5 = new Size(540, 900);
        Point location5 = new Point(237, -210);
        Size size6 = new Size(450, 750);
        Point location6 = new Point(282, -135);
        Size size7 = new Size(360, 600);
        Point location7 = new Point(327, -60);
        Size size8 = new Size(270, 450);
        Point location8 = new Point(372, 15);
        Size size9 = new Size(180, 300);
        Point location9 = new Point(417, 90);
        Size size10 = new Size(90, 150);
        Point location10 = new Point(462, 165);

        Point endGameLocation0 = new Point(12, 404);
        Point endGameLocation1 = new Point(12, 402);
        Point endGameLocation2 = new Point(641, 404);
        Point endGameLocation3 = new Point(641, 402);

        List<Point> endGamePoints = new List<Point>();
        List<Size> sizes = new List<Size>();
        List<Point> locations = new List<Point>();

        Random rndNum = new Random();
        #endregion

        public Form1()
        {
            Form blackBack = new Form();
            blackBack.FormBorderStyle = FormBorderStyle.None;
            blackBack.BackColor = Color.Black;
            blackBack.WindowState = FormWindowState.Maximized;
            blackBack.Show();

            intro.Play();
            InitializeComponent();
            gameTimer.Start();
            //making point list
            endGamePoints.Add(endGameLocation0);
            endGamePoints.Add(endGameLocation1);
            endGamePoints.Add(endGameLocation2);
            endGamePoints.Add(endGameLocation3);
            //making size list
            sizes.Add(size1);
            sizes.Add(size2);
            sizes.Add(size3);
            sizes.Add(size4);
            sizes.Add(size5);
            sizes.Add(size6);
            sizes.Add(size7);
            sizes.Add(size8);
            sizes.Add(size9);
            sizes.Add(size10);
            //making location list
            locations.Add(location1);
            locations.Add(location2);
            locations.Add(location3);
            locations.Add(location4);
            locations.Add(location5);
            locations.Add(location6);
            locations.Add(location7);
            locations.Add(location8);
            locations.Add(location9);
            locations.Add(location10);
        }

        private void CallCountdown()
        {
            pictureBox5.Visible = true;
            GameCountdown();
            pictureBox5.BackgroundImage = Properties.Resources.CountDown2redone;
            GameCountdown();
            pictureBox5.BackgroundImage = Properties.Resources.CountDown1redone;
            GameCountdown();
            pictureBox5.Visible = false;
            yellowMole.Visible = true;
            blueMole.Visible = true;
            greenMole.Visible = true;
            redMole.Visible = true;
        }

        private void GameCountdown()
        {
            pictureBox5.Size = sizes[0];
            pictureBox5.Location = locations[0];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[1];
            pictureBox5.Location = locations[1];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[2];
            pictureBox5.Location = locations[2];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[3];
            pictureBox5.Location = locations[3];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[4];
            pictureBox5.Location = locations[4];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[5];
            pictureBox5.Location = locations[5];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[6];
            pictureBox5.Location = locations[6];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[7];
            pictureBox5.Location = locations[7];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[8];
            pictureBox5.Location = locations[8];
            Refresh();
            Thread.Sleep(10);
            pictureBox5.Size = sizes[9];
            pictureBox5.Location = locations[9];
            Refresh();
            Thread.Sleep(910);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (endGameTimer.Enabled == true && endGameCounter >= 4)
            {
                intro.Play();
                pictureBox1.BackgroundImage = Properties.Resources.Score0;
                pictureBox2.BackgroundImage = Properties.Resources.Score0;
                pictureBox3.BackgroundImage = Properties.Resources.Score0;
                pictureBox4.BackgroundImage = Properties.Resources.Score0;
                endGameTimer.Enabled = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                gameOverBox.Visible = false;
                continueBox.Visible = false;
                CallCountdown();
                plr1Score = 0;
                plr2Score = 0;
                plr1Miss = 0;
                plr2Miss = 0;
                plr1Timer = 120;
                plr2Timer = 120;
                mole0 = false;
                mole1 = false;
                mole2 = false;
                mole3 = false;
                endGameCounter = 0;
                gameTimer.Start();
            }
            else {
                //check to see if a key is pressed and set is KeyDown value to true if it has 
                switch (e.KeyCode)
                {
                    case Keys.Escape:
                        this.Close();
                        break;
                    case Keys.M:
                        if (mole1 == true && plr1Enabled == true)
                        {
                            mole1 = false;
                            plr1Score++;
                            redMole.BackgroundImage = Properties.Resources.RedHit;
                            int rando = rndNum.Next(0,2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr1Enabled == false)
                            {
                                plr1Miss--;
                            }
                            plr1Miss++;
                            miss.Play();
                            //play the silly sound
                        }
                        break;
                    case Keys.N:
                        if (mole0 == true && plr1Enabled == true)
                        {
                            mole0 = false;
                            plr1Score++;
                            yellowMole.BackgroundImage = Properties.Resources.RedHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr1Enabled == false)
                            {
                                plr1Miss--;
                            }
                            plr1Miss++;
                            miss.Play();
                        }
                        break;
                    case Keys.B:
                        if (mole3 == true && plr1Enabled == true)
                        {
                            mole3 = false;
                            plr1Score++;
                            blueMole.BackgroundImage = Properties.Resources.RedHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr1Enabled == false)
                            {
                                plr1Miss--;
                            }
                            plr1Miss++;
                            miss.Play();
                        }
                        break;
                    case Keys.Space:
                        if (mole2 == true && plr1Enabled == true)
                        {
                            mole2 = false;
                            plr1Score++;
                            greenMole.BackgroundImage = Properties.Resources.RedHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr1Enabled == false)
                            {
                                plr1Miss--;
                            }
                            plr1Miss++;
                            miss.Play();
                        }
                        break;
                    case Keys.V:
                        if (mole0 == true && plr2Enabled == true)
                        {
                            mole0 = false;
                            plr2Score++;
                            yellowMole.BackgroundImage = Properties.Resources.BlueHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr2Enabled == false)
                            {
                                plr2Miss--;
                            }
                            plr2Miss++;
                            miss.Play();
                        }
                        break;
                    case Keys.C:
                        if (mole1 == true && plr2Enabled == true)
                        {
                            mole1 = false;
                            plr2Score++;
                            redMole.BackgroundImage = Properties.Resources.BlueHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr2Enabled == false)
                            {
                                plr2Miss--;
                            }
                            plr2Miss++;
                            miss.Play();
                        }
                        break;
                    case Keys.X:
                        if (mole2 == true && plr2Enabled == true)
                        {
                            mole2 = false;
                            plr2Score++;
                            greenMole.BackgroundImage = Properties.Resources.BlueHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr2Enabled == false)
                            {
                                plr2Miss--;
                            }
                            plr2Miss++;
                            miss.Play();
                        }
                        break;
                    case Keys.Z:
                        if (mole3 == true && plr2Enabled == true)
                        {
                            mole3 = false;
                            plr2Score++;
                            blueMole.BackgroundImage = Properties.Resources.BlueHit;
                            int rando = rndNum.Next(0, 2);
                            switch (rando)
                            {
                                case 0:
                                    hit.Play();
                                    break;
                                case 1:
                                    hit1.Play();
                                    break;
                            }
                        }
                        else
                        {
                            if (plr2Enabled == false)
                            {
                                plr2Miss--;
                            }
                            plr2Miss++;
                            miss.Play();
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public void SpawnMole(int moleSpot)
        {
            switch (moleSpot)
            {
                case 0:
                    if (mole0 == false)
                    {
                        moleAnimationCounter = 0;
                        MoleUp(0);
                        mole0 = true;
                        //spawn mole in place 0
                    }
                    break;
                case 1:
                    if (mole1 == false)
                    {
                        moleAnimationCounter1 = 0;
                        MoleUp(1);
                        mole1 = true;
                        //spawn mole in place 1
                    }
                    break;
                case 2:
                    if (mole2 == false)
                    {
                        moleAnimationCounter2 = 0;
                        MoleUp(2);
                        mole2 = true;
                        //spawn mole in place 2
                    }
                    break;
                case 3:
                    if (mole3 == false)
                    {
                        moleAnimationCounter3 = 0;
                        MoleUp(3);
                        mole3 = true;
                        //spawn mole in place 3
                    }
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mole0 == true)
            {
                MoleUp(0);
            }
            if (mole1 == true)
            {
                MoleUp(1);
            }
            if (mole2 == true)
            {
                MoleUp(2);
            }
            if (mole3 == true)
            {
                MoleUp(3);
            }
            moleAnimationCounter++;
            moleAnimationCounter1++;
            moleAnimationCounter2++;
            moleAnimationCounter3++;
            counter++;
            if (plr1Enabled == false)
            {
                StunPlayer(1);
            }
            if (plr2Enabled == false)
            {
                StunPlayer(2);
            }
            if (plr1Miss == 0 && plr1Timer > 120)
            {
                plr1Misses1.Visible = false;
                plr1Misses2.Visible = false;
                plr1Misses3.Visible = false;
            }
            else if (plr1Miss == 1)
            {
                plr1Misses1.Visible = true;
            }
            else if (plr1Miss == 2)
            {
                plr1Misses1.Visible = true;
                plr1Misses2.Visible = true;
            }
            else if (plr1Miss == 3)
            {
                plr1Misses1.Visible = true;
                plr1Misses2.Visible = true;
                plr1Misses3.Visible = true;
            }
            if (plr2Miss == 0 && plr2Timer >= 120)
            {
                plr2Misses1.Visible = false;
                plr2Misses2.Visible = false;
                plr2Misses3.Visible = false;
            }
            else if (plr2Miss == 1)
            {
                plr2Misses1.Visible = true;
            }
            else if (plr2Miss == 2)
            {
                plr2Misses1.Visible = true;
                plr2Misses2.Visible = true;
            }
            else if (plr2Miss == 3)
            {
                plr2Misses1.Visible = true;
                plr2Misses2.Visible = true;
                plr2Misses3.Visible = true;
            }

            if (countdownTimer == 0)
            {
                CallCountdown();
            }
            countdownTimer++;
            if (mole0 == false)
            {
                yellowMole.BackgroundImage = null;
            }
            if (mole1 == false)
            {
                redMole.BackgroundImage = null;
            }
            if (mole2 == false)
            {
                greenMole.BackgroundImage = null;
            }
            if (mole3 == false)
            {
                blueMole.BackgroundImage = null;
            }
            mole = rndNum.Next(0, moleChance);
            if (mole == 1)
            {
                moleSpot = rndNum.Next(0, 5);
                SpawnMole(moleSpot);
            }

            plr1Timer++;
            plr2Timer++;

            if (plr1Timer >= 120)
            {
                plr1Enabled = true;
            }
            else
            {
                plr1Enabled = false;
            }
            if (plr2Timer >= 120)
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

            //ending game
            if (plr1Score + plr2Score >= 35)
            {
                EndGame();

            }

            //player Score
            //player 1
            foreach (var character in plr1Score.ToString())
            {
                switch (character)
                {
                    case '0':
                        pictureBox4.BackgroundImage = Properties.Resources.Score0;
                        break;
                    case '1':
                        pictureBox4.BackgroundImage = Properties.Resources.Score1;
                        break;
                    case '2':
                        pictureBox4.BackgroundImage = Properties.Resources.Score2;
                        break;
                    case '3':
                        pictureBox4.BackgroundImage = Properties.Resources.Score3;
                        break;
                    case '4':
                        pictureBox4.BackgroundImage = Properties.Resources.Score4;
                        break;
                    case '5':
                        pictureBox4.BackgroundImage = Properties.Resources.Score5;
                        break;
                    case '6':
                        pictureBox4.BackgroundImage = Properties.Resources.Score6;
                        break;
                    case '7':
                        pictureBox4.BackgroundImage = Properties.Resources.Score7;
                        break;
                    case '8':
                        pictureBox4.BackgroundImage = Properties.Resources.Score8;
                        break;
                    case '9':
                        pictureBox4.BackgroundImage = Properties.Resources.Score9;
                        break;
                    default:
                        break;
                }
                if (plr1Score >= 10 && plr1Score < 20)
                {
                    pictureBox3.BackgroundImage = Properties.Resources.Score1;
                }
                else if (plr1Score >= 20 && plr1Score < 30)
                {
                    pictureBox3.BackgroundImage = Properties.Resources.Score2;
                }
                else if (plr1Score >= 30)
                {
                    pictureBox3.BackgroundImage = Properties.Resources.Score3;
                }
                else
                {
                    pictureBox3.BackgroundImage = Properties.Resources.Score0;
                }

                //
                foreach (var characterp2 in plr2Score.ToString())
                {
                    switch (characterp2)
                    {
                        case '0':
                            pictureBox2.BackgroundImage = Properties.Resources.Score0;
                            break;
                        case '1':
                            pictureBox2.BackgroundImage = Properties.Resources.Score1;
                            break;
                        case '2':
                            pictureBox2.BackgroundImage = Properties.Resources.Score2;
                            break;
                        case '3':
                            pictureBox2.BackgroundImage = Properties.Resources.Score3;
                            break;
                        case '4':
                            pictureBox2.BackgroundImage = Properties.Resources.Score4;
                            break;
                        case '5':
                            pictureBox2.BackgroundImage = Properties.Resources.Score5;
                            break;
                        case '6':
                            pictureBox2.BackgroundImage = Properties.Resources.Score6;
                            break;
                        case '7':
                            pictureBox2.BackgroundImage = Properties.Resources.Score7;
                            break;
                        case '8':
                            pictureBox2.BackgroundImage = Properties.Resources.Score8;
                            break;
                        case '9':
                            pictureBox2.BackgroundImage = Properties.Resources.Score9;
                            break;
                        default:
                            break;
                    }
                    if (plr2Score >= 10 && plr2Score < 20)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Score1;
                    }
                    else if (plr2Score >= 20 && plr2Score < 30)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Score2;
                    }
                    else if (plr2Score >= 30)
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Score3;
                    }
                    else
                    {
                        pictureBox1.BackgroundImage = Properties.Resources.Score0;
                    }
                }
            }
        }

        private void EndGame()
        {
            end.Play();
            mole0 = false;
            mole1 = false;
            mole2 = false;
            mole3 = false;
            yellowMole.Visible = false;
            redMole.Visible = false;
            blueMole.Visible = false;
            greenMole.Visible = false;
            if (endGameCounter == 1)
            {
                gameTimer.Stop();
            }
            endGameCounter++;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            gameOverBox.Visible = true;
            continueBox.Visible = true;
            endGameTimer.Enabled = true;
            endGameTimer.Start();
            if (plr1Score > plr2Score)
            {
                pictureBox6.BackgroundImage = Properties.Resources.winner;
                pictureBox7.BackgroundImage = Properties.Resources.loser;
            }
            else
            {
                pictureBox6.BackgroundImage = Properties.Resources.loser;
                pictureBox7.BackgroundImage = Properties.Resources.winner;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void endGameTimer_Tick(object sender, EventArgs e)
        {
            endGameCounter++;
            if (endGameCounter % 2 == 0)
            {
                gameOverBox.Visible = true;
                continueBox.Visible = true;
                pictureBox6.Location = endGamePoints[0];
                pictureBox7.Location = endGamePoints[2];
            }
            else
            {
                gameOverBox.Visible = false;
                continueBox.Visible = false;
                pictureBox6.Location = endGamePoints[1];
                pictureBox7.Location = endGamePoints[3];
            }
        }

        private void TitleScreen()
        {
            //basically everything not visible
            //and switch background
            //and use the endgametimer to have menu animations
            //also needs instructions
        }

        private void StunPlayer(int player)
        {
            if (player == 1)
            {
                if (counter % 30 == 0)
                {
                    plr1Misses1.Visible = false;
                    plr1Misses2.Visible = false;
                    plr1Misses3.Visible = false;
                }
                else if (counter % 30 == 15)
                {
                    plr1Misses1.Visible = true;
                    plr1Misses2.Visible = true;
                    plr1Misses3.Visible = true;
                }
            }
            else
            {
                if (counter % 30 == 0)
                {
                    plr2Misses1.Visible = false;
                    plr2Misses2.Visible = false;
                    plr2Misses3.Visible = false;
                }
                else if (counter % 30 == 15)
                {
                    plr2Misses1.Visible = true;
                    plr2Misses2.Visible = true;
                    plr2Misses3.Visible = true;
                }
            }
        }

        private void MoleUp(int destination)
        {
            if (destination == 0)
            {
                if (moleAnimationCounter == 1)
                {
                    yellowMole.BackgroundImage = Properties.Resources.Diglett5;
                }
                if (moleAnimationCounter == 2)
                {
                    yellowMole.BackgroundImage = Properties.Resources.Diglett4;
                }
                if (moleAnimationCounter == 3)
                {
                    yellowMole.BackgroundImage = Properties.Resources.Diglett3;
                }
                if (moleAnimationCounter == 4)
                {
                    yellowMole.BackgroundImage = Properties.Resources.Diglett2;
                }
                if (moleAnimationCounter >= 5)
                {
                    yellowMole.BackgroundImage = Properties.Resources.Diglett;
                }
            }
            if (destination == 1)
            {
                if (moleAnimationCounter1 == 1)
                {
                    redMole.BackgroundImage = Properties.Resources.Diglett5;
                }
                if (moleAnimationCounter1 == 2)
                {
                    redMole.BackgroundImage = Properties.Resources.Diglett4;
                }
                if (moleAnimationCounter1 == 3)
                {
                    redMole.BackgroundImage = Properties.Resources.Diglett3;
                }
                if (moleAnimationCounter1 == 4)
                {
                    redMole.BackgroundImage = Properties.Resources.Diglett2;
                }
                if (moleAnimationCounter1 >= 5)
                {
                    redMole.BackgroundImage = Properties.Resources.Diglett;
                }
            }
            if (destination == 2)
            {
                if (moleAnimationCounter2 == 1)
                {
                    greenMole.BackgroundImage = Properties.Resources.Diglett5;
                }
                if (moleAnimationCounter2 == 2)
                {
                    greenMole.BackgroundImage = Properties.Resources.Diglett4;
                }
                if (moleAnimationCounter2 == 3)
                {
                    greenMole.BackgroundImage = Properties.Resources.Diglett3;
                }
                if (moleAnimationCounter2 == 4)
                {
                    greenMole.BackgroundImage = Properties.Resources.Diglett2;
                }
                if (moleAnimationCounter2 >= 5)
                {
                    greenMole.BackgroundImage = Properties.Resources.Diglett;
                }
            }
            if (destination == 3)
            {
                if (moleAnimationCounter3 == 1)
                {
                    blueMole.BackgroundImage = Properties.Resources.Diglett5;
                }
                if (moleAnimationCounter3 == 2)
                {
                    blueMole.BackgroundImage = Properties.Resources.Diglett4;
                }
                if (moleAnimationCounter3 == 3)
                {
                    blueMole.BackgroundImage = Properties.Resources.Diglett3;
                }
                if (moleAnimationCounter3 == 4)
                {
                    blueMole.BackgroundImage = Properties.Resources.Diglett2;
                }
                if (moleAnimationCounter3 >= 5)
                {
                    blueMole.BackgroundImage = Properties.Resources.Diglett;
                }
            }
        }
        }
    }
