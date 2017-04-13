using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirİşlem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in groupBox1.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Visible = false;
                }
            }
            foreach (Control item in groupBox2.Controls)
            {
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Visible = false;
                }
            }
            btn_harf.Visible = true;
            btn_sayi.Visible = true;
            counter = 0;
            counterh = 0;
        }
        int counter = 0;
        int counterh = 0;
        string[] harfler = { "A", "A", "B", "C", "Ç", "D", "E", "E", "F", "G", "Ğ", "H", "I", "İ", "İ", "J", "K", "L", "M", "N", "O", "P", "R", "S", "Ş", "T", "U", "Ü", "V", "Y", "Z" };
            Random rnd = new Random();
        
        private void btn_harf_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(0, harfler.Length);
            counter++;
            if (counter == 1)
            { b1.Visible = true; b1.Text = harfler[a]; }
            else if (counter == 2)
            {
                b2.Visible = true; b2.Text = harfler[a];
            }
            else if (counter == 3)
            {
                b3.Visible = true; b3.Text = harfler[a];
            }
            else if (counter == 4)
            {
                b4.Visible = true; b4.Text = harfler[a];
            }
            else if (counter == 5)
            {
                b5.Visible = true; b5.Text = harfler[a];
            }
            else if (counter == 6)
            {
                b6.Visible = true; b6.Text = harfler[a];
            }
            else if (counter == 7)
            {
                b7.Visible = true; b7.Text = harfler[a];
            }
            else if (counter == 8)
            {
                b8.Visible = true; b8.Text = harfler[a];
                b9.Visible = true; b9.Text = "?";
            }
        }

        private void btn_sayi_Click(object sender, EventArgs e)
        {
            int a = rnd.Next(1,11);
            counterh++;
            if (counterh == 1)
            { bn1.Visible = true; bn1.Text = a.ToString(); }
            else if (counterh == 2)
            {
                bn2.Visible = true; bn2.Text = a.ToString();
            }
            else if (counterh == 3)
            {
                bn3.Visible = true; bn3.Text = a.ToString();
            }
            else if (counterh == 4)
            {
                bn4.Visible = true; bn4.Text = a.ToString();
            }
            else if (counterh == 5)
            {
                bn5.Visible = true; bn5.Text = a.ToString();
            }
            else if (counterh == 6)
            {
                bn6.Visible = true; bn6.Text = a.ToString();
            }
            else if (counterh == 7)
            {
                bn7.Visible = true; bn7.Text = rnd.Next(25,35).ToString();
            }
            else if (counterh == 8)
            {
                bn8.Visible = true;
                bn9.Visible = true; bn9.Text = rnd.Next(350,450).ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(new object { }, new EventArgs { });
        }
    }
}
