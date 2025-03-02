using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml;
using System.Security.Cryptography.X509Certificates;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Security.Cryptography;

namespace Stem_Squad_Gaming_Fanatics2
{
    public partial class LoginForm : Form
    {
        public int myreader = 0;
        public int myreader2 = 0;

        public LoginForm()
        {

            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = Program.connect();
            SQLiteCommand command = new SQLiteCommand();
            command = connection.CreateCommand();

            string user = Encrypt(userTXT.Text);
            string pass = Encrypt(passTXT.Text);

            command.CommandText = "SELECT access_level FROM Login WHERE username= '" + user + "' and password = '" + pass + "';";
            myreader2 = Convert.ToInt32(command.ExecuteScalar());

            command.CommandText = "SELECT count(*) FROM Login WHERE username = '" + user + "' and password = '" + pass + "';";
            myreader = Convert.ToInt32(command.ExecuteScalar());

            if (myreader > 0)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }

        }

        private void newBTN_Click(object sender, EventArgs e)
        {
            NewAccount newAccount = new NewAccount();
            newAccount.ShowDialog();
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
    }
}
