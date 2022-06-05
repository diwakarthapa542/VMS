namespace Vehicle_Management_System
{
    partial class AssignedToPractice
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAssignedToHead = new System.Windows.Forms.Label();
            this.lblAssignedTo = new System.Windows.Forms.Label();
            this.txtAssignedTo = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAssignedToHead
            // 
            this.lblAssignedToHead.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblAssignedToHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lblAssignedToHead.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAssignedToHead.Location = new System.Drawing.Point(19, 28);
            this.lblAssignedToHead.Name = "lblAssignedToHead";
            this.lblAssignedToHead.Size = new System.Drawing.Size(960, 69);
            this.lblAssignedToHead.TabIndex = 0;
            this.lblAssignedToHead.Text = "Assigned To";
            this.lblAssignedToHead.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAssignedTo
            // 
            this.lblAssignedTo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblAssignedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssignedTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAssignedTo.Location = new System.Drawing.Point(44, 97);
            this.lblAssignedTo.Name = "lblAssignedTo";
            this.lblAssignedTo.Padding = new System.Windows.Forms.Padding(10);
            this.lblAssignedTo.Size = new System.Drawing.Size(903, 126);
            this.lblAssignedTo.TabIndex = 1;
            this.lblAssignedTo.Text = "Assined to:";
            this.lblAssignedTo.Click += new System.EventHandler(this.txtAssignedTo_Click);
            // 
            // txtAssignedTo
            // 
            this.txtAssignedTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAssignedTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.txtAssignedTo.Location = new System.Drawing.Point(58, 141);
            this.txtAssignedTo.Name = "txtAssignedTo";
            this.txtAssignedTo.Size = new System.Drawing.Size(189, 23);
            this.txtAssignedTo.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(58, 179);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(54, 27);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AssignedToPractice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAssignedTo);
            this.Controls.Add(this.lblAssignedTo);
            this.Controls.Add(this.lblAssignedToHead);
            this.Name = "AssignedToPractice";
            this.Size = new System.Drawing.Size(1005, 569);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssignedToHead;
        private System.Windows.Forms.Label lblAssignedTo;
        private System.Windows.Forms.TextBox txtAssignedTo;
        private System.Windows.Forms.Button btnSave;
    }
}
