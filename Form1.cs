using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikacija_z_bazo
{
    //"Izjavljam, da sem nalogo opravil samostojno in da sem njen avtor. Zavedam se, da v primeru, če izjava prvega stavka ni resnična, kršim disciplinska pravila."

    public partial class Form1 : Form
    {

        private Dictionary<object, string> itemTexts = new Dictionary<object, string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            Visible = true;
            form2.PodatkiPoslani += (data) =>
            {
                
                listBox1.Items.Add(data);
            
                itemTexts.Add(data, "");
            };
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                
                richTextBox1.Text = itemTexts[listBox1.SelectedItem];
            }
        }
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Posodobimo besedilo v slovarju ob spremembi vsebine RichTextBoxa
                itemTexts[listBox1.SelectedItem] = richTextBox1.Text;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                // Odstranimo izbran element
                var selectedItem = listBox1.SelectedItem;
                listBox1.Items.Remove(selectedItem);

                // Če je seznam prazen, pustimo ListBox brez izbire
                if (listBox1.Items.Count == 0)
                {
                    richTextBox1.Clear();
                }
                else
                {
                    // Če obstajajo elementi, izberemo prvega
                    listBox1.SelectedIndex = 0;
                }
            }
        }
    }
}
