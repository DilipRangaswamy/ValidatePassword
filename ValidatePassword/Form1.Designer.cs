namespace ValidatePassword
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
            txtEncryptedPassword = new TextBox();
            txtDycryptedPassword = new TextBox();
            btnDecrypt = new Button();
            label1 = new Label();
            listBoxDecryptedPasswords = new ListBox();
            SuspendLayout();
            // 
            // txtEncryptedPassword
            // 
            txtEncryptedPassword.Location = new Point(278, 45);
            txtEncryptedPassword.Multiline = true;
            txtEncryptedPassword.Name = "txtEncryptedPassword";
            txtEncryptedPassword.Size = new Size(462, 183);
            txtEncryptedPassword.TabIndex = 0;
            txtEncryptedPassword.TextChanged += txtEncryptedPassword_TextChanged;
            // 
            // txtDycryptedPassword
            // 
            txtDycryptedPassword.Location = new Point(0, 0);
            txtDycryptedPassword.Name = "txtDycryptedPassword";
            txtDycryptedPassword.Size = new Size(100, 31);
            txtDycryptedPassword.TabIndex = 0;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(659, 357);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(112, 34);
            btnDecrypt.TabIndex = 1;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 113);
            label1.Name = "label1";
            label1.Size = new Size(216, 25);
            label1.TabIndex = 2;
            label1.Text = "Enter Encrypted Password";
            label1.Click += label1_Click;
            // 
            // listBoxDecryptedPasswords
            // 
            listBoxDecryptedPasswords.FormattingEnabled = true;
            listBoxDecryptedPasswords.ItemHeight = 25;
            listBoxDecryptedPasswords.Location = new Point(302, 290);
            listBoxDecryptedPasswords.Name = "listBoxDecryptedPasswords";
            listBoxDecryptedPasswords.Size = new Size(180, 129);
            listBoxDecryptedPasswords.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxDecryptedPasswords);
            Controls.Add(label1);
            Controls.Add(btnDecrypt);
            Controls.Add(txtEncryptedPassword);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEncryptedPassword;
        private TextBox txtDycryptedPassword;
        private Button btnDecrypt;
        private Label label1;
        private ListBox listBoxDecryptedPasswords;
    }
}
