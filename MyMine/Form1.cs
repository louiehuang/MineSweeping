using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyMine
{
    public partial class FormMain : Form
    {
        const int MineBlockLength = 20; //雷块的边长

        const int MaxNumPerRow = 64;   // 一行最多雷块数量
        const int MaxNumPerColumn = 32;  // 一列最多雷块数量

        int[] px = new int[] { 1, -1, 0, 0, 1, -1, 1, -1 };   // 四方向x坐标偏移量
        int[] py = new int[] { 0, 0, 1, -1, 1, 1, -1, -1 };   // 四方向y坐标偏移量

        List<Direction> directions = new List<Direction>();
        

        public int nWidth;     // 表示雷区的宽度
        public int nHeight;        // 表示雷区的高度
        public int nMineCnt;       // 表示地雷的数目

        bool bMark = true;     // 表示是否使用标记

        bool bMouseLeft;    // 鼠标左键是否被按下
        bool bMouseRight;   // 鼠标右键是否被按下

        MineBlock[,] mineBlock = new MineBlock[MaxNumPerColumn+1, MaxNumPerRow+1]; //雷区二维数组，一维是行，也即一列最多的雷快数量

        Point MouseFocus;   // 高亮点记录


        public FormMain()
        {
            InitializeComponent();

            this.DoubleBuffered = true; // 开启双缓冲

            // 初始化游戏参数
            nWidth = Properties.Settings.Default.Width;
            nHeight = Properties.Settings.Default.Height;
            nMineCnt = Properties.Settings.Default.MineCnt;

            for (int i = 0; i < MaxNumPerColumn; i++)
            {
                for (int j = 0; j < MaxNumPerRow; j++)
                {
                    mineBlock[i, j] = new MineBlock();
                    mineBlock[i, j].MineNum = 0;
                    mineBlock[i, j].Status = 0;
                    mineBlock[i, j].IsHover = false;
                }
            }

            //Array.Clear(mineBlock, 0, mineBlock.Length);

            //生成方向
            for (int i = -1; i <= 1; i++)
            {
                for (int j = -1; j <= 1; j++)
                {
                    if (i == 0 && j == 0)
                        continue;
                    else
                    {
                        Direction direction = new Direction(i, j);
                        directions.Add(direction);
                    }
                }
            }


            UpdateSize();
            SelectLevel();

        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 游戏参数设置
        /// </summary>
        /// <param name="Width">雷区宽度</param>
        /// <param name="Height">雷区高度</param>
        /// <param name="MineCnt">地雷数目</param>
        private void SetGame(int Width, int Height, int MineCnt)
        {
            nWidth = Width;
            nHeight = Height;
            nMineCnt = MineCnt;
            UpdateSize();
        }

        /// <summary>
        /// 自动更新窗口大小
        /// </summary>
        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;  // 包含了窗口标题栏以及上下边框的高度,6
            int nOffsetY = this.Height - this.ClientSize.Height;    // 包含了左右边框的宽度,29
            //int nAdditionY = MenuStrip_Main.Height + TableLayoutPanel_Main.Height;  // 包含了菜单栏以及下方显示信息栏的高度
            int nAdditionY = MenuStrip_Main.Height;  // 包含了菜单栏以及下方显示信息栏的高度

            this.Width = 12 + MineBlockLength * nWidth + nOffsetX;   // 设置窗口高度，MineBlockLength为每个雷区的高度，12为上下总空隙（6px+6px），再加上偏移量
            this.Height = 12 + MineBlockLength * nHeight + nAdditionY + nOffsetY;    // 设置窗口宽度，同理

            开局NToolStripMenuItem_Click(new object(), new EventArgs()); // 调用新建游戏函数

            //this.Refresh();
        }

        /// <summary>
        /// 设置游戏等级为初级
        /// </summary>
        private void SetGameBeginner()
        {
            SetGame(10, 10, 10);
        }

        /// <summary>
        /// 设置游戏等级为中级
        /// </summary>
        private void SetGameIntermediate()
        {
            SetGame(16, 16, 40);
        }

        /// <summary>
        /// 设置游戏等级为高级
        /// </summary>
        private void SetGameExpert()
        {
            SetGame(30, 16, 99);
        }

        /// <summary>
        /// 选择对应的游戏等级
        /// </summary>
        private void SelectLevel()
        {
            if (nWidth == 10 && nHeight == 10 && nMineCnt == 10)
            {
                初级BToolStripMenuItem.Checked = true;
                中级IToolStripMenuItem.Checked = false;
                高级EToolStripMenuItem.Checked = false;
                设置SToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 16 && nHeight == 16 && nMineCnt == 40)
            {
                初级BToolStripMenuItem.Checked = false;
                中级IToolStripMenuItem.Checked = true;
                高级EToolStripMenuItem.Checked = false;
                设置SToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 30 && nHeight == 16 && nMineCnt == 99)
            {
                初级BToolStripMenuItem.Checked = false;
                中级IToolStripMenuItem.Checked = false;
                高级EToolStripMenuItem.Checked = true;
                设置SToolStripMenuItem.Checked = false;
            }
            else
            {
                初级BToolStripMenuItem.Checked = false;
                中级IToolStripMenuItem.Checked = false;
                高级EToolStripMenuItem.Checked = false;
                设置SToolStripMenuItem.Checked = true;
            }
        }


        private void FormMain_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                PaintGame(e.Graphics);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 绘制游戏区
        /// </summary>
        private void PaintGame(Graphics g)
        {
            g.Clear(Color.White);   // 清空绘图区
            // 我们需要是雷区在用户显示的区域上下左右保持6px的偏移量，使得整体看起来更加协调
            int nOffsetX = 6;   // X方向偏移量
            int nOffsetY = 6 + MenuStrip_Main.Height;   // Y方向偏移量
            int length = MineBlockLength - 2;
            for (int i = 1; i <= nWidth; i++)    // 绘制行
            {
                for (int j = 1; j <= nHeight; j++)   // 绘制列
                {
                    // 第一个参数为笔刷，这里采用内置笔刷SandyBronw
                    // 第二个参数为方块的参数，这里采用左上角坐标以及长宽的形式给出
                    // MineBlockLength表示每个雷区的大小，再加上偏移量就是我们当前雷区的起始位置，由于要空出1px的间隔，因此还需要加1
                    // 由此可以的到每个方块在雷区中的位置，然后利用循环绘制出来

                    //需要先初始化mineBlock？
                    if (mineBlock[i, j].Status != 1)   // 未点开
                    {
                        // 绘制背景
                        if (i == MouseFocus.X && j == MouseFocus.Y)  // 是否为高亮点
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.DarkGray)), new Rectangle(nOffsetX + MineBlockLength * (i - 1) + 1, nOffsetY + MineBlockLength * (j - 1) + 1, 18, 18));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.DarkGray, new Rectangle(nOffsetX + MineBlockLength * (i - 1) + 1, nOffsetY + MineBlockLength * (j - 1) + 1, 18, 18));   // 绘制雷区方块
                        }
                        // 绘制标记
                        if (mineBlock[i, j].Status == 2)
                        {
                            g.DrawImage(Properties.Resources.Flag, nOffsetX + MineBlockLength * (i - 1), nOffsetY + MineBlockLength * (j - 1));   // 绘制红旗
                        }
                        if (mineBlock[i, j].Status == 3)
                        {
                            g.DrawImage(Properties.Resources.Doubt, nOffsetX + MineBlockLength * (i - 1), nOffsetY + MineBlockLength * (j - 1));   // 绘制问号
                        }
                    }
                    else if (mineBlock[i, j].Status == 1)  // 点开
                    {
                        // 绘制背景
                        if (MouseFocus.X == i && MouseFocus.Y == j)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.LightGray)), new Rectangle(nOffsetX + MineBlockLength * (i - 1) + 1, nOffsetY + MineBlockLength * (j - 1) + 1, length, length));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.LightGray, new Rectangle(nOffsetX + MineBlockLength * (i - 1) + 1, nOffsetY + MineBlockLength * (j - 1) + 1, length, length));
                        }
                        // 绘制数字
                        if (mineBlock[i, j].MineNum > 0)
                        {
                            Brush DrawBrush = new SolidBrush(Color.Blue);    // 定义钢笔
                            // 各个地雷数目的颜色
                            if (mineBlock[i, j].MineNum == 2) { DrawBrush = new SolidBrush(Color.Green); }
                            if (mineBlock[i, j].MineNum == 3) { DrawBrush = new SolidBrush(Color.Red); }
                            if (mineBlock[i, j].MineNum == 4) { DrawBrush = new SolidBrush(Color.DarkBlue); }
                            if (mineBlock[i, j].MineNum == 5) { DrawBrush = new SolidBrush(Color.DarkRed); }
                            if (mineBlock[i, j].MineNum == 6) { DrawBrush = new SolidBrush(Color.DarkSeaGreen); }
                            if (mineBlock[i, j].MineNum == 7) { DrawBrush = new SolidBrush(Color.Black); }
                            if (mineBlock[i, j].MineNum == 8) { DrawBrush = new SolidBrush(Color.DarkGray); }
                            SizeF Size = g.MeasureString(mineBlock[i, j].MineNum.ToString(), new Font("Consolas", 15));
                            g.DrawString(mineBlock[i, j].MineNum.ToString(), new Font("Consolas", 15), DrawBrush, nOffsetX + MineBlockLength * (i - 1) + 1 + (length - Size.Width) / 2, nOffsetY + MineBlockLength * (j - 1) + 1 + (length - Size.Height) / 2);
                        }
                        // 绘制地雷
                        if (mineBlock[i, j].MineNum == -1)
                        {
                            //g.DrawImage(Properties.Resources.Mine, nOffsetX + MineBlockLength * (i - 1) + 1 + 4, nOffsetY + MineBlockLength * (j - 1) + 1 + 2);   // 绘制地雷
                        }
                    }
                }
            }
        }

        private void 初级BToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 10; nHeight = 10; nMineCnt = 10;
            SelectLevel();
            UpdateSize();
        }

        private void 中级IToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 16; nHeight = 16; nMineCnt = 40;
            SelectLevel();
            UpdateSize();
        }

        private void 高级EToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 30; nHeight = 16; nMineCnt = 99;
            SelectLevel();
            UpdateSize();
        }

        private void 设置SToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 开局NToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //实际雷区是1~nHeight和1~nWidth，但由于向八个方向拓展时可能会拓展到0、nHeight+1、nWidth，因此这里范围前后均扩大了1
            for (int i = 0; i <= nHeight + 1; i++)
            {
                for (int j = 0; j <= nWidth + 1; j++)
                {
                    mineBlock[i, j] = new MineBlock();
                    mineBlock[i, j].MineNum = 0;
                    mineBlock[i, j].Status = 0;
                    mineBlock[i, j].IsHover = false;
                }
            }

            // 重置高亮点
            MouseFocus.X = 0; MouseFocus.Y = 0;
            // 初始化地雷数据
            Random Rand = new Random();

            try
            {
                for (int i = 1; i <= nMineCnt; )  // 地雷总数
                {
                    // 随机地雷坐标(x, y)
                    int x = Rand.Next(nWidth) + 1;
                    int y = Rand.Next(nHeight) + 1;
                    //if (pMine[x, y] != -1)
                    //{
                    //    pMine[x, y] = -1; i++;
                    //}
                    if (mineBlock[x, y].MineNum != -1) //直到找到不是雷的区域（后面random的可能和前面重合，排重），将其置为雷
                    {
                        mineBlock[x, y].MineNum = -1; i++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("1." + ex.Message);
            }

            try
            {
                for (int i = 1; i <= nWidth; i++)    // 枚举宽度
                {
                    for (int j = 1; j <= nHeight; j++)   // 枚举高度
                    {
                        if (mineBlock[i, j].MineNum != -1)   // 不是地雷，显示周围地雷数
                        {
                            for (int k = 0; k < 8; k++)  // 八个方向拓展
                            {
                                if (mineBlock[i + directions[k].X, j + directions[k].Y].MineNum == -1)   // 找到地雷
                                {
                                    mineBlock[i, j].MineNum++;  // 地雷数自增
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("2." + ex.Message);
            }
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < 6 || e.X > 6 + nWidth * MineBlockLength ||
                e.Y < 6 + MenuStrip_Main.Height ||
                e.Y > 6 + MenuStrip_Main.Height + nHeight * MineBlockLength) // 不在地雷区域
            {
                MouseFocus.X = 0; MouseFocus.Y = 0;
            }
            else
            {
                //获取鼠标悬浮区所在的位置（第y行第x列，如第一个则为第1行第1列）
                int x = (e.X - 6) / MineBlockLength + 1; // 获取x位置
                int y = (e.Y - MenuStrip_Main.Height - 6) / MineBlockLength + 1; // 获取y位置
                MouseFocus.X = x; MouseFocus.Y = y; // 设置当前高亮点
            }
            this.Refresh();    // 重绘雷区

        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)   // 鼠标左键被按下
            {
                bMouseLeft = true;
            }
            if (e.Button == MouseButtons.Right)  // 鼠标右键被按下
            {
                bMouseRight = true;
            }
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if ((MouseFocus.X == 0 && MouseFocus.Y == 0)) // 不在地雷区域或游戏结束
            {
                return; // 不做任何处理
            }

            if (bMouseLeft && bMouseRight)   // 左右键同时按下
            {

            }
            else if (bMouseLeft) // 左键被按下
            {
                if (mineBlock[MouseFocus.X, MouseFocus.Y].MineNum != -1) //不是雷，深搜周围雷区
                {
                    if (mineBlock[MouseFocus.X, MouseFocus.Y].Status == 0) //未打开
                    {
                        dfs(MouseFocus.X, MouseFocus.Y);
                    }
                }
                else
                {
                    // 地雷，游戏结束
                    //GameLost();
                }
            }
            else if (bMouseRight)    // 右键被按下
            {
                if (bMark)   // 可以使用标记
                {
                    if (mineBlock[MouseFocus.X, MouseFocus.Y].Status == 0) // 未点开
                    {
                        mineBlock[MouseFocus.X, MouseFocus.Y].Status = 2; // 红旗
                    }
                    else if (mineBlock[MouseFocus.X, MouseFocus.Y].Status == 2) // 红旗
                    {
                        mineBlock[MouseFocus.X, MouseFocus.Y].Status = 3; // 问号
                    }
                    else if (mineBlock[MouseFocus.X, MouseFocus.Y].Status == 3) // 问号
                    {
                        mineBlock[MouseFocus.X, MouseFocus.Y].Status = 0;  // 未点开
                    }
                }

            }
            this.Refresh();
            //GameWin();
            bMouseLeft = bMouseRight = false;

        }


        private void dfs(int sx, int sy)
        {
            mineBlock[sx, sy].Status = 1; // 访问该点
            for (int i = 0; i < 8; i++)
            {
                // 获取相邻点的坐标
                int x = sx + px[i];
                int y = sy + py[i];
                if (x >= 1 && x <= nWidth && y >= 1 && y <= nHeight &&
                    mineBlock[x, y].MineNum != -1 && mineBlock[sx, sy].MineNum == 0 &&
                    (mineBlock[x, y].Status == 0 || mineBlock[x, y].Status == 3)) // 不是地雷，处于地雷区域，且未点开，或者标记为问号
                {
                    dfs(x, y);  // 访问该点
                }
            }
        }


        //private void dfs(int sx, int sy)
        //{
        //    //设置雷块类，队列放入这种类型，广度优先搜索

        //    //创建一个队列 
        //    Queue<Vertex<T>> queue = newQueue<Vertex<T>>();
        //    Console.Write(v.data + "");//访问 
        //    v.visited = true;//设置访问标志
        //    queue.Enqueue(v);//进队 
        //    while (queue.Count > 0)//只要队不为空就循环 
        //    {
        //        Vertex<T> w = queue.Dequeue();
        //        Nodenode = w.firstEdge;
        //        while (node != null)//访问此顶点的所有邻接点 
        //        {　//如果邻接点未被访问，则递归访问它的边
        //            if (!node.adjvex.visited)
        //            {
        //                Console.Write(node.adjvex.data + "");//访问
        //                node.adjvex.visited = true;//设置访问标志
        //                queue.Enqueue(node.adjvex);//进队 
        //            }
        //            node = node.next;//访问下一个邻接点
        //        }
        //    }

        //}





    }
}
