using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VotingApp
{
    public partial class VoteForm : Form
    {
        private SqlConnection sc = new SqlConnection();
        string first_name, last_name, party_voted;
        
        public VoteForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            first_name = txt_fname.Text;
            last_name = txt_lname.Text;

            if (string.IsNullOrEmpty(first_name) || string.IsNullOrEmpty(last_name) || string.IsNullOrEmpty(party_voted))
            {
                lbl_error.Visible = true;

            }
            else
            {
                lbl_error.Visible = false;
                string query = $"INSERT INTO voters (fname, lname, party) VALUES ('{first_name}', '{last_name}', '{party_voted.Substring(0,3)}')";

                
                SqlCommand com = new SqlCommand();
                sc.ConnectionString = ("Data Source=LAPTOP-213ODDUM;Initial Catalog=vote_app_db;Integrated Security=True");
                sc.Open();

                com.Connection = sc;
                com.CommandText = query;
                com.ExecuteNonQuery();

                sc.Close();

                goBackToolStripMenuItem_Click(sender, e);
            }
        }

        private void VoteForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void partyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            party_voted = (string)partyList.SelectedItem;
        }

        private void goBackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainMenu menuPage = new MainMenu();
            menuPage.Show();
            this.Hide();
        }
    }
}
