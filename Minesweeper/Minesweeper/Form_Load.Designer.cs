namespace Minesweeper
{
    partial class Form_Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Load));
            this.btn_traditional = new System.Windows.Forms.Button();
            this.btn_burst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_traditional
            // 
            this.btn_traditional.BackColor = System.Drawing.SystemColors.Control;
            this.btn_traditional.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_traditional.Location = new System.Drawing.Point(239, 145);
            this.btn_traditional.Name = "btn_traditional";
            this.btn_traditional.Size = new System.Drawing.Size(323, 57);
            this.btn_traditional.TabIndex = 0;
            this.btn_traditional.Text = "传统模式";
            this.btn_traditional.UseVisualStyleBackColor = false;
            this.btn_traditional.Click += new System.EventHandler(this.btn_traditional_Click);
            this.btn_traditional.MouseLeave += new System.EventHandler(this.btn_traditional_MouseLeave);
            this.btn_traditional.MouseHover += new System.EventHandler(this.btn_traditional_MouseHover);
            // 
            // btn_burst
            // 
            this.btn_burst.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_burst.Location = new System.Drawing.Point(239, 303);
            this.btn_burst.Name = "btn_burst";
            this.btn_burst.Size = new System.Drawing.Size(323, 53);
            this.btn_burst.TabIndex = 1;
            this.btn_burst.Text = "爆破模式";
            this.btn_burst.UseVisualStyleBackColor = true;
            this.btn_burst.Click += new System.EventHandler(this.btn_burst_Click);
            this.btn_burst.MouseLeave += new System.EventHandler(this.btn_burst_MouseLeave);
            this.btn_burst.MouseHover += new System.EventHandler(this.btn_burst_MouseHover);
            // 
            // Form_Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Fuchsia;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(799, 531);
            this.Controls.Add(this.btn_burst);
            this.Controls.Add(this.btn_traditional);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Load";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_traditional;
        private System.Windows.Forms.Button btn_burst;
    }
}