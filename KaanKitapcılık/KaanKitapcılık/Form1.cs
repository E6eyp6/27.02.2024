using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KaanKitapcılık
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Dizin Kitap Kaydetme//////////////
        string[] kutuphane = new string[9999999];
        double[] fiyat = new double[9999999];

        public void diziyukle() {
            //Listboxların Form Yüklendiğinde Otomatik Olarak Yazılması
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();

            for (int i = 0; i <= 9999999; i++)
            {
                if (kutuphane[i] == null)
                {
                    break;
                }
                listBox1.Items.Add(i);
                listBox2.Items.Add(kutuphane[i]);
                listBox3.Items.Add(fiyat[i]);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Dizilerin Form Yüklendiğinde Otomatik Olarak Tanımlanması
            kutuphane[0] = "Şeker Portakalı"; fiyat[0] = 93;
            kutuphane[1] = "Küçük Prens"; fiyat[1] = 47.13;
            kutuphane[2] = "1984"; fiyat[2] = 56.9;
            kutuphane[3] = "Simyacı"; fiyat[3] = 89.19;
            kutuphane[4] = "Kürk Mantolu Madonna"; fiyat[4] = 19.6;
            kutuphane[5] = "Kırmızı Pazartesi"; fiyat[5] = 66.1;
            kutuphane[6] = "Otomatik Portakal"; fiyat[6] = 26.5;

            diziyukle();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kitap Ekleme

            int no = Convert.ToInt32(numericUpDown1.Value);
            if (kutuphane[no] == null) {
                kutuphane[no] = textBox1.Text;
                fiyat[no] = Convert.ToInt32(numericUpDown4.Value);
            }
            diziyukle();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox4.Items.Add(Convert.ToInt32(numericUpDown1.Value) + ". " + textBox1.Text + " " + Convert.ToInt32(numericUpDown4.Value) + "₺ ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Numara Olarak Arama

            if (kutuphane[Convert.ToInt32(numericUpDown2.Value)] != null)
            {
                label15.Text = Convert.ToString(numericUpDown2.Value);
                label16.Text = kutuphane[Convert.ToInt32(numericUpDown2.Value)].ToString();
                label17.Text = fiyat[Convert.ToInt32(numericUpDown2.Value)].ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Yazı Olarak Arama
            for (int i = 0; i <= 9999999; i++)
            {
                if (kutuphane[i] == null)
                {
                    break;
                }
                if(kutuphane[i] == textBox2.Text){
                 label15.Text = Convert.ToString(i);
                 label16.Text = Convert.ToString(kutuphane[i]);
                 label17.Text = Convert.ToString(fiyat[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (kutuphane[Convert.ToInt32(numericUpDown3.Value)] != null) {
                for (int i = 0; i <= 9999999; i++)
                {
                    if (kutuphane[i] == null)
                    {
                        break;
                    }
                    if (kutuphane[i] == textBox5.Text)
                    {
                        kutuphane[Convert.ToInt32(numericUpDown3.Value)] = "";
                        fiyat[Convert.ToInt32(numericUpDown3.Value)] = 0;
                        diziyukle();
                    }
                }
            }
        }


    }
}
