using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Convertitore
{
    public partial class dieciAdueForm : Form
    {
        public dieciAdueForm()
        {
            InitializeComponent();
            if (home.languagename == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
                languagename = 1;
            }
            else if (home.languagename == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                languagename = 0;
            }
        }

        public string binary;
        public string dex;
        public int languagename;
        public string messagebox1;

        private void dieciAdueForm_Load(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            home form = new home();
            form.Show();
            this.Hide();
        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        //Dex To Bin 
        private void dex1_TextChanged(object sender, EventArgs e)
        {
            if (languagename == 1)
            {
                messagebox1 = "Inserisci solo cifre da 0 e 9";
            }
            else if (languagename == 0)
            {
                messagebox1 = "Enter only digits from 0 and 9";
            }

            string value = "0"; string value1 = "1"; string value2 = "2"; string value3 = "3"; string value4 = "4";
            string value5 = "5"; string value6 = "6"; string value7 = "7"; string value8 = "8"; string value9 = "9";

            if (dex1.Text.EndsWith(value) == true || dex1.Text.EndsWith(value1) == true 
                || dex1.Text.EndsWith(value2) == true || dex1.Text.EndsWith(value3) == true 
                || dex1.Text.EndsWith(value4) == true || dex1.Text.EndsWith(value5) == true 
                || dex1.Text.EndsWith(value6) == true || dex1.Text.EndsWith(value7) == true 
                || dex1.Text.EndsWith(value8) == true || dex1.Text.EndsWith(value9) == true)
            {
                int valuestring = (int)Convert.ToInt64(dex1.Text);
                binary = Convert.ToString(valuestring, 2);
            }
            else if (dex1.Text == string.Empty)
            {

            }
            else
            {
                MessageBox.Show(messagebox1);
                dex1.Text = "";
            }

        }
        private void calcola1_Click(object sender, EventArgs e)
        {
            if (dex1.Text != string.Empty)
            {
                bin1.Text = binary;

            }
            else
            {
                dex1.Text = "0";
                bin1.Text = "0";
            }
        }


        //Bin to Dex
        private void bin2_TextChanged(object sender, EventArgs e)
        {
            if (languagename == 1)
            {
                messagebox1 = "Inserisci solo 0 e 1";
            }
            else if (languagename == 0)
            {
                messagebox1 = "Enter only 0 and 1 values";
            }

            string value = "0";
            string value1 = "1";
            if (bin2.Text.EndsWith(value) == true || bin2.Text.EndsWith(value1) == true)
            {
                int valuestring = (int)Convert.ToInt64(bin2.Text, 2);
                dex = Convert.ToString(valuestring);
            }
            else if (bin2.Text == string.Empty)
            {

            }
            else
            {
                MessageBox.Show(messagebox1);
                bin2.Text = "";
            }
        }

        private void calcola2_Click(object sender, EventArgs e)
        {
            if (bin2.Text != string.Empty)
            {
                dex2.Text = dex;
            }
            else
            {
                dex2.Text = "0";
                bin2.Text = "0";
            }
        }
    }
}
