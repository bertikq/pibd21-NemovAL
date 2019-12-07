using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    public abstract class Vehicle : ITransport
    {
        public int posX { protected set; get; }
        public int posY { protected set; get; }
        protected int widthWindow;
        protected int heightWindow;
        public int speed { protected set; get; }
        public Color mainColor { protected set; get; }

        public void SetPosition(int posX, int posY, int widthWindow, int heightWindow)
        {
            this.posX = posX;
            this.posY = posY;
            this.widthWindow = widthWindow;
            this.heightWindow = heightWindow;
        }
        public abstract void Draw(Graphics g);
        public abstract void Move(Direction direction);
    }
}
