using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class BusTerminal<T> where T : class, ITransport
    {
        private T[] places;
        
        private int WidthWindow { get; set; }
        private int HeightWindow { get; set; }

        private const int widthSizePlace = 200;
        private const int heightSizePlace = 50;

        public BusTerminal(int size, int widthWindow, int heightWindow)
        {
            places = new T[size];
            WidthWindow = widthWindow;
            HeightWindow = heightWindow;
            for (int i = 0; i < places.Length; i++)
                places[i] = null;
        }

        public static int operator +(BusTerminal<T> busTerminal, T bus)
        {
            for (int i = 0; i < busTerminal.places.Length; i++)
            {
                if (busTerminal.CheckFreePlace(i))
                {
                    bus.SetPosition(widthSizePlace / 2 + i / 5 * widthSizePlace + 5 - 50, i % 5 * heightSizePlace + heightSizePlace / 2,
                        busTerminal.WidthWindow, busTerminal.HeightWindow);
                    busTerminal.places[i] = bus;
                    return i;
                }
            }
            return -1;
        }

        public static T operator -(BusTerminal<T> busTerminal, int index)
        {
            if (index < 0 || index > busTerminal.places.Length)
                return null;
            if (!busTerminal.CheckFreePlace(index))
            {
                T bus = busTerminal.places[index];
                busTerminal.places[index] = null;
                return bus;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            for (int i = 0; i < places.Length; i++)
            {
                if (!CheckFreePlace(i))
                {
                    places[i].Draw(g);
                }
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (places.Length / 5) * widthSizePlace, 480);
            for (int i = 0; i < places.Length / 5; i++)
            {
                for (int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen, i * widthSizePlace, j * heightSizePlace,
                    i * widthSizePlace + 110, j * heightSizePlace);
                }
                g.DrawLine(pen, i * widthSizePlace, 0, i * widthSizePlace, 400);
            }
        }

        private bool CheckFreePlace(int indexPlace)
        {
            return places[indexPlace] == null;
        } 
    }
}
