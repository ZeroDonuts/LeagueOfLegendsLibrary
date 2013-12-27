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
    public partial class ChampionForm : Form
    {
        public ChampionForm()
        {
            InitializeComponent();
        }

        private void ChampionForm_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Attack");
            table.Columns.Add("Magic");
            table.Columns.Add("Defense");
            table.Columns.Add("Difficulty");

            ChampionCollection champions = LolInfo.ChampionCollection;

            foreach (Champion champion in champions.ChampionsList)
            {
                DataRow row = table.NewRow();

                row["Name"] = champion.Name;
                row["Attack"] = champion.AttackRank;
                row["Magic"] = champion.MagicRank;
                row["Defense"] = champion.DefenseRank;
                row["Difficulty"] = champion.DifficultyRank;
                table.Rows.Add(row);
            }

            championDataGridView.DataSource = table;
        }

    }
}
