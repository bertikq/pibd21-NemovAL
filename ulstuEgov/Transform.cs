using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ulstuEgov
{
    public class Transform
    {
        public Position position;
        public Direction direction;

        public Transform()
        {
            position = new Position(0, 0);
            direction = Direction.Right;
        }

        public Transform(Position pos, Direction rotate)
        {
            position = pos;
            direction = rotate;
        }
    }
}
