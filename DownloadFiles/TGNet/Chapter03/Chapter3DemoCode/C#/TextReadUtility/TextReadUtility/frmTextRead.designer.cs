namespace TextReadUtility
{
    partial class frmTextRead
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
            this.btnRead = new System.Windows.Forms.Button();
            this.txtFindString = new System.Windows.Forms.TextBox();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
// 
// btnRead
// 
            this.btnRead.Location = new System.Drawing.Point(70, 189);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(138, 26);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "&Search";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
// 
// txtFindString
// 
            this.txtFindString.Location = new System.Drawing.Point(70, 124);
            this.txtFindString.Name = "txtFindString";
            this.txtFindString.Size = new System.Drawing.Size(138, 20);
            this.txtFindString.TabIndex = 1;
            this.txtFindString.Text = "error";
// 
// txtFile
// 
            this.txtFile.Location = new System.Drawing.Point(70, 68);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(138, 20);
            this.txtFile.TabIndex = 2;
            this.txtFile.Text = "c:\\FiletoRead.txt";
// 
// label1
// 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "&Enter file to search";
// 
// label2
// 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 104);
            this.label2.Name = "label2";
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter string to &Find";
// 
// lblResult
// 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(70, 168);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 0);
            this.lblResult.TabIndex = 5;
// 
// frmTextRead
// 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(279, 249);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.txtFindString);
            this.Controls.Add(this.btnRead);
            this.Name = "frmTextRead";
            this.Text = "Text Read Utility";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtFindString;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

