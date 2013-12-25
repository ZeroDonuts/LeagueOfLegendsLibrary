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
            ApiKeyForm form = new ApiKeyForm();
            form.ShowDialog();

            if (LolInfo.APIKEY.Length == 0)
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
    }
}
