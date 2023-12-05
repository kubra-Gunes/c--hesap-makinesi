using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
              if (sayi1 == 0)

                { lblSayi1.Text += "1"; }
                else
                { lblSayi2.Text += "1"; }

        }        namespace _hesapmakinesi
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
            double sayi1 = 0;
            double sayi2 = 0;
            string islem;
            double sonuc;
            double max;//ekokta kullanmak için



            private void btn1_Click(object sender, EventArgs e)//1 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "1"; }
                else
                { lblSayi2.Text += "1"; }
            }


            private void btn2_Click(object sender, EventArgs e)//2 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "2"; }
                else
                { lblSayi2.Text += "2"; }
            }

            private void btn3_Click(object sender, EventArgs e)//3 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "3"; }
                else
                { lblSayi2.Text += "3"; }
            }

            private void btn4_Click(object sender, EventArgs e)//4 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "4"; }
                else
                { lblSayi2.Text += "4"; }
            }

            private void btn5_Click(object sender, EventArgs e)//5 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "5"; }
                else
                { lblSayi2.Text += "5"; }

            }

            private void btn6_Click(object sender, EventArgs e)//6 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "6"; }
                else
                { lblSayi2.Text += "6"; }
            }

            private void btn7_Click(object sender, EventArgs e)//7 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "7"; }
                else
                { lblSayi2.Text += "7"; }
            }

            private void btn8_Click(object sender, EventArgs e)//8 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "8"; }
                else
                { lblSayi2.Text += "8"; }

            }

            private void btn9_Click(object sender, EventArgs e)//9 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "9"; }
                else
                {

                    lblSayi2.Text += "9";
                }
            }

            private void btn0_Click(object sender, EventArgs e)//0 rakamını yazdırmak 
            {
                if (sayi1 == 0)

                { lblSayi1.Text += "0"; }
                else
                {

                    lblSayi2.Text += "0";
                }
            }
            private void btnToplama_Click(object sender, EventArgs e)//toplama
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text, CultureInfo.InvariantCulture);
                lblİslem.Text = "+";
                islem = "+";

            }



            private void btnCıkarma_Click(object sender, EventArgs e)//çıkarma
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "-";
                islem = "-";


            }

            private void btnBolme_Click(object sender, EventArgs e)//bölme
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "/";
                islem = "/";


            }

            private void btnCarpma_Click(object sender, EventArgs e)//çarpma
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "x";
                islem = "*";

            }
            private void btnKök_Click(object sender, EventArgs e)//karekök alma
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "√";
                islem = "√";
                MessageBox.Show("doğru sonuç elde etmek için 2.sayını yerine 1 sayısını giriniz");
            }
            private void btnPOW_Click(object sender, EventArgs e)//üs alma
            {

                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "^";
                islem = "^";

            }
            private void btnEBOB_Click(object sender, EventArgs e)//ebob bulma
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "ebob";
                islem = "ebob";
            }
            private void btnEKOK_Click(object sender, EventArgs e)//ekok bulma
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "ekok";
                islem = "ekok";
            }
            private void btnMOD_Click(object sender, EventArgs e)//mod alma
            {
                sayi1 = Convert.ToDouble(lblSayi1.Text);
                lblİslem.Text = "%";
                islem = "%";
            }
            private void btnEsittir_Click(object sender, EventArgs e)//hesaplama
            {
                sayi2 = Convert.ToDouble(lblSayi2.Text);
                if (islem == "-")//çıkarma
                {
                    sonuc = sayi1 - sayi2;
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);

                }
                if (islem == "+")//toplama
                {
                    sonuc = sayi1 + sayi2;
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "/")//bölme
                {
                    sonuc = sayi1 / sayi2;
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "*")//çarpma
                {
                    sonuc = sayi1 * sayi2;
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "√")//karekök

                {
                    sayi2 = 1;
                    sonuc = Math.Sqrt(sayi1) * sayi2;
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "^")//üs alma

                {

                    sonuc = Math.Pow(sayi1, sayi2);
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "ebob")//ebob

                {

                    for (int i = 1; i < sayi1; i++)
                    {
                        if (sayi1 % i == 0 && sayi2 % i == 0)
                        {
                            sonuc = i;

                        }
                        lblSonuc.Text = sonuc.ToString();

                    }
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "ekok")//ekok
                    max = sayi1 * sayi2;
                {
                    for (double i = max; i > 0; i--)
                    {
                        if (i % sayi1 == 0 && i % sayi2 == 0)
                        {
                            sonuc = i;
                        }
                        lblSonuc.Text = sonuc.ToString();
                    }
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
                if (islem == "%")//mod alma

                {

                    sonuc = (sayi1 % sayi2);
                    lblSonuc.Text = sonuc.ToString();
                    listGecmısIslemler.Items.Add(lblSayi1.Text + lblİslem.Text + lblSayi2.Text + "=" + lblSonuc.Text);
                }
            }

            private void btnTers_Click(object sender, EventArgs e)//sayının tersini alma
            {
                if (lblSayi1.Text != "" && lblİslem.Text == "")
                {
                    sayi1 = -Convert.ToDouble(lblSayi1.Text);
                    lblSayi1.Text = sayi1.ToString();

                }

                if (lblSayi1.Text != "" && lblİslem.Text != "")
                {
                    sayi2 = -Convert.ToDouble(lblSayi2.Text);
                    lblSayi2.Text = sayi2.ToString();

                }
            }


            private void btnVirgül_Click(object sender, EventArgs e)//ondalıklı sayı için virgül butonu
            {
                if (lblSayi1.Text != "" && lblİslem.Text == "")
                {

                    if (!lblSayi1.Text.Contains("."))
                    {
                        lblSayi1.Text += ".";
                    }

                }

                if (lblİslem.Text != "")
                {
                    if (!lblSayi2.Text.Contains("."))
                    {
                        lblSayi2.Text += ".";
                    }

                }
            }

            private void btnC_Click_1(object sender, EventArgs e)//tüm labelları temizleme
            {
                lblSayi1.Text = "";
                sayi1 = 0;
                lblSayi2.Text = "";
                lblİslem.Text = "";
                lblSonuc.Text = "";
            }

            private void btnGecmis_Click_1(object sender, EventArgs e)// geçmişi açma
            {
                listGecmısIslemler.Visible = true;

            }
            private void btnCE_Click(object sender, EventArgs e)//bulunulan labelı temizleme
            {
                if (lblSayi1.Text != "" && lblİslem.Text == "")
                {
                    lblSayi1.Text = "";

                }
                else if (lblİslem.Text != "" && lblSayi2.Text == "")
                {
                    lblİslem.Text = "";
                }
                else
                {
                    lblSayi2.Text = "";
                }

            }
            private void btnDelete_Click(object sender, EventArgs e)//bulunulan labeldan karakter silme
            {


                if (lblİslem.Text == "")
                {
                    if (!string.IsNullOrEmpty(lblSayi1.Text))
                    {
                        lblSayi1.Text = lblSayi1.Text.Substring(0, lblSayi1.Text.Length - 1);
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(lblSayi2.Text))
                    {
                        lblSayi2.Text = lblSayi2.Text.Substring(0, lblSayi2.Text.Length - 1);
                    }
                    else
                    {
                        lblİslem.Text = "";
                    }
                }


            }

            private void btnTemizlik_Click(object sender, EventArgs e)//geçmişi temizleme
            {
                listGecmısIslemler.Items.Clear();
            }


        }
    }
}
}
