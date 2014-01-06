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
    public partial class TeamsForm : Form
    {
        public TeamsForm()
        {
            InitializeComponent();
        }

        private void TeamsForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoGrabber g = new InfoGrabber();
            List<Team> team = g.GetTeams(41119307);
            DateTime c = team[2].CreateDate;
            //TimeSpan ss = TimeSpan.FromMilliseconds(javaNum);
            //DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
            //DateTime ddd = Jan1st1970.Add(ss);
            //DateTime final = ddd.ToUniversalTime(); 
        }
    }
}
