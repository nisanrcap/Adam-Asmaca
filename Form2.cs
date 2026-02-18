using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Media;

namespace AdamAsmaca
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        ArrayList kelimeler = new ArrayList();
        string[] bulunanHarfler;
        int sayac = 0;
        string secilenKelime;
        bool harfVar = true;
        int sure = 60;
        int dHarfSayisi = 0;
        SoundPlayer suresesi = new SoundPlayer();
        SoundPlayer kazanma = new SoundPlayer();
        SoundPlayer kaybetme = new SoundPlayer();
        private void Form2_Load(object sender, EventArgs e)
        {
            kaybetme.SoundLocation = "kaybetme.wav";
            kazanma.SoundLocation = "kazanma.wav";
            suresesi.SoundLocation = "ses.wav";
            suresesi.Play();
            secilenKelime = kelimeSec().ToString().ToUpper();
            button31.Visible = false;
            label1.Text = "";

            bulunanHarfler = new string[secilenKelime.Length];
            for (int i = 0; i < secilenKelime.Length; i++)
            {
                bulunanHarfler[i] = "_  "; // İlk harfler bulunmadığı için _ koyuyoruz. 
                label1.Text += bulunanHarfler[i].ToString();
            }
            label3.Text = "";
            timer1.Interval = 1000;
            timer1.Enabled = true;
            label2.Text = "";
            panel1.Visible = false;
        }

        object kelimeSec()  
        {
            Random rnd = new Random();
            kelimeler.Add("Orangutan");
            kelimeler.Add("Mamut");
            kelimeler.Add("Kuş");
            kelimeler.Add("Fil");
            kelimeler.Add("Hamsi");
            kelimeler.Add("Balık");
            kelimeler.Add("Koyun");
            kelimeler.Add("Buzak");

            int sayi = rnd.Next(0, kelimeler.Count);
            return kelimeler[sayi];

        }

        void harfsec(char secim)
        {
            harfVar = false;
            char harf= secim;
            label1.Text = "";
            for (int i = 0; i <secilenKelime.Length; i++)
            {
                if (secilenKelime[i]==harf)
                {
                    dHarfSayisi++;
                    bulunanHarfler[i] = harf.ToString();
                    harfVar = true;
                    pictureBox2.Image = ımageList2.Images[0];
                    if (dHarfSayisi==secilenKelime.Length)
                    {
                        Kazandiniz();
                    }
                }
                
                label1.Text += bulunanHarfler[i];
            }
            if (harfVar==false)
            {
                pictureBox2.Image = ımageList2.Images[3];
                pictureBox1.Image = ımageList1.Images[sayac];
                sayac++;
                    if (sayac == 10)
                    {
                    pictureBox2.Image = ımageList2.Images[1];
                    Kaybettiniz();
                    }
                
                
            }
 
        }

        void Kaybettiniz()
        {
            pictureBox2.Image = ımageList2.Images[1];
            label3.Text = "KAYBETTİNİZ";
            timer1.Stop();
            panel1.Visible = true;
            label5.Text = secilenKelime;
            button30.Enabled = false;
            textBox1.Enabled = false;
            suresesi.Stop();
            kaybetme.Play();
            button31.Visible = true;

        }
        void Kazandiniz()
        {
            pictureBox2.Image = ımageList2.Images[2];
            label3.Text = "KAZANDINIZ";
            timer1.Stop();
            panel1.Visible = true;
            label5.Text = secilenKelime;
            button30.Enabled = false;
            textBox1.Enabled = false;
            suresesi.Stop();
            kazanma.Play();
            button31.Visible = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button1.Text));
            button1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button2.Text));
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button3.Text));
            button3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button4.Text));
            button4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button5.Text));
            button5.Visible = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button6.Text));
            button6.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button7.Text));
            button7.Visible = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button8.Text));
            button8.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button9.Text));
            button9.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button10.Text));
            button10.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button11.Text));
            button11.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button12.Text));
            button12.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button13.Text));
            button13.Visible = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button15.Text));
            button15.Visible = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button17.Text));
            button17.Visible = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button19.Text));
            button19.Visible = false;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button22.Text));
            button22.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button14.Text));
            button14.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button16.Text));
            button16.Visible = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button18.Text));
            button18.Visible = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button20.Text));
            button20.Visible = false;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button23.Text));
            button23.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button21.Text));
            button21.Visible = false;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button24.Text));
            button24.Visible = false;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button25.Text));
            button25.Visible = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button26.Text));
            button26.Visible = false;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button28.Text));
            button28.Visible = false;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button27.Text));
            button27.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            harfsec(Convert.ToChar(button29.Text));
            button29.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            sure--;
            label2.Text = sure.ToString();
            if (sure==0)
            {
                Kaybettiniz();
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            string tahmin = textBox1.Text.ToUpper();
            if (tahmin==secilenKelime)
            {
                Kazandiniz();
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            kazanma.Stop();
            kaybetme.Stop();
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Hide();  
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
