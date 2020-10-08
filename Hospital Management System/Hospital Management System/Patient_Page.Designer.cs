namespace Hospital_Management_System
{
    partial class Patient_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient_Page));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Show_User_Info = new System.Windows.Forms.Button();
            this.Show_Doctor_Info = new System.Windows.Forms.Button();
            this.Update_User_Info = new System.Windows.Forms.Button();
            this.Show_Test_Info = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.Patient_Name = new System.Windows.Forms.TextBox();
            this.Patient_ID = new System.Windows.Forms.TextBox();
            this.Delete = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Appointment_Time = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(107, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 44);
            this.label1.TabIndex = 22;
            this.label1.Text = "Patient Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Patient Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(182, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 29);
            this.label3.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 29);
            this.label4.TabIndex = 26;
            this.label4.Text = "Patient ID:";
            // 
            // Show_User_Info
            // 
            this.Show_User_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Show_User_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_User_Info.Location = new System.Drawing.Point(98, 252);
            this.Show_User_Info.Name = "Show_User_Info";
            this.Show_User_Info.Size = new System.Drawing.Size(221, 46);
            this.Show_User_Info.TabIndex = 49;
            this.Show_User_Info.Text = "Show User Info";
            this.Show_User_Info.UseVisualStyleBackColor = false;
            this.Show_User_Info.Click += new System.EventHandler(this.Show_User_Info_Click);
            // 
            // Show_Doctor_Info
            // 
            this.Show_Doctor_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Show_Doctor_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Doctor_Info.Location = new System.Drawing.Point(98, 323);
            this.Show_Doctor_Info.Name = "Show_Doctor_Info";
            this.Show_Doctor_Info.Size = new System.Drawing.Size(221, 46);
            this.Show_Doctor_Info.TabIndex = 50;
            this.Show_Doctor_Info.Text = "Show Doctor Info";
            this.Show_Doctor_Info.UseVisualStyleBackColor = false;
            this.Show_Doctor_Info.Click += new System.EventHandler(this.Show_Doctor_Info_Click);
            // 
            // Update_User_Info
            // 
            this.Update_User_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Update_User_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update_User_Info.Location = new System.Drawing.Point(98, 397);
            this.Update_User_Info.Name = "Update_User_Info";
            this.Update_User_Info.Size = new System.Drawing.Size(221, 46);
            this.Update_User_Info.TabIndex = 51;
            this.Update_User_Info.Text = "Update User Info";
            this.Update_User_Info.UseVisualStyleBackColor = false;
            this.Update_User_Info.Click += new System.EventHandler(this.Update_User_Info_Click);
            // 
            // Show_Test_Info
            // 
            this.Show_Test_Info.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Show_Test_Info.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Show_Test_Info.Location = new System.Drawing.Point(98, 470);
            this.Show_Test_Info.Name = "Show_Test_Info";
            this.Show_Test_Info.Size = new System.Drawing.Size(221, 46);
            this.Show_Test_Info.TabIndex = 52;
            this.Show_Test_Info.Text = "Show Test Info";
            this.Show_Test_Info.UseVisualStyleBackColor = false;
            this.Show_Test_Info.Click += new System.EventHandler(this.Show_Test_Info_Click);
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.Location = new System.Drawing.Point(10, 683);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(81, 46);
            this.Back.TabIndex = 53;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(310, 683);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(80, 46);
            this.button_Exit.TabIndex = 54;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            this.button_Exit.Click += new System.EventHandler(this.button_Exit_Click);
            // 
            // Patient_Name
            // 
            this.Patient_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Patient_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patient_Name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patient_Name.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Name.ForeColor = System.Drawing.Color.White;
            this.Patient_Name.HideSelection = false;
            this.Patient_Name.Location = new System.Drawing.Point(182, 146);
            this.Patient_Name.Name = "Patient_Name";
            this.Patient_Name.ReadOnly = true;
            this.Patient_Name.Size = new System.Drawing.Size(227, 27);
            this.Patient_Name.TabIndex = 55;
            this.Patient_Name.TabStop = false;
            this.Patient_Name.TextChanged += new System.EventHandler(this.Patient_Name_TextChanged);
            // 
            // Patient_ID
            // 
            this.Patient_ID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Patient_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Patient_ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Patient_ID.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_ID.ForeColor = System.Drawing.Color.White;
            this.Patient_ID.HideSelection = false;
            this.Patient_ID.Location = new System.Drawing.Point(182, 188);
            this.Patient_ID.Name = "Patient_ID";
            this.Patient_ID.ReadOnly = true;
            this.Patient_ID.Size = new System.Drawing.Size(208, 27);
            this.Patient_ID.TabIndex = 56;
            this.Patient_ID.TabStop = false;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(98, 544);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(221, 46);
            this.Delete.TabIndex = 57;
            this.Delete.Text = "Delete Account";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = global::Hospital_Management_System.Properties.Resources.icons8_user_40;
            this.pictureBox2.Location = new System.Drawing.Point(187, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(51, 50);
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // Appointment_Time
            // 
            this.Appointment_Time.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(36)))), ((int)(((byte)(100)))));
            this.Appointment_Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appointment_Time.Location = new System.Drawing.Point(97, 616);
            this.Appointment_Time.Name = "Appointment_Time";
            this.Appointment_Time.Size = new System.Drawing.Size(221, 46);
            this.Appointment_Time.TabIndex = 58;
            this.Appointment_Time.Text = "Appointment Info";
            this.Appointment_Time.UseVisualStyleBackColor = false;
            this.Appointment_Time.Click += new System.EventHandler(this.Appointment_Time_Click);
            // 
            // Patient_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(409, 741);
            this.Controls.Add(this.Appointment_Time);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Patient_ID);
            this.Controls.Add(this.Patient_Name);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Show_Test_Info);
            this.Controls.Add(this.Update_User_Info);
            this.Controls.Add(this.Show_Doctor_Info);
            this.Controls.Add(this.Show_User_Info);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient_Page";
            this.Load += new System.EventHandler(this.Patient_Page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Show_User_Info;
        private System.Windows.Forms.Button Show_Doctor_Info;
        private System.Windows.Forms.Button Update_User_Info;
        private System.Windows.Forms.Button Show_Test_Info;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.TextBox Patient_Name;
        private System.Windows.Forms.TextBox Patient_ID;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Appointment_Time;
    }
}