namespace FightOfLegends2._0
{
    partial class Pocetna
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
            this.pVai = new System.Windows.Forms.Button();
            this.pVp = new System.Windows.Forms.Button();
            this.practiseTool = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sounding = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pVai
            // 
            this.pVai.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pVai.Location = new System.Drawing.Point(251, 110);
            this.pVai.Name = "pVai";
            this.pVai.Size = new System.Drawing.Size(261, 64);
            this.pVai.TabIndex = 1;
            this.pVai.Text = "player VS AI";
            this.pVai.UseVisualStyleBackColor = true;
            this.pVai.Click += new System.EventHandler(this.pVai_Click);
            // 
            // pVp
            // 
            this.pVp.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pVp.Location = new System.Drawing.Point(251, 208);
            this.pVp.Name = "pVp";
            this.pVp.Size = new System.Drawing.Size(261, 64);
            this.pVp.TabIndex = 2;
            this.pVp.Text = "player VS player";
            this.pVp.UseVisualStyleBackColor = true;
            this.pVp.Click += new System.EventHandler(this.pVp_Click);
            // 
            // practiseTool
            // 
            this.practiseTool.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.practiseTool.Location = new System.Drawing.Point(251, 306);
            this.practiseTool.Name = "practiseTool";
            this.practiseTool.Size = new System.Drawing.Size(261, 64);
            this.practiseTool.TabIndex = 3;
            this.practiseTool.Text = "practise tool";
            this.practiseTool.UseVisualStyleBackColor = true;
            this.practiseTool.Click += new System.EventHandler(this.practiseTool_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(12, 412);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(81, 41);
            this.exit.TabIndex = 4;
            this.exit.Text = "exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 34);
            this.label1.TabIndex = 7;
            this.label1.Text = "WE ARE MAKING OUT OF BRAWL STARS WITH DIS ONE";
            // 
            // sounding
            // 
            this.sounding.Font = new System.Drawing.Font("MV Boli", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sounding.Location = new System.Drawing.Point(741, 412);
            this.sounding.Name = "sounding";
            this.sounding.Size = new System.Drawing.Size(47, 41);
            this.sounding.TabIndex = 8;
            this.sounding.UseVisualStyleBackColor = true;
            this.sounding.Click += new System.EventHandler(this.sounding_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FightOfLegends2._0.Properties.Resources.pocetna1;
            this.pictureBox1.Location = new System.Drawing.Point(-58, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(909, 539);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 465);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sounding);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.practiseTool);
            this.Controls.Add(this.pVp);
            this.Controls.Add(this.pVai);
            this.Name = "Pocetna";
            this.Text = "Pocetna";
            this.Load += new System.EventHandler(this.Pocetna_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDOWN);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button pVai;
        private System.Windows.Forms.Button pVp;
        private System.Windows.Forms.Button practiseTool;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button sounding;
    }
}