using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Stem_Squad_Gaming_Fanatics2
{
    public partial class PatientView : Form
    {
        securityForm securityForm = new securityForm();
        lookupForm lookupForm = new lookupForm();
        public PatientView()
        {
            securityForm.ShowDialog();
            lookupForm.ShowDialog();
            InitializeComponent();
        }

        private void PatientView_Load(object sender, EventArgs e)
        {
            SQLiteConnection connection = Program.connect();
            SQLiteCommand command = new SQLiteCommand();
            command = connection.CreateCommand();

            string user = Encrypt(lookupForm.textBox1.Text.ToString());
            string pass = Encrypt(lookupForm.textBox2.Text.ToString());

            command.CommandText = "SELECT patient_id FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label1.Text = command.ExecuteScalar().ToString();

            command.CommandText = "SELECT first_name FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label2.Text = Decrypt(command.ExecuteScalar().ToString());

            command.CommandText = "SELECT last_name FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label3.Text = Decrypt(command.ExecuteScalar().ToString());

            command.CommandText = "SELECT sex FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label4.Text = Decrypt(command.ExecuteScalar().ToString());

            command.CommandText = "SELECT eye_color FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label5.Text = Decrypt(command.ExecuteScalar().ToString());

            command.CommandText = "SELECT height FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label6.Text = command.ExecuteScalar().ToString();

            command.CommandText = "SELECT hair_color FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label7.Text = Decrypt(command.ExecuteScalar().ToString());

            command.CommandText = "SELECT genome_sequence FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label8.Text = Decrypt(command.ExecuteScalar().ToString());

            command.CommandText = "SELECT email FROM Genetics WHERE first_name = '" + user + "' and last_name = '" + pass + "';";
            label9.Text = Decrypt(command.ExecuteScalar().ToString());
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
