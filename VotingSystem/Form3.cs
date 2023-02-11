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
    public partial class Vote : Form
    {
        

        public Vote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int voteCount = 0;

            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "SELECT NumOfVote FROM candidate WHERE CanName='"+comboBox1.Text+"';";

            con.Open();

            OleDbCommand cmd = new OleDbCommand(q, con);

            voteCount = (int)cmd.ExecuteScalar() + 1;

            con.Close();

            //Console.WriteLine(voteCount);

            //////////////////
            ///
            OleDbConnection con2 = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q2 = "UPDATE candidate SET NumOfVote="+voteCount+" WHERE canName = '"+comboBox1.Text+"';";

            con2.Open();

            OleDbCommand cmd2 = new OleDbCommand(q2, con2);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Vote Added !", "Congrats");

            con2.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            userLoging ul = new userLoging();
            ul.ShowDialog();
        }

        private void Vote_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "SELECT CanName FROM candidate";

            con.Open();

            OleDbCommand cmd = new OleDbCommand(q, con);

            OleDbDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Items.Add(dr["CanName"].ToString());
            }


            con.Close();
        }
    }
}
