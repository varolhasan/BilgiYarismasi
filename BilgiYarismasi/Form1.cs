using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 1, dogru = 0, yanlis = 0;

        private void btnA_Click(object sender, EventArgs e)
        {
            lbl02.Text = btnA.Text;
            if (lbl01.Text == lbl02.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox2.Visible = true;
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            lbl02.Text = btnB.Text;
            if (lbl01.Text == lbl02.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lbl02.Text = btnC.Text;
            if (lbl01.Text == lbl02.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            lbl02.Text = btnD.Text;
            if (lbl01.Text == lbl02.Text)
            {
                dogru++;
                lbldogru.Text = dogru.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnsonraki.Enabled = true;
                pictureBox2.Visible = true;
            }
        }

        private void btnsonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            lblsoruno.Text = soruno.ToString();
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnsonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            if (soruno == 1)
            {
                richTextBox1.Text = "'Sinekli Bakkal' Romanının Yazarı Aşağıdakilerden Hangisidir?";
                btnA.Text = "Reşat Nuri Güntekin";
                btnB.Text = "Halide Edip Adıvar";
                btnC.Text = "Ziya Gökalp";
                btnD.Text = "Ömer Seyfettin";
                lbl01.Text = "Halide Edip Adıvar";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Aşağıda Verilen İlk Çağ Uygarlıklarından Hangisi Yazıyı İcat Etmiştir?";
                btnA.Text = "Hititler ";
                btnB.Text = "Elamlar ";
                btnC.Text = "Sümerler ";
                btnD.Text = "Urartular";
                lbl01.Text = "Sümerler";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Tsunami Felaketinde En Fazla Zarar Gören Güney Asya Ülkesi Aşağıdakilerden Hangisidir?";
                btnA.Text = "Endonezya";
                btnB.Text = "Srilanka ";
                btnC.Text = "Tayland ";
                btnD.Text = "Hindistan";
                lbl01.Text = "Endonezya";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = " 2003 Yılında Euro Vizyon Şarkı Yarışmasında Ülkemizi Temsil Eden ve Yarışmada Birinci Gelen Sanatçımız Kimdir?";
                btnA.Text = "Grup Athena";
                btnB.Text = "Sertap Erener";
                btnC.Text = "Şebnem Paker";
                btnD.Text = "Ajda Pekkan";
                lbl01.Text = "Sertap Erener";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Mustafa Kemal Atatürk’ün Nüfusa Kayıtlı Olduğu İl Hangisidir?";
                btnA.Text = "Bursa";
                btnB.Text = "Ankara";
                btnC.Text = "İstanbul";
                btnD.Text = "Gaziantep";
                lbl01.Text = "Gaziantep";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Aşağıdakilerden Hangisi Dünya Sağlık Örgütünün Kısaltılmış İsmidir?";
                btnA.Text = "Uhw";
                btnB.Text = "Unıcef";
                btnC.Text = "Who";
                btnD.Text = "Nato";
                lbl01.Text = "Who";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Romen Rakamında Hangi Sayı Yoktur?";
                btnA.Text = "0";
                btnB.Text = "50";
                btnC.Text = "100";
                btnD.Text = "1000";
                lbl01.Text = "0";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Bir Gün Kaç Saniyedir?";
                btnA.Text = "86000";
                btnB.Text = "88600";
                btnC.Text = "86400";
                btnD.Text = "84800";
                lbl01.Text = "86400";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Üç Büyük Dince Kutsal Sayılan Şehir Hangisidir?";
                btnA.Text = "Mekke";
                btnB.Text = "Kudüs";
                btnC.Text = "Roma";
                btnD.Text = "İstanbul";
                lbl01.Text = "Kudüs";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Hangi İlimizde Demiryolu Yoktur?";
                btnA.Text = "Batman";
                btnB.Text = "Kütahya";
                btnC.Text = "Aydın";
                btnD.Text = "Muğla";
                lbl01.Text = "Muğla";
                btnsonraki.Text = "Bitir";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (soruno == 1)
            {
                richTextBox1.Text = "'Sinekli Bakkal' Romanının Yazarı Aşağıdakilerden Hangisidir?";
                btnA.Text = "Reşat Nuri Güntekin";
                btnB.Text = "Halide Edip Adıvar";
                btnC.Text = "Ziya Gökalp";
                btnD.Text = "Ömer Seyfettin";
                lbl01.Text = "Halide Edip Adıvar";
            }
        }
    }
}
