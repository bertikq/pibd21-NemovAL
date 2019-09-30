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
        public Transform transform { get; private set; }
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


        public Bus(Transform transform, Color colorBody, Color colorWings, int speed)
        {
            this.transform = transform;
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
                    if (transform.position.x + speed < widthWindow - width / 2)
                        transform.position.x += speed;
                    break;
                case Direction.Left:
                    if (transform.position.x - speed > width / 2)
                        transform.position.x -= speed;
                    break;
                case Direction.Up:
                    if (transform.position.y - speed > height / 2)
                        transform.position.y -= speed;
                    break;
                case Direction.Down:
                    if (transform.position.y + speed < heightWindow - height / 2)
                        transform.position.y += speed;
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
            g.DrawRectangle(penBody, transform.position.x - (width / 2), transform.position.y - (height / 2), width, height);
            g.DrawRectangle(penAccord, transform.position.x - (widthAccord / 2), transform.position.y - (height / 2), width / 6, height);

            Pen pen = new Pen(colorWings);
            g.DrawEllipse(pen, transform.position.x - (width / 3) - (radWheel / 2), transform.position.y + (height / 2) - (radWheel / 2), radWheel, radWheel);
            g.DrawEllipse(pen, transform.position.x + (width / 3) - (radWheel / 2), transform.position.y + (height / 2) - (radWheel / 2), radWheel, radWheel);

        }
    }
}
