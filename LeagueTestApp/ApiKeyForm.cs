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
            try
            {
                LolInfo.ChampionCollection = new InfoGrabber().GetChampions("na"); //... this takes a crazy amount of time

                this.Close();
            }
            catch (WebException ex)
            {
                
                MessageBox.Show("Invalid apikey");
            }
        }
    }
}
