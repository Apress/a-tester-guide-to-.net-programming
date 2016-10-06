namespace AutoTester
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
            this.txtAppName = new System.Windows.Forms.TextBox();
            this.btnStartApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAppName
            // 
            this.txtAppName.Location = new System.Drawing.Point(45, 39);
            this.txtAppName.Name = "txtAppName";
            this.txtAppName.Size = new System.Drawing.Size(100, 20);
            this.txtAppName.TabIndex = 0;
            // 
            // btnStartApp
            // 
            this.btnStartApp.Location = new System.Drawing.Point(45, 76);
            this.btnStartApp.Name = "btnStartApp";
            this.btnStartApp.Size = new System.Drawing.Size(100, 22);
            this.btnStartApp.TabIndex = 1;
            this.btnStartApp.Text = "Start Application";
            this.btnStartApp.Click += new System.EventHandler(this.btnStartApp_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnStartApp;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(192, 120);
            this.Controls.Add(this.btnStartApp);
            this.Controls.Add(this.txtAppName);
            this.Name = "Form1";
            this.Text = "AutoTester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppName;
        private System.Windows.Forms.Button btnStartApp;
    }
}

