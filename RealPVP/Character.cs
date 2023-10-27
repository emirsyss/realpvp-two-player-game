using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealPVP
{
    class Character
    {
        [DllImport("user32.dll")]
        public static extern bool GetKeyState(int nVirtKey);
        [DllImport("user32.dll")]
        public static extern void keybd_event(byte bVk, byte bScan, uint dwFlags, UIntPtr dwExtraInfo);

        private const int KEYEVENTF_EXTENDEDKEY = 0x0001;
        private const int KEYEVENTF_KEYUP = 0x0002;
        private const int VK_NUMLOCK = 0x90;

        public int characterSizeX = 63, characterSizeY = 91;
        public bool goLeft, goRight, goDown, goUp;
        public bool goLeft2, goRight2, goDown2, goUp2;
        public string weapon1 = "pistol";
        public string weapon2 = "pistol";
        public string character1Direction = "right";
        public string character2Direction = "left";
        public int character1WeaponRifleAmmo = 3, character1WeaponPistolAmmo = 8;
        public int character2WeaponRifleAmmo = 3, character2WeaponPistolAmmo = 8;

        int speed = 5;
        public void CharacterKeydown(PictureBox character1, PictureBox character2, Panel gameScreen, Panel character1Heath, Panel character2Health, PictureBox character1Weapon, PictureBox character2Weapon, Label weapon1Ammo, Label weapon2Ammo)
         {
            // Num Lock durumunu kontrol et
            int keyState = GetKeyState(VK_NUMLOCK) ? 1 : 0;

            if (keyState == 0)
            {
                // Num Lock kapalıysa aç
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY, (UIntPtr)0);
                keybd_event(VK_NUMLOCK, 0x45, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, (UIntPtr)0);
            }
            int screenWidth = gameScreen.Width;
            int screenHeight = gameScreen.Height;


            // CHARACTER 1
            if (weapon1 == "pistol")
            {
                character1Weapon.Image = RealPVP.Properties.Resources.pistol;
                weapon1Ammo.Text = character1WeaponPistolAmmo.ToString();
            }
            if (weapon1 == "rifle")
            {
                character1Weapon.Image = RealPVP.Properties.Resources.rifle;
                weapon1Ammo.Text = character1WeaponRifleAmmo.ToString();
            }
            if (weapon1 == "knife")
            {
                character1Weapon.Image = RealPVP.Properties.Resources.knife;
                weapon1Ammo.Text = "";
            }


            if (goUp && character1.Location.Y >= (screenHeight - screenHeight) + 45)
            {
                character1Weapon.Top -= speed;
                character1Heath.Top -= speed;
                weapon1Ammo.Top -= speed;
                character1.Top -= speed;
            }
            if (goDown && character1.Location.Y <= screenHeight - character1.Height - 10)
            {
                character1Weapon.Top += speed;
                character1Heath.Top += speed;
                weapon1Ammo.Top += speed;
                character1.Top += speed;
            }
            if (goRight && character1.Location.X <= screenWidth - character1.Width - 10)
            {
                character1Weapon.Left += speed;
                weapon1Ammo.Left += speed;
                character1Heath.Left += speed;
                character1.Left += speed;
            }
            if (goLeft && character1.Location.X >= 0 + 20)
            {
                character1Weapon.Left -= speed;
                character1Heath.Left -= speed;
                weapon1Ammo.Left -= speed;
                character1.Left -= speed;
            }








            // CHARACTER 2
            if (weapon2 == "pistol")
            {
                character2Weapon.Image = RealPVP.Properties.Resources.pistol;
                weapon2Ammo.Text = character2WeaponPistolAmmo.ToString();
            }
            if (weapon2 == "rifle")
            {
                character2Weapon.Image = RealPVP.Properties.Resources.rifle;
                weapon2Ammo.Text = character2WeaponRifleAmmo.ToString();
            }
            if (weapon2 == "knife")
            {
                character2Weapon.Image = RealPVP.Properties.Resources.knife;
                weapon2Ammo.Text = "";
            }


            if (goUp2 && character2.Location.Y >= (screenHeight - screenHeight) + 45)
            {
         
                character2Weapon.Top -= speed;
                character2Health.Top -= speed;
                weapon2Ammo.Top -= speed;
                character2.Top -= speed;
            }
            if (goDown2 && character2.Location.Y <= screenHeight - character2.Height - 10)
            {
                character2Weapon.Top += speed;
                character2Health.Top += speed;
                weapon2Ammo.Top += speed;
                character2.Top += speed;
            }
            if (goRight2 && character2.Location.X <= screenWidth - character2.Width - 10)
            {
                character2Weapon.Left += speed;
                character2Health.Left += speed;
                weapon2Ammo.Left += speed;
                character2.Left += speed;
            }
            if (goLeft2 && character2.Location.X >= 0 + 20)
            {
                character2Weapon.Left -= speed;
                character2Health.Left -= speed;
                weapon2Ammo.Left -= speed;
                character2.Left -= speed;
            }
         } 
    }
}
