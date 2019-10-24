using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class BusWithAcсord : BaseBus
    {
        public Color accordColor { private set; get; }

        public int widthAccord { private set; get; }

        public int paddingAccord { private set; get; }

        public int widthHalfBus { private set; get; }

        public BusWithAcсord(int speed, Color mainColor, float radWheel, Color colorWheels,
            Color accordColor, int widthAccord, int paddingAccord, int widthHalfBus) : base(speed, mainColor, radWheel, colorWheels)
        {
            this.accordColor = accordColor;
            this.widthAccord = widthAccord;
            this.paddingAccord = paddingAccord;
            this.widthHalfBus = widthHalfBus;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen penAccord = new Pen(accordColor);
            g.DrawRectangle(penAccord, posX + (width / 2), posY - (height / 2) - paddingAccord, widthAccord, height + paddingAccord * 2);
            for (int i = posX + (width / 2); i < posX + width / 2 + widthAccord; i += 3)
            {
                g.DrawLine(penAccord, i, posY - (height / 2) - paddingAccord, i, posY + (height / 2) + paddingAccord);
            }
            Pen penBody = new Pen(mainColor);
            g.DrawRectangle(penBody, posX + width / 2 + widthAccord, posY - (height / 2), widthHalfBus, height);
            Pen penWheel = new Pen(colorWheels);
            g.DrawEllipse(penWheel, posX + width / 2 + widthAccord + (widthHalfBus / 2 - radWheel / 2), posY + (height / 2) - (radWheel / 2), radWheel, radWheel);
        }
    }
}
