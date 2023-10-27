using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RealPVP
{
    class Ammo
    {
        int sizeX = 60, sizeY = 50;
        int locX = 0, locY=0;

        Random rnd = new Random();
        Label ammo;
        public List<Label> ammos = new List<Label>();
        public void AmmoCreate(Panel gameScreen)
        {
            if (ammos.Count < 1)
            {
                int rand = rnd.Next(1, 10);

                if (rand == 1)
                {
                    locX = 53;
                    locY = 43;
                }
                if (rand == 2)
                {
                    locX = 179;
                    locY = 102;
                }
                if (rand == 3)
                {
                    locX = 419;
                    locY = 30;
                }
                if (rand == 3)
                {
                    //423; 357
                    locX = 423;
                    locY = 357;
                }
                if (rand == 4)
                {
                    locX = 423;
                    locY = 357;
                }
                if (rand == 5)
                {
                    //780; 26
                    locX = 780;
                    locY = 26;
                }
                if (rand == 6)
                {
                    locX = 780;
                    locY = 26;
                }
                if (rand == 7)
                {
                    //25; 378
                    locX = 25;
                    locY = 378;
                }
                if (rand == 8)
                {
                    //516; 176
                    locX = 516;
                    locY = 176;
                }
                if (rand == 9)
                {
                    locX = 3;
                    locY = 190;
                }

                ammo = new Label();
                ammo.AutoSize = false;
                ammo.Size = new Size(sizeX, sizeY);
                ammo.Location = new Point(locX, locY);
                ammo.BackColor = Color.FromArgb(255, 224, 192);
                ammo.Name = "ammo";
                int rand2 = rnd.Next(1, 3);
                int randammo = rnd.Next(3, 9);
                if (rand2 == 1)
                {
                    ammo.Text = "Pistol +" + randammo.ToString();
                }
                else if (rand2 == 2)
                {
                    ammo.Text = "Rifle +" + randammo.ToString();
                }
                ammo.Font = new Font("Nirmala UI", 11.75F, FontStyle.Bold);
                ammo.TextAlign = ContentAlignment.MiddleCenter;
                gameScreen.Controls.Add(ammo);
                ammo.BringToFront();
                ammos.Add(ammo);
            }
          
        }
    }
}
