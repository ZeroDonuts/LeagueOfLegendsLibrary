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
    public partial class SummonerForm : Form
    {
        InfoGrabber info;
        Summoner summoner;
        DataTable table;
        List<Game> gamesPlayed;
        ChampionCollection champs;
        public SummonerForm()
        {
            InitializeComponent();
        }

        private void SummonerForm_Load(object sender, EventArgs e)
        {
            info = new InfoGrabber();
            table = new DataTable();
            gamesPlayed = new List<Game>();
            champs = new ChampionCollection();
            table.Columns.Add("Game");
            table.Columns.Add("Date");
            table.Columns.Add("Type");
            table.Columns.Add("Champion");
            table.Columns.Add("WinLoss");
            table.Columns.Add("K/D");
           
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            if (nameTextBox.Text.Trim() == "" || regionComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please enter a name or select a region.");
                return;
            }
            summoner = info.LookupSummonerByName(nameTextBox.Text, regionComboBox.SelectedItem.ToString());
            gamesPlayed = info.GetRecentGames(regionComboBox.SelectedItem.ToString(), summoner.ID);
            champs = info.GetChampions(regionComboBox.SelectedItem.ToString());

            for (int i = 0; i < gamesPlayed.Count; i++)
            {
                DataRow row = table.NewRow();

                row["Game"] = string.Format("Game {0}", i + 1);
                row["Champion"] = champs.GetChampionByID(gamesPlayed[i].championId).Name;
                string winLoss = gamesPlayed[i].GetStat(RawStatID.MatchWon).value == 1 ? "Win" : "Loss" ;
              
                row["WinLoss"] = winLoss;
                row["Type"] = gamesPlayed[i].gameType;
                row["Date"] = gamesPlayed[i].CreateDateTime.Date;
                string kda = gamesPlayed[i].GetStat(RawStatID.ChampionsKilled).value.ToString() +"/" + gamesPlayed[i].GetStat(RawStatID.NumOfDeaths).value.ToString();
                row["K/D"] = kda;
                table.Rows.Add(row);
            }
            summonerInfoDataGrid.DataSource = table;
        }
    }
}

