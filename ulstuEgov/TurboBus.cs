using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    class TurboBus : BaseBus
    {
        private int speedTurbo;
        public Color turboColor { private set; get; }
        public Color pipeColor { private set; get; }

        public int widthPipe { private set; get; }
        public TurboBus(int speed, Color mainColor, float radWheel, Color colorAccord, Color colorWheels, 
            int speedTurbo, Color turboColor, Color pipeColor, int widthPipe) : base(speed, mainColor, radWheel, colorWheels)
        {
            this.speedTurbo = speedTurbo;
            this.turboColor = turboColor;
            this.pipeColor = pipeColor;
            this.widthPipe = widthPipe;
        }

        public override void Draw(Graphics g)
        {
            base.Draw(g);
            Pen penPipe = new Pen(pipeColor);
            int heightPipe = height / 4;
            int posPipeX = posX + (width / 2);
            int posPipeY = (posY + (height / 2)) - heightPipe;
            g.DrawRectangle(penPipe, new Rectangle(posPipeX, posPipeY, widthPipe, heightPipe));
            Pen penTurbo = new Pen(turboColor);
            for (int i = 1; i < 6; i++)
            {
                g.DrawLine(penTurbo, posPipeX + widthPipe, posPipeY + heightPipe - heightPipe / i, posPipeX + widthPipe + 20, posPipeY + (6 - i) * 2);
            }
            for (int i = 1; i < 6; i++)
            {
                g.DrawLine(penTurbo, posPipeX + widthPipe, posPipeY + heightPipe / i, posPipeX + widthPipe + 20, posPipeY - (6 - i) * 2);
            }
        }
    }
}
