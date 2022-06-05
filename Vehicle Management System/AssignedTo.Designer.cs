namespace Vehicle_Management_System
{
    partial class AssignedTo
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
            this.txtAssignedTo = new System.Windows.Forms.TextBox();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.lblAssignedToHead = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(47, 160);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 27);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // txtAssignedTo
            // 
            this.txtAssignedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAssignedTo.Location = new System.Drawing.Point(47, 122);
            this.txtAssignedTo.Name = "txtAssignedTo";
            this.txtAssignedTo.Size = new System.Drawing.Size(189, 23);
            this.txtAssignedTo.TabIndex = 6;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAssignedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssignedTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAssignedTo.Location = new System.Drawing.Point(32, 77);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Padding = new System.Windows.Forms.Padding(10);
            this.lblAssignedTo.Size = new System.Drawing.Size(846, 126);
            this.lblAssignedTo.TabIndex = 5;
            this.lblAssignedTo.Text = "Assined to:";
            // 
            // lblAssignedToHead
            // 
            this.lblAssignedToHead.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAssignedToHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblAssignedToHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAssignedToHead.Location = new System.Drawing.Point(26, 20);
            this.lblAssignedToHead.Name = "lblAssignedToHead";
            this.lblAssignedToHead.Size = new System.Drawing.Size(852, 37);
            this.lblAssignedToHead.TabIndex = 4;
            this.lblAssignedToHead.Text = "Assigned To";
            this.lblAssignedToHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AssignedTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 486);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAssignedTo);
            this.Controls.Add(this.lblAssignedTo);
            this.Controls.Add(this.lblAssignedToHead);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AssignedTo";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AssignedTo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtAssignedTo;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.Label lblAssignedToHead;
    }
}

