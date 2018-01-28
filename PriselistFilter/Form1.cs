using System;
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
        private XlsInterface myXlsFileWorker;
        private XlsInterface providerXlsFileWorker;
        public Form1()
        {
            InitializeComponent();
        }

        private void checkFilterByManufactor_CheckedChanged(object sender, EventArgs e)
        {
            manufactorInput.Enabled = !manufactorInput.Enabled;
            startFilter.Enabled = checkFilterByManufactor.Checked || checkFIlterByName.Checked;
        }

        private void checkFIlterByName_CheckedChanged(object sender, EventArgs e)
        {
            nameInput.Enabled = !nameInput.Enabled;
            notIncludeNameInput.Enabled = !notIncludeNameInput.Enabled;
            startFilter.Enabled = checkFilterByManufactor.Checked || checkFIlterByName.Checked;
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "xls files (*.xls)|*.xls|(*.xlsx)|*.xlsx|(*.csv)|*.csv";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileNameLabel.Text = openFileDialog1.FileName;
                myXlsFileWorker = new MyXlsWorker(fileNameLabel.Text);
            }
        }

        private void startFilter_Click(object sender, EventArgs e)
        {
            saveButton.Enabled = true;
            if (filterMyListRadio.Checked)
            {
                filterFile(myXlsFileWorker);
            }
            else if (filterProviderListRadio.Checked)
            {
                filterFile(providerXlsFileWorker);
            }
        }

        private void filterFile(XlsInterface worker)
        {
            if (checkFilterByManufactor.Checked)
            {
                var manufactorKeyWords = manufactorInput.Text.Split(',').Select(keyword => keyword.Trim().ToLower()).ToArray();
                worker.FilterRowsByManufactor(manufactorKeyWords);
            }
            if (checkFIlterByName.Checked)
            {
                var nameKeyWords = nameInput.Text.Split(',').Select(keyword => keyword.Trim().ToLower()).ToArray();
                var notIncludeKeyWords = notIncludeNameInput.Text.Split(',').Select(keyword => keyword.Trim().ToLower()).ToArray();
                if (notIncludeKeyWords.Length > 1)
                {
                    worker.FilterRowsByName(nameKeyWords, notIncludeKeyWords);
                }
                else if (notIncludeKeyWords[0] == "")
                {
                    worker.FilterRowsByName(nameKeyWords);
                }
               
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (filterMyListRadio.Checked)
            {
                myXlsFileWorker.SaveFile("myFileResult.csv");
            }
            else if (filterProviderListRadio.Checked) 
            {
                providerXlsFileWorker.SaveFile("providerFileResult.csv");
            }
        }

        private void openProviderFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "xls files (*.xls)|*.xls|(*.xlsx)|*.xlsx|(*.csv)|*.csv";
            openFileDialog2.FilterIndex = 2;
            openFileDialog2.RestoreDirectory = true;

            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                providerFileName.Text = openFileDialog2.FileName;
                providerXlsFileWorker = new ProviderXlsWorker(openFileDialog2.FileName);
            }
        }

        private void compareButton_Click(object sender, EventArgs e)
        {
            double myMarkup = markup.Text == "" ? 0 : Double.Parse(markup.Text);
            var comparator = new Comparator(myMarkup);
            comparator.Compare(myXlsFileWorker, providerXlsFileWorker);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myXlsFileWorker.SaveFile("myFileResult.csv");
        }
    }
}
