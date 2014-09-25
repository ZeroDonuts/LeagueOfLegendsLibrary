using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using LeagueOfLegendsLibrary;
using LeagueOfLegendsLibrary.ChampionInfo;
using LeagueOfLegendsLibrary.GameInfo;


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
            info = new InfoGrabber("na", LolInfo.APIKEY);
            table = new DataTable();
            gamesPlayed = new RecentGamesCollection();
            champs = new ChampionCollection();
    
            table.Columns.Add("Date");
            table.Columns.Add("Game");
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
            MessageBox.Show(summoner.Name);//21014383
            summoner = info.LookupSummonerByID(regionComboBox.SelectedItem.ToString(), summoner.ID);
            gamesPlayed = summoner.GetRecentGames();
            champs = info.GetChampions();
            PlayerStatsSummaryList sum = summoner.GetStatSummary(Season.SEASON3);
            int i = 0;
            foreach(Game game in gamesPlayed)
            {
                DataRow row = table.NewRow();

                row["Game"] = string.Format("Game {0}", i + 1);
                i++;
                //row["Champion"] = champs.FindById(game.ChampionId).Name;

                row["Queue"] = game.subType;
              
                row["WinLoss"] = game.Statistics.Win.ToString();

                row["Type"] = game.GameType;

                row["Date"] = game.CreateDateTime.Date;
                string kda = "";
                kda += game.Statistics.ChampionsKilled.ToString() + "/" + game.Statistics.Deaths.ToString() +"/" + game.Statistics.Assists.ToString();
               

                
                
                row["K/D/A"] = kda;
                table.Rows.Add(row);
            }
            summonerInfoDataGrid.DataSource = table;
        }

        private void runeButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text.Trim() != "")
            {
                Runes runeForm = new Runes(summoner, regionComboBox.SelectedItem.ToString());
                runeForm.ShowDialog();
            }
        }

        private void summonerInfoDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

