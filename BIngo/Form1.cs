using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Media;

namespace BIngo
{
    public partial class Form1 : Form
    {
        Rectangle Card = new Rectangle(450, 40, 450, 500);
        Rectangle CardLabel = new Rectangle(450, 40, 450, 85);
        Rectangle Counterbox = new Rectangle(40, 50, 125, 125);
        Rectangle Numberbox = new Rectangle(185, 180, 225, 300);

        List<string> callednumbers = new List<string>();

        string gameState = "waiting";

        bool escapeDown = false;

        Random randgen = new Random();

        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush mintcreamBrush = new SolidBrush(Color.MintCream);
        SolidBrush lgreenBrush = new SolidBrush(Color.LightGreen);
        Pen drawPen = new Pen(Color.Black, 3);


        public Form1()
        {
            InitializeComponent();
        }

        private void GameInitalize()
        {
            gameTimer.Enabled = true;
            gameState = "running";

            titleLabel.Text = "";
            escLabel.Text = "";
            startButton.Visible = false;

            numcallOutput.Text += $"Called Numbers-------\n";

            showbuttons();

            numbergen(); 

        }

        private void showbuttons()
        {
            bingoLabel.Visible = true;

            b1Button.Visible = true;
            b2Button.Visible = true;
            b3Button.Visible = true;
            b4Button.Visible = true;
            b5Button.Visible = true;

            i1Button.Visible = true;
            i2Button.Visible = true;
            i3Button.Visible = true;
            i4Button.Visible = true;
            i5Button.Visible = true;

            n1Button.Visible = true;
            n2Button.Visible = true;
            n3Button.Visible = true;
            n4Button.Visible = true;
            n5Button.Visible = true;

            g1Button.Visible = true;
            g2Button.Visible = true;
            g3Button.Visible = true;
            g4Button.Visible = true;
            g5Button.Visible = true;

            o1Button.Visible = true;
            o2Button.Visible = true;
            o3Button.Visible = true;
            o4Button.Visible = true;
            o5Button.Visible = true;
 
        }

        private void hidebuttons()
        {
            bingoLabel.Visible = false;

            b1Button.Visible = false;
            b2Button.Visible = false;
            b3Button.Visible = false;
            b4Button.Visible = false;
            b5Button.Visible = false;

            i1Button.Visible = false;
            i2Button.Visible = false;
            i3Button.Visible = false;
            i4Button.Visible = false;
            i5Button.Visible = false;

            n1Button.Visible = false;
            n2Button.Visible = false;
            n3Button.Visible = false;
            n4Button.Visible = false;
            n5Button.Visible = false;

            g1Button.Visible = false;
            g2Button.Visible = false;
            g3Button.Visible = false;
            g4Button.Visible = false;
            g5Button.Visible = false;

            o1Button.Visible = false;
            o2Button.Visible = false;
            o3Button.Visible = false;
            o4Button.Visible = false;
            o5Button.Visible = false;

        }

