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
    public partial class Form_Setting : Form
    {
        Form_Main Main;
        public Form_Setting(Form_Main _Main)
        {
            InitializeComponent();
            Main = _Main;//传递父窗口的实例
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            Main.nWidth = Convert.ToInt32(numericUpDown_Width.Value);
            Main.nHeight = Convert.ToInt32(numericUpDown_Height.Value);
            Main.nBomb = Convert.ToInt32(numericUpDown_Bomb.Value);
            this.Close();
        }

        private void Form_Setting_Load(object sender, EventArgs e)
        {
            numericUpDown_Width.Value = Convert.ToDecimal(Main.nWidth);
            numericUpDown_Height.Value = Convert.ToDecimal(Main.nHeight);
            numericUpDown_Bomb.Value = Convert.ToDecimal(Main.nBomb);
        }

    }
}
