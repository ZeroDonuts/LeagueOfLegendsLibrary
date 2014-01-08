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

            try
            {
                teams = g.GetTeams(summoner.ID);
            }
            catch
            {

            }
            finally
            {
                for (int i = 0; i < teams.Count(); i++)
                {
                    DataRow row = table.NewRow();

                    row["Team Name"] = teams[i].Name;
                    row["Number of Members"] = teams[i].Roster.MemberList.Count().ToString();

                    int team3v3Wins = 0;
                    int team3v3Losses = 0;

                    int team5v5Wins = 0;
                    int team5v5Losses = 0;

                    if (teams[i].MatchHistory != null)
                    {
                        for (int j = 0; j < teams[i].MatchHistory.Count(); j++)
                        {
                            if (teams[i].MatchHistory[j].Win)
                            {
                                if (teams[i].MatchHistory[j].MapId == 41)
                                {
                                    team3v3Wins++;
                                }
                                else
                                {
                                    team5v5Wins++;
                                }
                            }
                            else
                            {
                                if (teams[i].MatchHistory[j].MapId == 41)
                                {
                                    team3v3Losses++;
                                }
                                else
                                {
                                    team5v5Losses++;
                                }
                            }
                        }
                        row["Total Win/Loss"] = (team3v3Wins + team5v5Wins).ToString() + "/" + (team3v3Losses + team5v5Losses).ToString();
                        row["3v3 Win/Loss"] = team3v3Wins.ToString() + "/" + team3v3Losses.ToString();
                        row["5v5 Win/Loss"] = team5v5Wins.ToString() + "/" + team5v5Losses.ToString();
                    }
                    else
                    {
                        row["Total Win/Loss"] = "No Games Played";
                        row["3v3 Win/Loss"] = "No Games Played";
                        row["5v5 Win/Loss"] = "No Games Played";
                    }
                    table.Rows.Add(row);
                }
            }
            teamsInfoDataGrid.DataSource = table;
        }

    }
}
