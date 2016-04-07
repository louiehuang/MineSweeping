using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMine
{
    /// <summary>
    /// 拓展的八个方向
    /// </summary>
    class Direction
    {
        private int _x;

        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        private int _y;

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public Direction()
        {  
        }

        public Direction(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }


}
