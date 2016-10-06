namespace MaxOrdersTest
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
            this.cmdADO = new System.Windows.Forms.Button();
            this.lstResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdADO
            // 
            this.cmdADO.Location = new System.Drawing.Point(108, 215);
            this.cmdADO.Name = "cmdADO";
            this.cmdADO.Size = new System.Drawing.Size(75, 23);
            this.cmdADO.TabIndex = 0;
            this.cmdADO.Text = "Start Test";
            this.cmdADO.Click += new System.EventHandler(this.cmdADO_Click);
            // 
            // lstResults
            // 
            this.lstResults.FormattingEnabled = true;
            this.lstResults.ItemHeight = 16;
            this.lstResults.Location = new System.Drawing.Point(12, 3);
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(268, 196);
            this.lstResults.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 260);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.cmdADO);
            this.Name = "Form1";
            this.Text = "Max Orders Test";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdADO;
        private System.Windows.Forms.ListBox lstResults;
    }
}

