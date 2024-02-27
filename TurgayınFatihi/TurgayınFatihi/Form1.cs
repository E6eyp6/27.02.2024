using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.IO;


namespace TurgayınFatihi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string line = "";

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        string a = "";

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            StreamReader sr = new StreamReader(a);
            line = sr.ReadLine();
            while (line != null)
            {
                listBox1.Items.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Klasor = new FolderBrowserDialog();
            Klasor.ShowDialog();
            a = Klasor.SelectedPath;
            label1.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            a = file.FileName;
        }
    }
}
