using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Uttråkad_igen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Q)
            {
                MoveForwardQ();
                return true;
            }
            if (keyData == Keys.W)
            {
                MoveForwardW();
                return true;
            }
            if (keyData == Keys.E)
            {
                MoveForwardE();
                return true;
            }
            if (keyData == Keys.Left)
            {
                MoveForwardLeft();
                return true;
            }
            if (keyData == Keys.Down)
            {
                MoveForwardDown();
                return true;
            }
            if (keyData == Keys.Right)
            {
                MoveForwardRight();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void BtnKör_Click(object sender, EventArgs e)
        {
            BtnKör.Visible = false;
            LblSlow.Visible = false;
            LblFast.Visible = false;
            SLOW.Visible = false;
            FAST.Visible = false;
            Timer1.Enabled = true;
            Timer3.Enabled = true;
            BQ.Enabled = true;
            BW.Enabled = true;
            BE.Enabled = true;
            BAL.Enabled = true;
            BAD.Enabled = true;
            BAR.Enabled = true;
        }
        private Random random = new Random();
        private void Timer1_Tick(object sender, EventArgs e)
        {
            var randomNumber1 = random.Next(0, 3);
            if (randomNumber1 == 0)
            {
                BQ.BackColor = Color.LimeGreen;
            }
            else if (randomNumber1 == 1)
            {
                BW.BackColor = Color.LimeGreen;
            }
            else
            {
                BE.BackColor = Color.LimeGreen;
            }
            Timer2.Enabled = true;
            Timer1.Enabled = false;
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            BQ.BackColor = Color.White;
            BW.BackColor = Color.White;
            BE.BackColor = Color.White;
            Timer1.Enabled = true;
            Timer2.Enabled = false;
        }
        private void Timer3_Tick(object sender, EventArgs e)
        {
            var randomNumber2 = random.Next(0, 3);
            if (randomNumber2 == 0)
            {
                BAL.BackColor = Color.LimeGreen;
            }
            else if (randomNumber2 == 1)
            {
                BAD.BackColor = Color.LimeGreen;
            }
            else
            {
                BAR.BackColor = Color.LimeGreen;
            }
            Timer4.Enabled = true;
            Timer3.Enabled = false;
        }
        private void Timer4_Tick(object sender, EventArgs e)
        {
            BAL.BackColor = Color.White;
            BAD.BackColor = Color.White;
            BAR.BackColor = Color.White;
            Timer3.Enabled = true;
            Timer4.Enabled = false;
        }
        private void BQ_Click(object sender, EventArgs e)
        {
            MoveForwardQ();
        }
        private void MoveForwardQ()
        {
            if (((SLOW.BackColor) == (Color.LimeGreen)) && ((FAST.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(SLOW.Text);
                if (BQ.BackColor == Color.LimeGreen)
                {
                    Player1.Location = new Point(Player1.Location.X + Speed, Player1.Location.Y);
                    BQ.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                else
                {
                    Player1.Location = new Point(Player1.Location.X - Speed, Player1.Location.Y);
                    BQ.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                if ((Player1.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Grön vann";
                    Victory.BackColor = Color.Lime;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
            else if (((FAST.BackColor) == (Color.LimeGreen)) && ((SLOW.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(FAST.Text);
                if (BQ.BackColor == Color.LimeGreen)
                {
                    Player1.Location = new Point(Player1.Location.X + Speed, Player1.Location.Y);
                    BQ.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                else
                {
                    Player1.Location = new Point(Player1.Location.X - Speed, Player1.Location.Y);
                    BQ.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                if ((Player1.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Grön vann";
                    Victory.BackColor = Color.Lime;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
        }

        private void BW_Click(object sender, EventArgs e)
        {
            MoveForwardW();
        }
        private void MoveForwardW()
        {
            if (((SLOW.BackColor) == (Color.LimeGreen)) && ((FAST.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(SLOW.Text);
                if (BW.BackColor == Color.LimeGreen)
                {
                    Player1.Location = new Point(Player1.Location.X + Speed, Player1.Location.Y);
                    BW.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                else
                {
                    Player1.Location = new Point(Player1.Location.X - Speed, Player1.Location.Y);
                    BW.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                if ((Player1.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Grön vann";
                    Victory.BackColor = Color.Lime;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
            else if (((FAST.BackColor) == (Color.LimeGreen)) && ((SLOW.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(FAST.Text);
                if (BW.BackColor == Color.LimeGreen)
                {
                    Player1.Location = new Point(Player1.Location.X + Speed, Player1.Location.Y);
                    BW.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                else
                {
                    Player1.Location = new Point(Player1.Location.X - Speed, Player1.Location.Y);
                    BW.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                if ((Player1.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Grön vann";
                    Victory.BackColor = Color.Lime;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
        }
        private void BE_Click(object sender, EventArgs e)
        {
            MoveForwardE();
        }
        private void MoveForwardE()
        {
            if (((SLOW.BackColor) == (Color.LimeGreen)) && ((FAST.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(SLOW.Text);
                if (BE.BackColor == Color.LimeGreen)
                {
                    Player1.Location = new Point(Player1.Location.X + Speed, Player1.Location.Y);
                    BE.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                else
                {
                    Player1.Location = new Point(Player1.Location.X - Speed, Player1.Location.Y);
                    BE.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                if ((Player1.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Grön vann";
                    Victory.BackColor = Color.Lime;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
            else if (((FAST.BackColor) == (Color.LimeGreen)) && ((SLOW.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(FAST.Text);
                if (BE.BackColor == Color.LimeGreen)
                {
                    Player1.Location = new Point(Player1.Location.X + Speed, Player1.Location.Y);
                    BE.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                else
                {
                    Player1.Location = new Point(Player1.Location.X - Speed, Player1.Location.Y);
                    BE.BackColor = Color.White;
                    Timer1.Enabled = true;
                }
                if ((Player1.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Grön vann";
                    Victory.BackColor = Color.Lime;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
        }

        private void BAL_Click(object sender, EventArgs e)
        {
            MoveForwardLeft();
        }
        private void MoveForwardLeft()
        {
            if (((SLOW.BackColor) == (Color.LimeGreen)) && ((FAST.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(SLOW.Text);
                if (BAL.BackColor == Color.LimeGreen)
                {
                    Player2.Location = new Point(Player2.Location.X + Speed, Player2.Location.Y);
                    BAL.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                else
                {
                    Player2.Location = new Point(Player2.Location.X - Speed, Player2.Location.Y);
                    BAL.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                if ((Player2.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Röd vann";
                    Victory.BackColor = Color.Red;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
            else if (((FAST.BackColor) == (Color.LimeGreen)) && ((SLOW.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(FAST.Text);
                if (BAL.BackColor == Color.LimeGreen)
                {
                    Player2.Location = new Point(Player2.Location.X + Speed, Player2.Location.Y);
                    BAL.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                else
                {
                    Player2.Location = new Point(Player2.Location.X - Speed, Player2.Location.Y);
                    BAL.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                if ((Player2.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Röd vann";
                    Victory.BackColor = Color.Red;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
        }
        private void BAD_Click(object sender, EventArgs e)
        {
            MoveForwardDown();
        }
        private void MoveForwardDown()
        {
            if (((SLOW.BackColor) == (Color.LimeGreen)) && ((FAST.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(SLOW.Text);
                if (BAD.BackColor == Color.LimeGreen)
                {
                    Player2.Location = new Point(Player2.Location.X + Speed, Player2.Location.Y);
                    BAD.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                else
                {
                    Player2.Location = new Point(Player2.Location.X - Speed, Player2.Location.Y);
                    BAD.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                if ((Player2.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Röd vann";
                    Victory.BackColor = Color.Red;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
            else if (((FAST.BackColor) == (Color.LimeGreen)) && ((SLOW.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(FAST.Text);
                if (BAD.BackColor == Color.LimeGreen)
                {
                    Player2.Location = new Point(Player2.Location.X + Speed, Player2.Location.Y);
                    BAD.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                else
                {
                    Player2.Location = new Point(Player2.Location.X - Speed, Player2.Location.Y);
                    BAD.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                if ((Player2.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Röd vann";
                    Victory.BackColor = Color.Red;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
        }
        private void BAR_Click(object sender, EventArgs e)
        {
            MoveForwardRight();
        }
        private void MoveForwardRight()
        {
            if (((SLOW.BackColor) == (Color.LimeGreen)) && ((FAST.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(SLOW.Text);
                if (BAR.BackColor == Color.LimeGreen)
                {
                    Player2.Location = new Point(Player2.Location.X + Speed, Player2.Location.Y);
                    BAR.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                else
                {
                    Player2.Location = new Point(Player2.Location.X - Speed, Player2.Location.Y);
                    BAR.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                if ((Player2.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Röd vann";
                    Victory.BackColor = Color.Red;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
            else if (((FAST.BackColor) == (Color.LimeGreen)) && ((SLOW.BackColor) == (Color.White)))
            {
                int Speed = int.Parse(FAST.Text);
                if (BAR.BackColor == Color.LimeGreen)
                {
                    Player2.Location = new Point(Player2.Location.X + Speed, Player2.Location.Y);
                    BAR.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                else
                {
                    Player2.Location = new Point(Player2.Location.X - Speed, Player2.Location.Y);
                    BAR.BackColor = Color.White;
                    Timer3.Enabled = true;
                }
                if ((Player2.Location.X >= Mål.Location.X))
                {
                    Victory.Text = "Röd vann";
                    Victory.BackColor = Color.Red;
                    Victory.Visible = true;
                    BQ.Enabled = false;
                    BW.Enabled = false;
                    BE.Enabled = false;
                    BAL.Enabled = false;
                    BAD.Enabled = false;
                    BAR.Enabled = false;
                }
            }
        }
        private void SLOW_Click(object sender, EventArgs e)
        {
            SLOW.BackColor = Color.LimeGreen;
            SLOW.ForeColor = Color.LimeGreen;
            FAST.BackColor = Color.White;
            FAST.ForeColor = Color.White;
            BtnKör.Enabled = true;
        }
        private void FAST_Click(object sender, EventArgs e)
        {
            FAST.BackColor = Color.LimeGreen;
            FAST.ForeColor = Color.LimeGreen;
            SLOW.BackColor = Color.White;
            SLOW.ForeColor = Color.White;
            BtnKör.Enabled = true;
        }
        private void Victory_Click(object sender, EventArgs e)
        {
            Player1.Location = new Point(12, 12);
            Player2.Location = new Point(12, 151);
            LblSlow.Visible = true;
            LblFast.Visible = true;
            SLOW.BackColor = Color.White;
            SLOW.ForeColor = Color.White;
            SLOW.Visible = true;
            FAST.BackColor = Color.White;
            FAST.ForeColor = Color.White;
            FAST.Visible = true;
            BtnKör.Visible = true;
            Timer1.Enabled = false;
            Timer2.Enabled = false;
            Timer3.Enabled = false;
            Timer4.Enabled = false;
            BQ.BackColor = Color.White;
            BW.BackColor = Color.White;
            BE.BackColor = Color.White;
            BAR.BackColor = Color.White;
            BAD.BackColor = Color.White;
            BAL.BackColor = Color.White;
            Victory.Visible = false;
            BQ.Enabled = false;
            BW.Enabled = false;
            BE.Enabled = false;
            BAL.Enabled = false;
            BAD.Enabled = false;
            BAR.Enabled = false;
            BtnKör.Enabled = false;
        }
        private void Restart_Click(object sender, EventArgs e)
        {
            Player1.Location = new Point(12, 12);
            Player2.Location = new Point(12, 151);
            LblSlow.Visible = true;
            LblFast.Visible = true;
            SLOW.BackColor = Color.White;
            SLOW.ForeColor = Color.White;
            SLOW.Visible = true;
            FAST.BackColor = Color.White;
            FAST.ForeColor = Color.White;
            FAST.Visible = true;
            BtnKör.Visible = true;
            Timer1.Enabled = false;
            Timer2.Enabled = false;
            Timer3.Enabled = false;
            Timer4.Enabled = false;
            BQ.BackColor = Color.White;
            BW.BackColor = Color.White;
            BE.BackColor = Color.White;
            BAR.BackColor = Color.White;
            BAD.BackColor = Color.White;
            BAL.BackColor = Color.White;
            Victory.Visible = false;
            BQ.Enabled = false;
            BW.Enabled = false;
            BE.Enabled = false;
            BAL.Enabled = false;
            BAD.Enabled = false;
            BAR.Enabled = false;
            BtnKör.Enabled = false;
        }
    }
}
