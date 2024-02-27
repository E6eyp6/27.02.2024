using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dizi_Uygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] isim = new string[10];

        int bilmem = 0;

        private void button1_Click(object sender, EventArgs e)
        {
           
            isim[bilmem] = textBox1.Text;
            textBox1.Text = "";
            bilmem++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i <= 10; i++)
            {
                if (isim[i] == null)
                {
                    break;
                }
                listBox1.Items.Add(isim[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
