namespace LPR_18_WIN_FORMS
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
            this.vehiclePictureBox = new System.Windows.Forms.PictureBox();
            this.extractNumberPlateBtn = new System.Windows.Forms.Button();
            this.selectVehicleBtn = new System.Windows.Forms.Button();
            this.openCvOCRoBtn = new System.Windows.Forms.Button();
            this.uploadToDbBtn = new System.Windows.Forms.Button();
            this.GetDataBtn = new System.Windows.Forms.Button();
            this.lPpictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.msftComputerVisionOCRBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPpictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiclePictureBox
            // 
            this.vehiclePictureBox.Location = new System.Drawing.Point(29, 39);
            this.vehiclePictureBox.Name = "vehiclePictureBox";
            this.vehiclePictureBox.Size = new System.Drawing.Size(215, 196);
            this.vehiclePictureBox.TabIndex = 0;
            this.vehiclePictureBox.TabStop = false;
            // 
            // extractNumberPlateBtn
            // 
            this.extractNumberPlateBtn.Location = new System.Drawing.Point(29, 316);
            this.extractNumberPlateBtn.Name = "extractNumberPlateBtn";
            this.extractNumberPlateBtn.Size = new System.Drawing.Size(130, 23);
            this.extractNumberPlateBtn.TabIndex = 1;
            this.extractNumberPlateBtn.Text = "Extract Number Plate";
            this.extractNumberPlateBtn.UseVisualStyleBackColor = true;
            this.extractNumberPlateBtn.Click += new System.EventHandler(this.ExtractNumberPlateClick);
            // 
            // selectVehicleBtn
            // 
            this.selectVehicleBtn.Location = new System.Drawing.Point(29, 275);
            this.selectVehicleBtn.Name = "selectVehicleBtn";
            this.selectVehicleBtn.Size = new System.Drawing.Size(130, 23);
            this.selectVehicleBtn.TabIndex = 2;
            this.selectVehicleBtn.Text = "Select Vehicle";
            this.selectVehicleBtn.UseVisualStyleBackColor = true;
            this.selectVehicleBtn.Click += new System.EventHandler(this.SelectCarClick);
            // 
            // openCvOCRoBtn
            // 
            this.openCvOCRoBtn.Location = new System.Drawing.Point(29, 360);
            this.openCvOCRoBtn.Name = "openCvOCRoBtn";
            this.openCvOCRoBtn.Size = new System.Drawing.Size(130, 23);
            this.openCvOCRoBtn.TabIndex = 3;
            this.openCvOCRoBtn.Text = "OCR With OpenCV";
            this.openCvOCRoBtn.UseVisualStyleBackColor = true;
            // 
            // uploadToDbBtn
            // 
            this.uploadToDbBtn.Location = new System.Drawing.Point(188, 275);
            this.uploadToDbBtn.Name = "uploadToDbBtn";
            this.uploadToDbBtn.Size = new System.Drawing.Size(187, 23);
            this.uploadToDbBtn.TabIndex = 4;
            this.uploadToDbBtn.Text = "Upload To Database";
            this.uploadToDbBtn.UseVisualStyleBackColor = true;
            // 
            // GetDataBtn
            // 
            this.GetDataBtn.Location = new System.Drawing.Point(188, 316);
            this.GetDataBtn.Name = "GetDataBtn";
            this.GetDataBtn.Size = new System.Drawing.Size(187, 23);
            this.GetDataBtn.TabIndex = 5;
            this.GetDataBtn.Text = "Get Data";
            this.GetDataBtn.UseVisualStyleBackColor = true;
            // 
            // lPpictureBox
            // 
            this.lPpictureBox.Location = new System.Drawing.Point(356, 39);
            this.lPpictureBox.Name = "lPpictureBox";
            this.lPpictureBox.Size = new System.Drawing.Size(124, 80);
            this.lPpictureBox.TabIndex = 6;
            this.lPpictureBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "License Plate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Vehicle";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(512, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "License Plate Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(512, 77);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "Confidence";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(408, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(353, 283);
            this.dataGridView1.TabIndex = 11;
            // 
            // msftComputerVisionOCRBtn
            // 
            this.msftComputerVisionOCRBtn.Location = new System.Drawing.Point(188, 359);
            this.msftComputerVisionOCRBtn.Name = "msftComputerVisionOCRBtn";
            this.msftComputerVisionOCRBtn.Size = new System.Drawing.Size(187, 23);
            this.msftComputerVisionOCRBtn.TabIndex = 12;
            this.msftComputerVisionOCRBtn.Text = "OCR With Microsoft Computer Vison";
            this.msftComputerVisionOCRBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msftComputerVisionOCRBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPpictureBox);
            this.Controls.Add(this.GetDataBtn);
            this.Controls.Add(this.uploadToDbBtn);
            this.Controls.Add(this.openCvOCRoBtn);
            this.Controls.Add(this.selectVehicleBtn);
            this.Controls.Add(this.extractNumberPlateBtn);
            this.Controls.Add(this.vehiclePictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lPpictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox vehiclePictureBox;
        private System.Windows.Forms.Button extractNumberPlateBtn;
        private System.Windows.Forms.Button selectVehicleBtn;
        private System.Windows.Forms.Button openCvOCRoBtn;
        private System.Windows.Forms.Button uploadToDbBtn;
        private System.Windows.Forms.Button GetDataBtn;
        private System.Windows.Forms.PictureBox lPpictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button msftComputerVisionOCRBtn;
    }
}

