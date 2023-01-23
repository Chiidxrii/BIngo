namespace BIngo
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.escLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.bingoButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.timeLabel = new System.Windows.Forms.Label();
            this.numcallButton = new System.Windows.Forms.Button();
            this.numcallOutput = new System.Windows.Forms.Label();
            this.numboxLabel = new System.Windows.Forms.Label();
            this.b5Button = new System.Windows.Forms.Button();
            this.b4Button = new System.Windows.Forms.Button();
            this.b3Button = new System.Windows.Forms.Button();
            this.b2Button = new System.Windows.Forms.Button();
            this.b1Button = new System.Windows.Forms.Button();
            this.i1Button = new System.Windows.Forms.Button();
            this.g1Button = new System.Windows.Forms.Button();
            this.o1Button = new System.Windows.Forms.Button();
            this.n1Button = new System.Windows.Forms.Button();
            this.i2Button = new System.Windows.Forms.Button();
            this.i3Button = new System.Windows.Forms.Button();
            this.i4Button = new System.Windows.Forms.Button();
            this.i5Button = new System.Windows.Forms.Button();
            this.n2Button = new System.Windows.Forms.Button();
            this.n3Button = new System.Windows.Forms.Button();
            this.n4Button = new System.Windows.Forms.Button();
            this.n5Button = new System.Windows.Forms.Button();
            this.g2Button = new System.Windows.Forms.Button();
            this.g3Button = new System.Windows.Forms.Button();
            this.g4Button = new System.Windows.Forms.Button();
            this.g5Button = new System.Windows.Forms.Button();
            this.o2Button = new System.Windows.Forms.Button();
            this.o3Button = new System.Windows.Forms.Button();
            this.o4Button = new System.Windows.Forms.Button();
            this.o5Button = new System.Windows.Forms.Button();
            this.bingoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.titleLabel.Location = new System.Drawing.Point(342, 105);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(263, 76);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bingo!";
            // 
            // escLabel
            // 
            this.escLabel.AutoSize = true;
            this.escLabel.BackColor = System.Drawing.Color.Transparent;
            this.escLabel.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.escLabel.Location = new System.Drawing.Point(1, 568);
            this.escLabel.Name = "escLabel";
            this.escLabel.Size = new System.Drawing.Size(231, 23);
            this.escLabel.TabIndex = 1;
            this.escLabel.Text = "press esc to exit";
            // 
            // startButton
            // 
            this.startButton.AutoSize = true;
            this.startButton.BackColor = System.Drawing.Color.LightGreen;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.startButton.Location = new System.Drawing.Point(396, 285);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(130, 130);
            this.startButton.TabIndex = 2;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // bingoButton
            // 
            this.bingoButton.AutoSize = true;
            this.bingoButton.BackColor = System.Drawing.Color.LightGreen;
            this.bingoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bingoButton.Font = new System.Drawing.Font("Courier New", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoButton.ForeColor = System.Drawing.Color.Black;
            this.bingoButton.Location = new System.Drawing.Point(35, 514);
            this.bingoButton.Name = "bingoButton";
            this.bingoButton.Size = new System.Drawing.Size(162, 53);
            this.bingoButton.TabIndex = 3;
            this.bingoButton.Text = "BINGO!";
            this.bingoButton.UseVisualStyleBackColor = false;
            this.bingoButton.Visible = false;
            this.bingoButton.Click += new System.EventHandler(this.bingoButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.AutoSize = true;
            this.stopButton.BackColor = System.Drawing.Color.LightCoral;
            this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopButton.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Black;
            this.stopButton.Location = new System.Drawing.Point(282, 514);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(122, 48);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "STOP!";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Visible = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(288, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(100, 32);
            this.timeLabel.TabIndex = 5;
            this.timeLabel.Text = "7:30";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numcallButton
            // 
            this.numcallButton.AutoSize = true;
            this.numcallButton.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.numcallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.numcallButton.Font = new System.Drawing.Font("Courier New", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcallButton.ForeColor = System.Drawing.Color.Black;
            this.numcallButton.Location = new System.Drawing.Point(59, 195);
            this.numcallButton.Name = "numcallButton";
            this.numcallButton.Size = new System.Drawing.Size(90, 43);
            this.numcallButton.TabIndex = 6;
            this.numcallButton.Text = "NEXT";
            this.numcallButton.UseVisualStyleBackColor = false;
            this.numcallButton.Visible = false;
            this.numcallButton.Click += new System.EventHandler(this.numcallButton_Click);
            // 
            // numcallOutput
            // 
            this.numcallOutput.BackColor = System.Drawing.Color.Transparent;
            this.numcallOutput.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numcallOutput.Location = new System.Drawing.Point(185, 185);
            this.numcallOutput.Name = "numcallOutput";
            this.numcallOutput.Size = new System.Drawing.Size(226, 300);
            this.numcallOutput.TabIndex = 7;
            // 
            // numboxLabel
            // 
            this.numboxLabel.BackColor = System.Drawing.Color.Transparent;
            this.numboxLabel.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numboxLabel.Location = new System.Drawing.Point(40, 50);
            this.numboxLabel.Name = "numboxLabel";
            this.numboxLabel.Size = new System.Drawing.Size(125, 125);
            this.numboxLabel.TabIndex = 8;
            // 
            // b5Button
            // 
            this.b5Button.BackColor = System.Drawing.Color.Transparent;
            this.b5Button.Enabled = false;
            this.b5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b5Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5Button.Location = new System.Drawing.Point(452, 457);
            this.b5Button.Name = "b5Button";
            this.b5Button.Size = new System.Drawing.Size(87, 83);
            this.b5Button.TabIndex = 9;
            this.b5Button.Text = "B5";
            this.b5Button.UseVisualStyleBackColor = false;
            this.b5Button.Visible = false;
            this.b5Button.Click += new System.EventHandler(this.b5Button_Click);
            // 
            // b4Button
            // 
            this.b4Button.BackColor = System.Drawing.Color.Transparent;
            this.b4Button.Enabled = false;
            this.b4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b4Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4Button.Location = new System.Drawing.Point(452, 374);
            this.b4Button.Name = "b4Button";
            this.b4Button.Size = new System.Drawing.Size(87, 83);
            this.b4Button.TabIndex = 10;
            this.b4Button.Text = "B4";
            this.b4Button.UseVisualStyleBackColor = false;
            this.b4Button.Visible = false;
            this.b4Button.Click += new System.EventHandler(this.b4Button_Click);
            // 
            // b3Button
            // 
            this.b3Button.BackColor = System.Drawing.Color.Transparent;
            this.b3Button.Enabled = false;
            this.b3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b3Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3Button.Location = new System.Drawing.Point(452, 291);
            this.b3Button.Name = "b3Button";
            this.b3Button.Size = new System.Drawing.Size(87, 83);
            this.b3Button.TabIndex = 11;
            this.b3Button.Text = "B3";
            this.b3Button.UseVisualStyleBackColor = false;
            this.b3Button.Visible = false;
            this.b3Button.Click += new System.EventHandler(this.b3Button_Click);
            // 
            // b2Button
            // 
            this.b2Button.BackColor = System.Drawing.Color.Transparent;
            this.b2Button.Enabled = false;
            this.b2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b2Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2Button.Location = new System.Drawing.Point(452, 208);
            this.b2Button.Name = "b2Button";
            this.b2Button.Size = new System.Drawing.Size(87, 83);
            this.b2Button.TabIndex = 12;
            this.b2Button.Text = "B2";
            this.b2Button.UseVisualStyleBackColor = false;
            this.b2Button.Visible = false;
            this.b2Button.Click += new System.EventHandler(this.b2Button_Click);
            // 
            // b1Button
            // 
            this.b1Button.BackColor = System.Drawing.Color.Transparent;
            this.b1Button.Enabled = false;
            this.b1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b1Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1Button.Location = new System.Drawing.Point(452, 125);
            this.b1Button.Name = "b1Button";
            this.b1Button.Size = new System.Drawing.Size(87, 83);
            this.b1Button.TabIndex = 13;
            this.b1Button.Text = "B1";
            this.b1Button.UseVisualStyleBackColor = false;
            this.b1Button.Visible = false;
            this.b1Button.Click += new System.EventHandler(this.b1Button_Click);
            // 
            // i1Button
            // 
            this.i1Button.BackColor = System.Drawing.Color.Transparent;
            this.i1Button.Enabled = false;
            this.i1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i1Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i1Button.Location = new System.Drawing.Point(542, 125);
            this.i1Button.Name = "i1Button";
            this.i1Button.Size = new System.Drawing.Size(87, 83);
            this.i1Button.TabIndex = 14;
            this.i1Button.Text = "I1";
            this.i1Button.UseVisualStyleBackColor = false;
            this.i1Button.Visible = false;
            this.i1Button.Click += new System.EventHandler(this.i1Button_Click);
            // 
            // g1Button
            // 
            this.g1Button.BackColor = System.Drawing.Color.Transparent;
            this.g1Button.Enabled = false;
            this.g1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g1Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g1Button.Location = new System.Drawing.Point(722, 125);
            this.g1Button.Name = "g1Button";
            this.g1Button.Size = new System.Drawing.Size(87, 83);
            this.g1Button.TabIndex = 15;
            this.g1Button.Text = "G1";
            this.g1Button.UseVisualStyleBackColor = false;
            this.g1Button.Visible = false;
            this.g1Button.Click += new System.EventHandler(this.g1Button_Click);
            // 
            // o1Button
            // 
            this.o1Button.BackColor = System.Drawing.Color.Transparent;
            this.o1Button.Enabled = false;
            this.o1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o1Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o1Button.Location = new System.Drawing.Point(812, 125);
            this.o1Button.Name = "o1Button";
            this.o1Button.Size = new System.Drawing.Size(87, 83);
            this.o1Button.TabIndex = 16;
            this.o1Button.Text = "O1";
            this.o1Button.UseVisualStyleBackColor = false;
            this.o1Button.Visible = false;
            this.o1Button.Click += new System.EventHandler(this.o1Button_Click);
            // 
            // n1Button
            // 
            this.n1Button.BackColor = System.Drawing.Color.Transparent;
            this.n1Button.Enabled = false;
            this.n1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n1Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n1Button.Location = new System.Drawing.Point(632, 125);
            this.n1Button.Name = "n1Button";
            this.n1Button.Size = new System.Drawing.Size(87, 83);
            this.n1Button.TabIndex = 17;
            this.n1Button.Text = "N1";
            this.n1Button.UseVisualStyleBackColor = false;
            this.n1Button.Visible = false;
            this.n1Button.Click += new System.EventHandler(this.n1Button_Click);
            // 
            // i2Button
            // 
            this.i2Button.BackColor = System.Drawing.Color.Transparent;
            this.i2Button.Enabled = false;
            this.i2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i2Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i2Button.Location = new System.Drawing.Point(542, 208);
            this.i2Button.Name = "i2Button";
            this.i2Button.Size = new System.Drawing.Size(87, 83);
            this.i2Button.TabIndex = 21;
            this.i2Button.Text = "I2";
            this.i2Button.UseVisualStyleBackColor = false;
            this.i2Button.Visible = false;
            this.i2Button.Click += new System.EventHandler(this.i2Button_Click);
            // 
            // i3Button
            // 
            this.i3Button.BackColor = System.Drawing.Color.Transparent;
            this.i3Button.Enabled = false;
            this.i3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i3Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i3Button.Location = new System.Drawing.Point(542, 291);
            this.i3Button.Name = "i3Button";
            this.i3Button.Size = new System.Drawing.Size(87, 83);
            this.i3Button.TabIndex = 20;
            this.i3Button.Text = "I3";
            this.i3Button.UseVisualStyleBackColor = false;
            this.i3Button.Visible = false;
            this.i3Button.Click += new System.EventHandler(this.i3Button_Click);
            // 
            // i4Button
            // 
            this.i4Button.BackColor = System.Drawing.Color.Transparent;
            this.i4Button.Enabled = false;
            this.i4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i4Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i4Button.Location = new System.Drawing.Point(542, 374);
            this.i4Button.Name = "i4Button";
            this.i4Button.Size = new System.Drawing.Size(87, 83);
            this.i4Button.TabIndex = 19;
            this.i4Button.Text = "I4";
            this.i4Button.UseVisualStyleBackColor = false;
            this.i4Button.Visible = false;
            this.i4Button.Click += new System.EventHandler(this.i4Button_Click);
            // 
            // i5Button
            // 
            this.i5Button.BackColor = System.Drawing.Color.Transparent;
            this.i5Button.Enabled = false;
            this.i5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.i5Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.i5Button.Location = new System.Drawing.Point(542, 457);
            this.i5Button.Name = "i5Button";
            this.i5Button.Size = new System.Drawing.Size(87, 83);
            this.i5Button.TabIndex = 18;
            this.i5Button.Text = "I5";
            this.i5Button.UseVisualStyleBackColor = false;
            this.i5Button.Visible = false;
            this.i5Button.Click += new System.EventHandler(this.i5Button_Click);
            // 
            // n2Button
            // 
            this.n2Button.BackColor = System.Drawing.Color.Transparent;
            this.n2Button.Enabled = false;
            this.n2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n2Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n2Button.Location = new System.Drawing.Point(632, 208);
            this.n2Button.Name = "n2Button";
            this.n2Button.Size = new System.Drawing.Size(87, 83);
            this.n2Button.TabIndex = 25;
            this.n2Button.Text = "N2";
            this.n2Button.UseVisualStyleBackColor = false;
            this.n2Button.Visible = false;
            this.n2Button.Click += new System.EventHandler(this.n2Button_Click);
            // 
            // n3Button
            // 
            this.n3Button.BackColor = System.Drawing.Color.Transparent;
            this.n3Button.Enabled = false;
            this.n3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n3Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n3Button.Location = new System.Drawing.Point(632, 291);
            this.n3Button.Name = "n3Button";
            this.n3Button.Size = new System.Drawing.Size(87, 83);
            this.n3Button.TabIndex = 24;
            this.n3Button.Text = "N3";
            this.n3Button.UseVisualStyleBackColor = false;
            this.n3Button.Visible = false;
            this.n3Button.Click += new System.EventHandler(this.n3Button_Click);
            // 
            // n4Button
            // 
            this.n4Button.BackColor = System.Drawing.Color.Transparent;
            this.n4Button.Enabled = false;
            this.n4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n4Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n4Button.Location = new System.Drawing.Point(632, 374);
            this.n4Button.Name = "n4Button";
            this.n4Button.Size = new System.Drawing.Size(87, 83);
            this.n4Button.TabIndex = 23;
            this.n4Button.Text = "N4";
            this.n4Button.UseVisualStyleBackColor = false;
            this.n4Button.Visible = false;
            this.n4Button.Click += new System.EventHandler(this.n4Button_Click);
            // 
            // n5Button
            // 
            this.n5Button.BackColor = System.Drawing.Color.Transparent;
            this.n5Button.Enabled = false;
            this.n5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.n5Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n5Button.Location = new System.Drawing.Point(632, 457);
            this.n5Button.Name = "n5Button";
            this.n5Button.Size = new System.Drawing.Size(87, 83);
            this.n5Button.TabIndex = 22;
            this.n5Button.Text = "N5";
            this.n5Button.UseVisualStyleBackColor = false;
            this.n5Button.Visible = false;
            this.n5Button.Click += new System.EventHandler(this.n5Button_Click);
            // 
            // g2Button
            // 
            this.g2Button.BackColor = System.Drawing.Color.Transparent;
            this.g2Button.Enabled = false;
            this.g2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g2Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g2Button.Location = new System.Drawing.Point(722, 208);
            this.g2Button.Name = "g2Button";
            this.g2Button.Size = new System.Drawing.Size(87, 83);
            this.g2Button.TabIndex = 29;
            this.g2Button.Text = "G2";
            this.g2Button.UseVisualStyleBackColor = false;
            this.g2Button.Visible = false;
            this.g2Button.Click += new System.EventHandler(this.g2Button_Click);
            // 
            // g3Button
            // 
            this.g3Button.BackColor = System.Drawing.Color.Transparent;
            this.g3Button.Enabled = false;
            this.g3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g3Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g3Button.Location = new System.Drawing.Point(722, 291);
            this.g3Button.Name = "g3Button";
            this.g3Button.Size = new System.Drawing.Size(87, 83);
            this.g3Button.TabIndex = 28;
            this.g3Button.Text = "G3";
            this.g3Button.UseVisualStyleBackColor = false;
            this.g3Button.Visible = false;
            this.g3Button.Click += new System.EventHandler(this.g3Button_Click);
            // 
            // g4Button
            // 
            this.g4Button.BackColor = System.Drawing.Color.Transparent;
            this.g4Button.Enabled = false;
            this.g4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g4Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g4Button.Location = new System.Drawing.Point(722, 374);
            this.g4Button.Name = "g4Button";
            this.g4Button.Size = new System.Drawing.Size(87, 83);
            this.g4Button.TabIndex = 27;
            this.g4Button.Text = "G4";
            this.g4Button.UseVisualStyleBackColor = false;
            this.g4Button.Visible = false;
            this.g4Button.Click += new System.EventHandler(this.g4Button_Click);
            // 
            // g5Button
            // 
            this.g5Button.BackColor = System.Drawing.Color.Transparent;
            this.g5Button.Enabled = false;
            this.g5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.g5Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.g5Button.Location = new System.Drawing.Point(722, 457);
            this.g5Button.Name = "g5Button";
            this.g5Button.Size = new System.Drawing.Size(87, 83);
            this.g5Button.TabIndex = 26;
            this.g5Button.Text = "G5";
            this.g5Button.UseVisualStyleBackColor = false;
            this.g5Button.Visible = false;
            this.g5Button.Click += new System.EventHandler(this.g5Button_Click);
            // 
            // o2Button
            // 
            this.o2Button.BackColor = System.Drawing.Color.Transparent;
            this.o2Button.Enabled = false;
            this.o2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o2Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o2Button.Location = new System.Drawing.Point(812, 208);
            this.o2Button.Name = "o2Button";
            this.o2Button.Size = new System.Drawing.Size(87, 83);
            this.o2Button.TabIndex = 33;
            this.o2Button.Text = "O2";
            this.o2Button.UseVisualStyleBackColor = false;
            this.o2Button.Visible = false;
            this.o2Button.Click += new System.EventHandler(this.o2Button_Click);
            // 
            // o3Button
            // 
            this.o3Button.BackColor = System.Drawing.Color.Transparent;
            this.o3Button.Enabled = false;
            this.o3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o3Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o3Button.Location = new System.Drawing.Point(812, 291);
            this.o3Button.Name = "o3Button";
            this.o3Button.Size = new System.Drawing.Size(87, 83);
            this.o3Button.TabIndex = 32;
            this.o3Button.Text = "O3";
            this.o3Button.UseVisualStyleBackColor = false;
            this.o3Button.Visible = false;
            this.o3Button.Click += new System.EventHandler(this.o3Button_Click);
            // 
            // o4Button
            // 
            this.o4Button.BackColor = System.Drawing.Color.Transparent;
            this.o4Button.Enabled = false;
            this.o4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o4Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o4Button.Location = new System.Drawing.Point(812, 374);
            this.o4Button.Name = "o4Button";
            this.o4Button.Size = new System.Drawing.Size(87, 83);
            this.o4Button.TabIndex = 31;
            this.o4Button.Text = "O4";
            this.o4Button.UseVisualStyleBackColor = false;
            this.o4Button.Visible = false;
            this.o4Button.Click += new System.EventHandler(this.o4Button_Click);
            // 
            // o5Button
            // 
            this.o5Button.BackColor = System.Drawing.Color.Transparent;
            this.o5Button.Enabled = false;
            this.o5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.o5Button.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.o5Button.Location = new System.Drawing.Point(812, 457);
            this.o5Button.Name = "o5Button";
            this.o5Button.Size = new System.Drawing.Size(87, 83);
            this.o5Button.TabIndex = 30;
            this.o5Button.Text = "O5";
            this.o5Button.UseVisualStyleBackColor = false;
            this.o5Button.Visible = false;
            this.o5Button.Click += new System.EventHandler(this.o5Button_Click);
            // 
            // bingoLabel
            // 
            this.bingoLabel.BackColor = System.Drawing.Color.Transparent;
            this.bingoLabel.Font = new System.Drawing.Font("Courier New", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bingoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bingoLabel.Location = new System.Drawing.Point(464, 46);
            this.bingoLabel.Name = "bingoLabel";
            this.bingoLabel.Size = new System.Drawing.Size(456, 76);
            this.bingoLabel.TabIndex = 34;
            this.bingoLabel.Text = "B I N G O";
            this.bingoLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(950, 600);
            this.Controls.Add(this.bingoLabel);
            this.Controls.Add(this.b1Button);
            this.Controls.Add(this.o2Button);
            this.Controls.Add(this.o3Button);
            this.Controls.Add(this.o4Button);
            this.Controls.Add(this.o5Button);
            this.Controls.Add(this.g2Button);
            this.Controls.Add(this.g3Button);
            this.Controls.Add(this.g4Button);
            this.Controls.Add(this.g5Button);
            this.Controls.Add(this.n2Button);
            this.Controls.Add(this.n3Button);
            this.Controls.Add(this.n4Button);
            this.Controls.Add(this.n5Button);
            this.Controls.Add(this.i2Button);
            this.Controls.Add(this.i3Button);
            this.Controls.Add(this.i4Button);
            this.Controls.Add(this.i5Button);
            this.Controls.Add(this.n1Button);
            this.Controls.Add(this.o1Button);
            this.Controls.Add(this.g1Button);
            this.Controls.Add(this.i1Button);
            this.Controls.Add(this.b2Button);
            this.Controls.Add(this.b3Button);
            this.Controls.Add(this.b4Button);
            this.Controls.Add(this.numboxLabel);
            this.Controls.Add(this.numcallButton);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.bingoButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.escLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.numcallOutput);
            this.Controls.Add(this.b5Button);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label escLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button bingoButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Button numcallButton;
        private System.Windows.Forms.Label numcallOutput;
        private System.Windows.Forms.Label numboxLabel;
        private System.Windows.Forms.Button b5Button;
        private System.Windows.Forms.Button b4Button;
        private System.Windows.Forms.Button b3Button;
        private System.Windows.Forms.Button b2Button;
        private System.Windows.Forms.Button b1Button;
        private System.Windows.Forms.Button i1Button;
        private System.Windows.Forms.Button g1Button;
        private System.Windows.Forms.Button o1Button;
        private System.Windows.Forms.Button n1Button;
        private System.Windows.Forms.Button i2Button;
        private System.Windows.Forms.Button i3Button;
        private System.Windows.Forms.Button i4Button;
        private System.Windows.Forms.Button i5Button;
        private System.Windows.Forms.Button n2Button;
        private System.Windows.Forms.Button n3Button;
        private System.Windows.Forms.Button n4Button;
        private System.Windows.Forms.Button n5Button;
        private System.Windows.Forms.Button g2Button;
        private System.Windows.Forms.Button g3Button;
        private System.Windows.Forms.Button g4Button;
        private System.Windows.Forms.Button g5Button;
        private System.Windows.Forms.Button o2Button;
        private System.Windows.Forms.Button o3Button;
        private System.Windows.Forms.Button o4Button;
        private System.Windows.Forms.Button o5Button;
        private System.Windows.Forms.Label bingoLabel;
    }
}

