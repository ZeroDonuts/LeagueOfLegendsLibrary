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

            List<Champion> champions = new InfoGrabber().GetChampions("na", false);

            foreach (Champion champion in champions)
            {
                DataRow row = table.NewRow();

                row["Name"] = champion.Name;

                table.Rows.Add(row);
            }

            championDataGridView.DataSource = table;
        }
    }
}
