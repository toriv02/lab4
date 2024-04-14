namespace lab4tp
{
    partial class Form1
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
            btnRefill = new Button();
            btnGet = new Button();
            txtOut = new RichTextBox();
            txtInfo = new RichTextBox();
            SuspendLayout();
            // 
            // btnRefill
            // 
            btnRefill.Location = new Point(12, 12);
            btnRefill.Name = "btnRefill";
            btnRefill.Size = new Size(260, 23);
            btnRefill.TabIndex = 0;
            btnRefill.Text = "Перезаполнить";
            btnRefill.UseVisualStyleBackColor = true;
            btnRefill.Click += btnRefill_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(188, 92);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(84, 108);
            btnGet.TabIndex = 1;
            btnGet.Text = "Взять";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += btnGet_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(12, 92);
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(170, 108);
            txtOut.TabIndex = 2;
            txtOut.Text = "";
            // 
            // txtInfo
            // 
            txtInfo.BackColor = SystemColors.Info;
            txtInfo.BorderStyle = BorderStyle.None;
            txtInfo.Location = new Point(12, 41);
            txtInfo.Name = "txtInfo";
            txtInfo.ReadOnly = true;
            txtInfo.Size = new Size(260, 34);
            txtInfo.TabIndex = 3;
            txtInfo.Text = "";
            // 
            // Form1
            // 
            ClientSize = new Size(284, 222);
            Controls.Add(txtInfo);
            Controls.Add(txtOut);
            Controls.Add(btnGet);
            Controls.Add(btnRefill);
            Name = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRefill;
        private Button btnGet;
        private RichTextBox txtOut;
        private RichTextBox txtInfo;
    }
}