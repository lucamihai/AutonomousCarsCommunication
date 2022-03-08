namespace AutonomousCarsCommunication.GUI.UserControls
{
    partial class CarPreviewUserControl
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
            this.pictureBoxPreviewCar = new System.Windows.Forms.PictureBox();
            this.labelCarManufacturer = new System.Windows.Forms.Label();
            this.labelCarModel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxPreviewCar
            // 
            this.pictureBoxPreviewCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPreviewCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreviewCar.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxPreviewCar.Name = "pictureBoxPreviewCar";
            this.pictureBoxPreviewCar.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxPreviewCar.TabIndex = 0;
            this.pictureBoxPreviewCar.TabStop = false;
            // 
            // labelCarManufacturer
            // 
            this.labelCarManufacturer.AutoSize = true;
            this.labelCarManufacturer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelCarManufacturer.Location = new System.Drawing.Point(154, 39);
            this.labelCarManufacturer.Name = "labelCarManufacturer";
            this.labelCarManufacturer.Size = new System.Drawing.Size(102, 19);
            this.labelCarManufacturer.TabIndex = 1;
            this.labelCarManufacturer.Text = "Manufacturer";
            // 
            // labelCarModel
            // 
            this.labelCarModel.AutoSize = true;
            this.labelCarModel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCarModel.Location = new System.Drawing.Point(154, 67);
            this.labelCarModel.Name = "labelCarModel";
            this.labelCarModel.Size = new System.Drawing.Size(49, 19);
            this.labelCarModel.TabIndex = 2;
            this.labelCarModel.Text = "Model";
            // 
            // CarPreviewUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelCarModel);
            this.Controls.Add(this.labelCarManufacturer);
            this.Controls.Add(this.pictureBoxPreviewCar);
            this.Name = "CarPreviewUserControl";
            this.Size = new System.Drawing.Size(273, 148);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreviewCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxPreviewCar;
        private Label labelCarManufacturer;
        private Label labelCarModel;
    }
}
