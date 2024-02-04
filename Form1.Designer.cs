namespace FightOfLegends2._0
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
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.cdr1 = new System.Windows.Forms.Label();
            this.cdr2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nidalieButtonPlayer1 = new System.Windows.Forms.Button();
            this.player = new System.Windows.Forms.PictureBox();
            this.yasuoButtonPlayer1 = new System.Windows.Forms.Button();
            this.bardButtonPlayer1 = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.PictureBox();
            this.bardButtonPlayer2 = new System.Windows.Forms.Button();
            this.yasuoButtonPlayer2 = new System.Windows.Forms.Button();
            this.nidalieButtonPlayer2 = new System.Windows.Forms.Button();
            this.hp1 = new System.Windows.Forms.Label();
            this.hp2 = new System.Windows.Forms.Label();
            this.score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // cdr1
            // 
            this.cdr1.AutoSize = true;
            this.cdr1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr1.Location = new System.Drawing.Point(161, 368);
            this.cdr1.Name = "cdr1";
            this.cdr1.Size = new System.Drawing.Size(63, 34);
            this.cdr1.TabIndex = 3;
            this.cdr1.Text = "HP:";
            // 
            // cdr2
            // 
            this.cdr2.AutoSize = true;
            this.cdr2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdr2.Location = new System.Drawing.Point(674, 368);
            this.cdr2.Name = "cdr2";
            this.cdr2.Size = new System.Drawing.Size(63, 34);
            this.cdr2.TabIndex = 4;
            this.cdr2.Text = "HP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "Press ENTER to start when ready";
            // 
            // nidalieButtonPlayer1
            // 
            this.nidalieButtonPlayer1.BackgroundImage = global::FightOfLegends2._0.Properties.Resources.nidalieIcon;
            this.nidalieButtonPlayer1.Location = new System.Drawing.Point(109, 149);
            this.nidalieButtonPlayer1.Name = "nidalieButtonPlayer1";
            this.nidalieButtonPlayer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nidalieButtonPlayer1.Size = new System.Drawing.Size(58, 52);
            this.nidalieButtonPlayer1.TabIndex = 5;
            this.nidalieButtonPlayer1.UseVisualStyleBackColor = true;
            this.nidalieButtonPlayer1.Click += new System.EventHandler(this.nidalieButtonPlayer1_Click);
            // 
            // player
            // 
            this.player.Image = global::FightOfLegends2._0.Properties.Resources.needalie;
            this.player.Location = new System.Drawing.Point(109, 29);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(217, 93);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // yasuoButtonPlayer1
            // 
            this.yasuoButtonPlayer1.BackgroundImage = global::FightOfLegends2._0.Properties.Resources.yasuo2;
            this.yasuoButtonPlayer1.Location = new System.Drawing.Point(190, 149);
            this.yasuoButtonPlayer1.Name = "yasuoButtonPlayer1";
            this.yasuoButtonPlayer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yasuoButtonPlayer1.Size = new System.Drawing.Size(58, 52);
            this.yasuoButtonPlayer1.TabIndex = 7;
            this.yasuoButtonPlayer1.UseVisualStyleBackColor = true;
            this.yasuoButtonPlayer1.Click += new System.EventHandler(this.yasuoButtonPlayer1_Click);
            // 
            // bardButtonPlayer1
            // 
            this.bardButtonPlayer1.BackgroundImage = global::FightOfLegends2._0.Properties.Resources.imFine;
            this.bardButtonPlayer1.Location = new System.Drawing.Point(268, 149);
            this.bardButtonPlayer1.Name = "bardButtonPlayer1";
            this.bardButtonPlayer1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bardButtonPlayer1.Size = new System.Drawing.Size(58, 52);
            this.bardButtonPlayer1.TabIndex = 8;
            this.bardButtonPlayer1.UseVisualStyleBackColor = true;
            this.bardButtonPlayer1.Click += new System.EventHandler(this.bardButtonPlayer1_Click);
            // 
            // player2
            // 
            this.player2.Image = global::FightOfLegends2._0.Properties.Resources.needalie;
            this.player2.Location = new System.Drawing.Point(476, 29);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(217, 93);
            this.player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player2.TabIndex = 9;
            this.player2.TabStop = false;
            // 
            // bardButtonPlayer2
            // 
            this.bardButtonPlayer2.BackgroundImage = global::FightOfLegends2._0.Properties.Resources.imFine;
            this.bardButtonPlayer2.Location = new System.Drawing.Point(637, 149);
            this.bardButtonPlayer2.Name = "bardButtonPlayer2";
            this.bardButtonPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bardButtonPlayer2.Size = new System.Drawing.Size(58, 52);
            this.bardButtonPlayer2.TabIndex = 12;
            this.bardButtonPlayer2.UseVisualStyleBackColor = true;
            this.bardButtonPlayer2.Click += new System.EventHandler(this.bardButtonPlayer2_Click);
            // 
            // yasuoButtonPlayer2
            // 
            this.yasuoButtonPlayer2.BackgroundImage = global::FightOfLegends2._0.Properties.Resources.yasuo2;
            this.yasuoButtonPlayer2.Location = new System.Drawing.Point(559, 149);
            this.yasuoButtonPlayer2.Name = "yasuoButtonPlayer2";
            this.yasuoButtonPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yasuoButtonPlayer2.Size = new System.Drawing.Size(58, 52);
            this.yasuoButtonPlayer2.TabIndex = 11;
            this.yasuoButtonPlayer2.UseVisualStyleBackColor = true;
            this.yasuoButtonPlayer2.Click += new System.EventHandler(this.yasuoButtonPlayer2_Click);
            // 
            // nidalieButtonPlayer2
            // 
            this.nidalieButtonPlayer2.BackgroundImage = global::FightOfLegends2._0.Properties.Resources.nidalieIcon;
            this.nidalieButtonPlayer2.Location = new System.Drawing.Point(478, 149);
            this.nidalieButtonPlayer2.Name = "nidalieButtonPlayer2";
            this.nidalieButtonPlayer2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nidalieButtonPlayer2.Size = new System.Drawing.Size(58, 52);
            this.nidalieButtonPlayer2.TabIndex = 10;
            this.nidalieButtonPlayer2.UseVisualStyleBackColor = true;
            this.nidalieButtonPlayer2.Click += new System.EventHandler(this.nidalieButtonPlayer2_Click);
            // 
            // hp1
            // 
            this.hp1.AutoSize = true;
            this.hp1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp1.Location = new System.Drawing.Point(12, 368);
            this.hp1.Name = "hp1";
            this.hp1.Size = new System.Drawing.Size(63, 34);
            this.hp1.TabIndex = 13;
            this.hp1.Text = "HP:";
            // 
            // hp2
            // 
            this.hp2.AutoSize = true;
            this.hp2.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp2.Location = new System.Drawing.Point(522, 368);
            this.hp2.Name = "hp2";
            this.hp2.Size = new System.Drawing.Size(63, 34);
            this.hp2.TabIndex = 14;
            this.hp2.Text = "HP:";
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("MV Boli", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(359, 9);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(78, 29);
            this.score.TabIndex = 15;
            this.score.Text = "0 - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.score);
            this.Controls.Add(this.hp2);
            this.Controls.Add(this.hp1);
            this.Controls.Add(this.bardButtonPlayer2);
            this.Controls.Add(this.yasuoButtonPlayer2);
            this.Controls.Add(this.nidalieButtonPlayer2);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.bardButtonPlayer1);
            this.Controls.Add(this.yasuoButtonPlayer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nidalieButtonPlayer1);
            this.Controls.Add(this.cdr2);
            this.Controls.Add(this.cdr1);
            this.Controls.Add(this.player);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.gameKeyIsPressed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox needalie2;
        private System.Windows.Forms.Label cdr1;
        private System.Windows.Forms.Label cdr2;
        private System.Windows.Forms.Button nidalieButtonPlayer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yasuoButtonPlayer1;
        private System.Windows.Forms.Button bardButtonPlayer1;
        private System.Windows.Forms.PictureBox player2;
        private System.Windows.Forms.Button bardButtonPlayer2;
        private System.Windows.Forms.Button yasuoButtonPlayer2;
        private System.Windows.Forms.Button nidalieButtonPlayer2;
        private System.Windows.Forms.Label hp1;
        private System.Windows.Forms.Label hp2;
        private System.Windows.Forms.Label score;
    }
}

