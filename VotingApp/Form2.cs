using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VotingApp
{
    public partial class MainMenu : Form
    {
        private SqlConnection sc = new SqlConnection();
        int totalVotes, redVotes, bluVotes;
        
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("Data Source=LAPTOP-213ODDUM;Initial Catalog=vote_app_db;Integrated Security=True");
            sc.Open();

            com.Connection = sc;
            com.CommandText = "SELECT count(*) FROM voters";
            totalVotes = (int)com.ExecuteScalar();

            com.CommandText = "SELECT count(*) FROM voters WHERE party = 'RED'";
            redVotes = (int)com.ExecuteScalar();

            com.CommandText = "SELECT count(*) FROM voters WHERE party = 'BLU'";
            bluVotes = (int)com.ExecuteScalar();

            sc.Close();

            lbl_totalVotes.Text = "Total Votes Cast: " + totalVotes;

            fillChart();
        }

        private void fillChart()
        {
            chrt_votes.Series["Votes"].Points.AddXY("BLU", bluVotes);
            chrt_votes.Series["Votes"].Points.AddXY("RED", redVotes);

            chrt_votes.Titles.Add("Votes Chart");
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VoteForm votePage = new VoteForm();
            votePage.Show();
            Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
