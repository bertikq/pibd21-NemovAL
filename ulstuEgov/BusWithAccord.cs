using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class BusWithAccord : BaseBus, IComparable<BusWithAccord>, IEquatable<BusWithAccord>
    {
        public Color accordColor { private set; get; }

        public int widthAccord { private set; get; }

        public int paddingAccord { private set; get; }

        public int widthHalfBus { private set; get; }

        public BusWithAccord(int speed, Color mainColor, float radWheel, Color colorWheels,
            Color accordColor, int widthAccord, int paddingAccord, int widthHalfBus) : base(speed, mainColor, radWheel, colorWheels)
        {
            this.accordColor = accordColor;
            this.widthAccord = widthAccord;
            this.paddingAccord = paddingAccord;
            this.widthHalfBus = widthHalfBus;
        }

        public BusWithAccord(string save) : base(save)
        {
            string[] mas = save.Split(';');
            if (mas.Length == 8)
            {
                speed = int.Parse(mas[0]);
                mainColor = Color.FromName(mas[1]);
                radWheel = float.Parse(mas[2]);
                colorWheels = Color.FromName(mas[3]);
                accordColor = Color.FromName(mas[4]);
                widthAccord = int.Parse(mas[5]);
                paddingAccord = int.Parse(mas[6]);
                widthHalfBus = int.Parse(mas[7]);
            }
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

        public void SetAccordColor(Color color)
        {
            accordColor = color;
        }

        public override string ToString()
        {
            return base.ToString() + ";" + 
                String.Join(";", new object[] { accordColor.Name, widthAccord, paddingAccord, widthHalfBus });
        }

        public int CompareTo(BusWithAccord other)
        {
            var res = (this is BaseBus).CompareTo(other is BaseBus);
            if (res != 0)
            {
                return res;
            }
            if (accordColor != other.accordColor)
            {
                accordColor.Name.CompareTo(other.accordColor.Name);
            }
            if (widthAccord != other.widthAccord)
            {
                return widthAccord.CompareTo(other.widthAccord);
            }
            if (paddingAccord != other.paddingAccord)
            {
                return paddingAccord.CompareTo(other.paddingAccord);
            }
            if (widthHalfBus != other.widthHalfBus)
            {
                return widthHalfBus.CompareTo(other.widthHalfBus);
            }
            return 0;
        }

        public bool Equals(BusWithAccord other)
        {
            var res = (this as BaseBus).Equals(other as BaseBus);
            if (!res)
            {
                return res;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (accordColor != other.accordColor)
            {
                return false;
            }
            if (widthAccord != other.widthAccord)
            {
                return false;
            }
            if (paddingAccord != other.paddingAccord)
            {
                return false;
            }
            if (widthHalfBus != other.widthHalfBus)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is BusWithAccord bus))
            {
                return false;
            }
            else
            {
                return Equals(bus);
            }
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
