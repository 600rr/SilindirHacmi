using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SilindirHacmi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            var numTabanCapi = Convert.ToDouble(txtTabanCapi.Text);
            var numYukseklik = Convert.ToDouble(txtYukseklik.Text);
            var numSilindirinHacmi = Math.PI * Math.Pow(numTabanCapi,2) * numYukseklik;
            //MessageBox.Show(@"Silindirin Hacmi: " + numSilindirinHacmi);
            richTextBox1.AppendText(
                @"Tabanin Yarı Çapı: " + numTabanCapi + Environment.NewLine +
                @"Silindirin Yüksekliği: " + numYukseklik + Environment.NewLine +
                @"Silindirin Hacmi: " + numSilindirinHacmi);
        }

        private void txtTabanCapi_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtTabanCapi.Text, "[^0-9]"))
            {
                MessageBox.Show(@"Sadece sayı giriniz.");
                txtTabanCapi.Text = txtTabanCapi.Text.Remove(txtTabanCapi.Text.Length - 1);
            }
        }

        private void txtYukseklik_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtYukseklik.Text, "[^0-9]"))
            {
                MessageBox.Show(@"Sadece sayı giriniz.");
                txtYukseklik.Text = txtYukseklik.Text.Remove(txtYukseklik.Text.Length - 1);
            }
        }
    }
}
