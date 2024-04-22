using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_z_bazo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public event Action<string> PodatkiPoslani;

        private void button1_Click(object sender, EventArgs e)
        {
            string vnesen_tekst = textBox1.Text;
            if (PodatkiPoslani != null)
            {
           
                PodatkiPoslani(vnesen_tekst);
            }

           
            this.Close();

        }
    }
}
