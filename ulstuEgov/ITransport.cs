using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    interface ITransport
    {
        void SetPosition(int posX, int posY, int widthWindow, int heightWindow);

        void Move(Direction direction);

        void Draw(Graphics g);
    }
}
