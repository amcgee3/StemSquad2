using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;


namespace Stem_Squad_Gaming_Fanatics2
{
    public partial class NewAccount : Form
    {
        public NewAccount()
        {
            InitializeComponent();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            string first = Encrypt(fnameTXT.Text);
            string last = Encrypt(lnameTXT.Text);
            string user = Encrypt(userTXT.Text);
            string pass = Encrypt(passTXT.Text);
            string email = Encrypt(emailTXT.Text);

            SQLiteCommand command;
            SQLiteConnection connect = Program.connect();
            command = connect.CreateCommand();
            command.CommandText = "INSERT INTO Login(username, password, first_name, last_name, access_level, email) VALUES ('" + user + "', '" + pass + "', '" + first + "', '" + last + "', '" + 0 + "', '" + email + "');";
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Account created successfully. ");

            this.Close();
        }

        private string Encrypt(string item)
        {
            string original = item;
            using (Aes aes = Aes.Create())
            {
                aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("StemSquad:Gamin"));
                aes.IV = Encoding.UTF8.GetBytes("HATCH2025islit2".PadRight(16));

                byte[] encrypted = EncryptStringToBytes_Aes(original, aes.Key, aes.IV);

                return Convert.ToBase64String(encrypted);
            }

        }

        private static byte[] EncryptStringToBytes_Aes(string plainText, byte[] Key, byte[] IV)
        {
            if (plainText == null || plainText.Length <= 0)
                throw new ArgumentNullException(nameof(plainText));
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException(nameof(Key));
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException(nameof(IV));

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    return msEncrypt.ToArray();
                }
            }
        }

        public static string Decrypt(string encryptedBase64)
        {
            using (Aes aes = Aes.Create())
            {
                // 🔹 Ensure the key is exactly 32 bytes (AES-256)
                aes.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes("StemSquad:Gamin"));

                // 🔹 Ensure IV is exactly 16 bytes
                aes.IV = Encoding.UTF8.GetBytes("HATCH2025islit2".PadRight(16)); // Same IV as encryption

                // 🔹 Set AES mode & padding
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                // 🔹 Convert Base64 string back to byte array
                byte[] cipherText = Convert.FromBase64String(encryptedBase64);

                // 🔹 Decrypt and return the original text
                return DecryptStringFromBytes_Aes(cipherText, aes.Key, aes.IV);
            }
        }

        private static string DecryptStringFromBytes_Aes(byte[] cipherText, byte[] Key, byte[] IV)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException(nameof(cipherText));
            if (Key == null || Key.Length != 32) // Ensure key is 32 bytes
                throw new ArgumentException("Key must be 32 bytes long.");
            if (IV == null || IV.Length != 16) // Ensure IV is 16 bytes
                throw new ArgumentException("IV must be 16 bytes long.");

            using (Aes aes = Aes.Create())
            {
                aes.Key = Key;
                aes.IV = IV;
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using (MemoryStream msDecrypt = new MemoryStream(cipherText))
                {
                    using (ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd(); // Read decrypted text
                    }
                }
            }
        }

        private void passLBL_Click(object sender, EventArgs e)
        {

        }
    }
}
