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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='E:\Project Files\software project\voting system\VotingSystem\VotingSystem\VotingSystem\votingsystemDB.accdb'");

            string q = "SELECT * FROM candidate";

            con.Open();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(q, con);

            DataSet ds = new DataSet();

            dataAdapter.Fill(ds, "[Order]");
            dataGridView1.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDB adb = new AdminDB();
            adb.ShowDialog();
        }
    }
}
