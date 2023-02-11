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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            userLoging ul = new userLoging();
            ul.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminLoging al = new AdminLoging();
            al.Show();
        }
    }
}