        private void clearButtons()
        {
            
            b1Button.Text = "B1";
            b2Button.Text = "B2";
            b3Button.Text = "B3";
            b4Button.Text = "B4";
            b5Button.Text = "B5";

            i1Button.Text = "I1";
            i2Button.Text = "I2";
            i3Button.Text = "I3";
            i4Button.Text = "I4";
            i5Button.Text = "I5";

            n1Button.Text = "N1";
            n2Button.Text = "N2";
            n3Button.Text = "N3";
            n4Button.Text = "N4";
            n5Button.Text = "N5";

            g1Button.Text = "G1";
            g2Button.Text = "G2";
            g3Button.Text = "G3";
            g4Button.Text = "G4";
            g5Button.Text = "G5";

            o1Button.Text = "O1";
            o2Button.Text = "O2";
            o3Button.Text = "O3";
            o4Button.Text = "O4";
            o5Button.Text = "05";
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (escapeDown == true)
            {
                Thread.Sleep(2000);
                Application.Exit();
            }
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if (gameState == "waiting")
            {
                titleLabel.Text = "Bingo!";
                escLabel.Text = "press this to exit";
                timeLabel.Text = "";
                startButton.Visible = true;
                againButton.Visible = false;
                exitButton.Visible = false;
                               

            }
            else if (gameState == "running")
            {
                bingoButton.Visible = true;
                stopButton.Visible = true;
                numcallButton.Visible = true;
                timeLabel.Text = "";
                
                clearButtons();

                e.Graphics.FillRectangle(mintcreamBrush, Card);
                e.Graphics.FillRectangle(lgreenBrush, CardLabel);
                e.Graphics.FillRectangle(whiteBrush, Counterbox);
                e.Graphics.FillRectangle(whiteBrush, Numberbox);
                e.Graphics.DrawLine(drawPen, 450, 40, 450, 540);
                e.Graphics.DrawLine(drawPen, 540, 40, 540, 540);
                e.Graphics.DrawLine(drawPen, 630, 40, 630, 540);
                e.Graphics.DrawLine(drawPen, 720, 40, 720, 540);
                e.Graphics.DrawLine(drawPen, 810, 40, 810, 540);
                e.Graphics.DrawLine(drawPen, 900, 40, 900, 540);
                e.Graphics.DrawLine(drawPen, 450, 40, 900, 40);
                e.Graphics.DrawLine(drawPen, 450, 125, 900, 125);
                e.Graphics.DrawLine(drawPen, 450, 540, 900, 540);
                e.Graphics.DrawLine(drawPen, 450, 208, 900, 208);
                e.Graphics.DrawLine(drawPen, 450, 291, 900, 291);
                e.Graphics.DrawLine(drawPen, 450, 374, 900, 374);
                e.Graphics.DrawLine(drawPen, 450, 457, 900, 457);
                //e.Graphics.DrawLine(drawPen, );

            }
            else if (gameState == "ending")
            {
                e.Graphics.Clear(Color.Gainsboro);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (gameState == "waiting")
            {
                GameInitalize();
            }
        }

        private void numcallButton_Click(object sender, EventArgs e)
        {
            numbergen();
            
            
        }
        private void numbergen()
        {
            int col = 0;

            int row = randgen.Next(0, 25);


            if (callednumbers.Count() < 25)
            {
                String mystring = row.ToString();

                if (callednumbers.Contains(mystring))
                {
                    numbergen();
                }
                else
                {
                    callednumbers.Add(mystring);
                    
                    if (col == 0)
                    {
                        if (row == 0)
                        {
                            numboxLabel.Text = "B1";
                            b1Button.Enabled = true;
                        }
                        else if (row == 1)
                        {
                            numboxLabel.Text = "B2";
                            b2Button.Enabled = true;
                        }
                        else if (row == 2)
                        {
                            numboxLabel.Text = "B3";
                            b3Button.Enabled = true;
                        }
                        else if (row == 3)
                        {
                            numboxLabel.Text = "B4";
                            b4Button.Enabled = true;
                        }
                        else if (row == 4)
                        {
                            numboxLabel.Text = "B5";
                            b5Button.Enabled = true;
                        }
                        else if (row == 5)
                        {
                            numboxLabel.Text = "I1";
                            i1Button.Enabled = true;
                        }
                        else if (row == 6)
                        {
                            numboxLabel.Text = "I2";
                            i2Button.Enabled = true;
                        }
                        else if (row == 7)
                        {
                            numboxLabel.Text = "I3";
                            i3Button.Enabled = true;
                        }
                        else if (row == 8)
                        {
                            numboxLabel.Text = "I4";
                            i4Button.Enabled = true;
                        }
                        else if (row == 9)
                        {
                            numboxLabel.Text = "I5";
                            i5Button.Enabled = true;
                        }
                        else if (row == 10)
                        {
                            numboxLabel.Text = "N1";
                            n1Button.Enabled = true;
                        }
                        else if (row == 11)
                        {
                            numboxLabel.Text = "N2";
                            n2Button.Enabled = true;
                        }
                        else if (row == 12)
                        {
                            numboxLabel.Text = "N3";
                            n3Button.Enabled = true;
                        }
                        else if (row == 13)
                        {
                            numboxLabel.Text = "N4";
                            n4Button.Enabled = true;
                        }
                        else if (row == 14)
                        {
                            numboxLabel.Text = "N5";
                            n5Button.Enabled = true;
                        }
                        else if (row == 15)
                        {
                            numboxLabel.Text = "G1";
                            g1Button.Enabled = true;
                        }
                        else if (row == 16)
                        {
                            numboxLabel.Text = "G2";
                            g2Button.Enabled = true;
                        }
                        else if (row == 17)
                        {
                            numboxLabel.Text = "G3";
                            g3Button.Enabled = true;
                        }
                        else if (row == 18)
                        {
                            numboxLabel.Text = "G4";
                            g4Button.Enabled = true;
                        }
                        else if (row == 19)
                        {
                            numboxLabel.Text = "G5";
                            g5Button.Enabled = true;
                        }
                        else if (row == 20)
                        {
                            numboxLabel.Text = "O1";
                            o1Button.Enabled = true;
                        }
                        else if (row == 21)
                        {
                            numboxLabel.Text = "O2";
                            o2Button.Enabled = true;
                        }
                        else if (row == 22)
                        {
                            numboxLabel.Text = "O3";
                            o3Button.Enabled = true;
                        }
                        else if (row == 23)
                        {
                            numboxLabel.Text = "O4";
                            o4Button.Enabled = true;
                        }
                        else if (row == 24)
                        {
                            numboxLabel.Text = "O5";
                            o5Button.Enabled = true;
                        }
                        numcallOutput.Text += $"{numboxLabel.Text}, ";
                    }

           
                }
 
            }

        }


        private void b1Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            b1Button.Text = "X";
            b1Button.BackColor = Color.Salmon;
        }

