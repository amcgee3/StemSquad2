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

namespace Stem_Squad_Gaming_Fanatics2
{
    public partial class patientForm : Form
    {
        public patientForm()
        {
            InitializeComponent();
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitBTN_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(idTXT.Text);
            string fname = Encrypt(nameTXT.Text);
            string lname = Encrypt(name2TXT.Text);
            string sex = Encrypt(sexTXT.Text);
            string color = Encrypt(colorTXT.Text);
            string height = Encrypt(heightTXT.Text);
            string hair = Encrypt(hairTXT.Text);
            string genome = Encrypt(genomeTXT.Text);
            string email = Encrypt(emailTXT.Text);


            SQLiteCommand command;
            SQLiteConnection connect = Program.connect();
            command = connect.CreateCommand();
            command.CommandText = "INSERT INTO Genetics(first_name, last_name, sex, eye_color, height, hair_color, genome_sequence, email) VALUES ('" + fname + "', '" + lname + "', '" + sex + "', '" + color + "', '" + height + "', '" + hair + "', '" + genome + "', '" + email + "');";
            command.ExecuteNonQuery();
            connect.Close();
            MessageBox.Show("Patient created successfully. ");

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
    }
}
