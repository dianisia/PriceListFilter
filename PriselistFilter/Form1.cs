﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PriselistFilter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkFilterByManufactor_CheckedChanged(object sender, EventArgs e)
        {
            manufactorInput.Enabled = !manufactorInput.Enabled;
        }

        private void checkFIlterByName_CheckedChanged(object sender, EventArgs e)
        {
            nameInput.Enabled = !nameInput.Enabled;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xls files (*.xls)|*.xls";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLabel.Text = openFileDialog1.FileName;
            }
        }
    }
}