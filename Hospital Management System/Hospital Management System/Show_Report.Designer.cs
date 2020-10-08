namespace Hospital_Management_System
{
    partial class Show_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show_Report));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Patient_ID = new System.Windows.Forms.TextBox();
            this.Test_ID = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Refresh = new System.Windows.Forms.Button();
            this.Help = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.M = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(11, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1901, 676);
            this.reportViewer1.TabIndex = 0;
            // 
            // Patient_ID
            // 
            this.Patient_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Patient_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patient_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patient_ID.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_ID.ForeColor = System.Drawing.Color.Black;
            this.Patient_ID.HideSelection = false;
            this.Patient_ID.Location = new System.Drawing.Point(11, 19);
            this.Patient_ID.Name = "Patient_ID";
            this.Patient_ID.Size = new System.Drawing.Size(89, 31);
            this.Patient_ID.TabIndex = 57;
            this.Patient_ID.TabStop = false;
            this.Patient_ID.Text = "P_ID";
            this.Patient_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Patient_ID.Click += new System.EventHandler(this.Patient_ID_Click);
            // 
            // Test_ID
            // 
            this.Test_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Test_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Test_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Test_ID.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Test_ID.ForeColor = System.Drawing.Color.Black;
            this.Test_ID.HideSelection = false;
            this.Test_ID.Location = new System.Drawing.Point(106, 19);
            this.Test_ID.Name = "Test_ID";
            this.Test_ID.Size = new System.Drawing.Size(89, 31);
            this.Test_ID.TabIndex = 58;
            this.Test_ID.TabStop = false;
            this.Test_ID.Text = "T_ID";
            this.Test_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Test_ID.Click += new System.EventHandler(this.Test_ID_Click);
            // 
            // Load
            // 
            this.Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Load.Location = new System.Drawing.Point(222, 12);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(197, 46);
            this.Load.TabIndex = 59;
            this.Load.Text = "Load Report";
            this.Load.UseVisualStyleBackColor = false;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1352, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(80, 46);
            this.Exit.TabIndex = 60;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(444, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(453, 31);
            this.textBox1.TabIndex = 61;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Test Name";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Refresh
            // 
            this.Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh.Location = new System.Drawing.Point(919, 13);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(144, 46);
            this.Refresh.TabIndex = 62;
            this.Refresh.Text = "Refresh";
            this.Refresh.UseVisualStyleBackColor = false;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Help
            // 
            this.Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Help.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Help.ForeColor = System.Drawing.Color.Transparent;
            this.Help.Image = ((System.Drawing.Image)(resources.GetObject("Help.Image")));
            this.Help.Location = new System.Drawing.Point(1069, 12);
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(51, 48);
            this.Help.TabIndex = 99;
            this.Help.UseVisualStyleBackColor = false;
            this.Help.Click += new System.EventHandler(this.Help_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(1126, 12);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(80, 46);
            this.Back.TabIndex = 100;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // M
            // 
            this.M.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.M.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(1212, 12);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(134, 46);
            this.M.TabIndex = 101;
            this.M.Text = "Maximize";
            this.M.UseVisualStyleBackColor = false;
            this.M.Click += new System.EventHandler(this.M_Click);
            // 
            // Show_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1924, 765);
            this.Controls.Add(this.M);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Help);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.Test_ID);
            this.Controls.Add(this.Patient_ID);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Show_Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show_Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox Patient_ID;
        private System.Windows.Forms.TextBox Test_ID;
        private System.Windows.Forms.Button Load;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Help;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button M;
    }
}