using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

//布局代码里也可以定义一些为必要显示出来的变量

namespace Minesweeper
{
    public partial class Form_Main : Form
    {

        //变量定义的地方,公有，要和其他界面进行交互
        public int nWidth, nHeight, nBomb;//长宽雷,长和宽不代表像素，代表格子数
        bool bMark, bAudio;//标记，语音启用

        //表示地雷的最大宽度
        const int Max_Width = 64;//最大宽
        const int Max_Height = 32;//最大高

        int [,] pBomb=new int[Max_Width,Max_Height];//-1表示有地雷，数字表示周围有几个雷
        int[,] pState = new int[Max_Width, Max_Height];//0表未打开，1表打开，2表红旗，3表问号

        //地雷周围8个方格的坐标
        int [] dx = new int[]{-1,0,1,-1,1,-1,0,1 };
        int[] dy = new int[] { 1,1,1,0,0,-1,-1,-1};
        //地雷四周的坐标偏移量
        int[] px = new int[] { 1, -1, 0, 0, 1, -1, 1, -1 };
        int[] py = new int[] { 0, 0, 1, -1, 1, 1, -1, -1 };
        //高亮点记录
        Point MouseFocus;

        //鼠标按键响应
        bool bMouseLeft;
        bool bMouseRight;

        //游戏结束判别
        bool bGame;

        //音效
        System.Media.SoundPlayer soundtick;//计时
        System.Media.SoundPlayer soundboom;//爆炸

        public Form_Main()
        {
            InitializeComponent();
            //双缓冲,注意下
            this.DoubleBuffered=true;
            //初始化游戏参数
            nWidth = Properties.Settings.Default.Width;
            nHeight = Properties.Settings.Default.Height;
            nBomb = Properties.Settings.Default.Bomb;

            bMark = Properties.Settings.Default.Mark;
            bAudio = Properties.Settings.Default.Audio;
            markMToolStripMenuItem.Checked = bMark;
            audioMToolStripMenuItem.Checked = bAudio;
            //重置高亮点
            MouseFocus.X = MouseFocus.Y = 0;
            //音效
            soundtick = new System.Media.SoundPlayer(Properties.Resources.tick);
            soundboom = new System.Media.SoundPlayer(Properties.Resources.burst);
            UpdateSize();
            SelectLevel();
        }

        //初始化
        /// <summary>
        /// 雷区参数设置
        /// </summary>
        /// <param name="Width">宽度</param>
        /// <param name="Height">高度</param>
        /// <param name="Bomb">雷数</param>
        private void setGame(int Width, int Height, int Bomb)
        {
            nWidth = Width;
            nHeight = Height;
            nBomb = Bomb;
            UpdateSize();
            SelectLevel();
        }
        //在函数上面输入///时，可以设置函数的备注

        //比较有趣的设定，Properties里的Settings.settings可以设定程序第一次加载的状态

        /// <summary>
        /// 初级
        /// </summary>
        private void setBeginner()
        {
            setGame(10, 10, 10);
        }

        /// <summary>
        /// 中级
        /// </summary>
        private void setIntermediate()
        {
            setGame(16, 16, 40);
        }

        /// <summary>
        /// 高级
        /// </summary>
        private void setExpert()
        {
            setGame(30, 16, 99);
        }

        /// <summary>
        /// 窗口大小实时更新
        /// </summary>
        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;//包含上下边框的宽度
            int nOffsetY = this.Height - this.ClientSize.Height;//包含左右边框的高度
            int nAdditionY = menuStrip_Main.Height + tableLayoutPanelMain.Height;//菜单栏和下方信息栏的高度
            this.Width = 12 + 34 * nWidth + nOffsetX;//窗口宽度，12为上下6px空隙之和，再加偏移量
            this.Height = 12 + 34 * nHeight + nOffsetY + nAdditionY;//窗口高度，同上
            //非paint事件还需要清屏的就用refresh
            //PaintGame();
            //调用新建游戏函数
            newGameNToolStripMenuItem_Click(new Object(),new EventArgs());
            this.Refresh();
        }

