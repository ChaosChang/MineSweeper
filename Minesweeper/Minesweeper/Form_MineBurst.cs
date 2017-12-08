using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Form_MineBurst : Form
    {
        int nWidth, nHeight,nBomb,nstep;//长宽雷数步数
        bool bAudio;//标记，语音启用

        const int Max_Width = 32;//最大宽
        const int Max_Height = 32;//最大高

        int[,] pBomb = new int[Max_Width, Max_Height];//-1表示有地雷，数字表示周围有几个雷
        int[,] pState = new int[Max_Width, Max_Height];//0表未打开，1表打开，2表红旗，3表问号

        //地雷周围8个方格的坐标
        int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
        int[] dy = new int[] { 1, 1, 1, 0, 0, -1, -1, -1 };
        //地雷四周的坐标偏移量
        int[] px = new int[] { 1, -1, 0, 0, 1, -1, 1, -1 };
        int[] py = new int[] { 0, 0, 1, -1, 1, 1, -1, -1 };
        //高亮点记录
        Point MouseFocus;

        //鼠标按键响应
        bool bMouseLeft;
        bool bMouseRight;

        //计数的
        int BombCnt, StepCnt;

        //游戏结束判别
        bool bGame;
        public Form_MineBurst()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            nWidth = 30;
            nHeight = 16;
            nBomb = 106;
            nstep = 116;
            BombCnt = nBomb;
            StepCnt = nstep;

            bAudio = Properties.Settings.Default.Audio;
            MouseFocus.X = MouseFocus.Y = 0;
            UpdateSize();
        }

        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;//包含上下边框的宽度
            int nOffsetY = this.Height - this.ClientSize.Height;//包含左右边框的高度
            int nAdditionY = menuStrip_Burst.Height + tableLayoutPanelBurst.Height;//菜单栏和下方信息栏的高度
            this.Width = 12 + 34 * nWidth + nOffsetX;//窗口宽度，12为上下6px空隙之和，再加偏移量
            this.Height = 12 + 34 * nHeight + nOffsetY + nAdditionY;//窗口高度，同上
            newGameNToolStripMenuItem_Click(new Object(),new EventArgs());
            this.Refresh();
        }

        private void PaintGame(Graphics g)
        {
            //布局中的事件点,Graphics，传统创建方式
            //Graphics g = this.CreateGraphics();
            //重新画太影响效果，不用
            //g.FillRectangle(Brushes.White, new Rectangle(0, 0, this.Width, this.Height));

            //这里直接清空绘图区域
            g.Clear(Color.White);
            //偏移量设置
            int nOffsetX = 6;
            int nOffsetY = 6 + menuStrip_Burst.Height;

            for (int i = 1; i <= nWidth; i++)
                for (int j = 1; j <= nHeight; j++)
                {
                    if (pState[i, j] != 1)//未点开的状态
                    {
                        if (i == MouseFocus.X && j == MouseFocus.Y)
                        {
                            //这个好好看下
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.SandyBrown)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));//指针所指位置变色
                        }
                        //第一个参数为笔刷，第二个参数为方块参数，左上角坐标+长宽的形式来表示,34表示雷区大小，加上偏移量为雷区起始位置，+1为雷区间距，用for循环绘制
                        else
                        {
                            g.FillRectangle(Brushes.SandyBrown, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        //绘制标记
                        if (pState[i, j] == 2)
                        {
                            g.DrawImage(Properties.Resources.flag, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);//画旗,有时候导入的图可能不成比例，个人感觉是因为图的分辨率问题，72像素的正好，300像素的缩放了
                        }
                        if (pState[i, j] == 3)
                        {
                            g.DrawImage(Properties.Resources.wenhao, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);//画问号
                        }
                    }
                    else if (pState[i, j] == 1)//点开的状态
                    {
                        if (i == MouseFocus.X && j == MouseFocus.Y)
                        {
                            g.FillRectangle(new SolidBrush(Color.FromArgb(100, Color.LightGray)), new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        else
                        {
                            g.FillRectangle(Brushes.LightGray, new Rectangle(nOffsetX + 34 * (i - 1) + 1, nOffsetY + 34 * (j - 1) + 1, 32, 32));
                        }
                        //绘制数字颜色
                        if (pBomb[i, j] != 0)
                        {
                            Brush DrawBrush = new SolidBrush(Color.Blue);//定义钢笔
                            if (pBomb[i, j] == 2) { DrawBrush = new SolidBrush(Color.Green); }
                            if (pBomb[i, j] == 3) { DrawBrush = new SolidBrush(Color.Red); }
                            if (pBomb[i, j] == 4) { DrawBrush = new SolidBrush(Color.DarkBlue); }
                            if (pBomb[i, j] == 5) { DrawBrush = new SolidBrush(Color.DarkRed); }
                            if (pBomb[i, j] == 6) { DrawBrush = new SolidBrush(Color.DarkSeaGreen); }
                            if (pBomb[i, j] == 7) { DrawBrush = new SolidBrush(Color.Black); }
                            if (pBomb[i, j] == 8) { DrawBrush = new SolidBrush(Color.DarkGray); }
                            SizeF Size = g.MeasureString(pBomb[i, j].ToString(), new Font("Consolas", 16));//SizeF,font
                            //drawstring,在指定位置用指定字体和笔刷对象绘制指定的文本字符串
                            g.DrawString(pBomb[i, j].ToString(), new Font("Consolas", 16), DrawBrush, nOffsetX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, nOffsetY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);
                        }
                        if (pBomb[i, j] == -1)
                        {
                            g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);//画地雷
                        }
                    }

                }
        }

        private void newGameNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //数组清零
            Array.Clear(pBomb,0,pBomb.Length);
            Array.Clear(pState, 0, pState.Length);
            //随机数
            Random Rand = new Random();
            //随机生成地雷
            for(int i=1;i<=nBomb;)
            {
                //随机地雷坐标,rand.next随机选择，空为任意非负整数，一个值为小于该值的非负整数，两个值为最大最小值之间的数
                int x=Rand.Next(nWidth)+1;
                int y=Rand.Next(nHeight)+1;
                if(pBomb[x,y]!=-1)
                {
                    pBomb[x,y]=-1;
                    i++;
                }
            }
            //随机生成无地雷区域数字
            for(int i=1;i<=nWidth;i++)
            {
                for(int j=1;j<=nHeight;j++)
                {
                    if(pBomb[i,j]!=-1)
                    {
                        for (int k = 0; k < 8;k++ )
                        {
                            if(pBomb[i+dx[k],j+dy[k]]==-1)//检查方块周围的地雷数
                            {
                                pBomb[i,j]++;
                            }
                        }
                    }
                }
            }
            label_Bomb.Text = nBomb.ToString();
            label_Step.Text = nstep.ToString();
            bGame = false;//游戏未结束
            BombCnt = nBomb;
            StepCnt = nstep;
        }

        private void Form_MineBurst_Paint(object sender, PaintEventArgs e)
        {
            PaintGame(e.Graphics);
        }

        private void Form_MineBurst_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form_MineBurst_MouseMove(object sender, MouseEventArgs e)
        {
            //获取xy的位置
            if (e.X < 6 || e.X > 6 + nWidth * 34 || e.Y < 6 + MainMenuStrip.Height || e.Y > nHeight * 34 + MainMenuStrip.Height)
            {
                MouseFocus.X = 0;//如果不在有效区域就清零
                MouseFocus.Y = 0;
            }
            else
            {
                int x = (e.X - 6) / 34 + 1;
                int y = (e.Y - MainMenuStrip.Height - 6) / 34 + 1;//整体的坐标位置要转成对应的格子位置
                MouseFocus.X = x;
                MouseFocus.Y = y;
            }
            this.Refresh();
        }

        private void Form_MineBurst_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)//左键按下
            {
                bMouseLeft = true;
            }
            if (e.Button == MouseButtons.Right)//右键按下
            {
                bMouseRight = true;
            }
        }

        private void Form_MineBurst_MouseUp(object sender, MouseEventArgs e)
        {
            if (MouseFocus.X == 0 && MouseFocus.Y == 0 || bGame)
            {
                return;//界面外或游戏结束则不做处理
            }

            else if (bMouseLeft)//只有左
            {
                if (pBomb[MouseFocus.X, MouseFocus.Y] != -1 && pState[MouseFocus.X, MouseFocus.Y] == 0)//未标记打开且不是地雷
                {
                    StepCnt--;
                    label_Step.Text = Convert.ToString(Convert.ToInt32(label_Step.Text)-1);
                    dfs(MouseFocus.X, MouseFocus.Y);
                }
                else if (pBomb[MouseFocus.X, MouseFocus.Y] == -1 && pState[MouseFocus.X, MouseFocus.Y] == 0)//是地雷
                {
                    BombCnt--;
                    StepCnt--;
                    label_Step.Text = Convert.ToString(Convert.ToInt32(label_Step.Text) - 1);
                    label_Bomb.Text = Convert.ToString(Convert.ToInt32(label_Bomb.Text)-1);
                    pState[MouseFocus.X, MouseFocus.Y] = 1;
                    for (int k = 0; k < 8; k++)//检查方块周围
                    {
                        if (pBomb[MouseFocus.X + dx[k], MouseFocus.Y + dy[k]] != -1)//不是炸弹
                        {
                            Minecheck(MouseFocus.X + dx[k], MouseFocus.Y + dy[k]);
                        }
                    }
                }
            }

            else if (bMouseRight)//只有右
            {
                return;
            }
            else if(bMouseLeft&&bMouseRight)
            {
                return;
            }
            if(StepCnt<BombCnt)
            {
                Gameover();
            }
            this.Refresh();
            Gamewin();
            bMouseLeft = bMouseRight = false;
        }
        private void dfs(int sx, int sy)
        {
            pState[sx, sy] = 1;//访问该点
            for (int i = 0; i < 8; i++)
            {
                //邻接点坐标获取
                int x = sx + dx[i];
                int y = sy + dy[i];
                if ((x >= 1 && y >= 1 && x <= nWidth && y <= nHeight && pBomb[x, y] != -1 && pBomb[sx, sy] == 0 && pState[x, y] == 0))//游戏逻辑问题，有效区域，不是地雷，未点开
                {
                    dfs(x, y);//访问此点
                }
            }
        }

        //地雷检查,如果周围地雷都清除掉，则显示该块周围所有的区域
        private void Minecheck(int sx,int sy)
        {
            int BombClearCnt=0;
            for (int k = 0; k < 8; k++)
            {
                int x = sx + dx[k];
                int y = sy + dy[k];
                if (x >= 1 && y >= 1 && x <= nWidth && y <= nHeight && pBomb[x, y] == -1 && pState[x, y] == 1)//检查方块周围的地雷数
                {
                    BombClearCnt++;
                }
            }
            if (BombClearCnt == pBomb[sx, sy])
            {
                pState[sx,sy]=1;
                for (int i = 0; i < 8; i++)
                {
                    int x = sx + dx[i];
                    int y = sy + dy[i];
                    if (x >= 1 && y >= 1 && x <= nWidth && y <= nHeight && pState[x, y] == 0)//检查方块周围的地雷数
                    {
                        pState[x, y] = 1;
                        dfs(x,y);
                    }
                }
            }
        }

        private void Gamewin()
        {
            if (BombCnt==0)//因为游戏的设定是当场上除了地雷的所有格子全部打开时获得胜利
            {
                bGame = true;
                MessageBox.Show(String.Format("胜利！"), "提示", MessageBoxButtons.OK);
            }
        }

        private void Gameover()
        {
                bGame = true;
                MessageBox.Show(String.Format("失败！"), "提示", MessageBoxButtons.OK);
        }
    }
}
