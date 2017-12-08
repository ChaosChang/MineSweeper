namespace Minesweeper
{
    partial class Form_MineBurst
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MineBurst));
            this.menuStrip_Burst = new System.Windows.Forms.MenuStrip();
            this.gAMEGToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanelBurst = new System.Windows.Forms.TableLayoutPanel();
            this.label_Bomb = new System.Windows.Forms.Label();
            this.label_Step = new System.Windows.Forms.Label();
            this.menuStrip_Burst.SuspendLayout();
            this.tableLayoutPanelBurst.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip_Burst
            // 
            this.menuStrip_Burst.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip_Burst.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gAMEGToolStripMenuItem});
            this.menuStrip_Burst.Location = new System.Drawing.Point(0, 0);
            this.menuStrip_Burst.Name = "menuStrip_Burst";
            this.menuStrip_Burst.Size = new System.Drawing.Size(615, 28);
            this.menuStrip_Burst.TabIndex = 0;
            this.menuStrip_Burst.Text = "menuStrip1";
            // 
            // gAMEGToolStripMenuItem
            // 
            this.gAMEGToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameNToolStripMenuItem});
            this.gAMEGToolStripMenuItem.Name = "gAMEGToolStripMenuItem";
            this.gAMEGToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.gAMEGToolStripMenuItem.Text = "GAME(&G)";
            // 
            // newGameNToolStripMenuItem
            // 
            this.newGameNToolStripMenuItem.Name = "newGameNToolStripMenuItem";
            this.newGameNToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.newGameNToolStripMenuItem.Text = "New Game(&N)";
            this.newGameNToolStripMenuItem.Click += new System.EventHandler(this.newGameNToolStripMenuItem_Click);
            // 
            // tableLayoutPanelBurst
            // 
            this.tableLayoutPanelBurst.ColumnCount = 9;
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanelBurst.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanelBurst.Controls.Add(this.label_Bomb, 3, 0);
            this.tableLayoutPanelBurst.Controls.Add(this.label_Step, 5, 0);
            this.tableLayoutPanelBurst.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanelBurst.Location = new System.Drawing.Point(0, 362);
            this.tableLayoutPanelBurst.Name = "tableLayoutPanelBurst";
            this.tableLayoutPanelBurst.RowCount = 1;
            this.tableLayoutPanelBurst.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelBurst.Size = new System.Drawing.Size(615, 48);
            this.tableLayoutPanelBurst.TabIndex = 1;
            // 
            // label_Bomb
            // 
            this.label_Bomb.AutoSize = true;
            this.label_Bomb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Bomb.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Bomb.ForeColor = System.Drawing.Color.Firebrick;
            this.label_Bomb.Location = new System.Drawing.Point(99, 0);
            this.label_Bomb.Name = "label_Bomb";
            this.label_Bomb.Size = new System.Drawing.Size(189, 48);
            this.label_Bomb.TabIndex = 0;
            this.label_Bomb.Text = "label_Bomb";
            this.label_Bomb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Step
            // 
            this.label_Step.AutoSize = true;
            this.label_Step.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_Step.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Step.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_Step.Location = new System.Drawing.Point(326, 0);
            this.label_Step.Name = "label_Step";
            this.label_Step.Size = new System.Drawing.Size(189, 48);
            this.label_Step.TabIndex = 1;
            this.label_Step.Text = "label_Step";
            this.label_Step.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_MineBurst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 410);
            this.Controls.Add(this.tableLayoutPanelBurst);
            this.Controls.Add(this.menuStrip_Burst);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip_Burst;
            this.Name = "Form_MineBurst";
            this.Text = "Form_MineBurst";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_MineBurst_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form_MineBurst_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MineBurst_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form_MineBurst_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form_MineBurst_MouseUp);
            this.menuStrip_Burst.ResumeLayout(false);
            this.menuStrip_Burst.PerformLayout();
            this.tableLayoutPanelBurst.ResumeLayout(false);
            this.tableLayoutPanelBurst.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip_Burst;
        private System.Windows.Forms.ToolStripMenuItem gAMEGToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameNToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelBurst;
        private System.Windows.Forms.Label label_Bomb;
        private System.Windows.Forms.Label label_Step;
    }
}