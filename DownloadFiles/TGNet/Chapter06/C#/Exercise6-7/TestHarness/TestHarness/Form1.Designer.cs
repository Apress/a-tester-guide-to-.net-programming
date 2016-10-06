namespace TestHarness
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
      this.lblFileName = new System.Windows.Forms.Label();
      this.txtFileName = new System.Windows.Forms.TextBox();
      this.btnTest = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // lblFileName
      // 
      this.lblFileName.AutoSize = true;
      this.lblFileName.Location = new System.Drawing.Point(12, 9);
      this.lblFileName.Name = "lblFileName";
      this.lblFileName.Size = new System.Drawing.Size(80, 20);
      this.lblFileName.TabIndex = 0;
      this.lblFileName.Text = "File Name";
      // 
      // txtFileName
      // 
      this.txtFileName.Location = new System.Drawing.Point(12, 38);
      this.txtFileName.Name = "txtFileName";
      this.txtFileName.Size = new System.Drawing.Size(255, 26);
      this.txtFileName.TabIndex = 1;
      // 
      // btnTest
      // 
      this.btnTest.Location = new System.Drawing.Point(12, 76);
      this.btnTest.Name = "btnTest";
      this.btnTest.Size = new System.Drawing.Size(255, 34);
      this.btnTest.TabIndex = 2;
      this.btnTest.Text = "Test";
      this.btnTest.UseVisualStyleBackColor = true;
      this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(290, 138);
      this.Controls.Add(this.btnTest);
      this.Controls.Add(this.txtFileName);
      this.Controls.Add(this.lblFileName);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFileName;
    private System.Windows.Forms.TextBox txtFileName;
    private System.Windows.Forms.Button btnTest;
  }
}

