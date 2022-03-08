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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxSelectedCarEvents = new System.Windows.Forms.TextBox();
            this.labelDistanceFromSelectedCarToMyCar = new System.Windows.Forms.Label();
            this.labelSelectedCarPosition = new System.Windows.Forms.Label();
            this.labelSelectedCarSpeed = new System.Windows.Forms.Label();
            this.labelSelectedCarModel = new System.Windows.Forms.Label();
            this.labelSelectedCarManufacturer = new System.Windows.Forms.Label();
            this.pictureBoxSelectedCar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxMyCarEvents = new System.Windows.Forms.TextBox();
            this.labelMyCarPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelMyCarSpeed = new System.Windows.Forms.Label();
            this.pictureBoxMyCar = new System.Windows.Forms.PictureBox();
            this.labelMyCarModel = new System.Windows.Forms.Label();
            this.labelMyCarManufacturer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonSelectClosestCar = new System.Windows.Forms.Button();
            this.buttonSendMessage = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonSetMyCarSpeed = new System.Windows.Forms.Button();
            this.numericUpDownMyCarSpeed = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panelSelectedCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSelectedCar)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMyCarSpeed)).BeginInit();
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
            this.panelSelectedCar.Controls.Add(this.label5);
            this.panelSelectedCar.Controls.Add(this.textBoxSelectedCarEvents);
            this.panelSelectedCar.Controls.Add(this.labelDistanceFromSelectedCarToMyCar);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarPosition);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarSpeed);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarModel);
            this.panelSelectedCar.Controls.Add(this.labelSelectedCarManufacturer);
            this.panelSelectedCar.Controls.Add(this.pictureBoxSelectedCar);
            this.panelSelectedCar.Controls.Add(this.label2);
            this.panelSelectedCar.Location = new System.Drawing.Point(321, 12);
            this.panelSelectedCar.Name = "panelSelectedCar";
            this.panelSelectedCar.Size = new System.Drawing.Size(467, 544);
            this.panelSelectedCar.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Events";
            // 
            // textBoxSelectedCarEvents
            // 
            this.textBoxSelectedCarEvents.Location = new System.Drawing.Point(12, 297);
            this.textBoxSelectedCarEvents.Multiline = true;
            this.textBoxSelectedCarEvents.Name = "textBoxSelectedCarEvents";
            this.textBoxSelectedCarEvents.ReadOnly = true;
            this.textBoxSelectedCarEvents.Size = new System.Drawing.Size(440, 219);
            this.textBoxSelectedCarEvents.TabIndex = 11;
            // 
            // labelDistanceFromSelectedCarToMyCar
            // 
            this.labelDistanceFromSelectedCarToMyCar.AutoSize = true;
            this.labelDistanceFromSelectedCarToMyCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDistanceFromSelectedCarToMyCar.Location = new System.Drawing.Point(229, 223);
            this.labelDistanceFromSelectedCarToMyCar.Name = "labelDistanceFromSelectedCarToMyCar";
            this.labelDistanceFromSelectedCarToMyCar.Size = new System.Drawing.Size(138, 19);
            this.labelDistanceFromSelectedCarToMyCar.TabIndex = 10;
            this.labelDistanceFromSelectedCarToMyCar.Text = "Distance from my car";
            // 
            // labelSelectedCarPosition
            // 
            this.labelSelectedCarPosition.AutoSize = true;
            this.labelSelectedCarPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCarPosition.Location = new System.Drawing.Point(229, 177);
            this.labelSelectedCarPosition.Name = "labelSelectedCarPosition";
            this.labelSelectedCarPosition.Size = new System.Drawing.Size(89, 19);
            this.labelSelectedCarPosition.TabIndex = 9;
            this.labelSelectedCarPosition.Text = "Position (x,y)";
            // 
            // labelSelectedCarSpeed
            // 
            this.labelSelectedCarSpeed.AutoSize = true;
            this.labelSelectedCarSpeed.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSelectedCarSpeed.Location = new System.Drawing.Point(229, 144);
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxMyCarEvents);
            this.panel1.Controls.Add(this.labelMyCarPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelMyCarSpeed);
            this.panel1.Controls.Add(this.pictureBoxMyCar);
            this.panel1.Controls.Add(this.labelMyCarModel);
            this.panel1.Controls.Add(this.labelMyCarManufacturer);
            this.panel1.Location = new System.Drawing.Point(794, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 544);
            this.panel1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Events";
            // 
            // textBoxMyCarEvents
            // 
            this.textBoxMyCarEvents.Location = new System.Drawing.Point(17, 297);
            this.textBoxMyCarEvents.Multiline = true;
            this.textBoxMyCarEvents.Name = "textBoxMyCarEvents";
            this.textBoxMyCarEvents.ReadOnly = true;
            this.textBoxMyCarEvents.Size = new System.Drawing.Size(440, 219);
            this.textBoxMyCarEvents.TabIndex = 15;
            // 
            // labelMyCarPosition
            // 
            this.labelMyCarPosition.AutoSize = true;
            this.labelMyCarPosition.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMyCarPosition.Location = new System.Drawing.Point(237, 177);
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
            this.labelMyCarSpeed.Location = new System.Drawing.Point(237, 144);
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
            // buttonSelectClosestCar
            // 
            this.buttonSelectClosestCar.Location = new System.Drawing.Point(335, 562);
            this.buttonSelectClosestCar.Name = "buttonSelectClosestCar";
            this.buttonSelectClosestCar.Size = new System.Drawing.Size(112, 23);
            this.buttonSelectClosestCar.TabIndex = 5;
            this.buttonSelectClosestCar.Text = "Select closest car";
            this.buttonSelectClosestCar.UseVisualStyleBackColor = true;
            this.buttonSelectClosestCar.Click += new System.EventHandler(this.buttonSelectClosestCar_Click);
            // 
            // buttonSendMessage
            // 
            this.buttonSendMessage.Location = new System.Drawing.Point(335, 646);
            this.buttonSendMessage.Name = "buttonSendMessage";
            this.buttonSendMessage.Size = new System.Drawing.Size(112, 23);
            this.buttonSendMessage.TabIndex = 6;
            this.buttonSendMessage.Text = "Send message";
            this.buttonSendMessage.UseVisualStyleBackColor = true;
            this.buttonSendMessage.Click += new System.EventHandler(this.buttonSendMessage_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(335, 617);
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(440, 23);
            this.textBoxMessage.TabIndex = 7;
            this.textBoxMessage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxMessage_KeyUp);
            // 
            // buttonSetMyCarSpeed
            // 
            this.buttonSetMyCarSpeed.Location = new System.Drawing.Point(952, 562);
            this.buttonSetMyCarSpeed.Name = "buttonSetMyCarSpeed";
            this.buttonSetMyCarSpeed.Size = new System.Drawing.Size(74, 23);
            this.buttonSetMyCarSpeed.TabIndex = 8;
            this.buttonSetMyCarSpeed.Text = "Set speed";
            this.buttonSetMyCarSpeed.UseVisualStyleBackColor = true;
            this.buttonSetMyCarSpeed.Click += new System.EventHandler(this.buttonSetMyCarSpeed_Click);
            // 
            // numericUpDownMyCarSpeed
            // 
            this.numericUpDownMyCarSpeed.DecimalPlaces = 2;
            this.numericUpDownMyCarSpeed.Location = new System.Drawing.Point(816, 562);
            this.numericUpDownMyCarSpeed.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownMyCarSpeed.Minimum = new decimal(new int[] {
            150,
            0,
            0,
            -2147483648});
            this.numericUpDownMyCarSpeed.Name = "numericUpDownMyCarSpeed";
            this.numericUpDownMyCarSpeed.Size = new System.Drawing.Size(85, 23);
            this.numericUpDownMyCarSpeed.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(907, 566);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "km/h";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownMyCarSpeed);
            this.Controls.Add(this.buttonSetMyCarSpeed);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSendMessage);
            this.Controls.Add(this.buttonSelectClosestCar);
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMyCarSpeed)).EndInit();
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
        private Button buttonSelectClosestCar;
        private Label labelDistanceFromSelectedCarToMyCar;
        private Button buttonSendMessage;
        private TextBox textBoxMessage;
        private Button buttonSetMyCarSpeed;
        private NumericUpDown numericUpDownMyCarSpeed;
        private Label label4;
        private Label label5;
        private TextBox textBoxSelectedCarEvents;
        private Label label6;
        private TextBox textBoxMyCarEvents;
    }
}