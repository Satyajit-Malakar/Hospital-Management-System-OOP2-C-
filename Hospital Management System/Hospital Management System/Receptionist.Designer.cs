namespace Hospital_Management_System
{
    partial class Receptionist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist));
            this.label1 = new System.Windows.Forms.Label();
            this.R_Name = new System.Windows.Forms.Label();
            this.textR_Name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textR_ID = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.T_R = new System.Windows.Forms.Button();
            this.Take_Bill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(237, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 44);
            this.label1.TabIndex = 23;
            this.label1.Text = "Receptionist";
            // 
            // R_Name
            // 
            this.R_Name.AutoSize = true;
            this.R_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.R_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.R_Name.Location = new System.Drawing.Point(7, 129);
            this.R_Name.Name = "R_Name";
            this.R_Name.Size = new System.Drawing.Size(230, 29);
            this.R_Name.TabIndex = 67;
            this.R_Name.Text = "Receptionist Name :";
            // 
            // textR_Name
            // 
            this.textR_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textR_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textR_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textR_Name.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textR_Name.ForeColor = System.Drawing.Color.White;
            this.textR_Name.HideSelection = false;
            this.textR_Name.Location = new System.Drawing.Point(245, 129);
            this.textR_Name.Name = "textR_Name";
            this.textR_Name.ReadOnly = true;
            this.textR_Name.Size = new System.Drawing.Size(401, 27);
            this.textR_Name.TabIndex = 64;
            this.textR_Name.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(12, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 29);
            this.label4.TabIndex = 68;
            this.label4.Text = "ID :";
            // 
            // textR_ID
            // 
            this.textR_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.textR_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textR_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textR_ID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textR_ID.ForeColor = System.Drawing.Color.White;
            this.textR_ID.HideSelection = false;
            this.textR_ID.Location = new System.Drawing.Point(65, 204);
            this.textR_ID.Name = "textR_ID";
            this.textR_ID.ReadOnly = true;
            this.textR_ID.Size = new System.Drawing.Size(152, 27);
            this.textR_ID.TabIndex = 70;
            this.textR_ID.TabStop = false;
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(269, 391);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(125, 41);
            this.Exit.TabIndex = 73;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // T_R
            // 
            this.T_R.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.T_R.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.T_R.Location = new System.Drawing.Point(12, 274);
            this.T_R.Name = "T_R";
            this.T_R.Size = new System.Drawing.Size(205, 41);
            this.T_R.TabIndex = 74;
            this.T_R.Text = "Test Report";
            this.T_R.UseVisualStyleBackColor = false;
            this.T_R.Click += new System.EventHandler(this.T_R_Click);
            // 
            // Take_Bill
            // 
            this.Take_Bill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Take_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Take_Bill.Location = new System.Drawing.Point(441, 274);
            this.Take_Bill.Name = "Take_Bill";
            this.Take_Bill.Size = new System.Drawing.Size(205, 41);
            this.Take_Bill.TabIndex = 75;
            this.Take_Bill.Text = "Take Bill";
            this.Take_Bill.UseVisualStyleBackColor = false;
            this.Take_Bill.Click += new System.EventHandler(this.Take_Bill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.ErrorImage = global::Hospital_Management_System.Properties.Resources.icons8_front_desk_40;
            this.pictureBox1.Location = new System.Drawing.Point(181, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(672, 468);
            this.Controls.Add(this.Take_Bill);
            this.Controls.Add(this.T_R);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.textR_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.R_Name);
            this.Controls.Add(this.textR_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receptionist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist";
            this.Load += new System.EventHandler(this.Receptionist_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label R_Name;
        private System.Windows.Forms.TextBox textR_Name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textR_ID;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button T_R;
        private System.Windows.Forms.Button Take_Bill;
    }
}