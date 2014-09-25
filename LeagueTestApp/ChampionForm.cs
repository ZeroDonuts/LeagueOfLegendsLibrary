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
            table.Columns.Add("Lore");
            table.Columns.Add("Blurb");
            
            ChampionCollection champions = LolInfo.ChampionCollection;
            
            foreach (Champion champion in champions)
            {
                DataRow row = table.NewRow();
           
                row["ID"] = champion.Id;
                row["Name"] = champion.Name;
                row["Lore"] = champion.Lore.Replace("<br>", "\n");
                row["Blurb"] = champion.Blurb;
               
                
                table.Rows.Add(row);
            }

            championDataGridView.DataSource = table;
            championDataGridView.Columns["Lore"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            championDataGridView.Columns["Lore"].Width = 600;
            championDataGridView.AutoResizeRows();

            championDataGridView.Columns["Blurb"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            championDataGridView.Columns["Blurb"].Width = 600;
            championDataGridView.AutoResizeRows();


            championDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void championDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
