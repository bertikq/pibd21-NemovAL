using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class BusTerminal<T> : IEnumerator<T>, IEnumerable<T>, IComparable<BusTerminal<T>> where T : class, ITransport
    {

        Dictionary<int, T> places;

        private int WidthWindow { get; set; }
        private int HeightWindow { get; set; }

        private int maxCount;

        private const int widthSizePlace = 200;
        private const int heightSizePlace = 50;
        private int currentIndex;
        public int GetKey
        {
            get
            {
                return places.Keys.ToList()[currentIndex];
            }
        }

        public BusTerminal(int size, int widthWindow, int heightWindow)
        {
            places = new Dictionary<int, T>();
            WidthWindow = widthWindow;
            HeightWindow = heightWindow;
            maxCount = size;
            currentIndex = -1;
        }

        public T this[int ind]
        {
            get
            {
                if (places.ContainsKey(ind))
                {
                    return places[ind];
                }
                throw new ParkingNotFoundException(ind);
            }
            set
            {
                if (CheckFreePlace(ind))
                {
                    places.Add(ind, value);
                    places[ind].SetPosition(widthSizePlace / 2 + ind / 5 * widthSizePlace + 5 - 50,
                        ind % 5 * heightSizePlace + heightSizePlace / 2, WidthWindow, HeightWindow);
                }
                else throw new ParkingOccupiedPlaceException(ind);
            }
        }

        public static int operator +(BusTerminal<T> busTerminal, T bus)
        {
            if (busTerminal.places.Count == busTerminal.maxCount)
            {
                throw new ParkingOverflowException();
            }
            if (busTerminal.places.ContainsValue(bus))
            {
                throw new ParkingAlreadyHaveException();
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
            throw new ParkingNotFoundException(index);
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

        public T Current
        {
            get
            {
                return places[places.Keys.ToList()[currentIndex]];
            }
        }
        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }
        public bool MoveNext()
        {
            if (currentIndex + 1 >= places.Count)
            {
                Reset();
                return false;
            }
            currentIndex++;
            return true;
        }
        public void Reset()
        {
            currentIndex = -1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Dispose()
        {
            places.Clear();
        }

        public int CompareTo(BusTerminal<T> other)
        {
            if (places.Count > other.places.Count)
            {
                return -1;
            }
            else if (places.Count < other.places.Count)
            {
                return 1;
            }
            else if (places.Count > 0)
            {
                var thisKeys = places.Keys.ToList();
                for (int i = 0; i < places.Count; ++i)
                {
                    if (places[thisKeys[i]] is BaseBus && other.places[thisKeys[i]] is BusWithAccord)
                    {
                        return 1;
                    }
                    if (places[thisKeys[i]] is BusWithAccord && other.places[thisKeys[i]]
                    is BaseBus)
                    {
                        return -1;
                    }
                    if (places[thisKeys[i]] is BaseBus && other.places[thisKeys[i]] is
                    BaseBus)
                    {
                        return (places[thisKeys[i]] is
                       BaseBus).CompareTo(other.places[thisKeys[i]] is BaseBus);
                    }
                    if (places[thisKeys[i]] is BusWithAccord && other.places[thisKeys[i]]
                    is BusWithAccord)
                    {
                        return (places[thisKeys[i]] is
                       BusWithAccord).CompareTo(other.places[thisKeys[i]] is BusWithAccord);
                    }
                }
            }
            return 0;
        }


    }
}
