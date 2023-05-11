namespace Assigment
{
    partial class AssigmentResults
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
            this.dgvStatus = new System.Windows.Forms.DataGridView();
            this.dgvAssigments = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtbStudent = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPoints = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigments)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStatus
            // 
            this.dgvStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStatus.Location = new System.Drawing.Point(12, 30);
            this.dgvStatus.Name = "dgvStatus";
            this.dgvStatus.Size = new System.Drawing.Size(273, 165);
            this.dgvStatus.TabIndex = 0;
            this.dgvStatus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatus_CellContentClick);
            // 
            // dgvAssigments
            // 
            this.dgvAssigments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssigments.Location = new System.Drawing.Point(12, 227);
            this.dgvAssigments.Name = "dgvAssigments";
            this.dgvAssigments.Size = new System.Drawing.Size(710, 165);
            this.dgvAssigments.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(566, 474);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(647, 474);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtbStudent
            // 
            this.txtbStudent.Location = new System.Drawing.Point(344, 432);
            this.txtbStudent.Name = "txtbStudent";
            this.txtbStudent.Size = new System.Drawing.Size(122, 20);
            this.txtbStudent.TabIndex = 4;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(472, 432);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(122, 20);
            this.txtDescription.TabIndex = 5;
            // 
            // txtPoints
            // 
            this.txtPoints.Location = new System.Drawing.Point(600, 432);
            this.txtPoints.Name = "txtPoints";
            this.txtPoints.Size = new System.Drawing.Size(122, 20);
            this.txtPoints.TabIndex = 6;
            // 
            // AssigmentResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 536);
            this.Controls.Add(this.txtPoints);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtbStudent);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dgvAssigments);
            this.Controls.Add(this.dgvStatus);
            this.Name = "AssigmentResults";
            this.Text = "Assigments results";
            this.Load += new System.EventHandler(this.AssigmentResults_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssigments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStatus;
        private System.Windows.Forms.DataGridView dgvAssigments;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtbStudent;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPoints;
    }
}

