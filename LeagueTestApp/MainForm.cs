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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Shown += new EventHandler(MainForm_Shown);
            ApiKeyForm form = new ApiKeyForm();
            form.ShowDialog();
        }

        void MainForm_Shown(object sender, EventArgs e)
        {
            if (LolInfo.ChampionCollection == null)
            {
                this.Close();
            }
        }

        private void championsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChampionForm form = new ChampionForm();
            form.MdiParent = this;
            form.Show();
        }

        private void summonerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SummonerForm form = new SummonerForm();
            form.MdiParent = this;
            form.Show();
        }

        private void teamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TeamsForm form = new TeamsForm();
            form.MdiParent = this;
            form.Show();
        }
    }
}
