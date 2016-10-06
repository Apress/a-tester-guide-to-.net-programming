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
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.btnEmptyString = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(25, 22);
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(240, 26);
      this.textBox1.TabIndex = 0;
      // 
      // btnEmptyString
      // 
      this.btnEmptyString.Location = new System.Drawing.Point(25, 57);
      this.btnEmptyString.Name = "btnEmptyString";
      this.btnEmptyString.Size = new System.Drawing.Size(240, 32);
      this.btnEmptyString.TabIndex = 1;
      this.btnEmptyString.Text = "Is an Empty String?\"";
      this.btnEmptyString.UseVisualStyleBackColor = true;
      this.btnEmptyString.Click += new System.EventHandler(this.btnEmptyString_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(290, 101);
      this.Controls.Add(this.btnEmptyString);
      this.Controls.Add(this.textBox1);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Button btnEmptyString;
  }
}

