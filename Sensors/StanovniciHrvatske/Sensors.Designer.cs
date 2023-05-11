namespace StanovniciHrvatske
{
    partial class Sensors
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
            this.dgvSensors = new System.Windows.Forms.DataGridView();
            this.btnAddSensor = new System.Windows.Forms.Button();
            this.btnDeleteSenosr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSensors
            // 
            this.dgvSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSensors.Location = new System.Drawing.Point(26, 33);
            this.dgvSensors.Name = "dgvSensors";
            this.dgvSensors.Size = new System.Drawing.Size(512, 280);
            this.dgvSensors.TabIndex = 0;
            // 
            // btnAddSensor
            // 
            this.btnAddSensor.Location = new System.Drawing.Point(26, 336);
            this.btnAddSensor.Name = "btnAddSensor";
            this.btnAddSensor.Size = new System.Drawing.Size(75, 23);
            this.btnAddSensor.TabIndex = 1;
            this.btnAddSensor.Text = "Add Sensor";
            this.btnAddSensor.UseVisualStyleBackColor = true;
            this.btnAddSensor.Click += new System.EventHandler(this.btnAddSensor_Click);
            // 
            // btnDeleteSenosr
            // 
            this.btnDeleteSenosr.Location = new System.Drawing.Point(436, 336);
            this.btnDeleteSenosr.Name = "btnDeleteSenosr";
            this.btnDeleteSenosr.Size = new System.Drawing.Size(102, 23);
            this.btnDeleteSenosr.TabIndex = 2;
            this.btnDeleteSenosr.Text = "Delete Sensor";
            this.btnDeleteSenosr.UseVisualStyleBackColor = true;
            this.btnDeleteSenosr.Click += new System.EventHandler(this.btnDeleteSenosr_Click);
            // 
            // Stanovnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 375);
            this.Controls.Add(this.btnDeleteSenosr);
            this.Controls.Add(this.btnAddSensor);
            this.Controls.Add(this.dgvSensors);
            this.Name = "Stanovnici";
            this.Text = "Stanovnici hrvatske";
            this.Load += new System.EventHandler(this.Stanovnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSensors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSensors;
        private System.Windows.Forms.Button btnAddSensor;
        private System.Windows.Forms.Button btnDeleteSenosr;
    }
}

