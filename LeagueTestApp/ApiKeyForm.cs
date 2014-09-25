using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LeagueOfLegendsLibrary;
using System.Net;
using LeagueOfLegendsLibrary.GameInfo;
using LeagueOfLegendsLibrary.LeagueInfo;
namespace LeagueTestApp
{
    public partial class ApiKeyForm : Form
    {
        public ApiKeyForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            LolInfo.APIKEY = apiKeyTextBox.Text;

            //Dictionary<string, Summoner> summoners = new InfoGrabber().LookupSummonersByID("na", );
            try
            {
                //IDictionary<string, List<League>> leagueGroups = new InfoGrabber().GetLeague("na", 2);
                //RecentGamesCollection games = new InfoGrabber().GetRecentGames("na", 2);
                //LolInfo.ChampionCollection = new InfoGrabber().GetChampions("na"); //... this takes a crazy amount of time

                this.Close();
            }
            catch (WebException ex)
            {
                
                MessageBox.Show("Invalid apikey");
            }
        }
    }
}
