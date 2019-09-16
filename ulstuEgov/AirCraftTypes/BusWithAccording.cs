using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov.AirCraftTypes
{
    public class BusWithAccording : Bus
    {
        private Color colorAccord = Color.Blue;
        private int widthAccord = 40;

        public BusWithAccording() : base()
        {
        }

        public BusWithAccording(Transform transform)
        {
            this.transform = transform;
            speed = 20;
            colorBody = Color.Black;
            colorWings = Color.Red;
            width = 200;
            height = 40;
            radWheel = 15;
        }

        public override void DrawBody(Graphics g)
        {
            Pen penBody = new Pen(colorBody);
            Pen penAccord = new Pen(colorAccord);
            g.DrawRectangle(penBody, transform.position.x - (width / 2), transform.position.y - (height / 2), width, height);
            g.DrawRectangle(penAccord, transform.position.x - (widthAccord / 2), transform.position.y - (height / 2), width / 6, height);
        }

        public override void DrawWheels(Graphics g)
        {
            Pen pen = new Pen(colorWings);
            g.DrawEllipse(pen, transform.position.x - (width / 3) - (radWheel / 2), transform.position.y + (height / 2) - (radWheel / 2), radWheel, radWheel);
            g.DrawEllipse(pen, transform.position.x + (width / 3) - (radWheel / 2), transform.position.y + (height / 2) - (radWheel / 2), radWheel, radWheel);
        }
    }
}
