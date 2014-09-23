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

namespace LeagueTestApp
{
    public partial class ChampionForm : Form
    {
        public ChampionForm()
        {
            InitializeComponent();
        }

        private void ChampionForm_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(ChampionForm_Shown);

        }

        void ChampionForm_Shown(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID");
            table.Columns.Add("Name");
            table.Columns.Add("Bot");
            //table.Columns.Add("Attack");
            //table.Columns.Add("Magic");
            //table.Columns.Add("Defense");
            //table.Columns.Add("Difficulty");

            ChampionCollection champions = LolInfo.ChampionCollection;
            int i = 0;
            foreach (Champion champion in champions)
            {
                DataRow row = table.NewRow();

                row["ID"] = champion.Id;
                row["Name"] = champion.Name;
                row["Bot"] = champion.BotEnabled;
                //row["Attack"] = champion.AttackRank;
                //row["Magic"] = champion.MagicRank;
                //row["Defense"] = champion.DefenseRank;
                //row["Difficulty"] = champion.DifficultyRank;
                table.Rows.Add(row);
            }

            championDataGridView.DataSource = table;
        }

        private void championDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
