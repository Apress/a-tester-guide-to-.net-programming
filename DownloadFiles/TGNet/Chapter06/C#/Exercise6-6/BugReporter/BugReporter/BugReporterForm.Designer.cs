namespace BugReporter
{
  partial class BugReporterForm
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
this.lblFileName = new System.Windows.Forms.Label();
this.txtFileName = new System.Windows.Forms.TextBox();
this.btnSubmitBug = new System.Windows.Forms.Button();
this.lblDescription = new System.Windows.Forms.Label();
this.lblDateReported = new System.Windows.Forms.Label();
this.lblBuildNumber = new System.Windows.Forms.Label();
this.lblAppName = new System.Windows.Forms.Label();
this.lblTester = new System.Windows.Forms.Label();
this.txtDescription = new System.Windows.Forms.TextBox();
this.txtDateReported = new System.Windows.Forms.TextBox();
this.txtBuildNumber = new System.Windows.Forms.TextBox();
this.txtAppName = new System.Windows.Forms.TextBox();
this.txtTester = new System.Windows.Forms.TextBox();
this.SuspendLayout();
// 
// lblFileName
// 
this.lblFileName.AutoSize = true;
this.lblFileName.Location = new System.Drawing.Point(15, 388);
this.lblFileName.Name = "lblFileName";
this.lblFileName.Size = new System.Drawing.Size(120, 20);
this.lblFileName.TabIndex = 25;
this.lblFileName.Text = "Save to this file:";
// 
// txtFileName
// 
this.txtFileName.Location = new System.Drawing.Point(167, 388);
this.txtFileName.Margin = new System.Windows.Forms.Padding(3, 1, 1, 3);
this.txtFileName.Name = "txtFileName";
this.txtFileName.Size = new System.Drawing.Size(193, 26);
this.txtFileName.TabIndex = 24;
this.txtFileName.Text = "BugReport.csv";
// 
// btnSubmitBug
// 
this.btnSubmitBug.Location = new System.Drawing.Point(375, 383);
this.btnSubmitBug.Margin = new System.Windows.Forms.Padding(1, 1, 3, 3);
this.btnSubmitBug.Name = "btnSubmitBug";
this.btnSubmitBug.Size = new System.Drawing.Size(140, 37);
this.btnSubmitBug.TabIndex = 23;
this.btnSubmitBug.Text = "Submit Bug";
this.btnSubmitBug.Click += new System.EventHandler(this.btnSubmitBug_Click);
// 
// lblDescription
// 
this.lblDescription.AutoSize = true;
this.lblDescription.Location = new System.Drawing.Point(15, 157);
this.lblDescription.Margin = new System.Windows.Forms.Padding(3, 1, 3, 3);
this.lblDescription.Name = "lblDescription";
this.lblDescription.Size = new System.Drawing.Size(140, 20);
this.lblDescription.TabIndex = 22;
this.lblDescription.Text = "Description of Bug";
// 
// lblDateReported
// 
this.lblDateReported.AutoSize = true;
this.lblDateReported.Location = new System.Drawing.Point(307, 112);
this.lblDateReported.Margin = new System.Windows.Forms.Padding(3, 1, 3, 2);
this.lblDateReported.Name = "lblDateReported";
this.lblDateReported.Size = new System.Drawing.Size(94, 20);
this.lblDateReported.TabIndex = 21;
this.lblDateReported.Text = "Date Found";
// 
// lblBuildNumber
// 
this.lblBuildNumber.AutoSize = true;
this.lblBuildNumber.Location = new System.Drawing.Point(307, 78);
this.lblBuildNumber.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
this.lblBuildNumber.Name = "lblBuildNumber";
this.lblBuildNumber.Size = new System.Drawing.Size(104, 20);
this.lblBuildNumber.TabIndex = 20;
this.lblBuildNumber.Text = "Build Number";
// 
// lblAppName
// 
this.lblAppName.AutoSize = true;
this.lblAppName.Location = new System.Drawing.Point(307, 46);
this.lblAppName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
this.lblAppName.Name = "lblAppName";
this.lblAppName.Size = new System.Drawing.Size(141, 20);
this.lblAppName.TabIndex = 19;
this.lblAppName.Text = "Applications Name";
// 
// lblTester
// 
this.lblTester.AutoSize = true;
this.lblTester.Location = new System.Drawing.Point(307, 13);
this.lblTester.Margin = new System.Windows.Forms.Padding(3, 3, 3, 2);
this.lblTester.Name = "lblTester";
this.lblTester.Size = new System.Drawing.Size(108, 20);
this.lblTester.TabIndex = 18;
this.lblTester.Text = "Testers Name";
// 
// txtDescription
// 
this.txtDescription.Location = new System.Drawing.Point(15, 185);
this.txtDescription.Multiline = true;
this.txtDescription.Name = "txtDescription";
this.txtDescription.Size = new System.Drawing.Size(500, 193);
this.txtDescription.TabIndex = 17;
// 
// txtDateReported
// 
this.txtDateReported.Location = new System.Drawing.Point(15, 112);
this.txtDateReported.Name = "txtDateReported";
this.txtDateReported.Size = new System.Drawing.Size(267, 26);
this.txtDateReported.TabIndex = 16;
// 
// txtBuildNumber
// 
this.txtBuildNumber.Location = new System.Drawing.Point(15, 78);
this.txtBuildNumber.Name = "txtBuildNumber";
this.txtBuildNumber.Size = new System.Drawing.Size(267, 26);
this.txtBuildNumber.TabIndex = 15;
// 
// txtAppName
// 
this.txtAppName.Location = new System.Drawing.Point(15, 46);
this.txtAppName.Name = "txtAppName";
this.txtAppName.Size = new System.Drawing.Size(267, 26);
this.txtAppName.TabIndex = 14;
// 
// txtTester
// 
this.txtTester.Location = new System.Drawing.Point(15, 13);
this.txtTester.Name = "txtTester";
this.txtTester.Size = new System.Drawing.Size(267, 26);
this.txtTester.TabIndex = 13;
// 
// BugReporterForm
// 
this.AutoScaleBaseSize = new System.Drawing.Size(8, 19);
this.ClientSize = new System.Drawing.Size(528, 425);
this.Controls.Add(this.lblFileName);
this.Controls.Add(this.txtFileName);
this.Controls.Add(this.btnSubmitBug);
this.Controls.Add(this.lblDescription);
this.Controls.Add(this.lblDateReported);
this.Controls.Add(this.lblBuildNumber);
this.Controls.Add(this.lblAppName);
this.Controls.Add(this.lblTester);
this.Controls.Add(this.txtDescription);
this.Controls.Add(this.txtDateReported);
this.Controls.Add(this.txtBuildNumber);
this.Controls.Add(this.txtAppName);
this.Controls.Add(this.txtTester);
this.Name = "BugReporterForm";
this.Text = "Bug Reporter";
this.ResumeLayout(false);
this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblFileName;
    private System.Windows.Forms.TextBox txtFileName;
    private System.Windows.Forms.Button btnSubmitBug;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label lblDateReported;
    private System.Windows.Forms.Label lblBuildNumber;
    private System.Windows.Forms.Label lblAppName;
    private System.Windows.Forms.Label lblTester;
    private System.Windows.Forms.TextBox txtDescription;
    private System.Windows.Forms.TextBox txtDateReported;
    private System.Windows.Forms.TextBox txtBuildNumber;
    private System.Windows.Forms.TextBox txtAppName;
    private System.Windows.Forms.TextBox txtTester;
  }
}