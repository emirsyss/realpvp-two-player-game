using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealPVP
{
    public partial class Main : Form
    {

        public int damage = 7;
        public Main()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        Character character = new Character();
        int character1Key = 2;
        int character2Key = 2;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (gameStatus)
            {
                Keys enteredKey = e.KeyCode;

                Keys upKey = Keys.W;
                Keys downKey = Keys.S;
                Keys rightKey = Keys.D;
                Keys leftKey = Keys.A;
                if (enteredKey == upKey)
                {
                    character.goUp = true;
                }
                if (enteredKey == downKey)
                {
                    character.goDown = true;
                }
                if (enteredKey == rightKey)
                {
                    character.goRight = true;
                    character.character1Direction = "right";
                    character1.Image = RealPVP.Properties.Resources.karakter1sag;

                }
                if (enteredKey == leftKey)
                {
                    character.goLeft = true;
                    character.character1Direction = "left";
                    character1.Image = RealPVP.Properties.Resources.karakter1sol;
                }

                Keys upKey2 = Keys.Up;
                Keys downKey2 = Keys.Down;
                Keys rightKey2 = Keys.Right;
                Keys leftKey2 = Keys.Left;
                if (enteredKey == upKey2)
                {
                    character.goUp2 = true;
                }
                if (enteredKey == downKey2)
                {
                    character.goDown2 = true;
                }
                if (enteredKey == rightKey2)
                {
                    character.goRight2 = true;
                    character.character2Direction = "right";
                    character2.Image = RealPVP.Properties.Resources.karakter2sag;
                }
                if (enteredKey == leftKey2)
                {
                    character.goLeft2 = true;
                    character.character2Direction = "left";
                    character2.Image = RealPVP.Properties.Resources.karakter2sol;
                }
            }
            
            
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            label1.Text = character.character1Direction;
            label2.Text = character.character2Direction;
            character.CharacterKeydown(character1, character2, panel1, character1Health, character2Health, character1Weapon, character2Weapon, weapon1ammo, weaponammo2);
            bullets.BulletMovement(panel1);

            foreach (Control x in this.panel1.Controls)
            {
                foreach (Control j in this.panel1.Controls)
                {
                    if (j is Label && (string)j.Name == "ammo" && x is PictureBox && (string)x.Name == "character1")
                    {
                        string ammoText = j.Text;
                        string[] words = ammoText.Split(' ');
                        string ammoType = words[0];
                        if (ammoType == "Rifle")
                        {
                            

                            string ammovalue = words[1];
                            string ammovaluexd = ammovalue.Replace("+","");
                            if (j.Bounds.IntersectsWith(x.Bounds))
                            {
                                int ammoxd = Convert.ToInt32(ammovaluexd);
                                character.character1WeaponRifleAmmo += ammoxd;
                                this.panel1.Controls.Remove(j);
                                ammo.ammos.Clear();
                                ((Label)j).Dispose();

                            }
                        }
                        else if (ammoType == "Pistol")
                        {
                            string ammovalue = words[1];
                            string ammovaluexd = ammovalue.Replace("+", "");
                            if (j.Bounds.IntersectsWith(x.Bounds))
                            {
                                int ammoxd = Convert.ToInt32(ammovaluexd);
                                character.character1WeaponPistolAmmo += ammoxd;
                                this.panel1.Controls.Remove(j);
                                ammo.ammos.Clear();
                                ((Label)j).Dispose();

                            }
                        }
                       

                    }
                    if (j is Label && (string)j.Name == "ammo" && x is PictureBox && (string)x.Name == "character2")
                    {
                        string ammoText = j.Text;
                        string[] words = ammoText.Split(' ');
                        string ammoType = words[0];
                        if (ammoType == "Rifle")
                        {


                            string ammovalue = words[1];
                            string ammovaluexd = ammovalue.Replace("+", "");
                            if (j.Bounds.IntersectsWith(x.Bounds))
                            {
                                int ammoxd = Convert.ToInt32(ammovaluexd);
                                character.character2WeaponRifleAmmo += ammoxd;
                                this.panel1.Controls.Remove(j);
                                ammo.ammos.Clear();
                                ((Label)j).Dispose();

                            }
                            else
                            {
                                
                            }
                        }
                        else if (ammoType == "Pistol")
                        {
                            string ammovalue = words[1];
                            string ammovaluexd = ammovalue.Replace("+", "");
                            if (j.Bounds.IntersectsWith(x.Bounds))
                            {
                                int ammoxd = Convert.ToInt32(ammovaluexd);
                                character.character2WeaponPistolAmmo += ammoxd;
                                this.panel1.Controls.Remove(j);
                                ammo.ammos.Clear();
                                ((Label)j).Dispose();

                            }
                        }
                        else
                        {
                        }


                    }

                    if (j is Panel && (string)j.Name == "sagadogru" && x is PictureBox && (string)x.Name == "character1")
                    {

                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.panel1.Controls.Remove(j);
                            ((Panel)j).Dispose();
                            character1Health.Height = character1Health.Height - damage;
                            if (character1Health.Height <= 91)
                            {
                                character1Health.BackColor = Color.Lime;
                            }
                            if (character1Health.Height <= 63)
                            {
                                character1Health.BackColor = Color.Yellow;
                            }
                            if (character1Health.Height <= 33)
                            {
                                character1Health.BackColor = Color.Red;
                            }
                            if (character1Health.Height <= 0)
                            {
                                StopGame();

                                this.Text = "Real PVP - 2 Player Game - The second player won, congratulations!";
                                RestartGame();

                            }

                        }
                        
                    }
      
                    if (j is Panel && (string)j.Name == "soladogru" && x is PictureBox && (string)x.Name == "character1")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.panel1.Controls.Remove(j);
                            ((Panel)j).Dispose();
                            character1Health.Height = character1Health.Height - damage;
                            if (character1Health.Height <= 91)
                            {
                                character1Health.BackColor = Color.Lime;
                            }
                             if (character1Health.Height <= 63)
                            {
                                character1Health.BackColor = Color.Yellow;
                            }
                             if (character1Health.Height <= 33)
                            {
                                character1Health.BackColor = Color.Red;
                            }
                            if (character1Health.Height <= 0)
                            {
                           
                                StopGame();
                                this.Text = "Real PVP - 2 Player Game - The second player won, congratulations!";
                                RestartGame();

                            }
                        }
                    }
                     if (j is Panel && (string)j.Name == "sagadogru" && x is PictureBox && (string)x.Name == "character2")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.panel1.Controls.Remove(j);
                            ((Panel)j).Dispose();
                            character2Health.Height = character2Health.Height - damage;
                            if (character2Health.Height <= 91)
                            {
                                character2Health.BackColor = Color.Lime;
                            }
                            if(character2Health.Height <= 63)
                            {
                                character2Health.BackColor = Color.Yellow;
                            }
                            if (character2Health.Height <= 33)
                            {
                                character2Health.BackColor = Color.Red;
                            }
                            if (character2Health.Height <= 0)
                            {
          

                                StopGame();
                                this.Text = "Real PVP - 2 Player Game - The first player won, congratulations!";
                                RestartGame();

                            }
                        }
                    }
                     if (j is Panel && (string)j.Name == "soladogru" && x is PictureBox && (string)x.Name == "character2")
                    {
                        if (j.Bounds.IntersectsWith(x.Bounds))
                        {
                            this.panel1.Controls.Remove(j);
                            ((Panel)j).Dispose();
                            character2Health.Height = character2Health.Height - damage;
                            if (character2Health.Height <= 91)
                            {
                                character2Health.BackColor = Color.Lime;
                            }
                             if (character2Health.Height <= 63)
                            {
                                character2Health.BackColor = Color.Yellow;
                            }
                             if (character2Health.Height <= 33)
                            {
                                character2Health.BackColor = Color.Red;
                            }
                            if (character2Health.Height <= 0)
                            {
          
                                
                                StopGame();
                                this.Text = "Real PVP - 2 Player Game - The first player won, congratulations!";
                                RestartGame();


                            }
                        }
                    }
                }
            }

        }

        private  async void Main_KeyUp(object sender, KeyEventArgs e)
        {
            if (gameStatus)
            {
                Keys enteredKey = e.KeyCode;




                Keys upKey = Keys.W;
                Keys downKey = Keys.S;
                Keys rightKey = Keys.D;
                Keys leftKey = Keys.A;
                if (enteredKey == upKey)
                {
                    character.goUp = false;
                  
                }
                if (enteredKey == downKey)
                {
                    character.goDown = false;
                }
                if (enteredKey == rightKey)
                {
                    character.goRight = false;


                }
                if (enteredKey == leftKey)
                {
                    character.goLeft = false;

                }
                if (enteredKey == Keys.D1)
                {
                    character.weapon1 = "pistol";
                }
                if (enteredKey == Keys.D2)
                {
                    character.weapon1 = "rifle";
                }
                if (enteredKey == Keys.D3)
                {
                    character.weapon1 = "knife";
                }

                if (enteredKey == Keys.Space)
                {
                    if (character.weapon1 == "rifle")
                    {

                        if (character.character1WeaponRifleAmmo > 0)
                        {
                            bullets.BulletCreate(character1, panel1, label1, label2);
                            await Task.Delay(5);
                            bullets.BulletCreate(character1, panel1, label1, label2);
                            await Task.Delay(5);
                            bullets.BulletCreate(character1, panel1, label1, label2);
                            character.character1WeaponRifleAmmo = character.character1WeaponRifleAmmo - 1;

                        }

                    }
                    else if (character.weapon1 == "pistol")
                    {
                        if (character.character1WeaponPistolAmmo > 0)
                        {
                            bullets.BulletCreate(character1, panel1, label1, label2);
                            character.character1WeaponPistolAmmo = character.character1WeaponPistolAmmo - 1;
                        }


                    }
                    else if (character.weapon1 == "knife")
                    {
                        Point character1Location = character1.Location;
                        Point character2Location = character2.Location;

                        int distanceX = Math.Abs((character1Location.X) - (character2Location.X));

                        if (distanceX <= 95)
                        {
                            character2Health.Height = character2Health.Height - damage;
                        }
                        if (character2Health.Height <= 91)
                        {
                            character2Health.BackColor = Color.Lime;
                        }
                        if (character2Health.Height <= 63)
                        {
                            character2Health.BackColor = Color.Yellow;
                        }
                        if (character2Health.Height <= 33)
                        {
                            character2Health.BackColor = Color.Red;
                        }
                        if (character2Health.Height <= 0)
                        {
                            StopGame();
                            this.Text = "Real PVP - 2 Player Game - The first player won, congratulations!";
                            RestartGame();
                        }



                    }
                }

                Keys upKey2 = Keys.Up;
                Keys downKey2 = Keys.Down;
                Keys rightKey2 = Keys.Right;
                Keys leftKey2 = Keys.Left;
                if (enteredKey == upKey2)
                {
                    character.goUp2 = false;
                }
                if (enteredKey == downKey2)
                {
                    character.goDown2 = false;
                }
                if (enteredKey == rightKey2)
                {
                    character.goRight2 = false;
                  


                }
                if (enteredKey == leftKey2)
                {
                    character.goLeft2 = false;
                   

                }
                if (enteredKey == Keys.NumPad1)
                {
                    character.weapon2 = "pistol";
                }
                if (enteredKey == Keys.NumPad2)
                {
                    character.weapon2 = "rifle";
                }
                if (enteredKey == Keys.NumPad3)
                {
                    character.weapon2 = "knife";
                }



                if (enteredKey == Keys.Enter)
                {
                    if (character.weapon2 == "rifle")
                    {
                        if (character.character2WeaponRifleAmmo > 0)
                        {
                            bullets.BulletCreate(character2, panel1, label1, label2);
                            await Task.Delay(5);
                            bullets.BulletCreate(character2, panel1, label1, label2);
                            await Task.Delay(5);
                            bullets.BulletCreate(character2, panel1, label1, label2);
                            character.character2WeaponRifleAmmo = character.character2WeaponRifleAmmo - 1;

                        }
                    }
                    else if (character.weapon2 == "pistol")
                    {
                        if (character.character2WeaponPistolAmmo > 0)
                        {
                            bullets.BulletCreate(character2, panel1, label1, label2);
                            character.character2WeaponPistolAmmo = character.character2WeaponPistolAmmo - 1;
                        }
                    }
                    else if (character.weapon2 == "knife")
                    {
                        Point character1Location = character1.Location;
                        Point character2Location = character2.Location;

                        int distanceX = Math.Abs((character1Location.X - character2Location.X));

                        if (distanceX <= 95)
                        {
                            character1Health.Height = character1Health.Height - damage;
                        }
                        if (character1Health.Height <= 91)
                        {
                            character1Health.BackColor = Color.Lime;
                        }
                        if (character1Health.Height <= 63)
                        {
                            character1Health.BackColor = Color.Yellow;
                        }
                        if (character1Health.Height <= 33)
                        {
                            character1Health.BackColor = Color.Red;
                        }
                        if (character1Health.Height <= 0)
                        {
                            StopGame();
                            this.Text = "Real PVP - 2 Player Game - The second player won, congratulations!";
                            RestartGame();


                        }

                    }
                }
            }
                
        }
        Bullets bullets = new Bullets();
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }
        Ammo ammo = new Ammo();
        private void Main_Load(object sender, EventArgs e)
        {
            character1.Image = RealPVP.Properties.Resources.karakter1sag;
            character1.SizeMode = PictureBoxSizeMode.StretchImage;
            character2.Image = RealPVP.Properties.Resources.karakter2sol;
            character2.SizeMode = PictureBoxSizeMode.StretchImage;
            character1Weapon.Image = RealPVP.Properties.Resources.pistol;
            character1Weapon.SizeMode = PictureBoxSizeMode.StretchImage;
            character2Weapon.Image = RealPVP.Properties.Resources.pistol;
            character2Weapon.SizeMode = PictureBoxSizeMode.StretchImage;
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ammo.AmmoCreate(panel1);
         
        }
        public bool gameStatus = true;
        private void StopGame()
        {
            
            foreach (Control x in this.panel1.Controls)
            {
                foreach (Control j in this.panel1.Controls)
                {
                    if (j is Label && (string)j.Name == "ammo" && x is PictureBox && (string)x.Name == "character1")
                    {
                        this.panel1.Controls.Remove(j);
                        ammo.ammos.Clear();
                        ((Label)j).Dispose();


                    }
                    if (j is Label && (string)j.Name == "ammo" && x is PictureBox && (string)x.Name == "character2")
                    {
                        this.panel1.Controls.Remove(j);
                        ammo.ammos.Clear();
                        ((Label)j).Dispose();
                    }

                    if (j is Panel && (string)j.Name == "sagadogru")
                    {
                      
                        this.panel1.Controls.Remove(j);
                        ((Panel)j).Dispose();

                    }

                    if (j is Panel && (string)j.Name == "soladogru")
                    {
                       
                        this.panel1.Controls.Remove(j);
                        ((Panel)j).Dispose();


                    }
                    if (j is Panel && (string)j.Name == "sagadogru")
                    {

                        this.panel1.Controls.Remove(j);
                        ((Panel)j).Dispose();
                    }
                    if (j is Panel && (string)j.Name == "soladogru")
                    {
                       
                        this.panel1.Controls.Remove(j);
                        ((Panel)j).Dispose();
                    }
                }
            }
            gameStatus = false;
            GameTimer.Stop();
            timer1.Stop();
           

        }
        private void RestartGame()
        {
           
            character.character1WeaponPistolAmmo = 8;
            character.character2WeaponPistolAmmo = 8;

            character.character1WeaponRifleAmmo = 3;
            character.character2WeaponRifleAmmo = 3;

            character.goLeft = false;
            character.goLeft2= false;
            character.goDown = false;
            character.goDown2 = false;
            character.goUp = false;
            character.goUp2 = false;
            character.goRight = false;
            character.goRight2 = false;

            character.weapon1 = "pistol";
            character.weapon2 = "pistol";


            gameStatus = true;
            GameTimer.Start();
            timer1.Start();
            character2Health.Height = 91;
            character2Health.Location = new Point(822, 336);
            character2Health.BackColor = Color.Lime;
            character2Weapon.Location = new Point(760, 306);
             weaponammo2.Location = new Point(800, 310);
            character2.Location = new Point(757, 336);

            character1Health.Height = 91;
            character1Health.Location = new Point(122, 336);
            character1Health.BackColor = Color.Lime;
            character1Weapon.Location = new Point(60, 306);
            weapon1ammo.Location = new Point(100, 310);
            character1.Location = new Point(57,336);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
