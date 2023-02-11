using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace VotingSystem
{
    public partial class CreateUserAccount : Form
    {
        public CreateUserAccount()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void passTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (passTextbox1.Text == passTextbox2.Text)
            {
                OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");
               
                string q = "INSERT INTO users VALUES ('" + usernameTextbox.Text + "','" + passTextbox1.Text + "');";

                con.Open();

                OleDbCommand cmd = new OleDbCommand(q, con);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Submitted", "Congrats");

                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userLoging ul = new userLoging();
            ul.ShowDialog();
        }
    }
}
