namespace Minesweeper
{
    partial class Form_Rank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Rank));
            this.label_Beginner = new System.Windows.Forms.Label();
            this.label_Intermediate = new System.Windows.Forms.Label();
            this.label_Expert = new System.Windows.Forms.Label();
            this.button_Reset = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Beginner
            // 
            this.label_Beginner.AutoSize = true;
            this.label_Beginner.Location = new System.Drawing.Point(12, 28);
            this.label_Beginner.Name = "label_Beginner";
            this.label_Beginner.Size = new System.Drawing.Size(71, 15);
            this.label_Beginner.TabIndex = 0;
            this.label_Beginner.Text = "Beginner";
            // 
            // label_Intermediate
            // 
            this.label_Intermediate.AutoSize = true;
            this.label_Intermediate.Location = new System.Drawing.Point(12, 72);
            this.label_Intermediate.Name = "label_Intermediate";
            this.label_Intermediate.Size = new System.Drawing.Size(103, 15);
            this.label_Intermediate.TabIndex = 1;
            this.label_Intermediate.Text = "Intermediate";
            // 
            // label_Expert
            // 
            this.label_Expert.AutoSize = true;
            this.label_Expert.Location = new System.Drawing.Point(12, 117);
            this.label_Expert.Name = "label_Expert";
            this.label_Expert.Size = new System.Drawing.Size(55, 15);
            this.label_Expert.TabIndex = 2;
            this.label_Expert.Text = "Expert";
            // 
            // button_Reset
            // 
            this.button_Reset.Location = new System.Drawing.Point(57, 146);
            this.button_Reset.Name = "button_Reset";
            this.button_Reset.Size = new System.Drawing.Size(75, 23);
            this.button_Reset.TabIndex = 3;
            this.button_Reset.Text = "Reset";
            this.button_Reset.UseVisualStyleBackColor = true;
            this.button_Reset.Click += new System.EventHandler(this.button_Reset_Click);
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(226, 146);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 4;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // Form_Rank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 181);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Reset);
            this.Controls.Add(this.label_Expert);
            this.Controls.Add(this.label_Intermediate);
            this.Controls.Add(this.label_Beginner);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Rank";
            this.Text = "Rank";
            this.Load += new System.EventHandler(this.Form_Rank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Beginner;
        private System.Windows.Forms.Label label_Intermediate;
        private System.Windows.Forms.Label label_Expert;
        private System.Windows.Forms.Button button_Reset;
        private System.Windows.Forms.Button button_Ok;
    }
}