        /// <summary>
        /// 游戏等级选择
        /// </summary>
        private void SelectLevel()
        {
            //checked为选中标识
            if (nWidth == 10 && nHeight == 10 && nBomb == 10)
            {
                beginnerBToolStripMenuItem.Checked = true;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = false;
                settingsSToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 16 && nHeight == 16 && nBomb == 40)
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = true;
                expertEToolStripMenuItem.Checked = false;
                settingsSToolStripMenuItem.Checked = false;
            }
            else if (nWidth == 30 && nHeight == 16 && nBomb == 99)
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = true;
                settingsSToolStripMenuItem.Checked = false;
            }
            else
            {
                beginnerBToolStripMenuItem.Checked = false;
                intermediateIToolStripMenuItem.Checked = false;
                expertEToolStripMenuItem.Checked = false;
                settingsSToolStripMenuItem.Checked = true;
            }
        }


        private void beginnerBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 10; nHeight = 10; nBomb = 10;
            SelectLevel();
            UpdateSize();
        }

        private void intermediateIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 16; nHeight = 16; nBomb = 40;
            SelectLevel();
            UpdateSize();
        }

        private void expertEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nWidth = 30; nHeight = 16; nBomb = 99;
            SelectLevel();
            UpdateSize();
        }

        private void exitEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //这个东西有点意思，其实就是弹窗
            if (MessageBox.Show("Are you sure to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Form_Load.bForm_load = true;
                Application.Exit();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rankRToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        //这家伙应该就是所谓的布局
        private void tableLayoutPanelMain_Paint(object sender, PaintEventArgs e)
        {

        }
        //这家伙可以添加进布局里，也可以置于后台,Interval为记时间隔
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            PaintGame(e.Graphics);
        }

        /// <summary>
        /// 游戏区绘制
        /// </summary>
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
            int nOffsetY = 6 + menuStrip_Main.Height;

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
                        if(pState[i,j]==2)
                        {
                            g.DrawImage(Properties.Resources.flag, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);//画旗,有时候导入的图可能不成比例，个人感觉是因为图的分辨率问题，72像素的正好，300像素的缩放了
                        }
                        if(pState[i,j]==3)
                        {
                            g.DrawImage(Properties.Resources.wenhao, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);//画问号
                        }
                    }
                    else if(pState[i,j]==1)//点开的状态
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
                            if(pBomb[i,j]!=0)
                            {
                                Brush DrawBrush=new SolidBrush(Color.Blue);//定义钢笔
                                if (pBomb[i, j] == 2) { DrawBrush = new SolidBrush(Color.Green); }
                                if (pBomb[i, j] == 3) { DrawBrush = new SolidBrush(Color.Red); }
                                if (pBomb[i, j] == 4) { DrawBrush = new SolidBrush(Color.DarkBlue); }
                                if (pBomb[i, j] == 5) { DrawBrush = new SolidBrush(Color.DarkRed); }
                                if (pBomb[i, j] == 6) { DrawBrush = new SolidBrush(Color.DarkSeaGreen); }
                                if (pBomb[i, j] == 7) { DrawBrush = new SolidBrush(Color.Black); }
                                if (pBomb[i, j] == 8) { DrawBrush = new SolidBrush(Color.DarkGray); }
                                SizeF Size = g.MeasureString(pBomb[i,j].ToString(),new Font("Consolas",16));//SizeF,font
                                //drawstring,在指定位置用指定字体和笔刷对象绘制指定的文本字符串
                                g.DrawString(pBomb[i, j].ToString(), new Font("Consolas", 16), DrawBrush, nOffsetX + 34 * (i - 1) + 1 + (32 - Size.Width) / 2, nOffsetY + 34 * (j - 1) + 1 + (32 - Size.Height) / 2);
                            }
                            if(pBomb[i,j]==-1)
                            {
                                g.DrawImage(Properties.Resources.Mine, nOffsetX + 34 * (i - 1) + 1 + 4, nOffsetY + 34 * (j - 1) + 1 + 2);//画地雷
                            }
                    }

                }
        }

        /// <summary>
        /// 系统关于对话框（API）
        /// </summary>
        /// <param name="hWnd">窗口句柄</param>
        /// <param name="szApp">标题文本</param>
        /// <param name="szOtherStuff">内容文本</param>
        /// <param name="hIcon">图标句柄</param>
        /// <returns></returns>
        [DllImport("shell32.dll")]//用这个必须加上Runtime.InteropServices这个using
        public extern static int ShellAbout(IntPtr hWnd, string szApp, string szOtherStuff, IntPtr hIcon);

        private void aboutUsAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //说实话这个关于我还不太会用
            ShellAbout(this.Handle, "Minesweeper", "A minesweeper game using C# language.", this.Icon.Handle);
        }

        private void markMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            markMToolStripMenuItem.Checked = bMark = !bMark;
        }

        private void audioMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            audioMToolStripMenuItem.Checked = bAudio = !bAudio;
        }

        private void settingsSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Setting Setting=new Form_Setting(this);//包含公有参数后的结果
            Setting.ShowDialog();
            UpdateSize();
        }

        private void rankRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form_Rank Rank = new Form_Rank();
            Rank.ShowDialog();
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
            //设置文本
            label_Miner.Text = nBomb.ToString();
            label_Timer.Text = "0";
            //开始计时
            timer_Main.Enabled = true;
            bGame = false;//游戏未结束
        }

        //鼠标悬浮事件
        //这里有个小疑问，e的坐标和MouseFocus的计算量究竟有什么区别
        private void Form_Main_MouseMove(object sender, MouseEventArgs e)
        {
            //获取xy的位置
            if(e.X<6||e.X>6+nWidth*34||e.Y<6+MainMenuStrip.Height||e.Y>nHeight*34+MainMenuStrip.Height)
            {
                MouseFocus.X = 0;//如果不在有效区域就清零
                MouseFocus.Y = 0;
            }
            else
            {
                int x = (e.X - 6) / 34 + 1;
                int y = (e.Y -MainMenuStrip.Height- 6) / 34 + 1;//整体的坐标位置要转成对应的格子位置
                MouseFocus.X = x;
                MouseFocus.Y = y;
            }
            this.Refresh();
        }

        //计时器事件
        private void timer_Main_Tick(object sender, EventArgs e)
        {
            if(bAudio)
            {
                soundtick.Play();//声音播放
            }
            //自动计时
            label_Timer.Text=Convert.ToString(Convert.ToInt32(label_Timer.Text)+1);
        }

        private void Form_Main_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)//左键按下
            {
                bMouseLeft=true;
            }
            if(e.Button==MouseButtons.Right)//右键按下
            {
                bMouseRight = true;
            }
        }

        private void Form_Main_MouseUp(object sender, MouseEventArgs e)
        {
            if(MouseFocus.X==0&&MouseFocus.Y==0||bGame)
            {
                return;//界面外或游戏结束则不做处理
            }
            if(bMouseRight&&bMouseLeft)//左右键同时
            {
                if(pState[MouseFocus.X,MouseFocus.Y]==1&&pBomb[MouseFocus.X,MouseFocus.Y]>0)
                {
                    int nFlag = 0, nDoubt = 0, nSysCnt = pBomb[MouseFocus.X, MouseFocus.Y];//记录旗子数，问号数，九宫格地雷数
                    for(int i=0;i<8;i++)
                    {
                        //周围格子
                        int x = MouseFocus.X + dx[i];
                        int y = MouseFocus.Y + dy[i];
                        if(pState[x,y]==2)
                        {
                            nFlag++;
                        }
                        if(pState[x,y]==3)
                        {
                            nDoubt++;
                        }
                        if(nFlag==nSysCnt||nFlag+nDoubt==nSysCnt)
                        {
                            bool bFlag = OpenBomb(MouseFocus.X, MouseFocus.Y);
                            if(!bFlag)//周围有地雷
                            {
                               Gameover() ;//结束游戏
                            }
                        }
                    }
                }
            }
            else if(bMouseLeft)//只有左
            {
                if (pBomb[MouseFocus.X, MouseFocus.Y] != -1 )//只有未标记打开且不是地雷的时候才行
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)
                    {
                        dfs(MouseFocus.X, MouseFocus.Y);//非雷区自动打开周围区域
                    }
                }
                else
                {
                    Gameover();//Game over
                }
            }
            else if(bMouseRight)//只有右
            {
                if (bMark)//可以使用标记的状态下
                {
                    if (pState[MouseFocus.X, MouseFocus.Y] == 0)
                    {
                        if(Convert.ToInt32(label_Miner.Text)>0)//如果地雷数大于0
                        {
                            pState[MouseFocus.X, MouseFocus.Y] = 2;//插旗
                            label_Miner.Text = Convert.ToString(Convert.ToInt32(label_Miner.Text)-1);//剩余雷数目-1
                        }
                        
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 2)
                    {
                        pState[MouseFocus.X, MouseFocus.Y] = 3;//问号
                        label_Miner.Text = Convert.ToString(Convert.ToInt32(label_Miner.Text) + 1);//剩余雷数目+1
                    }
                    else if (pState[MouseFocus.X, MouseFocus.Y] == 3)
                        pState[MouseFocus.X, MouseFocus.Y] = 0;//重置回去
                }
            }
            this.Refresh();
            Gamewin();
            bMouseLeft = bMouseRight = false;
        }

        //深度优先搜索？？,数据结构里似曾相识
        private void dfs(int dx,int dy)
        {
            pState[dx,dy]=1;//访问该点
            for(int i=0;i<4;i++)
            {
                //邻接点坐标获取
                int x = dx + px[i];
                int y = dy + py[i];
                if(x>=1 && y>=1 && x<=nWidth && y<=nHeight && pBomb[x,y]!=-1&&pBomb[dx,dy]==0&&(pState[x,y]==0||pState[x,y]==3))//游戏逻辑问题，有效区域，不是地雷，未点开，或标记为问号
                {
                    dfs(x,y);//访问此点
                }
            }
        }

        private bool OpenBomb(int sx,int sy)
        {
            bool bFlag = true;//默认周围无雷
            for(int i=0;i<8;i++)
            {
                int x = MouseFocus.X + dx[i];
                int y = MouseFocus.Y + dy[i];
                if (pState[x, y] == 0)//问号情况
                {
                    pState[x, y] = 1;
                    if(pBomb[x,y]!=-1)
                    {
                        dfs(x,y);
                    }
                    else
                    {
                        bFlag = false;
                        break;
                    }
                }
            }
            return bFlag;
        }

        private void Gameover()
        {
            for(int i=1;i<=nWidth;i++)
            {
                for(int j=1;j<=nHeight;j++)
                {
                    if(pBomb[i,j]==-1&&(pState[i,j]==0||pState[i,j]==3))//未打开或标记为问号的地雷
                    {
                        pState[i,j]=1;//打开该地雷
                    }
                }
            }
            if(bAudio)
            {
                soundboom.Play();
            }
            timer_Main.Enabled = false;
            bGame = true;
        }

        //游戏胜利
        private void Gamewin()
        {
            int nCnt = 0;//用户红旗数，问号数，未打开区域数总数
            for(int i=1;i<=nWidth;i++)
            {
                for (int j = 1; j <= nHeight; j++)
                {
                    if(pState[i,j]==0||pState[i,j]==2||pState[i,j]==3)
                        nCnt++;
                }
            }
            if(nCnt==nBomb)//因为游戏的设定是当场上除了地雷的所有格子全部打开时获得胜利
            {
                timer_Main.Enabled = false;//关闭计时器
                MessageBox.Show(String.Format("胜利！用时    {0}s",label_Timer.Text),"提示",MessageBoxButtons.OK);
                //更新记录
                if(nWidth==10&&nHeight==10&&nBomb==10)//初级
                {
                    if(Properties.Settings.Default.Beginner>Convert.ToInt32(label_Timer.Text))
                    {
                        Properties.Settings.Default.Beginner = Convert.ToInt32(label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                else if(nWidth==16&&nHeight==16&&nBomb==40)//中级
                {
                    if (Properties.Settings.Default.Intermediate > Convert.ToInt32(label_Timer.Text))
                    {
                        Properties.Settings.Default.Intermediate = Convert.ToInt32(label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                else if (nWidth == 30 && nHeight == 16 && nBomb == 99)//高级
                {
                    if (Properties.Settings.Default.Expert > Convert.ToInt32(label_Timer.Text))
                    {
                        Properties.Settings.Default.Expert = Convert.ToInt32(label_Timer.Text);
                        Properties.Settings.Default.Save();
                    }
                }
                bGame = true;
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}

