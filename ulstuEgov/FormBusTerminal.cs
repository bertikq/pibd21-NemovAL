using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulstuEgov
{
    public partial class FormBusTerminal : Form
    {
        BusTerminal<ITransport> busTerminal;
        public FormBusTerminal()
        {
            InitializeComponent();
            busTerminal = new BusTerminal<ITransport>(10, pictureBoxTerminal.Width, pictureBoxTerminal.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bitmap = new Bitmap(pictureBoxTerminal.Width, pictureBoxTerminal.Height);
            Graphics g = Graphics.FromImage(bitmap);
            busTerminal.Draw(g);
            pictureBoxTerminal.Image = bitmap;
        }

        private void ParkingBaseBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new BaseBus(20, dialog.Color, 10, Color.Black);
                int place = busTerminal + bus;
                Draw();
            }
        }

        private void ParkingBusWithAccord_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new BusWithAcсord(20, dialog.Color, 10, Color.Black, dialogDop.Color, 20, 1, 50);
                    int place = busTerminal + bus;
                    Draw();
                }
            }
        }

        private void GetCar_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxIndex.Text != "")
            {
                var car = busTerminal - Convert.ToInt32(maskedTextBoxIndex.Text);
                if (car != null)
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    Graphics g = Graphics.FromImage(bmp);
                    car.SetPosition(pictureBoxTake.Width / 2 - 30, pictureBoxTake.Height / 2, pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    car.Draw(g);
                    pictureBoxTake.Image = bmp;
                }
                else
                {
                    Bitmap bmp = new Bitmap(pictureBoxTake.Width,
                   pictureBoxTake.Height);
                    pictureBoxTake.Image = bmp;
                }
                Draw();
            }
        }
    }
}