        private void b2Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            b2Button.Text = "X";
            b2Button.BackColor = Color.Salmon;
        }

        private void b3Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            b3Button.Text = "X";
            b3Button.BackColor = Color.Salmon;
        }

        private void b4Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            b4Button.Text = "X";
            b4Button.BackColor = Color.Salmon;
        }

        private void b5Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            b5Button.Text = "X";
            b5Button.BackColor = Color.Salmon;
        }

        private void i1Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            i1Button.Text = "X";
            i1Button.BackColor = Color.Salmon;
        }

        private void i2Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            i2Button.Text = "X";
            i2Button.BackColor = Color.Salmon;
        }

        private void i3Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            i3Button.Text = "X";
            i3Button.BackColor = Color.Salmon;
        }

        private void i4Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            i4Button.Text = "X";
            i4Button.BackColor = Color.Salmon;
        }

        private void i5Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            i5Button.Text = "X";
            i5Button.BackColor = Color.Salmon;
        }

        private void n1Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            n1Button.Text = "X";
            n1Button.BackColor = Color.Salmon;
        }

        private void n2Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            n2Button.Text = "X";
            n2Button.BackColor = Color.Salmon;
        }

        private void n3Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            n3Button.Text = "X";
            n3Button.BackColor = Color.Salmon;
        }

        private void n4Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            n4Button.Text = "X";
            n4Button.BackColor = Color.Salmon;
        }

        private void n5Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            n5Button.Text = "X";
            n5Button.BackColor = Color.Salmon;
        }

        private void g1Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            g1Button.Text = "X";
            g1Button.BackColor = Color.Salmon;
        }

        private void g2Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            g2Button.Text = "X";
            g2Button.BackColor = Color.Salmon;
        }

        private void g3Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            g3Button.Text = "X";
            g3Button.BackColor = Color.Salmon;
        }

        private void g4Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            g4Button.Text = "X";
            g4Button.BackColor = Color.Salmon;
        }

        private void g5Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            g5Button.Text = "X";
            g5Button.BackColor = Color.Salmon;
        }

        private void o1Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            o1Button.Text = "X";
            o1Button.BackColor = Color.Salmon;
        }

        private void o2Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            o2Button.Text = "X";
            o2Button.BackColor = Color.Salmon;
        }

        private void o3Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            o3Button.Text = "X";
            o3Button.BackColor = Color.Salmon;
        }

        private void o4Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            o4Button.Text = "X";
            o4Button.BackColor = Color.Salmon;
        }

        private void o5Button_Click(object sender, EventArgs e)
        {
            SoundPlayer uialert = new SoundPlayer(Properties.Resources.uialert);
            uialert.Play();
            o5Button.Text = "X";
            o5Button.BackColor = Color.Salmon;
        }

        private void bingoButton_Click(object sender, EventArgs e)
        {
            SoundPlayer bingo = new SoundPlayer(Properties.Resources.bingo);
            bingo.Play();
            gameState = "ending";
            BackColor = Color.Gainsboro;
            hidebuttons();
            stopButton.Visible = false;
            bingoButton.Visible = false;
            numboxLabel.Text = "";
            numcallOutput.Text = "";
            numcallButton.Visible = false;
            againButton.Visible = true;
            exitButton.Visible = true;

            timeLabel.Visible = true;
            timeLabel.Text = $"You got a bingo!";

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            SoundPlayer badoo = new SoundPlayer(Properties.Resources.badoo);
            badoo.Play();
            gameState = "stopping";
            hidebuttons();
            stopButton.Visible = false;
            bingoButton.Visible = false;
            numboxLabel.Text = "";
            numcallOutput.Text = "";
            numcallButton.Visible = false;
            againButton.Visible = true;
            exitButton.Visible = true;

            againButton.Text = "Restart";

            timeLabel.Visible = true;
            timeLabel.Text = $"You stopped the game!";
        }

        private void againButton_Click(object sender, EventArgs e)
        {
            SoundPlayer badoo = new SoundPlayer(Properties.Resources.bingo);
            badoo.Play();
            gameState = "waiting";

            b1Button.BackColor = Color.Transparent;
            b2Button.BackColor = Color.Transparent;
            b3Button.BackColor = Color.Transparent;
            b4Button.BackColor = Color.Transparent;
            b5Button.BackColor = Color.Transparent;

            i1Button.BackColor = Color.Transparent;
            i2Button.BackColor = Color.Transparent;
            i3Button.BackColor = Color.Transparent;
            i4Button.BackColor = Color.Transparent;
            i5Button.BackColor = Color.Transparent;

            n1Button.BackColor = Color.Transparent;
            n2Button.BackColor = Color.Transparent;
            n3Button.BackColor = Color.Transparent;
            n4Button.BackColor = Color.Transparent;
            n5Button.BackColor = Color.Transparent;

            g1Button.BackColor = Color.Transparent;
            g2Button.BackColor = Color.Transparent;
            g3Button.BackColor = Color.Transparent;
            g4Button.BackColor = Color.Transparent;
            g5Button.BackColor = Color.Transparent;

            o1Button.BackColor = Color.Transparent;
            o2Button.BackColor = Color.Transparent;
            o3Button.BackColor = Color.Transparent;
            o4Button.BackColor = Color.Transparent;
            o5Button.BackColor = Color.Transparent;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            SoundPlayer badoo = new SoundPlayer(Properties.Resources.bingo);
            badoo.Play();
            Application.Exit();
        }

        private void escLabel_Click(object sender, EventArgs e)
        {
            SoundPlayer badoo = new SoundPlayer(Properties.Resources.bingo);
            badoo.Play();
            Application.Exit();
        }
    }
}
