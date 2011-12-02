namespace RPS_Utility
{
    partial class UMP
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.reportPlatformDBDataSet1 = new RPS_Utility.ReportPlatformDBDataSet1();
            this.rpsuserinfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rps_userinfoTableAdapter = new RPS_Utility.ReportPlatformDBDataSet1TableAdapters.rps_userinfoTableAdapter();
            this.reportPlatformDBDataSet = new RPS_Utility.ReportPlatformDBDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.reportPlatformDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsuserinfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPlatformDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.rpsuserinfoBindingSource;
            this.comboBox1.DisplayMember = "user_name";
            this.comboBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.MaxDropDownItems = 10;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(514, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "user_id";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.rpsuserinfoBindingSource;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(200, 340);
            this.listBox1.TabIndex = 1;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(302, 27);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(200, 340);
            this.listBox2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(221, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // reportPlatformDBDataSet1
            // 
            this.reportPlatformDBDataSet1.DataSetName = "ReportPlatformDBDataSet1";
            this.reportPlatformDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rpsuserinfoBindingSource
            // 
            this.rpsuserinfoBindingSource.DataMember = "rps_userinfo";
            this.rpsuserinfoBindingSource.DataSource = this.reportPlatformDBDataSet1;
            // 
            // rps_userinfoTableAdapter
            // 
            this.rps_userinfoTableAdapter.ClearBeforeFill = true;
            // 
            // reportPlatformDBDataSet
            // 
            this.reportPlatformDBDataSet.DataSetName = "ReportPlatformDBDataSet";
            this.reportPlatformDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 375);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UMP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UMP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.UMP_UnLoad);
            this.Load += new System.EventHandler(this.UMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportPlatformDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rpsuserinfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportPlatformDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private ReportPlatformDBDataSet1 reportPlatformDBDataSet1;
        private System.Windows.Forms.BindingSource rpsuserinfoBindingSource;
        private ReportPlatformDBDataSet1TableAdapters.rps_userinfoTableAdapter rps_userinfoTableAdapter;
        private ReportPlatformDBDataSet reportPlatformDBDataSet;
    }
}