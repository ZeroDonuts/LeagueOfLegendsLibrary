﻿using System;
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
    public partial class Runes : Form
    {
        Summoner _summoner;
        InfoGrabber grabber = new InfoGrabber("na", LolInfo.APIKEY);
        RunePageCollection pages;

        public Runes(Summoner summoner, String region)
        {
            InitializeComponent();
            _summoner = summoner;

            DataTable table = new DataTable();

            table.Columns.Add("Rune Page ID");
            table.Columns.Add("Rune Page Name");
            table.Columns.Add("Is Current");

            for (int i = 1; i <= 30; i++)
            {
                table.Columns.Add("Rune Slot " + i.ToString());
            }

            pages = summoner.GetRunes();
            for (int i = 0; i < pages.Count<RunePage>(); i++)
            {
                DataRow row = table.NewRow();

                row["Rune Page ID"] = pages[i].id;
                row["Rune Page Name"] = pages[i].name;
                row["Is Current"] = pages[i].current.ToString();

                if (pages[i].slots != null)
                {
                    for (int j = 0; j < pages[i].slots.Count<RuneSlot>(); j++)
                    {
                        row["Rune Slot " + (j + 1).ToString()] = pages[i].slots[j].rune.description;
                    }
                }

                table.Rows.Add(row);
            }
            RuneDataGridView.DataSource = table;
        }
    }
}
