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
    public partial class ApiKeyForm : Form
    {
        public ApiKeyForm()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            

            LolInfo.APIKEY = apiKeyTextBox.Text;
            LolInfo.APIKEY = "8f424725-fc7f-4b84-aff0-ec7d4e212ae6";
            try
            {
                LolInfo.ChampionCollection = new InfoGrabber().GetChampions("na");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Invalid apikey");
            }
            
        }

        private void ApiKeyForm_Load(object sender, EventArgs e)
        {

        }
    }
}
