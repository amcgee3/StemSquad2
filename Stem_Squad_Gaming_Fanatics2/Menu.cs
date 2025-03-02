using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stem_Squad_Gaming_Fanatics2
{
    public partial class Menu : Form
    {
        LoginForm login = new LoginForm();
        public int myreader2 = 0;
        
        public Menu()
        {
            login.ShowDialog();
            myreader2 = login.myreader2;
            InitializeComponent();
            check_access(myreader2);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void check_access(int level)
        {
            int myreader2 = login.myreader2;
            if (myreader2 >= 4)
            {
                this.level1BOX.Enabled = true;
                this.level2BOX.Enabled = true;
                this.level3BOX.Enabled = true;
            }
            else if (login.myreader2 >= 3)
            {
                this.level3BOX.Enabled = true;
                this.level2BOX.Enabled = true;
                this.level1BOX.Enabled = true;
            }
            else if (login.myreader2 >= 2)
            {
                this.level2BOX.Enabled = true;
                this.level1BOX.Enabled = true;
            }
            else if(login.myreader2 >= 1)
            {
                this.level1BOX.Enabled= true;
            }
        }

        private void accountBTN_Click(object sender, EventArgs e)
        {
            informationForm info = new informationForm();
            info.ShowDialog();
        }

        private void updateBTN_Click(object sender, EventArgs e)
        {
            updateForm update = new updateForm();
            update.ShowDialog();
            requestForm request = new requestForm();
            request.ShowDialog();
        }

        private void accessBTN_Click(object sender, EventArgs e)
        {
            securityForm security = new securityForm();
            security.ShowDialog();
            requestForm form = new requestForm();
            form.ShowDialog();
        }

        private void patientBTN_Click(object sender, EventArgs e)
        {
            securityForm security = new securityForm();
            security.ShowDialog();
            patientForm patient = new patientForm();
            patient.ShowDialog();
        }

        private void lookupBTN_Click(object sender, EventArgs e)
        {
            PatientView patientView = new PatientView();
            patientView.ShowDialog();
        }

        private void groupBTN_Click(object sender, EventArgs e)
        {
            securityForm security = new securityForm();
            security.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            securityForm security = new securityForm();
            security.ShowDialog();
            MessageBox.Show("Coming Soon!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            securityForm security = new securityForm();
            security.ShowDialog();
            MessageBox.Show("Coming Soon!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            securityForm security = new securityForm();
            security.ShowDialog();
            MessageBox.Show("Coming Soon!");
        }
    }
}
