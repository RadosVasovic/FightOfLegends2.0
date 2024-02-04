using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightOfLegends2._0
{
    class Bard : Player
    {
        public string direction;
        public int univerzumLeft;
        public int univerzumTop;
        bool tmp = false;


        private int speed = 10;
        private PictureBox univerzum = new PictureBox();
        private Timer bardTimer = new Timer();
        public Bard()
        {
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
            univerzum.Image = Properties.Resources.univerzum;
            univerzum.Size = new Size(400, 400);
            univerzum.SizeMode = PictureBoxSizeMode.StretchImage;
            univerzum.Tag = "univerzum";
            univerzum.Left = univerzumLeft;
            univerzum.Top = univerzumTop;
            univerzum.BringToFront();

            form.Controls.Add(univerzum);

            bardTimer.Interval = speed;
            bardTimer.Tick += new EventHandler(BardTimerEvent);
            bardTimer.Start();
        }

        public override void changeTag(string tag)
        {
            univerzum.Tag = tag;
        }
        private void BardTimerEvent(object sender, EventArgs e)
        {
            if (direction == "left")
            {
                univerzum.Image = Properties.Resources.univerzum;
                univerzum.Left -= speed;
                tmp = true;
            }
            if (direction == "right")
            {
                univerzum.Image = Properties.Resources.univerzum;
                univerzum.Left += speed;
                tmp = false;
            }
            if (direction == "up" || direction == "down")
            {
                if (tmp == true)
                {
                    univerzum.Left -= speed;
                }
                if (tmp == false)
                {
                    univerzum.Left += speed;
                }
            }
            if (univerzum.Left < -400 || univerzum.Left > 1500)
            {
                bardTimer.Stop();
                bardTimer.Dispose();
                univerzum.Dispose();
                bardTimer = null;
                univerzum = null;
            }
        }
        public override void resetAbility()
        {
            cd = 3 * 20;
        }
    }
}
