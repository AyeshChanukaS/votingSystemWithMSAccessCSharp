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
    public partial class MaintainCandidate : Form
    {
        public MaintainCandidate()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "INSERT INTO candidate (CanID,CanName) VALUES ('" + CandidateIDTextbox.Text + "','" + CandidateNameTextbox.Text + "');";

            con.Open();

            OleDbCommand cmd = new OleDbCommand(q, con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Submitted", "Congrats");

            con.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "DELETE FROM candidate WHERE CanID = '" + CandidateIDTextbox.Text + "' OR CanName = '" + CandidateNameTextbox.Text + "';";

            con.Open();

            OleDbCommand cmd = new OleDbCommand(q, con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Deleted !", "Congrats");

            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "UPDATE candidate SET CanName = '" + CandidateNameTextbox.Text + "' WHERE CanID = '" + CandidateIDTextbox.Text + "';";

            con.Open();

            OleDbCommand cmd = new OleDbCommand(q, con);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Updated !", "Congrats");

            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDB adb = new AdminDB();
            adb.ShowDialog();
        }
    }
}
