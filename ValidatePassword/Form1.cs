using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ValidatePassword
{
    public partial class Form1 : Form
    {
        private static readonly string EncryptionKey = "2B4E6C8F1J3N5Q7S9VbYxD1zA3C5E7G9"; // Replace with a secure key

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string[] encryptedPasswords = txtEncryptedPassword.Text.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            List<string> decryptedPasswords = new List<string>();

            foreach (string encryptedPassword in encryptedPasswords)
            {
                try
                {
                    string decryptedPassword = DecryptPassword(encryptedPassword.Trim());
                    decryptedPasswords.Add(decryptedPassword);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error decrypting password: {ex.Message}", "Decryption Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Display decrypted passwords in a list box or another suitable control
            listBoxDecryptedPasswords.DataSource = decryptedPasswords;

            // Copy decrypted passwords to clipboard
            Clipboard.SetText(string.Join(Environment.NewLine, decryptedPasswords));
            MessageBox.Show("Decrypted passwords have been copied to the clipboard.", "Decryption Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static string DecryptPassword(string encryptedPassword)
        {
            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(EncryptionKey);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8];

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msDecrypt = new MemoryStream(Convert.FromBase64String(encryptedPassword)))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
        }

        private void txtEncryptedPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            // Add your event handling code here
        }

    }
}
