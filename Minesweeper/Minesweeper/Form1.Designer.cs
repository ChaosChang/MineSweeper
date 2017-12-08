namespace Minesweeper
{
    partial class Form_Main
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.menuStrip_Main = new System.Windows.Forms.MenuStrip();
            this.gameGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.beginnerBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intermediateIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expertEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.markMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.audioMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.rankRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox_Mine = new System.Windows.Forms.PictureBox();
            this.pictureBox_Timer = new System.Windows.Forms.PictureBox();
            this.label_Miner = new System.Windows.Forms.Label();
            this.label_Timer = new System.Windows.Forms.Label();
            this.timer_Main = new System.Windows.Forms.Timer(this.components);
            this.menuStrip_Main.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Timer)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip_Main
            // 
            this.menuStrip_Main.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameGToolStripMenuItem,
            this.helpHToolStripMenuItem});
            this.menuStrip_Main.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Main.Name = "menuStrip_Main";
            this.menuStrip_Main.Size = new System.Drawing.Size(622, 28);
            this.menuStrip_Main.TabIndex = 0;
            this.menuStrip_Main.Text = "menuStrip1";
            // 
            // gameGToolStripMenuItem
            // 
            this.gameGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameNToolStripMenuItem,
            this.toolStripSeparator1,
            this.beginnerBToolStripMenuItem,
            this.intermediateIToolStripMenuItem,
            this.expertEToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsSToolStripMenuItem,
            this.toolStripSeparator3,
            this.markMToolStripMenuItem,
            this.audioMToolStripMenuItem,
            this.toolStripSeparator4,
            this.rankRToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitEToolStripMenuItem});
            this.gameGToolStripMenuItem.Name = "gameGToolStripMenuItem";
            this.gameGToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.gameGToolStripMenuItem.Text = "Game(&G)";
            // 
            // newGameNToolStripMenuItem
            // 
            this.newGameNToolStripMenuItem.Name = "newGameNToolStripMenuItem";
            this.newGameNToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.newGameNToolStripMenuItem.Text = "New Game(N)";
            this.newGameNToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(189, 6);
            // 
            // beginnerBToolStripMenuItem
            // 
            this.beginnerBToolStripMenuItem.Name = "beginnerBToolStripMenuItem";
            this.beginnerBToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.beginnerBToolStripMenuItem.Text = "Beginner(&B)";
            this.beginnerBToolStripMenuItem.Click += new System.EventHandler(this.beginnerBToolStripMenuItem_Click);
            // 
            // intermediateIToolStripMenuItem
            // 
            this.intermediateIToolStripMenuItem.Name = "intermediateIToolStripMenuItem";
            this.intermediateIToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.intermediateIToolStripMenuItem.Text = "Intermediate(&I)";
            this.intermediateIToolStripMenuItem.Click += new System.EventHandler(this.intermediateIToolStripMenuItem_Click);
            // 
            // expertEToolStripMenuItem
            // 
            this.expertEToolStripMenuItem.Name = "expertEToolStripMenuItem";
            this.expertEToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.expertEToolStripMenuItem.Text = "Expert(&E)";
            this.expertEToolStripMenuItem.Click += new System.EventHandler(this.expertEToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(189, 6);
            // 
            // settingsSToolStripMenuItem
            // 
            this.settingsSToolStripMenuItem.Name = "settingsSToolStripMenuItem";
            this.settingsSToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.settingsSToolStripMenuItem.Text = "Settings(&S)";
            this.settingsSToolStripMenuItem.Click += new System.EventHandler(this.settingsSToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(189, 6);
            // 
            // markMToolStripMenuItem
            // 
            this.markMToolStripMenuItem.Name = "markMToolStripMenuItem";
            this.markMToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.markMToolStripMenuItem.Text = "Mark(&M)";
            this.markMToolStripMenuItem.Click += new System.EventHandler(this.markMToolStripMenuItem_Click);
            // 
            // audioMToolStripMenuItem
            // 
            this.audioMToolStripMenuItem.Name = "audioMToolStripMenuItem";
            this.audioMToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.audioMToolStripMenuItem.Text = "Audio(&M)";
            this.audioMToolStripMenuItem.Click += new System.EventHandler(this.audioMToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(189, 6);
            // 
            // rankRToolStripMenuItem
            // 
            this.rankRToolStripMenuItem.Name = "rankRToolStripMenuItem";
            this.rankRToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.rankRToolStripMenuItem.Text = "Rank(&R)";
            this.rankRToolStripMenuItem.Click += new System.EventHandler(this.rankRToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(189, 6);
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.exitEToolStripMenuItem.Text = "Exit(&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // helpHToolStripMenuItem
            // 
            this.helpHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutUsAToolStripMenuItem});
            this.helpHToolStripMenuItem.Name = "helpHToolStripMenuItem";
            this.helpHToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.helpHToolStripMenuItem.Text = "Help(&H)";
            // 
            // aboutUsAToolStripMenuItem
            // 
            this.aboutUsAToolStripMenuItem.Name = "aboutUsAToolStripMenuItem";
            this.aboutUsAToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.aboutUsAToolStripMenuItem.Text = "About us(&A)";
            this.aboutUsAToolStripMenuItem.Click += new System.EventHandler(this.aboutUsAToolStripMenuItem_Click);
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 9;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox_Mine, 1, 0);
            this.tableLayoutPanelMain.Controls.Add(this.pictureBox_Timer, 7, 0);
            this.tableLayoutPanelMain.Controls.Add(this.label_Miner, 3, 0);
            this.tableLayoutPanelMain.Controls.Add(this.label_Timer, 5, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 385);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(622, 48);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // pictureBox_Mine
            // 
            this.pictureBox_Mine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Mine.BackgroundImage")));
            this.pictureBox_Mine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Mine.Location = new System.Drawing.Point(35, 3);
            this.pictureBox_Mine.Name = "pictureBox_Mine";
            this.pictureBox_Mine.Size = new System.Drawing.Size(42, 42);
            this.pictureBox_Mine.TabIndex = 0;
            this.pictureBox_Mine.TabStop = false;
            // 
            // pictureBox_Timer
            // 
            this.pictureBox_Timer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_Timer.BackgroundImage")));
            this.pictureBox_Timer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_Timer.Location = new System.Drawing.Point(545, 3);
            this.pictureBox_Timer.Name = "pictureBox_Timer";
            this.pictureBox_Timer.Size = new System.Drawing.Size(42, 42);
            this.pictureBox_Timer.TabIndex = 1;
            this.pictureBox_Timer.TabStop = false;
            // 
            // label_Miner
            // 
            this.label_Miner.AutoSize = true;
            this.label_Miner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Miner.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Miner.ForeColor = System.Drawing.Color.Firebrick;
            this.label_Miner.Location = new System.Drawing.Point(99, 0);
            this.label_Miner.Name = "label_Miner";
            this.label_Miner.Size = new System.Drawing.Size(193, 48);
            this.label_Miner.TabIndex = 2;
            this.label_Miner.Text = "label_Mine";
            this.label_Miner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Timer
            // 
            this.label_Timer.AutoSize = true;
            this.label_Timer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Timer.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Timer.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_Timer.Location = new System.Drawing.Point(330, 0);
            this.label_Timer.Name = "label_Timer";
            this.label_Timer.Size = new System.Drawing.Size(193, 48);
            this.label_Timer.TabIndex = 3;
            this.label_Timer.Text = "label_Timer";
            this.label_Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Main
            // 
            this.timer_Main.Interval = 1000;
            this.timer_Main.Tick += new System.EventHandler(this.timer_Main_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Controls.Add(this.menuStrip_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Main;
            this.Name = "Form_Main";
            this.Text = "Minesweeper";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_Main_MouseUp);
            this.menuStrip_Main.ResumeLayout(false);
            this.menuStrip_Main.PerformLayout();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Mine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Timer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Main;
        private System.Windows.Forms.ToolStripMenuItem gameGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameNToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem beginnerBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intermediateIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem expertEToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem settingsSToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem markMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem audioMToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem rankRToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsAToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBox_Mine;
        private System.Windows.Forms.PictureBox pictureBox_Timer;
        private System.Windows.Forms.Label label_Miner;
        private System.Windows.Forms.Label label_Timer;
        private System.Windows.Forms.Timer timer_Main;
    }
}

