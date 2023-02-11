using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingSystem
{
    public partial class AdminLoging : Form
    {
        public AdminLoging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdpassTextbox.Text == "admin123#")
            {
                this.Hide();
                AdminDB adb = new AdminDB();
                adb.ShowDialog();
            }
            else {
                MessageBox.Show("Wrong Admin Password !");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }
    }
}
