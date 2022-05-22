using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace The_Tortoise_and_the_Hare
{
    public partial class Form1 : Form
    {
        //create 1D array to store win,lose,tie for hare and tort
        int[] RaceArray = new int[6];
        int Tscore = 0, Hscore = 0;
        bool picMode;

        //declare objects
        Hare hare;
        Tortoise tortoise;

        public class Contender
        {
            protected int iPosition;
            protected int iNumberofSteps;
            public Color clr;

            public Contender()
            {
                //default contructor 
                iPosition = 0;
                iNumberofSteps = 70;
                clr = Color.Black;
            }
            public Contender(int numSteps, int pos, Color clr1)
            {
                //contructor with user defined variables
                setNumSteps(numSteps);
                setPos(pos);
                setColor(clr1);
            }

            public void setNumSteps(int numSteps)
            {
                //sets numsteps to be pos
                if (numSteps < 0)
                {
                    iNumberofSteps = numSteps * (-1);
                }
                else
                {
                    iNumberofSteps = numSteps;
                }
            }

            public void setPos(int pos)
            {
                //sets pos to be positive
                if (pos < 0)
                {
                    iPosition = pos * (-1);
                }
                else
                {
                    iPosition = pos;
                }
            }
            public void setColor(Color clr1)
            {
                //sets colour
                clr = clr1;
            }

            //retrives variables
            public int getNumSteps()
            {
                return iNumberofSteps;
            }
            public int getPos()
            {
                return iPosition;
            }
            public Color getColor()
            {
                return clr;
            }

            //checks if a contender is the winner
            public bool isWinner()
            {
                if (iPosition == iNumberofSteps)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class Tortoise : Contender
        {
            Random rnd;

            public Tortoise()
            {
                //default contructor 
                rnd = new Random();
                iPosition = 0;
                clr = Color.Green;
                iNumberofSteps = 70;
            }
            public Tortoise(Color c, int numSteps, int pos, Random r)
            {
                //contructor with user defined variables
                rnd = r;
                iPosition = pos;
                clr = c;
                iNumberofSteps = numSteps;
            }

            public void UpdatePosition()
            {
                //updates position based on random number
                int rndNum = rnd.Next(0, 100);
                if (rndNum < 50)
                {
                    iPosition += 3;
                }
                else if (rndNum < 70)
                {
                    iPosition -= 6;
                }
                else
                {
                    iPosition += 1;
                }

                //makes sure position does not pass numberofsteps or becomes negative
                if (iPosition < 0)
                {
                    iPosition = 0;
                }
                else if (iPosition > iNumberofSteps)
                {
                    iPosition = iNumberofSteps;
                }
            }

            public void Draw(Graphics g, int yLoc)
            {
                //draws tortoise updated position 
                SolidBrush myBrush = new SolidBrush(clr);
                g.FillEllipse(myBrush, iPosition * 13 + 15, yLoc - 15, 30, 30);
            }
        }
        public class Hare : Contender
        {
            Random rnd;

            public Hare()
            {
                //default contructor
                rnd = new Random();
                iPosition = 0;
                clr = Color.Orange;
                iNumberofSteps = 70;
            }
            public Hare(Color c, int numSteps, int pos, Random r)
            {
                //contructor that sets 
                rnd = r;
                iPosition = pos;
                clr = c;
                iNumberofSteps = numSteps;
            }

            public void UpdatePosition()
            {
                //updates position based on random number
                int rndNum = rnd.Next(0, 100);
                if (rndNum < 20)
                {
                    iPosition += 0;
                }
                else if (rndNum < 40)
                {
                    iPosition += 9;
                }
                else if (rndNum < 50)
                {
                    iPosition -= 12;
                }
                else if (rndNum < 80)
                {
                    iPosition += 1;
                }
                else
                {
                    iPosition -= 2;
                }

                //make sure position is not negative or passes iNumberofSteps
                if (iPosition < 0)
                {
                    iPosition = 0;
                }
                else if (iPosition > iNumberofSteps)
                {
                    iPosition = iNumberofSteps;
                }
            }

            public void Draw(Graphics g, int yLoc)
            {
                //draw hare based on its position
                SolidBrush myBrush = new SolidBrush(clr);
                g.FillRectangle(myBrush, iPosition * 13 + 15, yLoc - 15, 30, 30);
            }
        }

        public Form1()
        {
            InitializeComponent();
            //instantiating objects
            hare = new Hare();
            tortoise = new Tortoise();

            rbMedium.Checked = true; //auto check medium radio button

            //show the chart and graph
            readInfo();
            showInfo();
            raceChart.Titles.Add("Race Chart");
            showChart();

            pbHare.Hide();
            pbTort.Hide();
        }
        public void showChart()
        {
            try
            {
                //resets chart every time
                foreach (var series in raceChart.Series)
                {
                    series.Points.Clear();
                }

                //shows updated info in chart
                raceChart.Series["Race Info"].Points.AddXY("Tortoise Win", RaceArray[3]);
                raceChart.Series["Race Info"].Points.AddXY("Hare Win", RaceArray[0]);
                raceChart.Series["Race Info"].Points.AddXY("Tie", RaceArray[4]);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void readInfo()
        {
            try
            {
                //reads info from text file and puts it in the raceArray
                TextReader tr = new StreamReader("TortandHare.txt");
                string strInput;
                string[] splittedInput;

                strInput = tr.ReadLine();
                splittedInput = strInput.Split(',');

                for (int i = 0; i < 6; i++)
                {
                    RaceArray[i] = Convert.ToInt32(splittedInput[i]);
                }

                tr.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        public void saveInfo(int h, int t)
        {
            try
            {
                //takes info in textfile, udpates it, and saves to array every time tort or hare wins
                TextReader tr = new StreamReader("TortandHare.txt");
                string strInput;
                string[] splittedInput;

                strInput = tr.ReadLine();
                splittedInput = strInput.Split(',');
                if (h == 1 && t == -1) //hare wins and tort loses
                {
                    RaceArray[0] = Convert.ToInt32(splittedInput[0]) + 1;
                    RaceArray[5] = Convert.ToInt32(splittedInput[5]) + 1;
                }
                else if (h == -1 && t == 1) //hare loses and tort wins
                {
                    RaceArray[2] = Convert.ToInt32(splittedInput[2]) + 1;
                    RaceArray[3] = Convert.ToInt32(splittedInput[3]) + 1;
                }
                else if (h == 0 && t == 0) //hare and tort ties
                {
                    RaceArray[1] = Convert.ToInt32(splittedInput[1]) + 1;
                    RaceArray[4] = Convert.ToInt32(splittedInput[4]) + 1;
                }
                tr.Close();


                //writes updated information in text file
                TextWriter tw = new StreamWriter("TortandHare.txt");
                for (int i = 0; i < 6; i++)
                {
                    tw.Write(RaceArray[i] + ",");
                }
                tw.Close();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void showInfo()
        {
            try
            {
                //show info to labels every time tort/hare wins
                winsH.Text = RaceArray[0].ToString();
                tiesH.Text = RaceArray[1].ToString();
                losesH.Text = RaceArray[2].ToString();
                winsT.Text = RaceArray[3].ToString();
                tiesT.Text = RaceArray[4].ToString();
                losesT.Text = RaceArray[5].ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        public void winReset()
        {
            try
            {
                //if somebody wins the race, updates chart, tabular, stops timer, and resets position of contesters
                showChart();
                showInfo();
                raceTime.Stop();
                hare.setPos(0);
                tortoise.setPos(0);
                pbTort.Left = tortoise.getPos();
                pbHare.Left = hare.getPos();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void cbChooseMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            //based on the selection item in the combo box, updates the mode. If nothing is selected, default is draw mode
            int item = cbChooseMode.SelectedIndex;
            if (item == 0)  //draw mode
            {
                picMode = false;
                pbHare.Hide();
                pbTort.Hide();
                hare.setColor(Color.Orange);
                tortoise.setColor(Color.Green);
                pbRace.Image = null;
            }
            else if (item == 1) //picture mode
            {
                picMode = true;
                pbHare.Top = 70;
                pbTort.Top = 270;
                pbRace.Image = Image.FromFile("back.jpg"); 
                pbTort.Parent = pbRace;
                pbHare.Parent = pbRace;
                pbTort.BackColor = Color.Transparent;
                pbHare.BackColor = Color.Transparent;
                pbHare.Show();
                pbTort.Show();
            }
        }
        private void raceTime_Tick(object sender, EventArgs e)
        {
            try
            {
                //for every tick, updates position of hare and tort, show on picture box        
                hare.UpdatePosition();
                tortoise.UpdatePosition();
                pbRace.Invalidate();

                //if position overlaps, play ouch sound
                if (hare.getPos() == tortoise.getPos())
                {
                    SoundPlayer s = new SoundPlayer("Ouch_.wav");
                    s.Play();
                }

                //updates graph, tabular, score and resets position
                //if it is a tie
                if (hare.isWinner() && tortoise.isWinner())
                {
                    saveInfo(0, 0);
                    winReset();
                    Hscore += 1;
                    Tscore += 1;                   
                    MessageBox.Show("It's a tie.");
                }
                //if hare wins
                else if (hare.isWinner())
                {
                    saveInfo(1, -1);
                    winReset();
                    Hscore += 1;
                    MessageBox.Show("Hare wins. Yuch.");
                }
                //if tort wins
                else if (tortoise.isWinner())
                {
                    saveInfo(-1, 1);
                    winReset();
                    Tscore += 1;
                    MessageBox.Show("TORTOISE WINS!!! YAY!!!");
                }

                //show score on scoreboard 
                lblH.Text = Hscore.ToString();
                lblT.Text = Tscore.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void pbRace_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                //draw the race track line for tort and hare               
                int hareLine = 100, tortoiseLine = 300;

                Graphics g = e.Graphics;
                Pen trackPen = new Pen(Color.Black, 2);
                trackPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLine(trackPen, 15, hareLine, 930, hareLine);
                g.DrawLine(trackPen, 15, tortoiseLine, 930, tortoiseLine);

                //draw position of tort and hare based on pic or draw mode
                if (picMode == false)
                {
                    tortoise.Draw(g, tortoiseLine);
                    hare.Draw(g, hareLine);
                }
                else
                {
                    pbTort.Left = tortoise.getPos() * 13;
                    pbHare.Left = hare.getPos() * 13;
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                //starts timer
                raceTime.Start();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            try
            {
                //stops timer
                raceTime.Stop();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                //stops timer, resets contesters position, updates picture box
                raceTime.Stop();
                hare.setPos(0);
                tortoise.setPos(0);
                pbTort.Left = tortoise.getPos();
                pbHare.Left = hare.getPos();
                pbRace.Invalidate();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnChangeColourHare_Click(object sender, EventArgs e)
        {
            try
            {
                //allow user to change colour of hare
                ColorDialog clrDlg = new ColorDialog();

                if (clrDlg.ShowDialog() == DialogResult.OK)
                {
                    hare.clr = clrDlg.Color;
                    pbRace.Invalidate();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnChangeColourTort_Click(object sender, EventArgs e)
        {
            try
            {
                //allows user to change colour or tort
                ColorDialog clrDlg = new ColorDialog();

                if (clrDlg.ShowDialog() == DialogResult.OK)
                {
                    tortoise.clr = clrDlg.Color;
                    pbRace.Invalidate();
                }
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnScoreReset_Click(object sender, EventArgs e)
        {
            try
            {
                //resets score displayed
                Tscore = 0;
                Hscore = 0;
                lblT.Text = Tscore.ToString();
                lblH.Text = Hscore.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        //based on which radiobutton selected, change speed of ticker
        private void rbFast_CheckedChanged(object sender, EventArgs e)
        {
            raceTime.Interval = 10;
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            raceTime.Interval = 300;
        }

        private void rbSlow_CheckedChanged(object sender, EventArgs e)
        {
            raceTime.Interval = 800;
        }
    }
}
