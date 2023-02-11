using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

using System.Data.OleDb;

namespace VotingSystem
{
    public partial class userLoging : Form
    {
        public userLoging()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userLoging_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "SELECT * FROM users WHERE userName='" + usernameTextbox.Text + "' AND password='" + passTextbox.Text + "';";

            con.Open();

            OleDbCommand cmd = new OleDbCommand(q, con);

            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();
                Vote v = new Vote();
                v.ShowDialog();
            }
            else
            {
                MessageBox.Show("Invalid UserName and Password !");
            }
        

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserAccount cua = new CreateUserAccount();
            cua.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login l = new Login();
            l.ShowDialog();
        }

        private void passTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
