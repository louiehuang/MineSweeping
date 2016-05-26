using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMine
{
    /// <summary>
    /// 雷块状态
    /// </summary>
    class MineBlock
    {
        /// <summary>
        /// 横坐标位置
        /// </summary>
        private int _x;
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// 纵坐标位置
        /// </summary>
        private int _y;
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public MineBlock()
        { 
        }

        public MineBlock(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// 雷的个数，-1表示此雷块有雷，0表示没有，1~8表示其周围的雷数
        /// </summary>
        private int _mineNum;
        public int MineNum
        {
            get { return _mineNum; }
            set { _mineNum = value; }
        }

        /// <summary>
        /// 雷块状态，0表示未翻开，1表示已翻开，2表示插旗，3表示不确定
        /// </summary>
        private int _status;
        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        /// <summary>
        /// 表示鼠标是否悬浮在当前雷块
        /// </summary>
        private bool _isHover;
        public bool IsHover
        {
            get { return _isHover; }
            set { _isHover = value; }
        }

        /// <summary>
        /// 表示此块是否被访问过（广度优先搜索时使用）
        /// </summary>
        private bool _visited;
        public bool Visited
        {
            get { return _visited; }
            set { _visited = value; }
        }


    }
}
