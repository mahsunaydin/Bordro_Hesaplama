using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BordroHesapla
{
    public partial class Form2 : System.Windows.Forms.Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //ayların dağılımı yapılacak değişkenler
        double ocak;
        double subat;
        double mart;
        double nisan;
        double mayis;
        double haziran;
        double temmuz;
        double agustos;
        double eylul;
        double ekim;
        double kasim;
        double aralik;

        //hesaplama değişkenleri
        double brut_ucret;
        double gelirVergisiOrani;
        double ozelKesinti;
        double ekGelirGiris;
        double gvMuafiyeti;
        double dvMuafiyeti = 75.9607;
        double dvMuafiyeti1 = 101.8161;


        //sonuç değişkenleri
        double sigortaPrimiIsciPayi;
        double issizlikSigortasiIsciPayi;
        double gelirVergisi;
        double gelirVergisiMatrahi;
        double gvMatrahi2, gvMatrahi3, gvMatrahi4, gvMatrahi5, gvMatrahi6, gvMatrahi7, gvMatrahi8, gvMatrahi9, gvMatrahi10, gvMatrahi11, gvMatrahi12;
        double ocakMatrahKumulatif, subatMatrahKumulatif, martMatrahKumulatif, nisanMatrahKumulatif, mayisMatrahKumulatif, haziranMatrahKumulatif, temmuzMatrahKumulatif, agustosMatrahKumulatif, eylulMatrahKumulatif, ekimMatrahKumulatif, kasimMatrahKumulatif, aralikMatrahKumulatif;
        double damgaVergisi;
        double damgaVergisi1;
        double toplamKesinti;

        //aylara göre gelir vergisi değişkenleri
        double ocakGelirVergisi;
        double subatGelirVergisi;
        double martGelirVergisi;
        double nisanGelirVergisi;
        double mayisGelirVergisi;
        double haziranGelirVergisi;

        double temmuzGelirVergisi;

        double agustosGelirVergisi;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && Convert.ToDouble(textBox1.Text) >= 13414)
            {
                button1_Click(sender, e);
            }
            else if (textBox1.Text == "" || Convert.ToDouble(textBox1.Text) < 13414)
            {
                textBox2.Text = "₺0";
                textBox3.Text = "₺0";
                textBox4.Text = "₺0";
                textBox5.Text = "₺0";
                textBox6.Text = "₺0";
                textBox7.Text = "₺0";
                textBox8.Text = "₺0";
                textBox9.Text = "₺0";
                textBox10.Text = "₺0";
                textBox11.Text = "₺0";
                textBox12.Text = "₺0";
                textBox13.Text = "₺0";
                textBox1.Focus();
            }
        }

        double eylulGelirVergisi;
        double ekimGelirVergisi;
        double kasimGelirVergisi;
        double aralikGelirVergisi;

        //aylara göre net ücret değişkenleri
        double netUcretOcak;
        double netUcretSubat;
        double netUcretMart;
        double netUcretNisan;
        double netUcretMayis;
        double netUcretHaziran;
        double netUcretTemmuz;
        double netUcretAgustos;
        double netUcretEylul;
        double netUcretEkim;
        double netUcretKasim;
        double netUcretAralik;

        private void button1_Click(object sender, EventArgs e)
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




                /* //hesaplamanın yapıldığı aya göre (o an ki system month değeri) gelir vergisi muafiyetinin işlenmesi
                 if (ay == 1 || ay == 2 || ay == 3 || ay == 4 || ay == 5 || ay == 6 || ay == 7 || ay == 8)
                 {
                     gvMuafiyeti = 1276.02;
                 }
                 else if (ay == 9)
                 {
                     gvMuafiyeti = 1604.08;
                 }
                 else
                 {
                     gvMuafiyeti = 1701.36;
                 }*/

                gvMuafiyeti = 1276.02;


                //hesaplamalar

                brut_ucret = Convert.ToDouble(textBox1.Text);

                if (brut_ucret < 10008)
                {

                    textBox2.Text = string.Format("{0:C}", 0).ToString();
                    textBox3.Text = string.Format("{0:C}", 0).ToString();
                    textBox4.Text = string.Format("{0:C}", 0).ToString();
                    textBox5.Text = string.Format("{0:C}", 0).ToString();
                    textBox6.Text = string.Format("{0:C}", 0).ToString();
                    textBox7.Text = string.Format("{0:C}", 0).ToString();
                    textBox8.Text = string.Format("{0:C}", 0).ToString();
                    textBox9.Text = string.Format("{0:C}", 0).ToString();
                    textBox10.Text = string.Format("{0:C}", 0).ToString();
                    textBox11.Text = string.Format("{0:C}", 0).ToString();
                    textBox12.Text = string.Format("{0:C}", 0).ToString();
                    textBox13.Text = string.Format("{0:C}", 0).ToString();
                    textBox1.Focus();


                    MessageBox.Show("Girmiş Olduğunuz Brüt Ücret Asgari Ücretin Brüt Değerinden Düşük Olduğu İçin Hesaplama Yapılamamıştır");
                    return;
                }


                gelirVergisiOrani = 0.15;


                if (brut_ucret < 75061) // 75.060 da dahil olacak şekilde hesaplama yapılıyor
                {
                    sigortaPrimiIsciPayi = brut_ucret * 0.14;
                    issizlikSigortasiIsciPayi = brut_ucret * 0.01;
                }

                else // tavan ücreti olan 75.060 üzeinden hesaplama yapılıyor
                {
                    sigortaPrimiIsciPayi = 75060 * 0.14;
                    issizlikSigortasiIsciPayi = 75060 * 0.01;
                }


                gelirVergisiMatrahi = brut_ucret - (sigortaPrimiIsciPayi + issizlikSigortasiIsciPayi);

                ocakMatrahKumulatif = gelirVergisiMatrahi;
                subatMatrahKumulatif = gelirVergisiMatrahi * 2;
                martMatrahKumulatif = gelirVergisiMatrahi * 3;
                nisanMatrahKumulatif = gelirVergisiMatrahi * 4;
                mayisMatrahKumulatif = gelirVergisiMatrahi * 5;
                haziranMatrahKumulatif = gelirVergisiMatrahi * 6;
                temmuzMatrahKumulatif = gelirVergisiMatrahi * 7;
                agustosMatrahKumulatif = gelirVergisiMatrahi * 8;
                eylulMatrahKumulatif = gelirVergisiMatrahi * 9;
                ekimMatrahKumulatif = gelirVergisiMatrahi * 10;
                kasimMatrahKumulatif = gelirVergisiMatrahi * 11;
                aralikMatrahKumulatif = gelirVergisiMatrahi * 12;

                bool ilkYirmi, ilkYirmiYedi, ilkOtuzBes, İlkKikrk = false;

                
                //ocak ayı gelir vegisi hesaplaması
                //

                if (ocakMatrahKumulatif < 70001 )
                {
                    ocakGelirVergisi = (ocakMatrahKumulatif * 0.15) - 1276.02;
                }
                else if (ocakMatrahKumulatif > 70000 && ocakMatrahKumulatif < 150001)
                {
                    ocakGelirVergisi = (((ocakMatrahKumulatif - 70000) * 0.20) + 10500) - 1276.02; // 15+20
                }
                else if (ocakMatrahKumulatif > 150000 && ocakMatrahKumulatif < 550001)
                {
                    ocakGelirVergisi = (((ocakMatrahKumulatif - 150000) * 0.27) + 26500) - 1276.02; //20+27
                }
                else if (ocakMatrahKumulatif > 550000 && ocakMatrahKumulatif < 1900001)
                {
                    ocakGelirVergisi = (((ocakMatrahKumulatif - 550000) * 0.35 ) + 134500) - 1276.02; //27+35
                }
                else if (ocakMatrahKumulatif > 1900000)
                {
                    ocakGelirVergisi = (((ocakMatrahKumulatif - 1900000) * 0.40 ) + 607000) - 1276.02; //35+40
                }


                //subat ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */

                if (subatMatrahKumulatif < 70001)
                {
                    subatGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1276.02;
                }

                else if (subatMatrahKumulatif > 70000 && subatMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (ocakMatrahKumulatif < 70001)
                    {
                        subatGelirVergisi = ((70000 - ocakMatrahKumulatif) * 0.15) + ((subatMatrahKumulatif - 70000) * 0.20) - 1276.02;
                    }
                    else
                    {
                        ilkYirmi = true;
                        subatGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1276.02;

                    }
                }

                else if (subatMatrahKumulatif > 150000 && subatMatrahKumulatif < 550001)
                {
                    if (ocakMatrahKumulatif < 150001)
                    {
                        subatGelirVergisi = ((150000 - ocakMatrahKumulatif) * 0.20) + ((subatMatrahKumulatif - 150000) * 0.27) - 1276.02;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        subatGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1276.02;

                    }
                }

                else if (subatMatrahKumulatif > 550000 && subatMatrahKumulatif < 1900001)
                {
                    if (ocakMatrahKumulatif < 550001)
                    {
                        subatGelirVergisi = ((550000 - ocakMatrahKumulatif) * 0.27) + ((subatMatrahKumulatif - 550000) * 0.35) - 1276.02;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        subatGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1276.02;
                    }
                }

                else if (subatMatrahKumulatif > 1900000)
                {
                    if (ocakMatrahKumulatif < 1900001)
                    {
                        subatGelirVergisi = (((1900000 - ocakMatrahKumulatif) * 0.40) + 607000) - 1276.02;
                    }
                    else
                    {

                    }
                }

                //mart ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (martMatrahKumulatif < 70001)
                {
                    martGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1276.02;
                }
                else if (martMatrahKumulatif > 70000 && martMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (subatMatrahKumulatif < 70001)
                    {
                        martGelirVergisi = ((70000 - subatMatrahKumulatif) * 0.15) + ((martMatrahKumulatif - 70000) * 0.20) - 1276.02;
                    }
                    else
                    {
                        ilkYirmi = true;
                        martGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1276.02;
                    }
                }
                else if (martMatrahKumulatif > 150000 && martMatrahKumulatif < 550001)
                {
                    if (subatMatrahKumulatif < 150001)
                    {
                        martGelirVergisi = ((150000 - subatMatrahKumulatif) * 0.20) + ((martMatrahKumulatif - 150000) * 0.27) - 1276.02;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        martGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1276.02;

                    }
                }

                else if (martMatrahKumulatif > 550000 && martMatrahKumulatif < 1900001)
                {
                    if (subatMatrahKumulatif < 550001)
                    {
                        martGelirVergisi = ((550000 - subatMatrahKumulatif) * 0.27) + ((martMatrahKumulatif - 550000) * 0.35) - 1276.02;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        martGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1276.02;
                    }
                }

                else if (martMatrahKumulatif > 1900000)
                {
                    if (subatMatrahKumulatif < 1900001)
                    {
                        martGelirVergisi = (((1900000 - subatMatrahKumulatif) * 0.40) + 607000) - 1276.02;
                    }
                    else
                    {

                    }
                }


                //nisan ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (nisanMatrahKumulatif < 70001)
                {
                    nisanGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1276.02;
                }
                else if (nisanMatrahKumulatif > 70000 && nisanMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (martMatrahKumulatif < 70001)
                    {
                        nisanGelirVergisi = ((70000 - martMatrahKumulatif) * 0.15) + ((nisanMatrahKumulatif - 70000) * 0.20) - 1276.02;
                    }
                    else
                    {
                        ilkYirmi = true;
                        nisanGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1276.02;
                    }
                }
                else if (nisanMatrahKumulatif > 150000 && nisanMatrahKumulatif < 550001)
                {
                    if (martMatrahKumulatif < 150001)
                    {
                        nisanGelirVergisi = ((150000 - martMatrahKumulatif) * 0.20) + ((nisanMatrahKumulatif - 150000) * 0.27) - 1276.02;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        nisanGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1276.02;

                    }
                }

                else if (nisanMatrahKumulatif > 550000 && nisanMatrahKumulatif < 1900001)
                {
                    if (martMatrahKumulatif < 550001)
                    {
                        nisanGelirVergisi = ((550000 - martMatrahKumulatif) * 0.27) + ((nisanMatrahKumulatif - 550000) * 0.35) - 1276.02;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        nisanGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1276.02;
                    }
                }

                else if (nisanMatrahKumulatif > 1900000)
                {
                    if (martMatrahKumulatif < 1900001)
                    {
                        nisanGelirVergisi = (((1900000 - martMatrahKumulatif) * 0.40) + 607000) - 1276.02;
                    }
                    else
                    {

                    }
                }



                //mayıs ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (mayisMatrahKumulatif < 70001)
                {
                    mayisGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1276.02;
                }
                else if (mayisMatrahKumulatif > 70000 && mayisMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (nisanMatrahKumulatif < 70001)
                    {
                        mayisGelirVergisi = ((70000 - nisanMatrahKumulatif) * 0.15) + ((mayisMatrahKumulatif - 70000) * 0.20) - 1276.02;
                    }
                    else
                    {
                        ilkYirmi = true;
                        mayisGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1276.02;
                    }
                }
                else if (mayisMatrahKumulatif > 150000 && mayisMatrahKumulatif < 550001)
                {
                    if (nisanMatrahKumulatif < 150001)
                    {
                        mayisGelirVergisi = ((150000 - nisanMatrahKumulatif) * 0.20) + ((mayisMatrahKumulatif - 150000) * 0.27) - 1276.02;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        mayisGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1276.02;

                    }
                }

                else if (mayisMatrahKumulatif > 550000 && mayisMatrahKumulatif < 1900001)
                {
                    if (nisanMatrahKumulatif < 550001)
                    {
                        mayisGelirVergisi = ((550000 - nisanMatrahKumulatif) * 0.27) + ((mayisMatrahKumulatif - 550000) * 0.35) - 1276.02;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        mayisGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1276.02;
                    }
                }

                else if (mayisMatrahKumulatif > 1900000)
                {
                    if (nisanMatrahKumulatif < 1900001)
                    {
                        mayisGelirVergisi = (((1900000 - nisanMatrahKumulatif) * 0.40) + 607000) - 1276.02;
                    }
                    else
                    {

                    }
                }



                //haziran ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (haziranMatrahKumulatif < 70001)
                {
                    haziranGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1276.02;
                }
                else if (haziranMatrahKumulatif > 70000 && haziranMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (mayisMatrahKumulatif < 70001)
                    {
                        haziranGelirVergisi = ((70000 - mayisMatrahKumulatif) * 0.15) + ((haziranMatrahKumulatif - 70000) * 0.20) - 1276.02;
                    }
                    else
                    {
                        ilkYirmi = true;
                        haziranGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1276.02;
                    }
                }
                else if (haziranMatrahKumulatif > 150000 && haziranMatrahKumulatif < 550001)
                {
                    if (mayisMatrahKumulatif < 150001)
                    {
                        haziranGelirVergisi = ((150000 - mayisMatrahKumulatif) * 0.20) + ((haziranMatrahKumulatif - 150000) * 0.27) - 1276.02;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        haziranGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1276.02;

                    }
                }

                else if (haziranMatrahKumulatif > 550000 && haziranMatrahKumulatif < 1900001)
                {
                    if (mayisMatrahKumulatif < 550001)
                    {
                        haziranGelirVergisi = ((550000 - mayisMatrahKumulatif) * 0.27) + ((haziranMatrahKumulatif - 550000) * 0.35) - 1276.02;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        haziranGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1276.02;
                    }
                }

                else if (haziranMatrahKumulatif > 1900000)
                {
                    if (mayisMatrahKumulatif < 1900001)
                    {
                        haziranGelirVergisi = (((1900000 - mayisMatrahKumulatif) * 0.40) + 607000) - 1276.02;
                    }
                    else
                    {
                       
                    }
                }


                //temmuz ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (temmuzMatrahKumulatif < 70001)
                {
                    temmuzGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1710.35;
                }
                else if (temmuzMatrahKumulatif > 70000 && temmuzMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (haziranMatrahKumulatif < 70001)
                    {
                        temmuzGelirVergisi = ((70000 - haziranMatrahKumulatif) * 0.15) + ((temmuzMatrahKumulatif - 70000) * 0.20) - 1710.35;
                    }
                    else
                    {
                        ilkYirmi = true;
                        temmuzGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1710.35;
                    }
                }
                else if (temmuzMatrahKumulatif > 150000 && temmuzMatrahKumulatif < 550001)
                {
                    if (haziranMatrahKumulatif < 150001)
                    {
                        temmuzGelirVergisi = ((150000 - haziranMatrahKumulatif) * 0.20) + ((temmuzMatrahKumulatif - 150000) * 0.27) - 1710.35;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        temmuzGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1710.35;

                    }
                }

                else if (temmuzMatrahKumulatif > 550000 && temmuzMatrahKumulatif < 1900001)
                {
                    if (haziranMatrahKumulatif < 550001)
                    {
                        temmuzGelirVergisi = ((550000 - haziranMatrahKumulatif) * 0.27) + ((temmuzMatrahKumulatif - 550000) * 0.35) - 1710.35;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        temmuzGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1710.35;
                    }
                }

                else if (temmuzMatrahKumulatif > 1900000)
                {
                    if (haziranMatrahKumulatif < 1900001)
                    {
                        temmuzGelirVergisi = (((1900000 - haziranMatrahKumulatif) * 0.40) + 607000) - 1710.35;
                    }
                    else
                    {

                    }
                }

                //ağustos ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (agustosMatrahKumulatif < 70001)
                {
                    agustosGelirVergisi = (gelirVergisiMatrahi * 0.15) - 1902.62;
                }
                else if (agustosMatrahKumulatif > 70000 && agustosMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (temmuzMatrahKumulatif < 70001)
                    {
                        agustosMatrahKumulatif = ((70000 - temmuzMatrahKumulatif) * 0.15) + ((agustosMatrahKumulatif - 70000) * 0.20) - 1902.62;
                    }
                    else
                    {
                        ilkYirmi = true;
                        agustosGelirVergisi = (gelirVergisiMatrahi * 0.20) - 1902.62;
                    }
                }
                else if (agustosMatrahKumulatif > 150000 && agustosMatrahKumulatif < 550001)
                {
                    if (temmuzMatrahKumulatif < 150001)
                    {
                        agustosGelirVergisi = ((150000 - temmuzMatrahKumulatif) * 0.20) + ((agustosMatrahKumulatif - 150000) * 0.27) - 1902.62;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        agustosGelirVergisi = (gelirVergisiMatrahi * 0.27) - 1902.62;

                    }
                }

                else if (agustosMatrahKumulatif > 550000 && agustosMatrahKumulatif < 1900001)
                {
                    if (temmuzMatrahKumulatif < 550001)
                    {
                        agustosGelirVergisi = ((550000 - temmuzMatrahKumulatif) * 0.27) + ((agustosMatrahKumulatif - 550000) * 0.35) - 1902.62;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        agustosGelirVergisi = (gelirVergisiMatrahi * 0.35) - 1902.62;
                    }
                }

                else if (agustosMatrahKumulatif > 1900000)
                {
                    if (temmuzMatrahKumulatif < 1900001)
                    {
                        agustosGelirVergisi = (((1900000 - temmuzMatrahKumulatif) * 0.40) + 607000) - 1902.62;
                    }
                    else
                    {

                    }
                }



                //eylül ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (eylulMatrahKumulatif < 70001)
                {
                    eylulGelirVergisi = (gelirVergisiMatrahi * 0.15) - 2280.47;
                }
                else if (eylulMatrahKumulatif > 70000 && eylulMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (agustosMatrahKumulatif < 70001)
                    {
                        eylulGelirVergisi = ((70000 - agustosMatrahKumulatif) * 0.15) + ((eylulMatrahKumulatif - 70000) * 0.20) - 2280.47;
                    }
                    else
                    {
                        ilkYirmi = true;
                        eylulGelirVergisi = (gelirVergisiMatrahi * 0.20) - 2280.47;
                    }
                }
                else if (eylulMatrahKumulatif > 150000 && eylulMatrahKumulatif < 550001)
                {
                    if (agustosMatrahKumulatif < 150001)
                    {
                        eylulGelirVergisi = ((150000 - agustosMatrahKumulatif) * 0.20) + ((eylulMatrahKumulatif - 150000) * 0.27) - 2280.47;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        eylulGelirVergisi = (gelirVergisiMatrahi * 0.27) - 2280.47;

                    }
                }

                else if (eylulMatrahKumulatif > 550000 && eylulMatrahKumulatif < 1900001)
                {
                    if (agustosMatrahKumulatif < 550001)
                    {
                        eylulGelirVergisi = ((550000 - agustosMatrahKumulatif) * 0.27) + ((eylulMatrahKumulatif - 550000) * 0.35) - 2280.47;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        eylulMatrahKumulatif = (gelirVergisiMatrahi * 0.35) - 2280.47;
                    }
                }

                else if (eylulMatrahKumulatif > 1900000)
                {
                    if (agustosMatrahKumulatif < 1900001)
                    {
                        eylulGelirVergisi = (((1900000 - agustosMatrahKumulatif) * 0.40) + 607000) - 2280.47;
                    }
                    else
                    {

                    }
                }



                //ekim ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (ekimMatrahKumulatif < 70001)
                {
                    ekimGelirVergisi = (gelirVergisiMatrahi * 0.15) - 2280.47;
                }
                else if (ekimMatrahKumulatif > 70000 && ekimMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (eylulMatrahKumulatif < 70001)
                    {
                        ekimGelirVergisi = ((70000 - eylulMatrahKumulatif) * 0.15) + ((ekimMatrahKumulatif - 70000) * 0.20) - 2280.47;
                    }
                    else
                    {
                        ilkYirmi = true;
                        ekimGelirVergisi = (gelirVergisiMatrahi * 0.20) - 2280.47;
                    }
                }
                else if (ekimMatrahKumulatif > 150000 && ekimMatrahKumulatif < 550001)
                {
                    if (eylulMatrahKumulatif < 150001)
                    {
                        ekimGelirVergisi = ((150000 - eylulMatrahKumulatif) * 0.20) + ((ekimMatrahKumulatif - 150000) * 0.27) - 2280.47;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        ekimGelirVergisi = (gelirVergisiMatrahi * 0.27) - 2280.47;

                    }
                }

                else if (ekimMatrahKumulatif > 550000 && ekimMatrahKumulatif < 1900001)
                {
                    if (eylulMatrahKumulatif < 550001)
                    {
                        ekimGelirVergisi = ((550000 - eylulMatrahKumulatif) * 0.27) + ((ekimMatrahKumulatif - 550000) * 0.35) - 2280.47;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        ekimMatrahKumulatif = (gelirVergisiMatrahi * 0.35) - 2280.47;
                    }
                }

                else if (ekimMatrahKumulatif > 1900000)
                {
                    if (eylulMatrahKumulatif < 1900001)
                    {
                        ekimGelirVergisi = (((1900000 - eylulMatrahKumulatif) * 0.40) + 607000) - 2280.47;
                    }
                    else
                    {

                    }
                }



                //kasim ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (kasimMatrahKumulatif < 70001)
                {
                    kasimGelirVergisi = (gelirVergisiMatrahi * 0.15) - 2280.47;
                }
                else if (kasimMatrahKumulatif > 70000 && kasimMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (ekimMatrahKumulatif < 70001)
                    {
                        kasimGelirVergisi = ((70000 - ekimMatrahKumulatif) * 0.15) + ((kasimMatrahKumulatif - 70000) * 0.20) - 2280.47;
                    }
                    else
                    {
                        ilkYirmi = true;
                        kasimGelirVergisi = (gelirVergisiMatrahi * 0.20) - 2280.47;
                    }
                }
                else if (kasimMatrahKumulatif > 150000 && kasimMatrahKumulatif < 550001)
                {
                    if (ekimMatrahKumulatif < 150001)
                    {
                        kasimGelirVergisi = ((150000 - ekimMatrahKumulatif) * 0.20) + ((kasimMatrahKumulatif - 150000) * 0.27) - 2280.47;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        kasimGelirVergisi = (gelirVergisiMatrahi * 0.27) - 2280.47;

                    }
                }

                else if (kasimMatrahKumulatif > 550000 && kasimMatrahKumulatif < 1900001)
                {
                    if (ekimMatrahKumulatif < 550001)
                    {
                        kasimGelirVergisi = ((550000 - ekimMatrahKumulatif) * 0.27) + ((kasimMatrahKumulatif - 550000) * 0.35) - 2280.47;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        kasimGelirVergisi = (gelirVergisiMatrahi * 0.35) - 2280.47;
                    }
                }

                else if (kasimMatrahKumulatif > 1900000)
                {
                    if (ekimMatrahKumulatif < 1900001)
                    {
                        kasimGelirVergisi = (((1900000 - ekimMatrahKumulatif) * 0.40) + 607000) - 2280.47;
                    }
                    else
                    {

                    }
                }



                //aralik ayı gelir vergisi hesaplaması
                /* ****************************************************************************************************************************** */


                if (aralikMatrahKumulatif < 70001)
                {
                    aralikGelirVergisi = (gelirVergisiMatrahi * 0.15) - 2280.47;
                }
                else if (aralikMatrahKumulatif > 70000 && aralikMatrahKumulatif < 150001) //70.001 ve 150.000
                {
                    if (kasimMatrahKumulatif < 70001)
                    {
                        aralikGelirVergisi = ((70000 - kasimMatrahKumulatif) * 0.15) + ((aralikMatrahKumulatif - 70000) * 0.20) - 2280.47;
                    }
                    else
                    {
                        ilkYirmi = true;
                        aralikGelirVergisi = (gelirVergisiMatrahi * 0.20) - 2280.47;
                    }
                }
                else if (aralikMatrahKumulatif > 150000 && aralikMatrahKumulatif < 550001)
                {
                    if (kasimMatrahKumulatif < 150001)
                    {
                        aralikGelirVergisi = ((150000 - kasimMatrahKumulatif) * 0.20) + ((aralikMatrahKumulatif - 150000) * 0.27) - 2280.47;
                    }
                    else
                    {
                        ilkYirmiYedi = true;
                        aralikGelirVergisi = (gelirVergisiMatrahi * 0.27) - 2280.47;

                    }
                }

                else if (aralikMatrahKumulatif > 550000 && aralikMatrahKumulatif < 1900001)
                {
                    if (kasimMatrahKumulatif < 550001)
                    {
                        aralikGelirVergisi = ((550000 - kasimMatrahKumulatif) * 0.27) + ((aralikMatrahKumulatif - 550000) * 0.35) - 2280.47;
                    }
                    else
                    {
                        ilkOtuzBes = true;
                        aralikGelirVergisi = (gelirVergisiMatrahi * 0.35) - 2280.47;
                    }
                }

                else if (aralikMatrahKumulatif > 1900000)
                {
                    if (kasimMatrahKumulatif < 1900001)
                    {
                        aralikGelirVergisi = (((1900000 - kasimMatrahKumulatif) * 0.40) + 607000) - 2280.47;
                    }
                    else
                    {

                    }
                }



                /*
                //gelir vergisi hesaplama
                if (brut_ucret > 10008 && brut_ucret < 70001) //0,15
                {
                    gelirVergisi = (gelirVergisiMatrahi * gelirVergisiOrani) - gvMuafiyeti;
                }
                else if (brut_ucret > 70000 && brut_ucret < 150001) //0,20
                {
                    gelirVergisi = (((gelirVergisiMatrahi - 70000) * 0.20) + 10500) - gvMuafiyeti;
                }
                else if (brut_ucret > 150000 && brut_ucret < 550001) //0,27
                {
                    gelirVergisi = (((gelirVergisiMatrahi - 150000) * 0.27) + 26500) - gvMuafiyeti;
                }
                else if (brut_ucret > 550000 && brut_ucret < 1900001) //0,35
                {
                    gelirVergisi = (((gelirVergisiMatrahi - 550000) * 0.35) + 134500) - gvMuafiyeti;
                }
                else if (brut_ucret > 1900000) //0,40
                {
                    gelirVergisi = (((gelirVergisiMatrahi - 1900000) * 0.40) + 607000) - gvMuafiyeti;
                }

                else
                {
                    gelirVergisi = 0;
                }
                */


                damgaVergisi = (brut_ucret * 0.00759) - dvMuafiyeti;
                damgaVergisi1 = (brut_ucret * 0.00759) - dvMuafiyeti1;

                toplamKesinti = sigortaPrimiIsciPayi + issizlikSigortasiIsciPayi + gelirVergisi + damgaVergisi;

                netUcretOcak = (brut_ucret - ocakGelirVergisi - damgaVergisi - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox2.Text = string.Format("{0:C}", netUcretOcak).ToString();

                netUcretSubat = (brut_ucret - subatGelirVergisi - damgaVergisi - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox3.Text = string.Format("{0:C}", netUcretSubat).ToString();

                netUcretMart = (brut_ucret - martGelirVergisi - damgaVergisi - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox4.Text = string.Format("{0:C}", netUcretMart).ToString();

                netUcretNisan = (brut_ucret - nisanGelirVergisi - damgaVergisi - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox5.Text = string.Format("{0:C}", netUcretNisan).ToString();

                netUcretMayis = (brut_ucret - mayisGelirVergisi - damgaVergisi - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox6.Text = string.Format("{0:C}", netUcretMayis).ToString();

                netUcretHaziran = (brut_ucret - haziranGelirVergisi - damgaVergisi - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox7.Text = string.Format("{0:C}", netUcretHaziran).ToString();

                netUcretTemmuz = (brut_ucret - temmuzGelirVergisi - damgaVergisi1 - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox8.Text = string.Format("{0:C}", netUcretTemmuz).ToString();

                netUcretAgustos = (brut_ucret - agustosGelirVergisi - damgaVergisi1 - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox9.Text = string.Format("{0:C}", netUcretAgustos).ToString();

                netUcretEylul = (brut_ucret - eylulGelirVergisi -     damgaVergisi1 - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox10.Text = string.Format("{0:C}", netUcretEylul).ToString();

                netUcretEkim = (brut_ucret - ekimGelirVergisi - damgaVergisi1 - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox11.Text = string.Format("{0:C}", netUcretEkim).ToString();

                netUcretKasim = (brut_ucret - kasimGelirVergisi - damgaVergisi1 - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox12.Text = string.Format("{0:C}", netUcretKasim).ToString();

                netUcretAralik = (brut_ucret - aralikGelirVergisi - damgaVergisi1 - sigortaPrimiIsciPayi - issizlikSigortasiIsciPayi - ozelKesinti) + ekGelirGiris;
                textBox13.Text = string.Format("{0:C}", netUcretAralik).ToString();



                //MessageBox.Show(gelirVergisiMatrahi.ToString());
                /*MessageBox.Show(damgaVergisi.ToString());
                MessageBox.Show("1-- " + ocakMatrahKumulatif.ToString());
                MessageBox.Show("2-- " + subatMatrahKumulatif.ToString());
                MessageBox.Show("3-- " + martMatrahKumulatif.ToString());
                MessageBox.Show("4-- " + nisanMatrahKumulatif.ToString());
                MessageBox.Show("5-- " + mayisMatrahKumulatif.ToString());
                MessageBox.Show("6-- " + haziranMatrahKumulatif.ToString());
                MessageBox.Show("7-- " + temmuzMatrahKumulatif.ToString());
                MessageBox.Show("8-- "  + agustosMatrahKumulatif.ToString());
                MessageBox.Show("9-- "  + eylulMatrahKumulatif.ToString());
                MessageBox.Show("10-- " + ekimMatrahKumulatif.ToString());
                MessageBox.Show("11-- " + kasimMatrahKumulatif.ToString());
                MessageBox.Show("12-- " + aralikMatrahKumulatif.ToString())*/

            }
            catch
            {
                MessageBox.Show("Lütfen değerleri doğru formatta giriniz!");
            }




        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox2.Text = "₺0";
            textBox3.Text = "₺0";
            textBox4.Text = "₺0";
            textBox5.Text = "₺0";
            textBox6.Text = "₺0";
            textBox7.Text = "₺0";
            textBox8.Text = "₺0";
            textBox9.Text = "₺0";
            textBox10.Text = "₺0";
            textBox11.Text = "₺0";
            textBox12.Text = "₺0";
            textBox13.Text = "₺0";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Text = "₺0";
            textBox3.Text = "₺0";
            textBox4.Text = "₺0";
            textBox5.Text = "₺0";
            textBox6.Text = "₺0";
            textBox7.Text = "₺0";
            textBox8.Text = "₺0";
            textBox9.Text = "₺0";
            textBox10.Text = "₺0";
            textBox11.Text = "₺0";
            textBox12.Text = "₺0";
            textBox13.Text = "₺0";
            textBox1.Focus();
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
            this.Close();
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false; //eğer rakamsa  yazdır.
            }
            else if ((int)e.KeyChar == 8 || (int)e.KeyChar == 44 || (int)e.KeyChar == 46)
            {
                e.Handled = false; //eğer basılan tuş backspace ise yazdır. Silme tuşu devre
            }
            else
            {
                e.Handled = true;// 0 ile 9 aralığı dışında tuş basılırsa klavye kontolü devre dışı kalır
            }
        }








    }


}
