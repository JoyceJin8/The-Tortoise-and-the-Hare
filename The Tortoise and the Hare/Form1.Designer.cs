namespace The_Tortoise_and_the_Hare
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.pbRace = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnChangeColourHare = new System.Windows.Forms.Button();
            this.btnChangeColourTort = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbFast = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbSlow = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblT = new System.Windows.Forms.Label();
            this.lblH = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnScoreReset = new System.Windows.Forms.Button();
            this.raceTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tcRace = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbChooseMode = new System.Windows.Forms.ComboBox();
            this.pbTort = new System.Windows.Forms.PictureBox();
            this.pbHare = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tiesT = new System.Windows.Forms.Label();
            this.tiesH = new System.Windows.Forms.Label();
            this.losesT = new System.Windows.Forms.Label();
            this.losesH = new System.Windows.Forms.Label();
            this.winsT = new System.Windows.Forms.Label();
            this.winsH = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabpg3 = new System.Windows.Forms.TabPage();
            this.raceChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.pbRace)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tcRace.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabpg3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raceChart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbRace
            // 
            this.pbRace.BackColor = System.Drawing.Color.Transparent;
            this.pbRace.Location = new System.Drawing.Point(80, 61);
            this.pbRace.Name = "pbRace";
            this.pbRace.Size = new System.Drawing.Size(1000, 400);
            this.pbRace.TabIndex = 0;
            this.pbRace.TabStop = false;
            this.pbRace.Paint += new System.Windows.Forms.PaintEventHandler(this.pbRace_Paint);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(16, 35);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 51);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(123, 35);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(96, 51);
            this.btnPause.TabIndex = 4;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(225, 35);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 51);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnChangeColourHare);
            this.groupBox1.Controls.Add(this.btnChangeColourTort);
            this.groupBox1.Location = new System.Drawing.Point(80, 477);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 121);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Colour";
            // 
            // btnChangeColourHare
            // 
            this.btnChangeColourHare.Location = new System.Drawing.Point(132, 40);
            this.btnChangeColourHare.Name = "btnChangeColourHare";
            this.btnChangeColourHare.Size = new System.Drawing.Size(91, 48);
            this.btnChangeColourHare.TabIndex = 2;
            this.btnChangeColourHare.Text = "Hare";
            this.btnChangeColourHare.UseVisualStyleBackColor = true;
            this.btnChangeColourHare.Click += new System.EventHandler(this.btnChangeColourHare_Click);
            // 
            // btnChangeColourTort
            // 
            this.btnChangeColourTort.Location = new System.Drawing.Point(22, 40);
            this.btnChangeColourTort.Name = "btnChangeColourTort";
            this.btnChangeColourTort.Size = new System.Drawing.Size(87, 48);
            this.btnChangeColourTort.TabIndex = 1;
            this.btnChangeColourTort.Text = "Tortoise";
            this.btnChangeColourTort.UseVisualStyleBackColor = true;
            this.btnChangeColourTort.Click += new System.EventHandler(this.btnChangeColourTort_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Controls.Add(this.btnPause);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Location = new System.Drawing.Point(347, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 121);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Controls";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbFast);
            this.groupBox3.Controls.Add(this.rbMedium);
            this.groupBox3.Controls.Add(this.rbSlow);
            this.groupBox3.Location = new System.Drawing.Point(704, 477);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(173, 121);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Speed";
            // 
            // rbFast
            // 
            this.rbFast.AutoSize = true;
            this.rbFast.Location = new System.Drawing.Point(18, 86);
            this.rbFast.Name = "rbFast";
            this.rbFast.Size = new System.Drawing.Size(66, 24);
            this.rbFast.TabIndex = 8;
            this.rbFast.Text = "Fast";
            this.rbFast.UseVisualStyleBackColor = true;
            this.rbFast.CheckedChanged += new System.EventHandler(this.rbFast_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(18, 55);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(90, 24);
            this.rbMedium.TabIndex = 7;
            this.rbMedium.TabStop = true;
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbSlow
            // 
            this.rbSlow.AutoSize = true;
            this.rbSlow.Location = new System.Drawing.Point(18, 26);
            this.rbSlow.Name = "rbSlow";
            this.rbSlow.Size = new System.Drawing.Size(68, 24);
            this.rbSlow.TabIndex = 6;
            this.rbSlow.Text = "Slow";
            this.rbSlow.UseVisualStyleBackColor = true;
            this.rbSlow.CheckedChanged += new System.EventHandler(this.rbSlow_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblT);
            this.groupBox4.Controls.Add(this.lblH);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.lblScore);
            this.groupBox4.Controls.Add(this.btnScoreReset);
            this.groupBox4.Location = new System.Drawing.Point(901, 477);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(179, 121);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Score";
            // 
            // lblT
            // 
            this.lblT.AutoSize = true;
            this.lblT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblT.Location = new System.Drawing.Point(45, 45);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(25, 26);
            this.lblT.TabIndex = 7;
            this.lblT.Text = "0";
            // 
            // lblH
            // 
            this.lblH.AutoSize = true;
            this.lblH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblH.Location = new System.Drawing.Point(122, 45);
            this.lblH.Name = "lblH";
            this.lblH.Size = new System.Drawing.Size(25, 26);
            this.lblH.TabIndex = 6;
            this.lblH.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tortoise        Hare";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = ":";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(19, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 20);
            this.lblScore.TabIndex = 1;
            // 
            // btnScoreReset
            // 
            this.btnScoreReset.Location = new System.Drawing.Point(27, 74);
            this.btnScoreReset.Name = "btnScoreReset";
            this.btnScoreReset.Size = new System.Drawing.Size(131, 33);
            this.btnScoreReset.TabIndex = 9;
            this.btnScoreReset.Text = "Score Reset";
            this.btnScoreReset.UseVisualStyleBackColor = true;
            this.btnScoreReset.Click += new System.EventHandler(this.btnScoreReset_Click);
            // 
            // raceTime
            // 
            this.raceTime.Tick += new System.EventHandler(this.raceTime_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1157, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tcRace
            // 
            this.tcRace.Controls.Add(this.tabPage1);
            this.tcRace.Controls.Add(this.tabPage2);
            this.tcRace.Controls.Add(this.tabpg3);
            this.tcRace.Location = new System.Drawing.Point(0, 0);
            this.tcRace.Name = "tcRace";
            this.tcRace.SelectedIndex = 0;
            this.tcRace.Size = new System.Drawing.Size(1165, 749);
            this.tcRace.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbChooseMode);
            this.tabPage1.Controls.Add(this.pbTort);
            this.tabPage1.Controls.Add(this.pbHare);
            this.tabPage1.Controls.Add(this.pbRace);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1157, 716);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Race";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbChooseMode
            // 
            this.cbChooseMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChooseMode.FormattingEnabled = true;
            this.cbChooseMode.Items.AddRange(new object[] {
            "Draw Mode",
            "Picture Mode"});
            this.cbChooseMode.Location = new System.Drawing.Point(80, 18);
            this.cbChooseMode.Name = "cbChooseMode";
            this.cbChooseMode.Size = new System.Drawing.Size(223, 37);
            this.cbChooseMode.TabIndex = 16;
            this.cbChooseMode.Text = "Choose Mode";
            this.cbChooseMode.SelectedIndexChanged += new System.EventHandler(this.cbChooseMode_SelectedIndexChanged);
            // 
            // pbTort
            // 
            this.pbTort.BackColor = System.Drawing.Color.Transparent;
            this.pbTort.Image = ((System.Drawing.Image)(resources.GetObject("pbTort.Image")));
            this.pbTort.InitialImage = null;
            this.pbTort.Location = new System.Drawing.Point(102, 311);
            this.pbTort.Name = "pbTort";
            this.pbTort.Size = new System.Drawing.Size(50, 49);
            this.pbTort.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTort.TabIndex = 15;
            this.pbTort.TabStop = false;
            // 
            // pbHare
            // 
            this.pbHare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbHare.Image = ((System.Drawing.Image)(resources.GetObject("pbHare.Image")));
            this.pbHare.Location = new System.Drawing.Point(102, 141);
            this.pbHare.Name = "pbHare";
            this.pbHare.Size = new System.Drawing.Size(50, 49);
            this.pbHare.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHare.TabIndex = 14;
            this.pbHare.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tiesT);
            this.tabPage2.Controls.Add(this.tiesH);
            this.tabPage2.Controls.Add(this.losesT);
            this.tabPage2.Controls.Add(this.losesH);
            this.tabPage2.Controls.Add(this.winsT);
            this.tabPage2.Controls.Add(this.winsH);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1157, 716);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabular";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tiesT
            // 
            this.tiesT.AutoSize = true;
            this.tiesT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesT.Location = new System.Drawing.Point(821, 451);
            this.tiesT.Name = "tiesT";
            this.tiesT.Size = new System.Drawing.Size(0, 32);
            this.tiesT.TabIndex = 10;
            // 
            // tiesH
            // 
            this.tiesH.AutoSize = true;
            this.tiesH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiesH.Location = new System.Drawing.Point(394, 451);
            this.tiesH.Name = "tiesH";
            this.tiesH.Size = new System.Drawing.Size(0, 32);
            this.tiesH.TabIndex = 9;
            // 
            // losesT
            // 
            this.losesT.AutoSize = true;
            this.losesT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losesT.Location = new System.Drawing.Point(821, 294);
            this.losesT.Name = "losesT";
            this.losesT.Size = new System.Drawing.Size(0, 32);
            this.losesT.TabIndex = 8;
            // 
            // losesH
            // 
            this.losesH.AutoSize = true;
            this.losesH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.losesH.Location = new System.Drawing.Point(394, 294);
            this.losesH.Name = "losesH";
            this.losesH.Size = new System.Drawing.Size(0, 32);
            this.losesH.TabIndex = 7;
            // 
            // winsT
            // 
            this.winsT.AutoSize = true;
            this.winsT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsT.Location = new System.Drawing.Point(821, 166);
            this.winsT.Name = "winsT";
            this.winsT.Size = new System.Drawing.Size(0, 32);
            this.winsT.TabIndex = 6;
            // 
            // winsH
            // 
            this.winsH.AutoSize = true;
            this.winsH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winsH.Location = new System.Drawing.Point(394, 166);
            this.winsH.Name = "winsH";
            this.winsH.Size = new System.Drawing.Size(0, 32);
            this.winsH.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(104, 451);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 32);
            this.label7.TabIndex = 4;
            this.label7.Text = "Ties";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 32);
            this.label6.TabIndex = 3;
            this.label6.Text = "Loses";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(104, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 32);
            this.label5.TabIndex = 2;
            this.label5.Text = "Wins";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(799, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tortoise";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(372, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "Hare";
            // 
            // tabpg3
            // 
            this.tabpg3.Controls.Add(this.raceChart);
            this.tabpg3.Location = new System.Drawing.Point(4, 29);
            this.tabpg3.Name = "tabpg3";
            this.tabpg3.Padding = new System.Windows.Forms.Padding(3);
            this.tabpg3.Size = new System.Drawing.Size(1157, 716);
            this.tabpg3.TabIndex = 2;
            this.tabpg3.Text = "Graph";
            this.tabpg3.UseVisualStyleBackColor = true;
            // 
            // raceChart
            // 
            chartArea1.Name = "ChartArea1";
            this.raceChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.raceChart.Legends.Add(legend1);
            this.raceChart.Location = new System.Drawing.Point(40, 41);
            this.raceChart.Name = "raceChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Race Info";
            this.raceChart.Series.Add(series1);
            this.raceChart.Size = new System.Drawing.Size(1022, 504);
            this.raceChart.TabIndex = 0;
            this.raceChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1157, 646);
            this.Controls.Add(this.tcRace);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Tortoise and the Hare Race";
            ((System.ComponentModel.ISupportInitialize)(this.pbRace)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tcRace.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHare)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabpg3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raceChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbRace;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnChangeColourHare;
        private System.Windows.Forms.Button btnChangeColourTort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnScoreReset;
        private System.Windows.Forms.Timer raceTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblT;
        private System.Windows.Forms.Label lblH;
        private System.Windows.Forms.RadioButton rbFast;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbSlow;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tcRace;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label tiesT;
        private System.Windows.Forms.Label tiesH;
        private System.Windows.Forms.Label losesT;
        private System.Windows.Forms.Label losesH;
        private System.Windows.Forms.Label winsT;
        private System.Windows.Forms.Label winsH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabpg3;
        private System.Windows.Forms.DataVisualization.Charting.Chart raceChart;
        private System.Windows.Forms.PictureBox pbTort;
        private System.Windows.Forms.PictureBox pbHare;
        private System.Windows.Forms.ComboBox cbChooseMode;
    }
}

