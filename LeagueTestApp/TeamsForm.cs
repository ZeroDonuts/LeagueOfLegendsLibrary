using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeagueOfLegendsLibrary;

namespace LeagueTestApp
{
    public partial class TeamsForm : Form
    {
        public TeamsForm()
        {
            InitializeComponent();
        }

        Summoner summoner;
        List<Team> teams;
        DataTable table;

        private void TeamsForm_Load(object sender, EventArgs e)
        {
            table = new DataTable();

            table.Columns.Add("Team Name");
            table.Columns.Add("Number of Members");
            table.Columns.Add("Total Win/Loss");
            table.Columns.Add("3v3 Win/Loss");
            table.Columns.Add("5v5 Win/Loss");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() == "" || regionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a name or select a region.");
                return;
            }

            InfoGrabber g = new InfoGrabber();

            summoner = g.LookupSummonerByName(nameTextBox.Text, regionComboBox.SelectedItem.ToString());

            teams = g.GetTeams(summoner.ID);

            for (int i = 0; i < teams.Count(); i++)
            {
                DataRow row = table.NewRow();

                row["Team Name"] = teams[i];

                table.Rows.Add(row);
            }
            teamsInfoDataGrid.DataSource = table;
        }

    }
}
