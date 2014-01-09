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
        RecentGamesCollection gamesPlayed;
        ChampionCollection champs;
        public SummonerForm()
        {
            InitializeComponent();
        }

        private void SummonerForm_Load(object sender, EventArgs e)
        {
            info = new InfoGrabber();
            table = new DataTable();
            gamesPlayed = new RecentGamesCollection();
            champs = new ChampionCollection();
            table.Columns.Add("Game");
            table.Columns.Add("Date");
            table.Columns.Add("Type");
            table.Columns.Add("Queue");
            table.Columns.Add("Champion");
            table.Columns.Add("WinLoss");
            table.Columns.Add("K/D/A");
           
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

            int i = 0;
            foreach(Game game in gamesPlayed)
            {
                DataRow row = table.NewRow();

                row["Game"] = string.Format("Game {0}", i + 1);
                i++;
                row["Champion"] = champs[game.championId].Name;

                row["Queue"] = game.subType;

                string winLoss = "";
                try
                {
                    winLoss = game.GetStat(RawStatID.MatchWon).name;
                }
                catch (KeyNotFoundException)
                {
                    winLoss = game.GetStat(RawStatID.MatchLost).name;
                }
               
              
                row["WinLoss"] = winLoss;

                row["Type"] = game.gameType;

                row["Date"] = game.CreateDateTime.Date;
                string kda =""; 
                try
                {
                    kda += game.GetStat(RawStatID.ChampionsKilled).value.ToString();
                }
                catch(KeyNotFoundException)
                {
                    kda += "0";
                }

                kda += "/";

                try
                {
                    kda += game.GetStat(RawStatID.NumOfDeaths).value.ToString();
                }
                catch (KeyNotFoundException)
                {
                    kda += "0";
                }

                kda += "/";

                try
                {
                    kda += game.GetStat(RawStatID.Assists).value.ToString();
                }
                catch (KeyNotFoundException)
                {
                    kda += "0";
                }
                
                row["K/D/A"] = kda;
                table.Rows.Add(row);
            }
            summonerInfoDataGrid.DataSource = table;
        }

        private void runeButton_Click(object sender, EventArgs e)
        {
            Runes runeForm = new Runes(summoner, regionComboBox.SelectedItem.ToString());
            runeForm.ShowDialog();
        }

        private void summonerInfoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

