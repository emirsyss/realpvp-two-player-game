
namespace RealPVP
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.character1 = new System.Windows.Forms.PictureBox();
            this.character2 = new System.Windows.Forms.PictureBox();
            this.character2Weapon = new System.Windows.Forms.PictureBox();
            this.character1Weapon = new System.Windows.Forms.PictureBox();
            this.weapon1ammo = new System.Windows.Forms.Label();
            this.weaponammo2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.character2Health = new Guna.UI2.WinForms.Guna2Panel();
            this.character1Health = new Guna.UI2.WinForms.Guna2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.character1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2Weapon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character1Weapon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 10;
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // character1
            // 
            this.character1.BackColor = System.Drawing.Color.Transparent;
            this.character1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.character1.Location = new System.Drawing.Point(57, 336);
            this.character1.Name = "character1";
            this.character1.Size = new System.Drawing.Size(63, 91);
            this.character1.TabIndex = 0;
            this.character1.TabStop = false;
            this.character1.Tag = "characters1";
            // 
            // character2
            // 
            this.character2.BackColor = System.Drawing.Color.Transparent;
            this.character2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.character2.Location = new System.Drawing.Point(756, 336);
            this.character2.Name = "character2";
            this.character2.Size = new System.Drawing.Size(63, 91);
            this.character2.TabIndex = 1;
            this.character2.TabStop = false;
            this.character2.Tag = "characters1";
            // 
            // character2Weapon
            // 
            this.character2Weapon.BackColor = System.Drawing.Color.Transparent;
            this.character2Weapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.character2Weapon.Location = new System.Drawing.Point(760, 306);
            this.character2Weapon.Name = "character2Weapon";
            this.character2Weapon.Size = new System.Drawing.Size(33, 23);
            this.character2Weapon.TabIndex = 6;
            this.character2Weapon.TabStop = false;
            // 
            // character1Weapon
            // 
            this.character1Weapon.BackColor = System.Drawing.Color.Transparent;
            this.character1Weapon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.character1Weapon.Location = new System.Drawing.Point(60, 306);
            this.character1Weapon.Name = "character1Weapon";
            this.character1Weapon.Size = new System.Drawing.Size(33, 23);
            this.character1Weapon.TabIndex = 7;
            this.character1Weapon.TabStop = false;
            // 
            // weapon1ammo
            // 
            this.weapon1ammo.AutoSize = true;
            this.weapon1ammo.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weapon1ammo.Location = new System.Drawing.Point(100, 310);
            this.weapon1ammo.Name = "weapon1ammo";
            this.weapon1ammo.Size = new System.Drawing.Size(21, 15);
            this.weapon1ammo.TabIndex = 8;
            this.weapon1ammo.Text = "10";
            // 
            // weaponammo2
            // 
            this.weaponammo2.AutoSize = true;
            this.weaponammo2.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponammo2.Location = new System.Drawing.Point(800, 310);
            this.weaponammo2.Name = "weaponammo2";
            this.weaponammo2.Size = new System.Drawing.Size(21, 15);
            this.weaponammo2.TabIndex = 9;
            this.weaponammo2.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // character2Health
            // 
            this.character2Health.BackColor = System.Drawing.Color.Lime;
            this.character2Health.BorderColor = System.Drawing.Color.Black;
            this.character2Health.BorderThickness = 1;
            this.character2Health.Location = new System.Drawing.Point(822, 336);
            this.character2Health.Name = "character2Health";
            this.character2Health.ShadowDecoration.Parent = this.character2Health;
            this.character2Health.Size = new System.Drawing.Size(4, 91);
            this.character2Health.TabIndex = 5;
            // 
            // character1Health
            // 
            this.character1Health.BackColor = System.Drawing.Color.Lime;
            this.character1Health.BorderColor = System.Drawing.Color.Black;
            this.character1Health.BorderThickness = 1;
            this.character1Health.Location = new System.Drawing.Point(122, 336);
            this.character1Health.Name = "character1Health";
            this.character1Health.ShadowDecoration.Parent = this.character1Health;
            this.character1Health.Size = new System.Drawing.Size(4, 91);
            this.character1Health.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.character1Health);
            this.panel1.Controls.Add(this.character2Health);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.weaponammo2);
            this.panel1.Controls.Add(this.weapon1ammo);
            this.panel1.Controls.Add(this.character1Weapon);
            this.panel1.Controls.Add(this.character2Weapon);
            this.panel1.Controls.Add(this.character2);
            this.panel1.Controls.Add(this.character1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 437);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 8000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 437);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "RealPVP - 2 Player Game";
            this.Load += new System.EventHandler(this.Main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Main_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.character1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2Weapon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character1Weapon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox character1;
        private System.Windows.Forms.PictureBox character2;
        private System.Windows.Forms.PictureBox character2Weapon;
        private System.Windows.Forms.PictureBox character1Weapon;
        private System.Windows.Forms.Label weapon1ammo;
        private System.Windows.Forms.Label weaponammo2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel character2Health;
        private Guna.UI2.WinForms.Guna2Panel character1Health;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
    }
}

