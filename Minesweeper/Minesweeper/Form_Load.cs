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
    public partial class Form_Load : Form
    {
        public static bool bForm_load = true;//本来打算做窗体状态的判定，不过似乎没啥用
        public Form_Load()
        {
            InitializeComponent();
            SetBtnStyle(btn_traditional);
            SetBtnStyle(btn_burst);
            UpdateSize();
        }
        /// <summary>
        /// 设置透明按钮样式
        /// </summary>
        private void SetBtnStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;//样式
            //btn.ForeColor = Color.Transparent;//前景,和文字有关
            btn.BackColor = Color.Transparent;//去背景
            btn.FlatAppearance.BorderSize = 0;//去边线
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;//鼠标经过
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;//鼠标按下
        }

        private void btn_traditional_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btn_traditional_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void btn_burst_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 1;
        }

        private void btn_burst_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void btn_traditional_Click(object sender, EventArgs e)
        {
            bForm_load = false;
            new Form_Main().Show();//显示窗口
            this.Hide();//隐藏当前窗口
        }
        private void UpdateSize()
        {
            int nOffsetX = this.Width - this.ClientSize.Width;//包含上下边框的宽度
            int nOffsetY = this.Height - this.ClientSize.Height;//包含左右边框的高度
            this.Width = Properties.Resources.loading.Width + nOffsetX;//窗口宽度，12为上下6px空隙之和，再加偏移量
            this.Height = Properties.Resources.loading.Height + nOffsetY;//窗口高度，同上
            //非paint事件还需要清屏的就用refresh
            //PaintGame();
            //调用新建游戏函数
        }

        private void btn_burst_Click(object sender, EventArgs e)
        {
            bForm_load = false;
            new Form_MineBurst().Show();//显示窗口
            this.Hide();//隐藏当前窗口
        }
    }
}
