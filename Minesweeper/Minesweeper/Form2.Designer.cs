namespace Minesweeper
{
    partial class Form_Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Setting));
            this.label_Width = new System.Windows.Forms.Label();
            this.numericUpDown_Width = new System.Windows.Forms.NumericUpDown();
            this.label_Bomb = new System.Windows.Forms.Label();
            this.label_Height = new System.Windows.Forms.Label();
            this.numericUpDown_Height = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Bomb = new System.Windows.Forms.NumericUpDown();
            this.button_Ok = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Bomb)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Width
            // 
            this.label_Width.AutoSize = true;
            this.label_Width.Location = new System.Drawing.Point(25, 29);
            this.label_Width.Name = "label_Width";
            this.label_Width.Size = new System.Drawing.Size(55, 15);
            this.label_Width.TabIndex = 0;
            this.label_Width.Text = "Width:";
            // 
            // numericUpDown_Width
            // 
            this.numericUpDown_Width.Location = new System.Drawing.Point(112, 27);
            this.numericUpDown_Width.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDown_Width.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Width.Name = "numericUpDown_Width";
            this.numericUpDown_Width.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Width.TabIndex = 1;
            this.numericUpDown_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Width.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_Bomb
            // 
            this.label_Bomb.AutoSize = true;
            this.label_Bomb.Location = new System.Drawing.Point(25, 141);
            this.label_Bomb.Name = "label_Bomb";
            this.label_Bomb.Size = new System.Drawing.Size(47, 15);
            this.label_Bomb.TabIndex = 2;
            this.label_Bomb.Text = "Bomb:";
            // 
            // label_Height
            // 
            this.label_Height.AutoSize = true;
            this.label_Height.Location = new System.Drawing.Point(25, 84);
            this.label_Height.Name = "label_Height";
            this.label_Height.Size = new System.Drawing.Size(63, 15);
            this.label_Height.TabIndex = 3;
            this.label_Height.Text = "Height:";
            // 
            // numericUpDown_Height
            // 
            this.numericUpDown_Height.Location = new System.Drawing.Point(112, 82);
            this.numericUpDown_Height.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_Height.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Height.Name = "numericUpDown_Height";
            this.numericUpDown_Height.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Height.TabIndex = 4;
            this.numericUpDown_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Height.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDown_Bomb
            // 
            this.numericUpDown_Bomb.Location = new System.Drawing.Point(112, 139);
            this.numericUpDown_Bomb.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDown_Bomb.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_Bomb.Name = "numericUpDown_Bomb";
            this.numericUpDown_Bomb.Size = new System.Drawing.Size(120, 25);
            this.numericUpDown_Bomb.TabIndex = 5;
            this.numericUpDown_Bomb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown_Bomb.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(39, 189);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 6;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.Location = new System.Drawing.Point(139, 189);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(75, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // Form_Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 230);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.numericUpDown_Bomb);
            this.Controls.Add(this.numericUpDown_Height);
            this.Controls.Add(this.label_Height);
            this.Controls.Add(this.label_Bomb);
            this.Controls.Add(this.numericUpDown_Width);
            this.Controls.Add(this.label_Width);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Setting";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.Form_Setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Height)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Bomb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Width;
        private System.Windows.Forms.NumericUpDown numericUpDown_Width;
        private System.Windows.Forms.Label label_Bomb;
        private System.Windows.Forms.Label label_Height;
        private System.Windows.Forms.NumericUpDown numericUpDown_Height;
        private System.Windows.Forms.NumericUpDown numericUpDown_Bomb;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Button button_Cancel;
    }
}