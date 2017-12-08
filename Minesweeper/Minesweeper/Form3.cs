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
    public partial class Form_Rank : Form
    {
        public Form_Rank()
        {
            InitializeComponent();
        }

        private void Form_Rank_Load(object sender, EventArgs e)
        {
            int nBeginner = Properties.Settings.Default.Beginner;
            int nIntermediate = Properties.Settings.Default.Intermediate;
            int nExpert = Properties.Settings.Default.Expert;

            //显示内容,这个格式挺有意思
            label_Beginner.Text = String.Format("Beginner:      {0}s",nBeginner);
            label_Intermediate.Text = String.Format("Beginner:      {0}s", nIntermediate);
            label_Expert.Text = String.Format("Beginner:      {0}s", nExpert);
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            //标签设为默认值
            label_Beginner.Text = String.Format("Beginner:      {0}s", 999);
            label_Intermediate.Text = String.Format("Beginner:      {0}s", 999);
            label_Expert.Text = String.Format("Beginner:      {0}s", 999);
            //数据恢复默认值
            Properties.Settings.Default.Beginner = 999;
            Properties.Settings.Default.Intermediate=999;
            Properties.Settings.Default.Expert = 999;
            //保存设置
            Properties.Settings.Default.Save();
        }
    }
}
