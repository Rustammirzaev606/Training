using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxApp
{
    public partial class Dude_form_1 : Form
    {
        public Dude_form_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  MessageBox.Show("Hello Dude!");

            string words = txtBox1.Text;
            act1.Text = words;


        }
    
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string lel = txtBox1.Text;
            label2.Text = lel;
            MessageBox.Show($"{lel}");
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string blah = txtBox1.Text;
            label1.Text = blah;
            //foreach (char c in blah)
            //{
            //    MessageBox.Show($"c");
            //}

            //for (int i = 0; i < blah.Length; i++)
            //{
            //    Console.WriteLine(blah[i]);
            //}
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            string blah1 = txtBox1.Text;
            string newDude = newTxtBox.Text;
            lbl4.Text = newDude + " "  + blah1;
        }
    }
}
