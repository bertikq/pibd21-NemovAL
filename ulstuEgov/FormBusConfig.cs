using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ulstuEgov
{
    public partial class FormBusConfig : Form
    {
        ITransport bus = null;
        private event carDelegate eventAddCar;
        public FormBusConfig()
        {
            InitializeComponent();
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;
            panel9.MouseDown += panelColor_MouseDown;

            cancelButton.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                Draw();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (bus != null)
            {
                if (bus is BusWithAccord)
                {
                    (bus as
                   BusWithAccord).SetAccordColor((Color)e.Data.GetData(typeof(Color)));
                    Draw();
                }
            }
        }

        private void Draw()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBox.Width, pictureBox.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(pictureBox.Width / 3, pictureBox.Height / 2, pictureBox.Width, pictureBox.Height);
                bus.Draw(gr);
                pictureBox.Image = bmp;
            }
        }

        public void AddEvent(carDelegate ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new carDelegate(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }

        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            label1.DoDragDrop(label1.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        private void labelBusAccord_MouseDown(object sender, MouseEventArgs e)
        {
            label2.DoDragDrop(label2.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Автобус":
                    bus = new BaseBus(20, Color.White, 10, Color.Black);
                    break;
                case "Автобус с Гармошкой":
                    bus = new BusWithAccord(20, Color.White, 10, Color.Black, Color.Black, 20, 1, 50);
                    break;
            }
            Draw();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            eventAddCar?.Invoke(bus);
            Close();
        }
    }
}
