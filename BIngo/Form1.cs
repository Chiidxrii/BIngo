using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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
                escLabel.Text = "Press esc to exit";
                timeLabel.Text = "";
            }
            else if (gameState == "running")
            {
                bingoButton.Visible = true;
                stopButton.Visible = true;
                numcallButton.Visible = true;
                timeLabel.Text = "";
                

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
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //switch (e.KeyCode)
            //{
            //    case Keys.Escape:
            //        escDown = true; 
            //        break;
            //}
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
            b1Button.Text = "X";
            b1Button.BackColor = Color.Salmon;
        }

        private void b2Button_Click(object sender, EventArgs e)
        {
            b2Button.Text = "X";
            b2Button.BackColor = Color.Salmon;
        }

        private void b3Button_Click(object sender, EventArgs e)
        {
            b3Button.Text = "X";
            b3Button.BackColor = Color.Salmon;
        }

        private void b4Button_Click(object sender, EventArgs e)
        {
            b4Button.Text = "X";
            b4Button.BackColor = Color.Salmon;
        }

        private void b5Button_Click(object sender, EventArgs e)
        {
            b5Button.Text = "X";
            b5Button.BackColor = Color.Salmon;
        }

        private void i1Button_Click(object sender, EventArgs e)
        {
            i1Button.Text = "X";
            i1Button.BackColor = Color.Salmon;
        }

        private void i2Button_Click(object sender, EventArgs e)
        {
            i2Button.Text = "X";
            i2Button.BackColor = Color.Salmon;
        }

        private void i3Button_Click(object sender, EventArgs e)
        {
            i3Button.Text = "X";
            i3Button.BackColor = Color.Salmon;
        }

        private void i4Button_Click(object sender, EventArgs e)
        {
            i4Button.Text = "X";
            i4Button.BackColor = Color.Salmon;
        }

        private void i5Button_Click(object sender, EventArgs e)
        {
            i5Button.Text = "X";
            i5Button.BackColor = Color.Salmon;
        }

        private void n1Button_Click(object sender, EventArgs e)
        {
            n1Button.Text = "X";
            n1Button.BackColor = Color.Salmon;
        }

        private void n2Button_Click(object sender, EventArgs e)
        {
            n2Button.Text = "X";
            n2Button.BackColor = Color.Salmon;
        }

        private void n3Button_Click(object sender, EventArgs e)
        {
            n3Button.Text = "X";
            n3Button.BackColor = Color.Salmon;
        }

        private void n4Button_Click(object sender, EventArgs e)
        {
            n4Button.Text = "X";
            n4Button.BackColor = Color.Salmon;
        }

        private void n5Button_Click(object sender, EventArgs e)
        {
            n5Button.Text = "X";
            n5Button.BackColor = Color.Salmon;
        }

        private void g1Button_Click(object sender, EventArgs e)
        {
            g1Button.Text = "X";
            g1Button.BackColor = Color.Salmon;
        }

        private void g2Button_Click(object sender, EventArgs e)
        {
            g2Button.Text = "X";
            g2Button.BackColor = Color.Salmon;
        }

        private void g3Button_Click(object sender, EventArgs e)
        {
            g3Button.Text = "X";
            g3Button.BackColor = Color.Salmon;
        }

        private void g4Button_Click(object sender, EventArgs e)
        {
            g4Button.Text = "X";
            g4Button.BackColor = Color.Salmon;
        }

        private void g5Button_Click(object sender, EventArgs e)
        {
            g5Button.Text = "X";
            g5Button.BackColor = Color.Salmon;
        }

        private void o1Button_Click(object sender, EventArgs e)
        {
            o1Button.Text = "X";
            o1Button.BackColor = Color.Salmon;
        }

        private void o2Button_Click(object sender, EventArgs e)
        {
            o2Button.Text = "X";
            o2Button.BackColor = Color.Salmon;
        }

        private void o3Button_Click(object sender, EventArgs e)
        {
            o3Button.Text = "X";
            o3Button.BackColor = Color.Salmon;
        }

        private void o4Button_Click(object sender, EventArgs e)
        {
            o4Button.Text = "X";
            o4Button.BackColor = Color.Salmon;
        }

        private void o5Button_Click(object sender, EventArgs e)
        {
            o5Button.Text = "X";
            o5Button.BackColor = Color.Salmon;
        }

        private void bingoButton_Click(object sender, EventArgs e)
        {

        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }
    }
}
