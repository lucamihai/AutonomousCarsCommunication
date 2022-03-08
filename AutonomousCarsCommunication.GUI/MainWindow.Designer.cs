namespace AutonomousCarsCommunication.GUI
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelAllCars = new System.Windows.Forms.Panel();
            this.panelSelectedCar = new System.Windows.Forms.Panel();
            this.labelSelectedCarPosition = new System.Windows.Forms.Label();
            this.labelSelectedCarSpeed = new System.Windows.Forms.Label();
            this.labelSelectedCarModel = new System.Windows.Forms.Label();
            this.labelSelectedCarManufacturer = new System.Windows.Forms.Label();
            this.pictureBoxSelectedCar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMyCarPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMyCarSpeed = new System.Windows.Forms.Label();
            this.pictureBoxMyCar = new System.Windows.Forms.PictureBox();
            this.labelMyCarModel = new System.Windows.Forms.Label();
            this.labelMyCarManufacturer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.panelSelectedCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedCar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyCar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelAllCars
            // 
            this.panelAllCars.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAllCars.Location = new System.Drawing.Point(12, 47);
            this.panelAllCars.Name = "panelAllCars";
            this.panelAllCars.Size = new System.Drawing.Size(275, 622);
            this.panelAllCars.TabIndex = 0;
            // 
            // panelSelectedCar
            // 
            this.panelSelectedCar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelSelectedCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarPosition);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarSpeed);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarModel);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarManufacturer);
            this.panelSelectedCar.Controls.Add(this.pictureBoxSelectedCar);
            this.panelSelectedCar.Controls.Add(this.label2);
            this.panelSelectedCar.Location = new System.Drawing.Point(321, 12);
            this.panelSelectedCar.Name = "panelSelectedCar";
            this.panelSelectedCar.Size = new System.Drawing.Size(467, 657);
            this.panelSelectedCar.TabIndex = 1;
            // 
            // labelSelectedCarPosition
            // 
            this.labelSelectedCarPosition.AutoSize = true;
            this.labelSelectedCarPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCarPosition.Location = new System.Drawing.Point(229, 211);
            this.labelSelectedCarPosition.Name = "labelSelectedCarPosition";
            this.labelSelectedCarPosition.Size = new System.Drawing.Size(89, 19);
            this.labelSelectedCarPosition.TabIndex = 9;
            this.labelSelectedCarPosition.Text = "Position (x,y)";
            // 
            // labelSelectedCarSpeed
            // 
            this.labelSelectedCarSpeed.AutoSize = true;
            this.labelSelectedCarSpeed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCarSpeed.Location = new System.Drawing.Point(229, 178);
            this.labelSelectedCarSpeed.Name = "labelSelectedCarSpeed";
            this.labelSelectedCarSpeed.Size = new System.Drawing.Size(92, 19);
            this.labelSelectedCarSpeed.TabIndex = 8;
            this.labelSelectedCarSpeed.Text = "Speed (km/h)";
            // 
            // labelSelectedCarModel
            // 
            this.labelSelectedCarModel.AutoSize = true;
            this.labelSelectedCarModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCarModel.Location = new System.Drawing.Point(229, 106);
            this.labelSelectedCarModel.Name = "labelSelectedCarModel";
            this.labelSelectedCarModel.Size = new System.Drawing.Size(49, 19);
            this.labelSelectedCarModel.TabIndex = 7;
            this.labelSelectedCarModel.Text = "Model";
            // 
            // labelSelectedCarManufacturer
            // 
            this.labelSelectedCarManufacturer.AutoSize = true;
            this.labelSelectedCarManufacturer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCarManufacturer.Location = new System.Drawing.Point(229, 74);
            this.labelSelectedCarManufacturer.Name = "labelSelectedCarManufacturer";
            this.labelSelectedCarManufacturer.Size = new System.Drawing.Size(102, 19);
            this.labelSelectedCarManufacturer.TabIndex = 6;
            this.labelSelectedCarManufacturer.Text = "Manufacturer";
            // 
            // pictureBoxSelectedCar
            // 
            this.pictureBoxSelectedCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxSelectedCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxSelectedCar.Location = new System.Drawing.Point(13, 53);
            this.pictureBoxSelectedCar.Name = "pictureBoxSelectedCar";
            this.pictureBoxSelectedCar.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxSelectedCar.TabIndex = 5;
            this.pictureBoxSelectedCar.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Selected Car";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelMyCarPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelMyCarSpeed);
            this.panel1.Controls.Add(this.pictureBoxMyCar);
            this.panel1.Controls.Add(this.labelMyCarModel);
            this.panel1.Controls.Add(this.labelMyCarManufacturer);
            this.panel1.Location = new System.Drawing.Point(794, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 657);
            this.panel1.TabIndex = 2;
            // 
            // labelMyCarPosition
            // 
            this.labelMyCarPosition.AutoSize = true;
            this.labelMyCarPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCarPosition.Location = new System.Drawing.Point(237, 211);
            this.labelMyCarPosition.Name = "labelMyCarPosition";
            this.labelMyCarPosition.Size = new System.Drawing.Size(89, 19);
            this.labelMyCarPosition.TabIndex = 14;
            this.labelMyCarPosition.Text = "Position (x,y)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "My Car";
            // 
            // labelMyCarSpeed
            // 
            this.labelMyCarSpeed.AutoSize = true;
            this.labelMyCarSpeed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCarSpeed.Location = new System.Drawing.Point(237, 178);
            this.labelMyCarSpeed.Name = "labelMyCarSpeed";
            this.labelMyCarSpeed.Size = new System.Drawing.Size(92, 19);
            this.labelMyCarSpeed.TabIndex = 13;
            this.labelMyCarSpeed.Text = "Speed (km/h)";
            // 
            // pictureBoxMyCar
            // 
            this.pictureBoxMyCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMyCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMyCar.Location = new System.Drawing.Point(21, 53);
            this.pictureBoxMyCar.Name = "pictureBoxMyCar";
            this.pictureBoxMyCar.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxMyCar.TabIndex = 10;
            this.pictureBoxMyCar.TabStop = false;
            // 
            // labelMyCarModel
            // 
            this.labelMyCarModel.AutoSize = true;
            this.labelMyCarModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCarModel.Location = new System.Drawing.Point(237, 106);
            this.labelMyCarModel.Name = "labelMyCarModel";
            this.labelMyCarModel.Size = new System.Drawing.Size(49, 19);
            this.labelMyCarModel.TabIndex = 12;
            this.labelMyCarModel.Text = "Model";
            // 
            // labelMyCarManufacturer
            // 
            this.labelMyCarManufacturer.AutoSize = true;
            this.labelMyCarManufacturer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelMyCarManufacturer.Location = new System.Drawing.Point(237, 74);
            this.labelMyCarManufacturer.Name = "labelMyCarManufacturer";
            this.labelMyCarManufacturer.Size = new System.Drawing.Size(102, 19);
            this.labelMyCarManufacturer.TabIndex = 11;
            this.labelMyCarManufacturer.Text = "Manufacturer";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "All Cars";
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(212, 18);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 4;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelSelectedCar);
            this.Controls.Add(this.panelAllCars);
            this.Name = "MainWindow";
            this.Text = "Autonomous Cars Communication";
            this.panelSelectedCar.ResumeLayout(false);
            this.panelSelectedCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedCar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelAllCars;
        private Panel panelSelectedCar;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonRefresh;
        private PictureBox pictureBoxSelectedCar;
        private Label labelSelectedCarManufacturer;
        private Label labelSelectedCarModel;
        private Label labelSelectedCarSpeed;
        private Label labelSelectedCarPosition;
        private Label labelMyCarPosition;
        private Label labelMyCarSpeed;
        private PictureBox pictureBoxMyCar;
        private Label labelMyCarModel;
        private Label labelMyCarManufacturer;
    }
}