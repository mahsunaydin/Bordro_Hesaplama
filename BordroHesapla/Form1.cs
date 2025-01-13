using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.NetworkInformation;
using System.Linq.Expressions;
using System.Security.Policy;

namespace BordroHesapla
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string osAdi = Environment.UserName.ToUpper();
        int ay = DateTime.Now.Month;
        string yilAy = DateTime.Now.Year.ToString() + " " + DateTime.Now.ToString("MMMM");

        /*string tarih = Convert.ToDateTime(
                       ((DateTime.Now.Day).ToString()).PadLeft(2, '0')
                        + "." +
                       ((DateTime.Now.Month).ToString()).PadLeft(2, '0')
                        + "." +
                       DateTime.Now.Year.ToString()
                       ).ToString("MMMM");*/



        private void Form1_Load(object sender, EventArgs e)
        {
            label14.Text = osAdi.Replace("İ", "I").Replace("Ü", "U").Replace("Ö", "O").Replace("Ğ", "G").Replace("Ş", "S").Replace("Ç", "C").Replace(".", " ");
            label13.Text = yilAy.ToUpper();
            comboBox1.Text = "%15";
            textBox1.Select();

            textBox6.Text = string.Format("{0:C}", 0).ToString();
            textBox7.Text = string.Format("{0:C}", 0).ToString();
            textBox8.Text = string.Format("{0:C}", 0).ToString();
            textBox9.Text = string.Format("{0:C}", 0).ToString();
            textBox10.Text = string.Format("{0:C}", 0).ToString();
            textBox11.Text = string.Format("{0:C}", 0).ToString();
            textBox12.Text = string.Format("{0:C}", 0).ToString();
            textBox16.Text = string.Format("{0:C}", 0).ToString();
            textBox17.Text = string.Format("{0:C}", 0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e) //temizle butonu
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Text = string.Format("{0:C}", 0).ToString();
            textBox7.Text = string.Format("{0:C}", 0).ToString();
            textBox8.Text = string.Format("{0:C}", 0).ToString();
            textBox9.Text = string.Format("{0:C}", 0).ToString();
            textBox10.Text = string.Format("{0:C}", 0).ToString();
            textBox11.Text = string.Format("{0:C}", 0).ToString();
            textBox12.Text = string.Format("{0:C}", 0).ToString();
            textBox13.Text = string.Format("{0:C}", 0).ToString();
            textBox1.Focus();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                try
                {
                    ay = ay - 1;

                    label13.Text = DateTime.Now.Year + " " + Convert.ToDateTime(
                           ((DateTime.Now.Day).ToString()).PadLeft(2, '0')
                            + "." +
                           ((DateTime.Now.Month - 1).ToString()).PadLeft(2, '0')
                            + "." +
                           DateTime.Now.Year.ToString()
                           ).ToString("MMMM").ToUpper();
                }
                catch (Exception)
                {

                }

            }
            else
            {
                ay = DateTime.Now.Month;

                label13.Text = DateTime.Now.Year + " " + Convert.ToDateTime(
                       ((DateTime.Now.Day).ToString()).PadLeft(2, '0')
                        + "." +
                       ((DateTime.Now.Month).ToString()).PadLeft(2, '0')
                        + "." +
                       DateTime.Now.Year.ToString()
                       ).ToString("MMMM").ToUpper();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // brüt ücretleri gizleme
        {
            if (checkBox1.Checked)
            {
                textBox1.UseSystemPasswordChar = true;
                textBox6.UseSystemPasswordChar = true;
                textBox13.UseSystemPasswordChar = true;
            }
            else
            {
                textBox1.UseSystemPasswordChar = false;
                textBox6.UseSystemPasswordChar = false;
                textBox13.UseSystemPasswordChar = false;
            }
        }

        //hesaplama değişkenleri
        Decimal brut_ucret;
        Decimal brut_asgari_ucret = 20002.5m;
        Decimal toplamBrutUcret;
        Decimal yuzdeElliMesaiSaat;
        Decimal yuzdeYuzMesaiSaat;
        Decimal yuzdeElliMesaiUcret;
        Decimal yuzdeYuzMesaiUcret;
        Decimal yolUcreti;
        Decimal ekBrutOdeme;
        Decimal gelirVergisiOrani;
        Decimal ozelKesinti;
        Decimal ekGelirGiris;
        Decimal gvMuafiyeti;
        Decimal dvMuafiyeti;
        Decimal aylik_tavan_ucret = 150018.9m;


        //sonuç değişkenleri
        Decimal sigortaPrimiIsciPayi;
        Decimal issizlikSigortasiIsciPayi;
        Decimal gelirVergisi;
        Decimal gelirVergisiMatrahi;
        Decimal damgaVergisi;
        Decimal toplamKesinti;
        Decimal netUcret;

        private void button1_Click(object sender, EventArgs e) //hesapla butonu
        {
            try
            {
                //kontroller
                //parametre kontrolleri

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Brüt Ücreti Girmelisiniz");
                    return;
                }

                if (comboBox1.Text == string.Empty)
                {
                    MessageBox.Show("Gelir Vergisi Oranı Seçmelisiniz");
                    return;
                }

                if (textBox2.Text == "")
                {
                    textBox2.Text = "0";
                    yuzdeElliMesaiUcret = 0;
                }

                if (textBox3.Text == "")
                {
                    textBox3.Text = "0";
                    yuzdeYuzMesaiUcret = 0;
                }

                if (textBox4.Text == "")
                {
                    ozelKesinti = 0;
                    textBox4.Text = "0";
                }

                if (textBox5.Text == "")
                {
                    ekGelirGiris = 0;
                    textBox5.Text = "0";
                }

                if (textBox14.Text == "")
                {
                    ekGelirGiris = 0;
                    textBox14.Text = "0";
                }

                if (textBox15.Text == "")
                {
                    ekGelirGiris = 0;
                    textBox15.Text = "0";
                }

                //hesaplamanın yapıldığı aya yani o an ki sistem tarih değerine göre gelir vergisi muafiyetinin işlenmesi

                brut_ucret = Convert.ToDecimal(textBox1.Text);

                if (brut_ucret >= brut_asgari_ucret)
                {
                    if (ay <= 6)
                    {
                        gvMuafiyeti = 2550.32m;
                    }
                    else if (ay == 7)
                    {
                        gvMuafiyeti = 3001.06m;
                    }
                    else if (ay >= 8)
                    {
                        gvMuafiyeti = 3400.43m;
                    }

                    if (ay <= 6)
                    {
                        dvMuafiyeti = 151.8190m;
                    }
                    else
                    {
                        dvMuafiyeti = 151.8190m;
                    }

                    textBox17.Text = string.Format("{0:C}", gvMuafiyeti).ToString();
                    textBox16.Text = string.Format("{0:C}", dvMuafiyeti).ToString();
                }



                // olası hataların kontrolleri yapıldıktan sonra hesaplama aşamasına geçiş



                if (brut_ucret < brut_asgari_ucret)
                {

                    //textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox6.Text = string.Format("{0:C}", 0).ToString();
                    textBox7.Text = string.Format("{0:C}", 0).ToString();
                    textBox8.Text = string.Format("{0:C}", 0).ToString();
                    textBox9.Text = string.Format("{0:C}", 0).ToString();
                    textBox10.Text = string.Format("{0:C}", 0).ToString();
                    textBox11.Text = string.Format("{0:C}", 0).ToString();
                    textBox12.Text = string.Format("{0:C}", 0).ToString();
                    textBox13.Text = string.Format("{0:C}", 0).ToString();
                    textBox1.Focus();


                    //MessageBox.Show("Girmiş Olduğunuz Brüt Ücret Asgari Ücretin Brüt Değerinden Düşük Olduğu İçin Hesaplama Yapılamamıştır");
                    return;
                }

                yuzdeElliMesaiSaat = Convert.ToDecimal(textBox2.Text);
                yuzdeYuzMesaiSaat = Convert.ToDecimal(textBox3.Text);

                yuzdeElliMesaiUcret = Math.Round(((brut_ucret / 225m) * 1.5m) * yuzdeElliMesaiSaat, 2);
                yuzdeYuzMesaiUcret = Math.Round(((brut_ucret / 225) * 2) * yuzdeYuzMesaiSaat, 2);

                yolUcreti = Convert.ToDecimal(textBox14.Text);
                ekBrutOdeme = Convert.ToDecimal(textBox15.Text);

                toplamBrutUcret = brut_ucret + yuzdeElliMesaiUcret + yuzdeYuzMesaiUcret + yolUcreti + ekBrutOdeme;

                ozelKesinti = Convert.ToDecimal(textBox4.Text);
                ekGelirGiris = Convert.ToDecimal(textBox5.Text);

                if (comboBox1.Text == "%15") { gelirVergisiOrani = 0.15m; }
                else if (comboBox1.Text == "%20") { gelirVergisiOrani = 0.20m; }
                else if (comboBox1.Text == "%27") { gelirVergisiOrani = 0.27m; }
                else if (comboBox1.Text == "%35") { gelirVergisiOrani = 0.35m; }
                else if (comboBox1.Text == "%40") { gelirVergisiOrani = 0.40m; }



                if (toplamBrutUcret < aylik_tavan_ucret)
                {

                    sigortaPrimiIsciPayi = Math.Round(toplamBrutUcret * 0.14m, 2);
                    textBox7.Text = string.Format("{0:C}", sigortaPrimiIsciPayi).ToString();

                    issizlikSigortasiIsciPayi = Math.Round(toplamBrutUcret * 0.01m, 2);
                    textBox8.Text = string.Format("{0:C}", issizlikSigortasiIsciPayi).ToString();

                }
                else
                {

                    sigortaPrimiIsciPayi = Math.Round(aylik_tavan_ucret * 0.14m, 2); //75060 eskisi
                    textBox7.Text = string.Format("{0:C}", sigortaPrimiIsciPayi).ToString();

                    issizlikSigortasiIsciPayi = Math.Round(aylik_tavan_ucret * 0.01m, 2); //75060 eskisi
                    textBox8.Text = string.Format("{0:C}", issizlikSigortasiIsciPayi).ToString();

                }

                // Matrah hesaplaması sigorta primi işçi payı ve işsizlik sigortası işçi payının toplamının brüt ücretten  -
                // çıkarılması ile elde edilir

                gelirVergisiMatrahi = Math.Round(toplamBrutUcret - (sigortaPrimiIsciPayi + issizlikSigortasiIsciPayi), 2);
                textBox12.Text = string.Format("{0:C}", gelirVergisiMatrahi).ToString();


                //gelir vergisi hesaplama
                if (toplamBrutUcret >= brut_asgari_ucret)
                {
                    if (gelirVergisiMatrahi < 110001) //0,15
                    {
                        gelirVergisi = Math.Round((gelirVergisiMatrahi * gelirVergisiOrani) - gvMuafiyeti, 2);
                        textBox9.Text = string.Format("{0:C}", gelirVergisi).ToString();
                    }
                    else if (gelirVergisiMatrahi > 110000 && gelirVergisiMatrahi < 230001) //0,20
                    {
                        gelirVergisi = Math.Round((((gelirVergisiMatrahi - 110000) * 0.20m) + 16500) - gvMuafiyeti, 2);
                        textBox9.Text = string.Format("{0:C}", gelirVergisi).ToString();
                    }
                    else if (gelirVergisiMatrahi > 230000 && gelirVergisiMatrahi < 580001) //0,27
                    {
                        gelirVergisi = Math.Round((((gelirVergisiMatrahi - 230000) * 0.27m) + 40500) - gvMuafiyeti, 2);
                        textBox9.Text = string.Format("{0:C}", gelirVergisi).ToString();
                    }
                    else if (gelirVergisiMatrahi > 580000 && gelirVergisiMatrahi < 3000001) //0,35
                    {
                        gelirVergisi = Math.Round((((gelirVergisiMatrahi - 580000) * 0.35m) + 135000) - gvMuafiyeti, 2);
                        textBox9.Text = string.Format("{0:C}", gelirVergisi).ToString();
                    }
                    else if (gelirVergisiMatrahi > 3000000) //0,40
                    {
                        gelirVergisi = Math.Round((((gelirVergisiMatrahi - 3000000) * 0.40m) + 982000) - gvMuafiyeti, 2);
                        textBox9.Text = string.Format("{0:C}", gelirVergisi).ToString();
                    }
                }

                else
                {
                    gelirVergisi = 0;
                    textBox9.Text = string.Format("{0:C}", gelirVergisi).ToString();
                }

                damgaVergisi = Math.Round((toplamBrutUcret * 0.00759m) - dvMuafiyeti, 2);
                textBox10.Text = string.Format("{0:C}", damgaVergisi).ToString();

                toplamKesinti = Math.Round(sigortaPrimiIsciPayi + issizlikSigortasiIsciPayi + gelirVergisi + damgaVergisi, 2);
                textBox11.Text = string.Format("{0:C}", toplamKesinti).ToString();

                textBox13.Text = string.Format("{0:C}", toplamBrutUcret).ToString();

                netUcret = Math.Round((toplamBrutUcret - toplamKesinti - ozelKesinti) + ekGelirGiris, 3);
                textBox6.Text = string.Format("{0:C}", netUcret).ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen değerleri doğru formatta giriniz!");
            }

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; // gelir vergisi comboBox'ı üzerinde klavyenin kontrolünün devre dışı bırakılması
        }

        private void btnYillikHesapla_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
            frm3.txtBrut1.Select();

            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToDecimal(textBox1.Text) >= brut_asgari_ucret)
                {
                    button1_Click(sender, e);
                }
                else if (textBox1.Text == "" || Convert.ToDecimal(textBox1.Text) < brut_asgari_ucret)
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox14.Text = "";
                    textBox15.Text = "";
                    textBox6.Text = string.Format("{0:C}", 0).ToString();
                    textBox7.Text = string.Format("{0:C}", 0).ToString();
                    textBox8.Text = string.Format("{0:C}", 0).ToString();
                    textBox9.Text = string.Format("{0:C}", 0).ToString();
                    textBox10.Text = string.Format("{0:C}", 0).ToString();
                    textBox11.Text = string.Format("{0:C}", 0).ToString();
                    textBox12.Text = string.Format("{0:C}", 0).ToString();
                    textBox13.Text = string.Format("{0:C}", 0).ToString();
                    textBox16.Text = string.Format("{0:C}", 0).ToString();
                    textBox17.Text = string.Format("{0:C}", 0).ToString();
                    textBox1.Focus();
                }
            }
            catch { }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "" && Convert.ToDecimal(textBox1.Text) >= brut_asgari_ucret)
                {
                    button1_Click(sender, e);
                }
                else if (textBox1.Text == "" || Convert.ToDecimal(textBox1.Text) < brut_asgari_ucret)
                {
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = string.Format("{0:C}", 0).ToString();
                    textBox7.Text = string.Format("{0:C}", 0).ToString();
                    textBox8.Text = string.Format("{0:C}", 0).ToString();
                    textBox9.Text = string.Format("{0:C}", 0).ToString();
                    textBox10.Text = string.Format("{0:C}", 0).ToString();
                    textBox11.Text = string.Format("{0:C}", 0).ToString();
                    textBox12.Text = string.Format("{0:C}", 0).ToString();
                    textBox13.Text = string.Format("{0:C}", 0).ToString();
                    textBox1.Focus();
                }
            }
            catch { }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
