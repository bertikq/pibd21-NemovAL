using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    public class Bus
    {
        private int posX;
        private int posY;
        private const int width = 150;
        private const int height = 40;
        private int speed;
        private Color colorBody;
        private Color colorWings;
        private Color colorAccord = Color.Blue;
        private float radWheel;
        private int widthWindow;
        private int heightWindow;
        private int widthAccord = 40;

        public int countPeople { get; set; }
        public string NameDriver { get; set; }


        public Bus(int posX, int posY, Color colorBody, Color colorWings, int speed)
        {
            this.posX = posX;
            this.posY = posY;
            this.colorBody = colorBody;
            this.colorWings = colorWings;
            this.speed = speed;
            radWheel = 15;
        }

        public void Move(Direction dir)
        {
            switch (dir)
            {
                case Direction.Right:
                    if (posX + speed < widthWindow - width / 2)
                        posX += speed;
                    break;
                case Direction.Left:
                    if (posX - speed > width / 2)
                        posX -= speed;
                    break;
                case Direction.Up:
                    if (posY - speed > height / 2)
                        posY -= speed;
                    break;
                case Direction.Down:
                    if (posY + speed < heightWindow - height / 2)
                        posY += speed;
                    break;
            }
        }

        public void SetSizeWindow(int w, int h)
        {
            widthWindow = w;
            heightWindow = h;
        }

        public void DrawBus(Graphics g)
        {
            Pen penBody = new Pen(colorBody);
            Pen penAccord = new Pen(colorAccord);
            g.DrawRectangle(penBody, posX - (width / 2), posY - (height / 2), width, height);
            g.DrawRectangle(penAccord, posX - (widthAccord / 2), posY - (height / 2), width / 6, height);

            Pen pen = new Pen(colorWings);
            g.DrawEllipse(pen, posX - (width / 3) - (radWheel / 2), posY + (height / 2) - (radWheel / 2), radWheel, radWheel);
            g.DrawEllipse(pen, posX + (width / 3) - (radWheel / 2), posY + (height / 2) - (radWheel / 2), radWheel, radWheel);

        }
    }
}
