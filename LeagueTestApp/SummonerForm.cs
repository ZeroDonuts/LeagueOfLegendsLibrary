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
        Champions champs;
        public SummonerForm()
        {
            InitializeComponent();
        }

        private void SummonerForm_Load(object sender, EventArgs e)
        {
            info = new InfoGrabber();
            table = new DataTable();
            gamesPlayed = new List<Game>();
            champs = new Champions();
            table.Columns.Add("Game");
            table.Columns.Add("Champion Played");
            table.Columns.Add("WinLoss");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            summoner = info.LookupSummonerByName(nameTextBox.Text, regionTextBox.Text);
            gamesPlayed = info.GetRecentGames(regionTextBox.Text, summoner.ID);
            champs = info.GetChampions(regionTextBox.Text);

            for (int i = 0; i < gamesPlayed.Count; i++)
            {
                DataRow row = table.NewRow();

                row["Game"] = string.Format("Game {0}", i + 1);
                row["Champion Played"] = champs.GetChampionByID(gamesPlayed[i].championId).Name;
                row["WinLoss"] = gamesPlayed[i].GetStat(RawStatID.MatchLost).name;
                table.Rows.Add(row);
            }
            summonerInfoDataGrid.DataSource = table;
        }
    }
}

