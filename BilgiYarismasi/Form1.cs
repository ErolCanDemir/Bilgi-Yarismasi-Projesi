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

        int soruno = 0,dogru = 0,yanlis=0;
        int puan = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnB.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                puan = puan + 10;
                lblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                puan = puan + 10;
                lblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                puan = puan + 10;
                lblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSonraki.Enabled = true;
            label5.Text = btnA.Text;
            if(label4.Text==label5.Text)
            {
                dogru++;
                puan = puan + 10;
                lblDoğru.Text = dogru.ToString();
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                lblYanlis.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void btnSonraki_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSonraki.Enabled = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            soruno++;
            lblSoruno.Text = soruno.ToString();
            if(soruno ==1)
            {
                richTextBox1.Text = "Cumhuriyet Kaç Yılında İlan Edilmiştir?";
                btnA.Text = "1920";
                btnB.Text = "1921";
                btnC.Text = "1922";
                btnD.Text = "1923";
                label4.Text = "1923";
            }
            if(soruno==2)
            {
                richTextBox1.Text = "Hangi İl Ege Bölgemizde Bulunmaz?";
                btnA.Text = "İzmir";
                btnB.Text = "Balıkesir";
                btnC.Text = "Aydın";
                btnD.Text = "Manisa";
                label4.Text = "Balıkesir";
            }
            if(soruno==3)
            {
                richTextBox1.Text = "Son Kuşlar Kitabı Hangi Yazara Aittir?";
                btnA.Text = "Sait Faik";
                btnB.Text = "Cemal Süreya";
                btnC.Text = "Atila İlhan";
                btnD.Text = "Reşat Nuri";
                label4.Text = "Sait Faik";
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Ülkemizin Başkenti Hangisidir?";
                btnA.Text = "İstanbul";
                btnB.Text = "Ankara";
                btnC.Text = "İzmir";
                btnD.Text = "Konya";
                label4.Text = "Ankara";
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Aşağıdakilerden hangisi temel programlama dilleri arasında yer alır?";
                btnA.Text = "C#";
                btnB.Text = "JAVA";
                btnC.Text = "C";
                btnD.Text = "Assembly";
                label4.Text = "Assembly";
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Bir futbol karşılasmasında oynanan topun resmi kurallara göre ağırlığı ne kadar olmalıdır?";
                btnA.Text = "448 gram";
                btnB.Text = "450 gram";
                btnC.Text = "452 gram";
                btnD.Text = "454 gram";
                label4.Text = "452 gram";
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Kurtuluş savaşında düzenli ordunun Batı Cephesindeki ilk zaferi hangisidir?";
                btnA.Text = "Eskişehir-Kütahya Savaşı";
                btnB.Text = "1.İnönü";
                btnC.Text = "2.İnönü";
                btnD.Text = "Çanakkale Savaşı";
                label4.Text = "1.İnönü";
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Manda ve Himaye fikri ilk kez nerede reddedilmiştir?";
                btnA.Text = "Amasya Genelgesi";
                btnB.Text = "Sivas Kongresi";
                btnC.Text = "Erzurum Kongresi";
                btnD.Text = "TBMM";
                label4.Text = "Erzurum Kongresi";
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Maddenin ölçülemeyen özelliği hangisidir?";
                btnA.Text = "Ağırlık";
                btnB.Text = "Boy";
                btnC.Text = "En";
                btnD.Text = "Koku";
                label4.Text = "Koku";
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Çocuk hakları günü hangi gün kutlanmaktadır?";
                btnA.Text = "10 Eylül";
                btnB.Text = "20 Ekim";
                btnC.Text = "10 Kasım";
                btnD.Text = "20 Kasım";
                label4.Text = "20 Kasım";
                btnSonraki.Text = "Sonuçlar";
            }
            if (soruno==11)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSonraki.Enabled = false;
                MessageBox.Show("Doğru:" + dogru + "\n" + "Yanlış:" + yanlis + "\n" + "Puan:" + puan);
            }
        }
    }
}