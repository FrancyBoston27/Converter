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

namespace Convertitore
{
    public partial class home : Form
    {
        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(home));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        public home()
        {
            InitializeComponent();
            if (Thread.CurrentThread.CurrentUICulture.Name == "it-IT")
            {
                languagename = 1;
            }
            else if (Thread.CurrentThread.CurrentUICulture.Name == "en")
            {
                languagename = 0;
            }
        }

        public static int languagename;
        private void home_Load(object sender, EventArgs e)
        {

        }

        private void benvenuto_Click(object sender, EventArgs e)
        {

        }

        private void inizia_Click(object sender, EventArgs e)
        {
            if (dieciAdue.Checked && languagename==1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
                dieciAdueForm form = new dieciAdueForm();
                form.Show();
                this.Hide();
            }
            else if (dieciAdue.Checked && languagename == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                dieciAdueForm form = new dieciAdueForm();
                form.Show();
                this.Hide();
            }
            if (dieciAotto.Checked && languagename == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
                dieciAottoForm form = new dieciAottoForm();
                form.Show();
                this.Hide();
            }
            else if (dieciAotto.Checked && languagename == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                dieciAottoForm form = new dieciAottoForm();
                form.Show();
                this.Hide();
            }
            if (dieciAsedici.Checked && languagename == 1)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
                dieciAsediciForm form = new dieciAsediciForm();
                form.Show();
                this.Hide();
            }
            else if (dieciAsedici.Checked && languagename == 0)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                dieciAsediciForm form = new dieciAsediciForm();
                form.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void descrizione_Click(object sender, EventArgs e)
        {

        }

        private void dieciAdue_CheckedChanged(object sender, EventArgs e)
        {
            if (dieciAdue.Checked && languagename == 1)
            {
                descrizione.Text = "Selezionando questa funzione, puoi convertire un numero dalla base decimale a quella binaria e viceversa";
            }

            else if (dieciAdue.Checked && languagename == 0)
            {
                descrizione.Text = "By selecting this function, you can convert a number from decimal to binary base and vice versa";
            }
        }

        private void dieciAotto_CheckedChanged(object sender, EventArgs e)
        {
            if (dieciAotto.Checked && languagename == 1)
            {
                descrizione.Text = "Selezionando questa funzione, puoi convertire un numero dalla base decimale a quella ottale e viceversa";
            }
            else if (dieciAotto.Checked && languagename == 0)
            {
                descrizione.Text = "By selecting this function, you can convert a number from decimal to octal base and vice versa";
            }
        }

        private void dieciAsedici_CheckedChanged(object sender, EventArgs e)
        {
            if (dieciAsedici.Checked && languagename == 1)
            {
                descrizione.Text = "Selezionando questa funzione, puoi convertire un numero dalla base decimale a quella esadecimale e viceversa";
            }
            else if (dieciAsedici.Checked && languagename == 0)
            {
                descrizione.Text = "By selecting this function, you can convert a number from decimal to hexadecimal base and vice versa";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void languageButton_Click(object sender, EventArgs e)
        {
            languageform form = new languageform();
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}