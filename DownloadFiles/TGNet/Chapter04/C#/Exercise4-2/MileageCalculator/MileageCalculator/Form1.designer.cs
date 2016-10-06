namespace MileageCalculator
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
          this.lblDistance = new System.Windows.Forms.Label();
          this.lblGallons = new System.Windows.Forms.Label();
          this.btnGetMileage = new System.Windows.Forms.Button();
          this.txtDistance = new System.Windows.Forms.TextBox();
          this.txtGallons = new System.Windows.Forms.TextBox();
          this.SuspendLayout();
          // 
          // lblDistance
          // 
          this.lblDistance.AutoSize = true;
          this.lblDistance.Location = new System.Drawing.Point(15, 28);
          this.lblDistance.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
          this.lblDistance.Name = "lblDistance";
          this.lblDistance.Size = new System.Drawing.Size(72, 20);
          this.lblDistance.TabIndex = 0;
          this.lblDistance.Text = "Distance";
          // 
          // lblGallons
          // 
          this.lblGallons.AutoSize = true;
          this.lblGallons.Location = new System.Drawing.Point(24, 96);
          this.lblGallons.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
          this.lblGallons.Name = "lblGallons";
          this.lblGallons.Size = new System.Drawing.Size(63, 20);
          this.lblGallons.TabIndex = 1;
          this.lblGallons.Text = "Gallons";
          // 
          // btnGetMileage
          // 
          this.btnGetMileage.Location = new System.Drawing.Point(159, 143);
          this.btnGetMileage.Name = "btnGetMileage";
          this.btnGetMileage.Size = new System.Drawing.Size(147, 38);
          this.btnGetMileage.TabIndex = 2;
          this.btnGetMileage.Text = "Get Mileage";
          this.btnGetMileage.Click += new System.EventHandler(this.btnGetMileage_Click);
          // 
          // txtDistance
          // 
          this.txtDistance.Location = new System.Drawing.Point(97, 28);
          this.txtDistance.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
          this.txtDistance.Name = "txtDistance";
          this.txtDistance.Size = new System.Drawing.Size(209, 26);
          this.txtDistance.TabIndex = 3;
          this.txtDistance.Text = "100";
          // 
          // txtGallons
          // 
          this.txtGallons.Location = new System.Drawing.Point(97, 96);
          this.txtGallons.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
          this.txtGallons.Name = "txtGallons";
          this.txtGallons.Size = new System.Drawing.Size(209, 26);
          this.txtGallons.TabIndex = 4;
          this.txtGallons.Text = "10";
          // 
          // Form1
          // 
          this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
          this.ClientSize = new System.Drawing.Size(359, 212);
          this.Controls.Add(this.txtGallons);
          this.Controls.Add(this.txtDistance);
          this.Controls.Add(this.btnGetMileage);
          this.Controls.Add(this.lblGallons);
          this.Controls.Add(this.lblDistance);
          this.Name = "Form1";
          this.Text = "Form1";
          this.ResumeLayout(false);
          this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblGallons;
        private System.Windows.Forms.Button btnGetMileage;
        private System.Windows.Forms.TextBox txtDistance;
        private System.Windows.Forms.TextBox txtGallons;
    }
}

