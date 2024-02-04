using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace FightOfLegends2._0
{
    public partial class Form1 : Form
    {
        //player 1 + things
        bool goLeft, goRight, goUp, goDown, start = false, pvAI = false, musica = true, practiseTool = false, gg= false;
        string facing = "right";
        int speed = 10;    
        string pickChampion = "yasuo";
        int cd = 0;
        int php1 = 1000;

        int score1 = 0, score2 = 0;

        
        //player 2
        bool goLeft2, goRight2, goUp2, goDown2;
        string facing2 = "right";
        string pickChampion2 = "nidalee";
        int speed2 = 10;
        int cd2 = 0;
        int php2 = 1000;


        private SoundPlayer zvuk;
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.KeyPreview = true;

            zvuk = new SoundPlayer();
            zvuk.Stream = Properties.Resources.yasuoUlt;
        }

        //GLAVNI TAJMER
        private void gameTimerEvent(object sender, EventArgs e)
        {
            hp1.Text = "HP: " + php1;
            hp2.Text = "HP: " + php2;
            //player 1
            if (pickChampion == "nidalee")
            {
                speed = 10;
            }
            if (pickChampion == "yasuo")
            {
                speed = 20;
            }
            if (pickChampion == "bard")
            {
                speed = 15;
            }

            //player 2
            if (pickChampion2 == "nidalee")
            {
                speed2 = 10;
            }
            if (pickChampion2 == "yasuo")
            {
                speed2 = 20;
            }
            if (pickChampion2 == "bard")
            {
                speed2 = 15;
            }

            //player 1
            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }
            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }
            if (goUp == true && player.Top > 0)
            {
                player.Top -= speed;
            }
            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }
            if (cd > 0)
            {
                cd--;
                cdr1.Text = "CD: " + cd.ToString();
            }
            else cdr1.Text = "ready";


            //player 2
            if (goRight2 == true && player2.Left + player2.Width < this.ClientSize.Width)
            {
                player2.Left += speed2;
            }
            if (goLeft2 == true && player2.Left > 0)
            {
                player2.Left -= speed2;
            }
            if (goUp2 == true && player2.Top > 0)
            {
                player2.Top -= speed2;
            }
            if (goDown2 == true && player2.Top + player2.Height < this.ClientSize.Height)
            {
                player2.Top += speed2;
            }
            if (cd2 > 0)
            {
                cd2--;
                cdr2.Text = "CD: " + cd2.ToString();
            }
            else cdr2.Text = "ready";


            //start
            if (start == true)
            {
                label1.Hide();
                nidalieButtonPlayer1.Hide();
                nidalieButtonPlayer1.Visible = false;
                yasuoButtonPlayer1.Hide();
                yasuoButtonPlayer1.Visible = false;
                bardButtonPlayer1.Hide();
                bardButtonPlayer1.Visible = false;
                nidalieButtonPlayer2.Hide();
                nidalieButtonPlayer2.Visible = false;
                yasuoButtonPlayer2.Hide();
                yasuoButtonPlayer2.Visible = false;
                bardButtonPlayer2.Hide();
                bardButtonPlayer2.Visible = false;
            }


            //AI
            if (pvAI == true && start == true)
            {
                Random goreDole = new Random();
                Random ability = new Random();
                int koliko = 10;
                int kolikoAbility = 100;
                int goreIliDole = goreDole.Next(0, koliko);
                int abilityDa = ability.Next(0, kolikoAbility);
                if (goreIliDole < koliko/2 && player2.Top > 0)
                {
                    player2.Top -= speed ;
                }
                if (goreIliDole >= koliko/2 && player2.Top + player2.Height < this.ClientSize.Height)
                {
                    player2.Top += speed ;
                }
                if (abilityDa == kolikoAbility-1)
                {
                    ShootAbility2("left");
                }
            }


            //hitboxovi :(
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "koplje2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        php1 -= 100;

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "katana2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        php1 -= 50;

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "univerzum2")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        php1 -= 1000;

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "koplje" && practiseTool != true)
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds))
                    {
                        php2 -= 100;

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "katana" && practiseTool != true)
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds))
                    {
                        php2 -= 50;

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }

                if (x is PictureBox && (string)x.Tag == "univerzum" && practiseTool!= true)
                {
                    if (player2.Bounds.IntersectsWith(x.Bounds))
                    {
                        php2 -= 1000;

                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                    }
                }
            }

            //restart
            if (php1 <= 0 || php2 <= 0)
            {
                if (php1 <= 0)
                {
                    score2++;
                    score.Text = score1 + " - " + score2;
                }
                if (php2 <= 0)
                {
                    score1++;
                    score.Text = score1 + " - " + score2;
                }
                    
                gameTimer.Stop();
                gameTimer.Dispose();
                gg = true;
                label1.Text = "Press R to restart";
                label1.Show();
                label1.BringToFront();
            }
        }

        private void RestartGame()
        {
            php1 = 1000;
            php2 = 1000;
            cd = 0;
            cd2 = 0;
            gameTimer.Start();

            label1.Hide();
        }

        private void gameKeyIsPressed(object sender, KeyPressEventArgs e)
        {
            
        } //ignorisati

        private void nidalieButtonPlayer1_Click(object sender, EventArgs e)
        {
            pickChampion = "nidalee";
        }

        private void nidalieButtonPlayer2_Click(object sender, EventArgs e)
        {
            pickChampion2 = "nidalee";
        }

        private void yasuoButtonPlayer2_Click(object sender, EventArgs e)
        {
            pickChampion2 = "yasuo";
        }

        private void bardButtonPlayer2_Click(object sender, EventArgs e)
        {
            pickChampion2 = "bard";
        }

        private void yasuoButtonPlayer1_Click(object sender, EventArgs e)
        {
            pickChampion= "yasuo";
        }

        private void bardButtonPlayer1_Click(object sender, EventArgs e)
        {
            pickChampion = "bard";
        }

        private void gameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D)
            {
                goRight= false;
            }
            if (e.KeyCode == Keys.A)
            {
                goLeft= false;
            }
            if (e.KeyCode == Keys.W)
            {
                goUp= false;
            }
            if (e.KeyCode == Keys.S)
            {
                goDown= false;
            }

            if (e.KeyCode == Keys.L)
            {
                goRight2 = false;
            }
            if (e.KeyCode == Keys.J)
            {
                goLeft2 = false;
            }
            if (e.KeyCode == Keys.I)
            {
                goUp2 = false;
            }
            if (e.KeyCode == Keys.K)
            {
                goDown2 = false;
            }


            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
                Pocetna pocetna= new Pocetna();
                pocetna.Show();
                
            }
            if (e.KeyCode == Keys.Enter)
            {
                start = true;
            }
            if (e.KeyCode == Keys.R && gg == true)
            {
                RestartGame();
            }
        }

        private void gameKeyDown(object sender, KeyEventArgs e)
        {

            //movement player 1
            if (start == true)
            {
                if (pickChampion == "nidalee")
                {
                    if (e.KeyCode == Keys.D)
                    {
                        goRight = true;
                        facing = "right";
                        player.Image = Properties.Resources.needalie___Copy;
                    }
                    if (e.KeyCode == Keys.A)
                    {
                        goLeft = true;
                        facing = "left";
                        player.Image = Properties.Resources.needalie;
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        goUp = true;
                        facing = "up";
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        goDown = true;
                        facing = "down";
                    }

                    if (e.KeyCode == Keys.E && cd == 0)
                    {
                        ShootAbility(facing);
                        cd = 3 * 20;
                        zvuk.Stream = Properties.Resources.nidaleeMjau;
                        if(musica == true) 
                            zvuk.Play();
                    }
                }

                if (pickChampion == "yasuo")
                {
                    if (e.KeyCode == Keys.D)
                    {
                        goRight = true;
                        facing = "right";
                        player.Image = Properties.Resources.yasuo2;
                    }
                    if (e.KeyCode == Keys.A)
                    {
                        goLeft = true;
                        facing = "left";
                        player.Image = Properties.Resources.yasuo;
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        goUp = true;
                        facing = "up";
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        goDown = true;
                        facing = "down";
                    }

                    if (e.KeyCode == Keys.E && cd == 0)
                    {
                        ShootAbility(facing);
                        cd = 1 * 20;
                        zvuk.Stream = Properties.Resources.yasuoUlt;
                        if (musica == true) 
                            zvuk.Play();
                    }
                }

                if (pickChampion == "bard")
                {
                    if (e.KeyCode == Keys.D)
                    {
                        goRight = true;
                        facing = "right";
                        player.Image = Properties.Resources.imFine2;
                    }
                    if (e.KeyCode == Keys.A)
                    {
                        goLeft = true;
                        facing = "left";
                        player.Image = Properties.Resources.imFine;
                    }
                    if (e.KeyCode == Keys.W)
                    {
                        goUp = true;
                        facing = "up";
                    }
                    if (e.KeyCode == Keys.S)
                    {
                        goDown = true;
                        facing = "down";
                    }

                    if (e.KeyCode == Keys.E && cd == 0)
                    {
                        ShootAbility(facing);
                        cd = 10 * 20;
                        zvuk.Stream = Properties.Resources.bardMMMMM;
                        if (musica == true)
                            zvuk.Play();
                    }
                }
            }

            //movement player 2
            if (start == true && pvAI == false)
            {
                if (pickChampion2 == "nidalee")
                {
                    if (e.KeyCode == Keys.L)
                    {
                        goRight2 = true;
                        facing2 = "right";
                        player2.Image = Properties.Resources.needalie___Copy;
                    }
                    if (e.KeyCode == Keys.J)
                    {
                        goLeft2 = true;
                        facing2 = "left";
                        player2.Image = Properties.Resources.needalie;
                    }
                    if (e.KeyCode == Keys.I)
                    {
                        goUp2 = true;
                        facing2 = "up";
                    }
                    if (e.KeyCode == Keys.K)
                    {
                        goDown2 = true;
                        facing2 = "down";
                    }

                    if (e.KeyCode == Keys.O && cd2 == 0)
                    {
                        ShootAbility2(facing2);
                        cd2 = 3 * 20;
                        zvuk.Stream = Properties.Resources.nidaleeMjau;
                        if (musica == true)
                            zvuk.Play();
                    }
                }

                if (pickChampion2 == "yasuo")
                {
                    if (e.KeyCode == Keys.L)
                    {
                        goRight2 = true;
                        facing2 = "right";
                        player2.Image = Properties.Resources.yasuo2;
                    }
                    if (e.KeyCode == Keys.J)
                    {
                        goLeft2 = true;
                        facing2 = "left";
                        player2.Image = Properties.Resources.yasuo;
                    }
                    if (e.KeyCode == Keys.I)
                    {
                        goUp2 = true;
                        facing2 = "up";
                    }
                    if (e.KeyCode == Keys.K)
                    {
                        goDown2 = true;
                        facing2 = "down";
                    }

                    if (e.KeyCode == Keys.O && cd2 == 0)
                    {
                        ShootAbility2(facing2);
                        cd2 = 1 * 20;
                        zvuk.Stream = Properties.Resources.yasuoUlt;
                        if (musica == true)
                            zvuk.Play();
                    }
                }

                if (pickChampion2 == "bard")
                {
                    if (e.KeyCode == Keys.L)
                    {
                        goRight2 = true;
                        facing2 = "right";
                        player2.Image = Properties.Resources.imFine2;
                    }
                    if (e.KeyCode == Keys.J)
                    {
                        goLeft2 = true;
                        facing2 = "left";
                        player2.Image = Properties.Resources.imFine;
                    }
                    if (e.KeyCode == Keys.I)
                    {
                        goUp2 = true;
                        facing2 = "up";
                    }
                    if (e.KeyCode == Keys.K)
                    {
                        goDown2 = true;
                        facing2 = "down";
                    }

                    if (e.KeyCode == Keys.O && cd2 == 0)
                    {
                        ShootAbility2(facing2);
                        cd2 = 10 * 20;
                        zvuk.Stream = Properties.Resources.bardMMMMM;
                        if (musica == true)
                            zvuk.Play();
                    }
                }
            }
        }
        
        private void ShootAbility(string direction)
        {
            if (pickChampion == "nidalee")
            {
                Nidalee ispaliKoplje = new Nidalee();
                ispaliKoplje.direction = direction;
                if (direction == "right")
                {
                    ispaliKoplje.kopljeLeft = player.Left + (player.Width / 2) - 350;
                }
                else ispaliKoplje.kopljeLeft = player.Left + (player.Width / 2) - 50;
                ispaliKoplje.kopljeTop = player.Top + (player.Height / 2) + 40;
                ispaliKoplje.makeAbility(this);
                ispaliKoplje.changeTag("koplje");
            }

            if (pickChampion == "yasuo")
            {
                Yasuo ispaliKoplje = new Yasuo();
                ispaliKoplje.direction = direction;
                if (direction == "left")
                {
                    ispaliKoplje.katanaLeft = player.Left + (player.Width / 2) - 350;
                }
                else ispaliKoplje.katanaLeft = player.Left + (player.Width / 2) - 50;
                ispaliKoplje.katanaTop = player.Top + (player.Height / 2) + 40;
                ispaliKoplje.makeAbility(this);
                ispaliKoplje.changeTag("katana");
            }

            if (pickChampion == "bard")
            {
                Bard ispaliKoplje = new Bard();
                ispaliKoplje.direction = direction;
                if (direction == "left")
                {
                    ispaliKoplje.univerzumLeft = player.Left + (player.Width / 2) - 350;
                }
                else ispaliKoplje.univerzumLeft = player.Left + (player.Width / 2) - 50;
                ispaliKoplje.univerzumTop = player.Top + (player.Height / 2) -150;
                ispaliKoplje.makeAbility(this);
                ispaliKoplje.changeTag("univerzum");
            }
        }

        private void ShootAbility2(string direction)
        {
            if (pickChampion2 == "nidalee")
            {
                Nidalee ispaliKoplje = new Nidalee();
                ispaliKoplje.direction = direction;
                if (direction == "right")
                {
                    ispaliKoplje.kopljeLeft = player2.Left + (player2.Width / 2) - 350;
                }
                else ispaliKoplje.kopljeLeft = player2.Left + (player2.Width / 2) - 50;
                ispaliKoplje.kopljeTop = player2.Top + (player2.Height / 2) + 40;
                ispaliKoplje.makeAbility(this);
                ispaliKoplje.changeTag("koplje2");
            }

            if (pickChampion2 == "yasuo")
            {
                Yasuo ispaliKoplje = new Yasuo();
                ispaliKoplje.direction = direction;
                if (direction == "left")
                {
                    ispaliKoplje.katanaLeft = player2.Left + (player2.Width / 2) - 350;
                }
                else ispaliKoplje.katanaLeft = player2.Left + (player2.Width / 2) - 50;
                ispaliKoplje.katanaTop = player2.Top + (player2.Height / 2) + 40;
                ispaliKoplje.makeAbility(this);
                ispaliKoplje.changeTag("katana2");
            }

            if (pickChampion2 == "bard")
            {
                Bard ispaliKoplje = new Bard();
                ispaliKoplje.direction = direction;
                if (direction == "left")
                {
                    ispaliKoplje.univerzumLeft = player2.Left + (player2.Width / 2) - 350;
                }
                else ispaliKoplje.univerzumLeft = player2.Left + (player2.Width / 2) - 50;
                ispaliKoplje.univerzumTop = player2.Top + (player2.Height / 2) - 150;
                ispaliKoplje.makeAbility(this);
                ispaliKoplje.changeTag("univerzum2");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            nidalieButtonPlayer1.BackgroundImageLayout = ImageLayout.Stretch;
            yasuoButtonPlayer1.BackgroundImageLayout = ImageLayout.Stretch;
            bardButtonPlayer1.BackgroundImageLayout = ImageLayout.Stretch;
            nidalieButtonPlayer2.BackgroundImageLayout = ImageLayout.Stretch;
            yasuoButtonPlayer2.BackgroundImageLayout = ImageLayout.Stretch;
            bardButtonPlayer2.BackgroundImageLayout = ImageLayout.Stretch;
        }

        public void HideForPractiseTool()
        {
            nidalieButtonPlayer2.Hide();
            nidalieButtonPlayer2.Visible= false;
            yasuoButtonPlayer2.Hide();
            yasuoButtonPlayer2.Visible = false;
            bardButtonPlayer2.Hide();
            bardButtonPlayer2.Visible = false;
            player2.Hide();
            player2.Visible = false;
            practiseTool = true;
            cdr2.Hide();
            hp2.Hide();
            score.Hide();
        }

        public void PvAImode()
        {
            nidalieButtonPlayer2.Hide();
            nidalieButtonPlayer2.Visible = false;
            yasuoButtonPlayer2.Hide();
            yasuoButtonPlayer2.Visible = false;
            bardButtonPlayer2.Hide();
            bardButtonPlayer2.Visible = false;
            cdr2.Hide();
            pvAI = true;
            score.Hide();
        }

        public void SoundOnOff(bool toggle)
        {
            if (toggle == true)
            {
                musica = true;
            }
            if (toggle == false) 
            {
                musica = false;
            }
        }
    }
}
