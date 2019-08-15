namespace snakeGameThree
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
            this.startBtn = new System.Windows.Forms.Button();
            this.gameTitle = new System.Windows.Forms.Label();
            this.gameVer = new System.Windows.Forms.Label();
            this.labelDev = new System.Windows.Forms.Label();
            this.bordersOnLabel = new System.Windows.Forms.Label();
            this.bordersOffLabel = new System.Windows.Forms.Label();
            this.bordersOn = new System.Windows.Forms.CheckBox();
            this.bordersOff = new System.Windows.Forms.CheckBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.labelTimer = new System.Windows.Forms.Timer(this.components);
            this.labelOver = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.scoreCont = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pressSpace = new System.Windows.Forms.Label();
            this.sodaPB = new System.Windows.Forms.PictureBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.sodaTimer = new System.Windows.Forms.Timer(this.components);
            this.yorkshirePB = new System.Windows.Forms.PictureBox();
            this.hintLabel = new System.Windows.Forms.Label();
            this.easyBtn = new System.Windows.Forms.Button();
            this.normalBtn = new System.Windows.Forms.Button();
            this.hardBtn = new System.Windows.Forms.Button();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.veryHardBtn = new System.Windows.Forms.Button();
            this.gameOverTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sodaPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yorkshirePB)).BeginInit();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.Sienna;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.startBtn.Location = new System.Drawing.Point(669, 425);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(144, 44);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            this.startBtn.MouseEnter += new System.EventHandler(this.startBtn_MouseEnter);
            this.startBtn.MouseLeave += new System.EventHandler(this.startBtn_MouseLeave);
            // 
            // gameTitle
            // 
            this.gameTitle.AutoSize = true;
            this.gameTitle.BackColor = System.Drawing.Color.ForestGreen;
            this.gameTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameTitle.Font = new System.Drawing.Font("Rocks__G", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameTitle.Location = new System.Drawing.Point(120, 81);
            this.gameTitle.Name = "gameTitle";
            this.gameTitle.Size = new System.Drawing.Size(374, 64);
            this.gameTitle.TabIndex = 2;
            this.gameTitle.Text = "Snake Game";
            // 
            // gameVer
            // 
            this.gameVer.AutoSize = true;
            this.gameVer.BackColor = System.Drawing.Color.ForestGreen;
            this.gameVer.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameVer.Location = new System.Drawing.Point(229, 157);
            this.gameVer.Name = "gameVer";
            this.gameVer.Size = new System.Drawing.Size(126, 42);
            this.gameVer.TabIndex = 3;
            this.gameVer.Text = "Ver 2.0";
            // 
            // labelDev
            // 
            this.labelDev.AutoSize = true;
            this.labelDev.BackColor = System.Drawing.Color.ForestGreen;
            this.labelDev.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDev.ForeColor = System.Drawing.Color.Lime;
            this.labelDev.Location = new System.Drawing.Point(32, 450);
            this.labelDev.Name = "labelDev";
            this.labelDev.Size = new System.Drawing.Size(279, 19);
            this.labelDev.TabIndex = 4;
            this.labelDev.Text = "Developed by: Onur Can Nişanci";
            // 
            // bordersOnLabel
            // 
            this.bordersOnLabel.AutoSize = true;
            this.bordersOnLabel.BackColor = System.Drawing.Color.DarkRed;
            this.bordersOnLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bordersOnLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bordersOnLabel.Location = new System.Drawing.Point(679, 133);
            this.bordersOnLabel.Name = "bordersOnLabel";
            this.bordersOnLabel.Size = new System.Drawing.Size(142, 24);
            this.bordersOnLabel.TabIndex = 5;
            this.bordersOnLabel.Text = "Borders: ON";
            // 
            // bordersOffLabel
            // 
            this.bordersOffLabel.AutoSize = true;
            this.bordersOffLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.bordersOffLabel.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bordersOffLabel.Location = new System.Drawing.Point(679, 171);
            this.bordersOffLabel.Name = "bordersOffLabel";
            this.bordersOffLabel.Size = new System.Drawing.Size(154, 24);
            this.bordersOffLabel.TabIndex = 6;
            this.bordersOffLabel.Text = "Borders: OFF";
            // 
            // bordersOn
            // 
            this.bordersOn.AutoSize = true;
            this.bordersOn.Checked = true;
            this.bordersOn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bordersOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bordersOn.Location = new System.Drawing.Point(658, 141);
            this.bordersOn.Name = "bordersOn";
            this.bordersOn.Size = new System.Drawing.Size(15, 14);
            this.bordersOn.TabIndex = 7;
            this.bordersOn.UseVisualStyleBackColor = true;
            this.bordersOn.CheckedChanged += new System.EventHandler(this.bordersOn_CheckedChanged);
            // 
            // bordersOff
            // 
            this.bordersOff.AutoSize = true;
            this.bordersOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bordersOff.Location = new System.Drawing.Point(658, 179);
            this.bordersOff.Name = "bordersOff";
            this.bordersOff.Size = new System.Drawing.Size(15, 14);
            this.bordersOff.TabIndex = 8;
            this.bordersOff.UseVisualStyleBackColor = true;
            this.bordersOff.CheckedChanged += new System.EventHandler(this.bordersOff_CheckedChanged);
            // 
            // progressBar
            // 
            this.progressBar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar.Location = new System.Drawing.Point(647, 336);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(100, 23);
            this.progressBar.TabIndex = 9;
            this.progressBar.Value = 100;
            this.progressBar.Visible = false;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelSpeed.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSpeed.Location = new System.Drawing.Point(653, 295);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(77, 26);
            this.labelSpeed.TabIndex = 10;
            this.labelSpeed.Text = "Speed:";
            this.labelSpeed.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 80;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // labelTimer
            // 
            this.labelTimer.Interval = 900;
            this.labelTimer.Tick += new System.EventHandler(this.labelTimer_Tick);
            // 
            // labelOver
            // 
            this.labelOver.AutoSize = true;
            this.labelOver.BackColor = System.Drawing.Color.Lime;
            this.labelOver.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelOver.Location = new System.Drawing.Point(38, 167);
            this.labelOver.Name = "labelOver";
            this.labelOver.Size = new System.Drawing.Size(0, 32);
            this.labelOver.TabIndex = 11;
            this.labelOver.Visible = false;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.BackColor = System.Drawing.Color.MediumTurquoise;
            this.labelScore.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.ForeColor = System.Drawing.Color.DarkViolet;
            this.labelScore.Location = new System.Drawing.Point(690, 105);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(82, 29);
            this.labelScore.TabIndex = 13;
            this.labelScore.Text = "Score:";
            this.labelScore.Visible = false;
            // 
            // scoreCont
            // 
            this.scoreCont.AutoSize = true;
            this.scoreCont.BackColor = System.Drawing.Color.Black;
            this.scoreCont.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreCont.ForeColor = System.Drawing.Color.LawnGreen;
            this.scoreCont.Location = new System.Drawing.Point(703, 140);
            this.scoreCont.Name = "scoreCont";
            this.scoreCont.Size = new System.Drawing.Size(25, 28);
            this.scoreCont.TabIndex = 14;
            this.scoreCont.Text = "0";
            this.scoreCont.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(588, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 453);
            this.label1.TabIndex = 15;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(22, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 453);
            this.label2.TabIndex = 16;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(31, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(566, 10);
            this.label3.TabIndex = 17;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(31, 474);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(566, 10);
            this.label4.TabIndex = 18;
            this.label4.Visible = false;
            // 
            // pressSpace
            // 
            this.pressSpace.AutoSize = true;
            this.pressSpace.BackColor = System.Drawing.Color.MediumTurquoise;
            this.pressSpace.Font = new System.Drawing.Font("Consolas", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pressSpace.ForeColor = System.Drawing.Color.MidnightBlue;
            this.pressSpace.Location = new System.Drawing.Point(628, 373);
            this.pressSpace.Name = "pressSpace";
            this.pressSpace.Size = new System.Drawing.Size(217, 15);
            this.pressSpace.TabIndex = 19;
            this.pressSpace.Text = "Press \'Space\' key to speed up!";
            this.pressSpace.Visible = false;
            // 
            // sodaPB
            // 
            this.sodaPB.BackColor = System.Drawing.Color.ForestGreen;
            this.sodaPB.Image = ((System.Drawing.Image)(resources.GetObject("sodaPB.Image")));
            this.sodaPB.Location = new System.Drawing.Point(197, 242);
            this.sodaPB.Name = "sodaPB";
            this.sodaPB.Size = new System.Drawing.Size(20, 31);
            this.sodaPB.TabIndex = 20;
            this.sodaPB.TabStop = false;
            this.sodaPB.Visible = false;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.ForestGreen;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox.Location = new System.Drawing.Point(25, 31);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(573, 453);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // sodaTimer
            // 
            this.sodaTimer.Interval = 1000;
            this.sodaTimer.Tick += new System.EventHandler(this.sodaTimer_Tick);
            // 
            // yorkshirePB
            // 
            this.yorkshirePB.BackColor = System.Drawing.Color.ForestGreen;
            this.yorkshirePB.Image = ((System.Drawing.Image)(resources.GetObject("yorkshirePB.Image")));
            this.yorkshirePB.Location = new System.Drawing.Point(295, 242);
            this.yorkshirePB.Name = "yorkshirePB";
            this.yorkshirePB.Size = new System.Drawing.Size(36, 40);
            this.yorkshirePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.yorkshirePB.TabIndex = 22;
            this.yorkshirePB.TabStop = false;
            this.yorkshirePB.Visible = false;
            // 
            // hintLabel
            // 
            this.hintLabel.AutoSize = true;
            this.hintLabel.BackColor = System.Drawing.Color.MediumTurquoise;
            this.hintLabel.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hintLabel.ForeColor = System.Drawing.Color.DarkGreen;
            this.hintLabel.Location = new System.Drawing.Point(628, 402);
            this.hintLabel.Name = "hintLabel";
            this.hintLabel.Size = new System.Drawing.Size(203, 28);
            this.hintLabel.TabIndex = 23;
            this.hintLabel.Text = "*HINT: Drink soda to fill up\r\nspeed bar.";
            this.hintLabel.Visible = false;
            // 
            // easyBtn
            // 
            this.easyBtn.AutoSize = true;
            this.easyBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.easyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.easyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.easyBtn.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.easyBtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.easyBtn.Location = new System.Drawing.Point(669, 250);
            this.easyBtn.Name = "easyBtn";
            this.easyBtn.Size = new System.Drawing.Size(121, 32);
            this.easyBtn.TabIndex = 24;
            this.easyBtn.Text = "Easy";
            this.easyBtn.UseVisualStyleBackColor = false;
            this.easyBtn.Click += new System.EventHandler(this.select_difficulty);
            // 
            // normalBtn
            // 
            this.normalBtn.AutoSize = true;
            this.normalBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.normalBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.normalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.normalBtn.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.normalBtn.ForeColor = System.Drawing.Color.AntiqueWhite;
            this.normalBtn.Location = new System.Drawing.Point(669, 288);
            this.normalBtn.Name = "normalBtn";
            this.normalBtn.Size = new System.Drawing.Size(121, 32);
            this.normalBtn.TabIndex = 25;
            this.normalBtn.Text = "Normal";
            this.normalBtn.UseVisualStyleBackColor = false;
            this.normalBtn.Click += new System.EventHandler(this.select_difficulty);
            // 
            // hardBtn
            // 
            this.hardBtn.AutoSize = true;
            this.hardBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.hardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.hardBtn.Font = new System.Drawing.Font("Consolas", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hardBtn.ForeColor = System.Drawing.Color.DarkRed;
            this.hardBtn.Location = new System.Drawing.Point(669, 324);
            this.hardBtn.Name = "hardBtn";
            this.hardBtn.Size = new System.Drawing.Size(121, 32);
            this.hardBtn.TabIndex = 26;
            this.hardBtn.Text = "Hard";
            this.hardBtn.UseVisualStyleBackColor = false;
            this.hardBtn.Click += new System.EventHandler(this.select_difficulty);
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.BackColor = System.Drawing.Color.Black;
            this.labelDifficulty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDifficulty.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDifficulty.ForeColor = System.Drawing.Color.Lime;
            this.labelDifficulty.Location = new System.Drawing.Point(631, 217);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(227, 21);
            this.labelDifficulty.TabIndex = 27;
            this.labelDifficulty.Text = "-Select game difficulty:\r\n";
            // 
            // veryHardBtn
            // 
            this.veryHardBtn.AutoSize = true;
            this.veryHardBtn.BackColor = System.Drawing.Color.Crimson;
            this.veryHardBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.veryHardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.veryHardBtn.Font = new System.Drawing.Font("Consolas", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.veryHardBtn.ForeColor = System.Drawing.Color.LightPink;
            this.veryHardBtn.Location = new System.Drawing.Point(669, 362);
            this.veryHardBtn.Name = "veryHardBtn";
            this.veryHardBtn.Size = new System.Drawing.Size(136, 32);
            this.veryHardBtn.TabIndex = 29;
            this.veryHardBtn.Text = "Very Hard!!!";
            this.veryHardBtn.UseVisualStyleBackColor = false;
            this.veryHardBtn.Click += new System.EventHandler(this.select_difficulty);
            // 
            // gameOverTitle
            // 
            this.gameOverTitle.AutoSize = true;
            this.gameOverTitle.BackColor = System.Drawing.Color.Lime;
            this.gameOverTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gameOverTitle.Font = new System.Drawing.Font("Rocks__G", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverTitle.Location = new System.Drawing.Point(144, 81);
            this.gameOverTitle.Name = "gameOverTitle";
            this.gameOverTitle.Size = new System.Drawing.Size(341, 64);
            this.gameOverTitle.TabIndex = 30;
            this.gameOverTitle.Text = "Game Over";
            this.gameOverTitle.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(876, 517);
            this.Controls.Add(this.gameOverTitle);
            this.Controls.Add(this.veryHardBtn);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.hardBtn);
            this.Controls.Add(this.normalBtn);
            this.Controls.Add(this.easyBtn);
            this.Controls.Add(this.hintLabel);
            this.Controls.Add(this.yorkshirePB);
            this.Controls.Add(this.sodaPB);
            this.Controls.Add(this.pressSpace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.scoreCont);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelOver);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.bordersOff);
            this.Controls.Add(this.bordersOn);
            this.Controls.Add(this.bordersOffLabel);
            this.Controls.Add(this.bordersOnLabel);
            this.Controls.Add(this.labelDev);
            this.Controls.Add(this.gameVer);
            this.Controls.Add(this.gameTitle);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.pictureBox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.sodaPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yorkshirePB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label gameTitle;
        private System.Windows.Forms.Label gameVer;
        private System.Windows.Forms.Label labelDev;
        private System.Windows.Forms.Label bordersOnLabel;
        private System.Windows.Forms.Label bordersOffLabel;
        private System.Windows.Forms.CheckBox bordersOn;
        private System.Windows.Forms.CheckBox bordersOff;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Timer labelTimer;
        private System.Windows.Forms.Label labelOver;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label scoreCont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pressSpace;
        private System.Windows.Forms.PictureBox sodaPB;
        private System.Windows.Forms.Timer sodaTimer;
        private System.Windows.Forms.PictureBox yorkshirePB;
        private System.Windows.Forms.Label hintLabel;
        private System.Windows.Forms.Button easyBtn;
        private System.Windows.Forms.Button normalBtn;
        private System.Windows.Forms.Button hardBtn;
        private System.Windows.Forms.Label labelDifficulty;
        private System.Windows.Forms.Button veryHardBtn;
        private System.Windows.Forms.Label gameOverTitle;
    }
}

