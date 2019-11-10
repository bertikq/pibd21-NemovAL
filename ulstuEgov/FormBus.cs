using System;
using System.Drawing;
using System.Windows.Forms;

namespace ulstuEgov
{
    internal class FormBus : Form
    {
        private PictureBox fieldDraw;
        private Button buttonCreateAir;
        private Button buttonRight;
        private Button buttonDown;
        private Button buttonLeft;
        private Button buttonUp;
        Bus bus;

        public FormBus()
        {
            InitializeComponent();
        }


        private void InitializeComponent()
        {
            this.buttonCreateAir = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.fieldDraw = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDraw)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCreateAir
            // 
            this.buttonCreateAir.Location = new System.Drawing.Point(44, 57);
            this.buttonCreateAir.Name = "buttonCreateAir";
            this.buttonCreateAir.Size = new System.Drawing.Size(127, 51);
            this.buttonCreateAir.TabIndex = 1;
            this.buttonCreateAir.Text = "Create Bus";
            this.buttonCreateAir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.buttonCreateAir.UseVisualStyleBackColor = true;
            this.buttonCreateAir.Click += new System.EventHandler(this.ButtonCreateAir_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUp.BackgroundImage = global::ulstuEgov.Properties.Resources.long_arrow_up;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(607, 342);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(50, 50);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = false;
            this.buttonUp.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.SystemColors.Control;
            this.buttonLeft.BackgroundImage = global::ulstuEgov.Properties.Resources.klbj83;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(551, 398);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(50, 50);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackColor = System.Drawing.SystemColors.Control;
            this.buttonDown.BackgroundImage = global::ulstuEgov.Properties.Resources.down_254095_1280;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(607, 398);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(50, 50);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = false;
            this.buttonDown.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.SystemColors.Control;
            this.buttonRight.BackgroundImage = global::ulstuEgov.Properties.Resources.стрелка;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(663, 398);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(50, 50);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.ButtonMove_Click);
            // 
            // fieldDraw
            // 
            this.fieldDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fieldDraw.Location = new System.Drawing.Point(0, 0);
            this.fieldDraw.Name = "fieldDraw";
            this.fieldDraw.Size = new System.Drawing.Size(713, 448);
            this.fieldDraw.TabIndex = 0;
            this.fieldDraw.TabStop = false;
            // 
            // FormBus
            // 
            this.ClientSize = new System.Drawing.Size(713, 448);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCreateAir);
            this.Controls.Add(this.fieldDraw);
            this.Name = "FormBus";
            this.Text = "Bus";
            ((System.ComponentModel.ISupportInitialize)(this.fieldDraw)).EndInit();
            this.ResumeLayout(false);

        }

        private void ButtonCreateAir_Click(object sender, System.EventArgs e)
        {
            bus = new Bus(fieldDraw.Width / 2, fieldDraw.Height / 2, Color.Black, Color.Red, 15);
            bus.SetSizeWindow(fieldDraw.Width, fieldDraw.Height);
            Draw();
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(fieldDraw.Width, fieldDraw.Height);
            Graphics g = Graphics.FromImage(bmp);
            bus.DrawBus(g);
            fieldDraw.Image = bmp;
        }

        private void ButtonMove_Click(object sender, EventArgs e)
        {
            try
            {
                switch (((Button)sender).Name)
                {
                    case "buttonRight":
                        bus.Move(Direction.Right);
                        break;
                    case "buttonLeft":
                        bus.Move(Direction.Left);
                        break;
                    case "buttonUp":
                        bus.Move(Direction.Up);
                        break;
                    case "buttonDown":
                        bus.Move(Direction.Down);
                        break;
                }
                Draw();
            }
            catch { }
        }
    }
}