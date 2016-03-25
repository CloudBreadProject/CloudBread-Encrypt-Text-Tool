using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CloudBreadLib.BAL.Crypto;

namespace CloudBread_Encrypt_Text_Tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = Crypto.AES_encrypt(txtPlain.Text, txtAESKey.Text, txtAESSalt.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtPlain.Text = Crypto.AES_decrypt(txtEncrypt.Text, txtAESKey.Text, txtAESSalt.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtEncrypt.Text = "";
            txtPlain.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            txtPlain.SelectAll();
            txtPlain.Copy();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtEncrypt.SelectAll();
            txtEncrypt.Copy();

        }

    }
}
