using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace FightOfLegends2._0
{
    class Nidalee : Player
    {
        public string direction;
        public int kopljeLeft;
        public int kopljeTop;
        bool tmp = false;


        private int speed = 10;
        private PictureBox koplje = new PictureBox();
        private Timer nidaleeTimer= new Timer();
        public Nidalee() {
            this.healt = 1000;
            this.cd = 3 * 20;
        }

        public override int attack()
        {
            return 0;
        }

        public override void takeDmg(int dmg)
        {
            this.healt -= dmg;
        }

        public override double getHp()
        {
            return 0;
        }

        public override void makeAbility(Form1 form)
        {
            koplje.Image = Properties.Resources.koplje;
            koplje.Size = new Size(396, 33);
            koplje.SizeMode = PictureBoxSizeMode.StretchImage;
            koplje.Tag = "koplje";
            koplje.Left = kopljeLeft;
            koplje.Top = kopljeTop;
            koplje.BringToFront();

            form.Controls.Add(koplje);

            nidaleeTimer.Interval = speed;
            nidaleeTimer.Tick += new EventHandler(NidaleeTimerEvent);
            nidaleeTimer.Start();
        }

        public override void changeTag(string tag)
        {
            koplje.Tag = tag;
        }
        private void NidaleeTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                koplje.Image = Properties.Resources.koplje___Copy;
                koplje.Left -= speed;
                tmp = true;
            }
            if (direction == "right")
            {
                koplje.Image = Properties.Resources.koplje;
                koplje.Left += speed;
                tmp = false;
            }
            if (direction == "up" || direction == "down")
            {
                if (tmp == true)
                {
                    koplje.Left -= speed;
                }
                if (tmp == false)
                {
                    koplje.Left += speed;
                }
            }
            if (koplje.Left < -400 || koplje.Left > 1500)
            {
                nidaleeTimer.Stop();
                nidaleeTimer.Dispose();
                koplje.Dispose();
                nidaleeTimer= null;
                koplje=null;
            }
        }
        public override void resetAbility()
        {
            cd = 3 * 20;
        }


    }
}
