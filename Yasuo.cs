using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FightOfLegends2._0
{
    class Yasuo : Player
    {
        public string direction;
        public int katanaLeft;
        public int katanaTop;
        bool tmp = false;
        private float rotationAngle;



        private int speed = 10;
        private PictureBox katana = new PictureBox();
        private Timer yasuoTimer = new Timer();
        public Yasuo()
        {
            this.healt = 2000;
            this.cd = 1 * 20;
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
            katana.Image = Properties.Resources.katana;
            katana.Size = new Size(396, 200);
            katana.SizeMode = PictureBoxSizeMode.StretchImage;
            katana.Tag = "katana";
            katana.Left = katanaLeft;
            katana.Top = katanaTop;
            katana.BringToFront();

            form.Controls.Add(katana);

            yasuoTimer.Interval = speed;
            yasuoTimer.Tick += new EventHandler(YasuoTimerEvent);
            yasuoTimer.Start();
            if (direction == "left")
            {
                katana.Image = Properties.Resources.katana;
            }
            else
            {
                katana.Image = Properties.Resources.katana;
            }

        }

        public override void changeTag(string tag)
        {
            katana.Tag = tag;
        }
        private void RotateSword(float angle)
        {
            
            Bitmap rotatedImage = RotateImage(Properties.Resources.katana, angle);
            katana.Image = rotatedImage;
        }
        private Bitmap RotateImage(Image image, float angle)
        {
            // Rotacija
            Bitmap rotatedImage = new Bitmap(image.Width, image.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(image.Width / 2, image.Height / 2);
                g.RotateTransform(angle);
                g.TranslateTransform(-image.Width / 2, -image.Height / 2);
                //g.ScaleTransform(1, -1); // Flip vertically
                g.DrawImage(image, new Point(0, 0));
            }

            return rotatedImage;
        }
        private void YasuoTimerEvent(object sender, EventArgs e)
        {
            rotationAngle += 1; // brzina rotiranja

            RotateSword(rotationAngle);

            
            if (rotationAngle >= 90)
            {
                
                yasuoTimer.Stop();
                katana.Visible = false;
            }

            //if (direction == "left")
            //{
            //    katana.Image = Properties.Resources.katana;
            //    katana.Left -= speed;
            //    tmp = true;
            //}
            //if (direction == "right")
            //{
            //    katana.Image = Properties.Resources.katana;
            //    katana.Left += speed;
            //    tmp = false;
            //}
            //if (direction == "up" || direction == "down")
            //{
            //    if (tmp == true)
            //    {
            //        katana.Left -= speed;
            //    }
            //    if (tmp == false)
            //    {
            //        katana.Left += speed;
            //    }
            //}
            //if (katana.Left < -400 || katana.Left > 1500)
            //{
            //    yasuoTimer.Stop();
            //    yasuoTimer.Dispose();
            //    katana.Dispose();
            //    yasuoTimer = null;
            //    katana = null;
            //}
        }
        public override void resetAbility()
        {
            cd = 1 * 20;
        }


    }
}
