using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NumberGeneratorLib;


namespace SimpleNumberGeneratorInWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NumberGenerator numberGenerator = new NumberGenerator();

            numberGenerator.Even += NumberGenerator_Even;
            listBox1.Items.Clear();
            numberGenerator.GetRandomNumbers();
        }

        private void NumberGenerator_Even(bool even, int number)
        {
            if (even)
            {
                listBox1.Items.Add($"Even number: {number}");
            }
        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

    }
}