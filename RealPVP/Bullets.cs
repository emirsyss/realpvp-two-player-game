using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RealPVP
{
    class Bullets
    {
        int bulletSizeX = 7, bulletSizeY = 5;
        Color bulletColor = Color.FromArgb(255, 128, 0);

        Panel bullet;
        public List<Panel> bullets = new List<Panel>();
        Character characterxd = new Character();
        public void BulletCreate(PictureBox character, Panel gameScreen, Label direction1, Label direction2)
        {
            characterxd = new Character();
            bullet = new Panel();
            bullet.BackColor = bulletColor;
            bullet.Size = new Size(bulletSizeX, bulletSizeY);
            if (character.Name == "character1")
            {
                if (direction1.Text== "right")
                {
                    bullet.Name = "sagadogru";
                    bullet.Location = new Point(character.Location.X + character.Width - 5, character.Location.Y + (character.Height - character.Height / 2) + 28);
                }
                if (direction1.Text == "left")
                {
                    bullet.Name = "soladogru";
                    bullet.Location = new Point(character.Location.X - 20, character.Location.Y + (character.Height - character.Height / 2) + 28);
                }


            }
            else
            {
                if (direction2.Text == "right")
                {
                    bullet.Name = "sagadogru";
                    bullet.Location = new Point(character.Location.X + character.Width - 5, character.Location.Y + (character.Height - character.Height / 2) + 28);
                }
                if (direction2.Text == "left")
                {
                    bullet.Name = "soladogru";
                    bullet.Location = new Point(character.Location.X - 20, character.Location.Y + (character.Height - character.Height / 2) + 28);
                }
            

            }
         
            bullets.Add(bullet);
           

            gameScreen.Controls.Add(bullet);
            bullet.BringToFront();
        }
        public void BulletMovement(Panel gameScreen)
        {
            characterxd = new Character();
            for (int i = 0; i < bullets.Count; i++)
            {
                try
                {
                    if (bullets[i].Name == "sagadogru")
                    {
                        bullets[i].Left += 10;
                    }
                    if (bullets[i].Name == "soladogru")
                    {
                        bullets[i].Left -= 10;
                    }
                    if (bullets[i].Location.X <= 0 || bullets[i].Location.X >= 862)
                    {
                        gameScreen.Controls.Remove(bullets[i]);
                        ((Panel)bullets[i]).Dispose();
                        bullets[i].Dispose();
                        bullets.Remove(bullets[i]);
                    }
                    
                }
                catch (ArgumentOutOfRangeException e)
                {

                }
             
            }
        } 
    }
}
