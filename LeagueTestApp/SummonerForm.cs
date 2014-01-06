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

            for (int i = 0; i < gamesPlayed.Count; i++)
            {
                DataRow row = table.NewRow();

                row["Game"] = string.Format("Game {0}", i + 1);

                row["Champion"] = champs[gamesPlayed[i].championId].Name;

                row["Queue"] = gamesPlayed[i].subType;

                string winLoss = "";
                try
                {
                    winLoss = gamesPlayed[i].GetStat(RawStatID.MatchWon).name;
                }
                catch (KeyNotFoundException)
                {
                    winLoss = gamesPlayed[i].GetStat(RawStatID.MatchLost).name;
                }
               
              
                row["WinLoss"] = winLoss;

                row["Type"] = gamesPlayed[i].gameType;

                row["Date"] = gamesPlayed[i].CreateDateTime.Date;
                string kda =""; 
                try
                {
                    kda += gamesPlayed[i].GetStat(RawStatID.ChampionsKilled).value.ToString();
                }
                catch(KeyNotFoundException)
                {
                    kda += "0";
                }

                kda += "/";

                try
                {
                    kda += gamesPlayed[i].GetStat(RawStatID.NumOfDeaths).value.ToString();
                }
                catch (KeyNotFoundException)
                {
                    kda += "0";
                }

                kda += "/";

                try
                {
                    kda += gamesPlayed[i].GetStat(RawStatID.Assists).value.ToString();
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

