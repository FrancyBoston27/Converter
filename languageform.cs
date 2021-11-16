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
    public partial class languageform : Form
    {
        public languageform()
        {
            InitializeComponent();
        }

        private void ChangeLanguage(string lang)
        {
            foreach (Control c in this.Controls)
            {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(home));
                resources.ApplyResources(c, c.Name, new CultureInfo(lang));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ita.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("it-IT");
                home form = new home();
                form.Show();
            }
            else if (eng.Checked)
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                home form = new home();
                form.Show();
            }
            this.Hide();
        }

        private void ita_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void eng_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void languageform_Load(object sender, EventArgs e)
        {

        }
    }
}
