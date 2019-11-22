using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class BaseBus : Vehicle
    {
        protected const int width = 100;
        protected const int height = 40;
        protected float radWheel;

        protected Color colorWheels;
        public BaseBus(int speed, Color mainColor, float radWheel, Color colorWheels)
        {
            this.speed = speed;
            this.mainColor = mainColor;
            this.radWheel = radWheel;
            this.colorWheels = colorWheels;
        }

        public BaseBus(string save)
        {
            string[] mas = save.Split(';');
            if (mas.Length == 4)
            {
                speed = int.Parse(mas[0]);
                mainColor = Color.FromName(mas[1]);
                radWheel = float.Parse(mas[2]);
                colorWheels = Color.FromName(mas[3]);
            }
        }

        public override void Draw(Graphics g)
        {
            Pen penBody = new Pen(mainColor);
            //body
            g.DrawRectangle(penBody, posX - (width / 2), posY - (height / 2), width, height);
            //window
            g.DrawRectangle(new Pen(Color.Blue), posX - (width / 2), posY - (height / 2), width / 6, height / 4);
            //wheels
            Pen pen = new Pen(colorWheels);
            g.DrawEllipse(pen, posX - (width / 3) - (radWheel / 2), posY + (height / 2) - (radWheel / 2), radWheel, radWheel);
            g.DrawEllipse(pen, posX + (width / 3) - (radWheel / 2), posY + (height / 2) - (radWheel / 2), radWheel, radWheel);
        }

        public override void Move(Direction direction)
        {
            switch (direction)
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

        public override string ToString()
        {
            return String.Join(";", new object[] { speed, mainColor.Name, radWheel, colorWheels.Name });
        }
    }
}
