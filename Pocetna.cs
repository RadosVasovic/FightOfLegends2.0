using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightOfLegends2._0
{
    public partial class Pocetna : Form
    {
        // private Form1 formaInstance;
        private bool toggle = true;
        public Pocetna()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           // formaInstance = new Form1();
        }

        private void Pocetna_Load(object sender, EventArgs e)
        {
            sounding.BackgroundImageLayout = ImageLayout.Stretch;
            sounding.BackgroundImage = Properties.Resources.soundOn;
            this.KeyPreview = true;
            this.KeyDown += keyIsDOWN;
            //pvAIpressed= false;
        }

        private void keyIsDOWN(object sender, KeyEventArgs e)
        {
            pictureBox1.Hide();
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult result = MessageBox.Show("Wanna exit?", "Nah, u crazyy", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
        Form1 form = new Form1();
        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pVai_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            form.PvAImode();

        }

        private void pVp_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
        }

        private void practiseTool_Click(object sender, EventArgs e)
        {
            this.Hide();
            form.Show();
            form.HideForPractiseTool();
        }

        private void sounding_Click(object sender, EventArgs e)
        {
            toggle = !toggle;
            form.SoundOnOff(toggle);
            if (toggle == true)
            {
                sounding.BackgroundImage = Properties.Resources.soundOn;
            }
            if (toggle == false)
            {
                sounding.BackgroundImage = Properties.Resources.soundOn___Copy;
            }
        }
    }
}
