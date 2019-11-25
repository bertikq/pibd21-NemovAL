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

        Dictionary<int, T> places;
        
        private int WidthWindow { get; set; }
        private int HeightWindow { get; set; }

        private int maxCount;

        private const int widthSizePlace = 200;
        private const int heightSizePlace = 50;

        public BusTerminal(int size, int widthWindow, int heightWindow)
        {
            places = new Dictionary<int, T>();
            WidthWindow = widthWindow;
            HeightWindow = heightWindow;
            maxCount = size;
        }

        public static int operator +(BusTerminal<T> busTerminal, T bus)
        {
            if (busTerminal.places.Count == busTerminal.maxCount)
            {
                return -1;
            }
            for (int i = 0; i < busTerminal.maxCount; i++)
            {
                if (busTerminal.CheckFreePlace(i))
                {
                    busTerminal.places.Add(i, bus);
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
            if (!busTerminal.CheckFreePlace(index))
            {
                T bus = busTerminal.places[index];
                busTerminal.places.Remove(index);
                return bus;
            }
            return null;
        }

        public void Draw(Graphics g)
        {
            DrawMarking(g);
            var keys = places.Keys.ToList();
            for (int i = 0; i < keys.Count; i++)
            {
                places[keys[i]].Draw(g);
            }
        }

        private void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, (maxCount / 5) * widthSizePlace, 480);
            for (int i = 0; i < maxCount / 5; i++)
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
            return !places.ContainsKey(indexPlace);
        } 
    }
}
