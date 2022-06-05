namespace Vehicle_Management_System
{
    partial class ChangePassword
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
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmNewPassword = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(28, 221);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(149, 39);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Change Password";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtCurrentPassword.Location = new System.Drawing.Point(28, 44);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(716, 23);
            this.txtCurrentPassword.TabIndex = 10;
            this.txtCurrentPassword.TextChanged += new System.EventHandler(this.txtAssignedTo_TextChanged);
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCurrentPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblCurrentPassword.Location = new System.Drawing.Point(13, 1);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Padding = new System.Windows.Forms.Padding(10);
            this.lblCurrentPassword.Size = new System.Drawing.Size(164, 40);
            this.lblCurrentPassword.TabIndex = 9;
            this.lblCurrentPassword.Text = "Current Password";
            this.lblCurrentPassword.Click += new System.EventHandler(this.lblAssignedTo_Click);
            // 
            // lblHeading
            // 
            this.lblHeading.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblHeading.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHeading.Location = new System.Drawing.Point(13, 10);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(774, 37);
            this.lblHeading.TabIndex = 8;
            this.lblHeading.Text = "सवारी साधन व्यवस्थान प्रणाली";
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeading.Click += new System.EventHandler(this.lblAssignedToHead_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.txtConfirmNewPassword);
            this.panel1.Controls.Add(this.txtNewPassword);
            this.panel1.Controls.Add(this.lblConfirmNewPassword);
            this.panel1.Controls.Add(this.lblCurrentPassword);
            this.panel1.Controls.Add(this.txtCurrentPassword);
            this.panel1.Controls.Add(this.lblNewPassword);
            this.panel1.Location = new System.Drawing.Point(13, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 320);
            this.panel1.TabIndex = 12;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtNewPassword.Location = new System.Drawing.Point(28, 113);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(716, 23);
            this.txtNewPassword.TabIndex = 14;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblNewPassword.Location = new System.Drawing.Point(13, 70);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Padding = new System.Windows.Forms.Padding(10);
            this.lblNewPassword.Size = new System.Drawing.Size(141, 40);
            this.lblNewPassword.TabIndex = 13;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtConfirmNewPassword
            // 
            this.txtConfirmNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtConfirmNewPassword.Location = new System.Drawing.Point(28, 179);
            this.txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            this.txtConfirmNewPassword.Size = new System.Drawing.Size(716, 23);
            this.txtConfirmNewPassword.TabIndex = 16;
            this.txtConfirmNewPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblConfirmNewPassword
            // 
            this.lblConfirmNewPassword.AutoSize = true;
            this.lblConfirmNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmNewPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblConfirmNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblConfirmNewPassword.Location = new System.Drawing.Point(13, 136);
            this.lblConfirmNewPassword.Name = "lblConfirmNewPassword";
            this.lblConfirmNewPassword.Padding = new System.Windows.Forms.Padding(10);
            this.lblConfirmNewPassword.Size = new System.Drawing.Size(205, 40);
            this.lblConfirmNewPassword.TabIndex = 15;
            this.lblConfirmNewPassword.Text = "Confirm New Password";
            this.lblConfirmNewPassword.Click += new System.EventHandler(this.label2_Click);
            // 
            // ChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panel1);
            this.Name = "ChangePassword";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ChangePassword";
            this.Load += new System.EventHandler(this.ChangePassword_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtConfirmNewPassword;
        private System.Windows.Forms.Label lblConfirmNewPassword;
    }
}