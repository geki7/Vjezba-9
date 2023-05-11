namespace Senors2
{
    partial class frmAssign
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
            this.cmbUnit = new System.Windows.Forms.ComboBox();
            this.btnAssignUnit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbUnit
            // 
            this.cmbUnit.FormattingEnabled = true;
            this.cmbUnit.Location = new System.Drawing.Point(27, 32);
            this.cmbUnit.Name = "cmbUnit";
            this.cmbUnit.Size = new System.Drawing.Size(299, 21);
            this.cmbUnit.TabIndex = 0;
            // 
            // btnAssignUnit
            // 
            this.btnAssignUnit.Location = new System.Drawing.Point(27, 85);
            this.btnAssignUnit.Name = "btnAssignUnit";
            this.btnAssignUnit.Size = new System.Drawing.Size(92, 39);
            this.btnAssignUnit.TabIndex = 1;
            this.btnAssignUnit.Text = "Assign";
            this.btnAssignUnit.UseVisualStyleBackColor = true;
            this.btnAssignUnit.Click += new System.EventHandler(this.btnAssignUnit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(234, 85);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 39);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmAssign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 164);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAssignUnit);
            this.Controls.Add(this.cmbUnit);
            this.Name = "frmAssign";
            this.Text = "frmAssign";
            this.Load += new System.EventHandler(this.frmAssign_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUnit;
        private System.Windows.Forms.Button btnAssignUnit;
        private System.Windows.Forms.Button btnCancel;
    }
}