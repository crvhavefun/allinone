namespace RPS_Utility
{
    partial class Menu
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
            this.Btn_UMP = new System.Windows.Forms.Button();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_UMP
            // 
            this.Btn_UMP.Location = new System.Drawing.Point(13, 13);
            this.Btn_UMP.Name = "Btn_UMP";
            this.Btn_UMP.Size = new System.Drawing.Size(267, 23);
            this.Btn_UMP.TabIndex = 0;
            this.Btn_UMP.Text = "User\'s Modules Permission";
            this.Btn_UMP.UseVisualStyleBackColor = true;
            this.Btn_UMP.Click += new System.EventHandler(this.Btn_UMP_Click);
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.Location = new System.Drawing.Point(13, 238);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(267, 23);
            this.Btn_Exit.TabIndex = 1;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.UseVisualStyleBackColor = true;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Btn_Exit;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_UMP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RPS Utilities v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_UMP;
        private System.Windows.Forms.Button Btn_Exit;
    }
}

