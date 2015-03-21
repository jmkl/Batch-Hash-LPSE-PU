using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Hash
{
    public partial class CompareTextBox : UserControl
    {
        public CompareTextBox()
        {
            InitializeComponent();
        }
        public void setTitle(string title) {
            lbl.Text = title;
        }
        public void setHash(string hash) {
            tb1.Text = hash;
        }

        private void cek_Click(object sender, EventArgs e)
        {
            string cektext;
            if (tb1.Text.ToString() == tb2.Text.ToString())
                cektext = "Hash Sama";
            else
                cektext = "Hash Tidak Sama";

            MessageBox.Show(cektext, "Hasil cek", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        internal void isError(bool isdir)
        {
            if (isdir)
                cek.Enabled = false;
        }
    }
}
