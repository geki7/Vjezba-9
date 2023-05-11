namespace Tasks
{
    partial class Form1
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
            this.dgvEmployee = new System.Windows.Forms.DataGridView();
            this.dgvTask = new System.Windows.Forms.DataGridView();
            this.txtbFName = new System.Windows.Forms.TextBox();
            this.txtbLName = new System.Windows.Forms.TextBox();
            this.txtbDescription = new System.Windows.Forms.TextBox();
            this.cmbPriorty = new System.Windows.Forms.ComboBox();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnTask = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEmployee
            // 
            this.dgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployee.Location = new System.Drawing.Point(12, 25);
            this.dgvEmployee.Name = "dgvEmployee";
            this.dgvEmployee.Size = new System.Drawing.Size(634, 187);
            this.dgvEmployee.TabIndex = 0;
            // 
            // dgvTask
            // 
            this.dgvTask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTask.Location = new System.Drawing.Point(12, 278);
            this.dgvTask.Name = "dgvTask";
            this.dgvTask.Size = new System.Drawing.Size(634, 187);
            this.dgvTask.TabIndex = 1;
            this.dgvTask.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTask_CellContentClick);
            // 
            // txtbFName
            // 
            this.txtbFName.Location = new System.Drawing.Point(12, 491);
            this.txtbFName.Name = "txtbFName";
            this.txtbFName.Size = new System.Drawing.Size(194, 20);
            this.txtbFName.TabIndex = 2;
            // 
            // txtbLName
            // 
            this.txtbLName.Location = new System.Drawing.Point(238, 491);
            this.txtbLName.Name = "txtbLName";
            this.txtbLName.Size = new System.Drawing.Size(194, 20);
            this.txtbLName.TabIndex = 3;
            // 
            // txtbDescription
            // 
            this.txtbDescription.Location = new System.Drawing.Point(12, 558);
            this.txtbDescription.Name = "txtbDescription";
            this.txtbDescription.Size = new System.Drawing.Size(194, 20);
            this.txtbDescription.TabIndex = 4;
            // 
            // cmbPriorty
            // 
            this.cmbPriorty.FormattingEnabled = true;
            this.cmbPriorty.Location = new System.Drawing.Point(238, 557);
            this.cmbPriorty.Name = "cmbPriorty";
            this.cmbPriorty.Size = new System.Drawing.Size(194, 21);
            this.cmbPriorty.TabIndex = 5;
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(438, 489);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(142, 23);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "Add Employee";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnTask
            // 
            this.btnTask.Location = new System.Drawing.Point(438, 555);
            this.btnTask.Name = "btnTask";
            this.btnTask.Size = new System.Drawing.Size(142, 23);
            this.btnTask.TabIndex = 7;
            this.btnTask.Text = "Add Task";
            this.btnTask.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(595, 502);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(101, 63);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete Task";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 590);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnTask);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.cmbPriorty);
            this.Controls.Add(this.txtbDescription);
            this.Controls.Add(this.txtbLName);
            this.Controls.Add(this.txtbFName);
            this.Controls.Add(this.dgvTask);
            this.Controls.Add(this.dgvEmployee);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmployee;
        private System.Windows.Forms.DataGridView dgvTask;
        private System.Windows.Forms.TextBox txtbFName;
        private System.Windows.Forms.TextBox txtbLName;
        private System.Windows.Forms.TextBox txtbDescription;
        private System.Windows.Forms.ComboBox cmbPriorty;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnTask;
        private System.Windows.Forms.Button btnDelete;
    }
}

