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
    public partial class updateForm : Form
    {
        securityForm security = new securityForm();

        public updateForm()
        {
            security.ShowDialog();    
            InitializeComponent();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            SQLiteConnection connection = Program.connect();
            SQLiteCommand command = new SQLiteCommand();
            command = connection.CreateCommand();

            string user = Encrypt(userTXT.Text);
            string pass = Encrypt(passTXT.Text);
            string fname = Encrypt(nameTXT.Text);
            string lname = Encrypt(name2TXT.Text);
            string email = Encrypt(emailTXT.Text);

            if (user == null || pass == null || fname == null || lname == null || email == null)
            {

                command.CommandText = "UPDATE login " + '\n' + "SET username = '" + user + "', password = '" + pass + "', first_name = '" + fname + "', last_name = '" + lname + "', email = " + email + '\n' + "WHERE username= '" + security.userTXT + "' and password = '" + security.passTXT + "';";
                command.ExecuteNonQuery();

            }
            else
            {
                MessageBox.Show("You must change all fields to continue. (re-type any fields to be left the same)");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
