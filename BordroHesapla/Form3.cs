using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordroHesapla
{
    public partial class Form3 : System.Windows.Forms.Form
    {

        double abrut = 20002.5;

        double gelirVergisiDilimi1 = 110000;
        double gelirVergisiDilimi2 = 230000;
        double gelirVergisiDilimi3 = 870000;
        double gelirVergisiDilimi4 = 3000000;

        double gelirVergisiDilimi2Fazlaligi = 16500;
        double gelirVergisiDilimi3Fazlaligi = 40500;
        double gelirVergisiDilimi4Fazlaligi = 135000;
        double gelirVergisiDilimi5Fazlaligi = 982000;

        double aylikTavanUcret = 150018.9;

        double brut1, brut2, brut3, brut4, brut5, brut6, brut7, brut8, brut9, brut10, brut11, brut12;
        double aubrut1, aubrut2, aubrut3, aubrut4, aubrut5, aubrut6, aubrut7, aubrut8, aubrut9, aubrut10, aubrut11, aubrut12;
        double calisanSgkPrimi1, calisanSgkPrimi2, calisanSgkPrimi3, calisanSgkPrimi4, calisanSgkPrimi5, calisanSgkPrimi6, calisanSgkPrimi7, calisanSgkPrimi8, calisanSgkPrimi9, calisanSgkPrimi10, calisanSgkPrimi11, calisanSgkPrimi12;
        double aucalisanSgkPrimi1, aucalisanSgkPrimi2, aucalisanSgkPrimi3, aucalisanSgkPrimi4, aucalisanSgkPrimi5, aucalisanSgkPrimi6, aucalisanSgkPrimi7, aucalisanSgkPrimi8, aucalisanSgkPrimi9, aucalisanSgkPrimi10, aucalisanSgkPrimi11, aucalisanSgkPrimi12;
        double calisanIssizlikSigortasi1, calisanIssizlikSigortasi2, calisanIssizlikSigortasi3, calisanIssizlikSigortasi4, calisanIssizlikSigortasi5, calisanIssizlikSigortasi6, calisanIssizlikSigortasi7, calisanIssizlikSigortasi8;

        private void txtBrut3_TextChanged(object sender, EventArgs e)
        {
            txtBrut4.Text = txtBrut3.Text;
            txtBrut4.Font = new Font(txtBrut4.Font, FontStyle.Regular);
            txtBrut4.ForeColor = Color.Black;

        }

        private void txtBrut2_TextChanged(object sender, EventArgs e)
        {
            txtBrut3.Text = txtBrut2.Text;
            txtBrut3.Font = new Font(txtBrut3.Font, FontStyle.Regular);
            txtBrut3.ForeColor = Color.Black;

        }

        private void txtBrut1_TextChanged_1(object sender, EventArgs e)
        {
            txtBrut2.Text = txtBrut1.Text;
            txtBrut2.Font = new Font(txtBrut2.Font, FontStyle.Regular);
            txtBrut2.ForeColor = Color.Black;
        }

        double calisanIssizlikSigortasi9, calisanIssizlikSigortasi10, calisanIssizlikSigortasi11, calisanIssizlikSigortasi12;
        double aucalisanIssizlikSigortasi1, aucalisanIssizlikSigortasi2, aucalisanIssizlikSigortasi3, aucalisanIssizlikSigortasi4, aucalisanIssizlikSigortasi5, aucalisanIssizlikSigortasi6, aucalisanIssizlikSigortasi7, aucalisanIssizlikSigortasi8;
        double aucalisanIssizlikSigortasi9, aucalisanIssizlikSigortasi10, aucalisanIssizlikSigortasi11, aucalisanIssizlikSigortasi12;
        double damgaVergisi1, damgaVergisi2, damgaVergisi3, damgaVergisi4, damgaVergisi5, damgaVergisi6, damgaVergisi7, damgaVergisi8, damgaVergisi9, damgaVergisi10, damgaVergisi11, damgaVergisi12;
        double audamgaVergisi1, audamgaVergisi2, audamgaVergisi3, audamgaVergisi4, audamgaVergisi5, audamgaVergisi6, audamgaVergisi7, audamgaVergisi8, audamgaVergisi9, audamgaVergisi10, audamgaVergisi11, audamgaVergisi12;
        double gvMuafiyeti1, gvMuafiyeti2, gvMuafiyeti3, gvMuafiyeti4, gvMuafiyeti5, gvMuafiyeti6, gvMuafiyeti7, gvMuafiyeti8, gvMuafiyeti9, gvMuafiyeti10, gvMuafiyeti11, gvMuafiyeti12;
        double dvMuafiyeti1, dvMuafiyeti2, dvMuafiyeti3, dvMuafiyeti4, dvMuafiyeti5, dvMuafiyeti6, dvMuafiyeti7, dvMuafiyeti8, dvMuafiyeti9, dvMuafiyeti10, dvMuafiyeti11, dvMuafiyeti12;
        double gvMatrahi1, gvMatrahi2, gvMatrahi3, gvMatrahi4, gvMatrahi5, gvMatrahi6, gvMatrahi7, gvMatrahi8, gvMatrahi9, gvMatrahi10, gvMatrahi11, gvMatrahi12;
        double augvMatrahi1, augvMatrahi2, augvMatrahi3, augvMatrahi4, augvMatrahi5, augvMatrahi6, augvMatrahi7, augvMatrahi8, augvMatrahi9, augvMatrahi10, augvMatrahi11, augvMatrahi12;
        double gelirVergisi1, gelirVergisi2, gelirVergisi3, gelirVergisi4, gelirVergisi5, gelirVergisi6, gelirVergisi7, gelirVergisi8, gelirVergisi9, gelirVergisi10, gelirVergisi11, gelirVergisi12;
        double augelirVergisi1, augelirVergisi2, augelirVergisi3, augelirVergisi4, augelirVergisi5, augelirVergisi6, augelirVergisi7, augelirVergisi8, augelirVergisi9, augelirVergisi10, augelirVergisi11, augelirVergisi12;
        double gvKumulatif1, gvKumulatif2, gvKumulatif3, gvKumulatif4, gvKumulatif5, gvKumulatif6, gvKumulatif7, gvKumulatif8, gvKumulatif9, gvKumulatif10, gvKumulatif11, gvKumulatif12;
        double augvKumulatif1, augvKumulatif2, augvKumulatif3, augvKumulatif4, augvKumulatif5, augvKumulatif6, augvKumulatif7, augvKumulatif8, augvKumulatif9, augvKumulatif10, augvKumulatif11, augvKumulatif12;
        double kesintilerToplami1, kesintilerToplami2, kesintilerToplami3, kesintilerToplami4, kesintilerToplami5, kesintilerToplami6, kesintilerToplami7, kesintilerToplami8, kesintilerToplami9, kesintilerToplami10, kesintilerToplami11, kesintilerToplami12;
        double netUcret1, netUcret2, netUcret3, netUcret4, netUcret5, netUcret6, netUcret7, netUcret8, netUcret9, netUcret10, netUcret11, netUcret12;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnButunAylariDoldur_Click(object sender, EventArgs e)
        {
            txtBrut2.Text = txtBrut1.Text;
            txtBrut3.Text = txtBrut1.Text;
            txtBrut4.Text = txtBrut1.Text;
            txtBrut5.Text = txtBrut1.Text;
            txtBrut6.Text = txtBrut1.Text;
            txtBrut7.Text = txtBrut1.Text;
            txtBrut8.Text = txtBrut1.Text;
            txtBrut9.Text = txtBrut1.Text;
            txtBrut10.Text = txtBrut1.Text;
            txtBrut11.Text = txtBrut1.Text;
            txtBrut12.Text = txtBrut1.Text;

            txtBrut2.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut2.ForeColor = Color.Black;
            txtBrut3.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut3.ForeColor = Color.Black;
            txtBrut4.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut4.ForeColor = Color.Black;
            txtBrut5.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut5.ForeColor = Color.Black;
            txtBrut6.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut6.ForeColor = Color.Black;
            txtBrut7.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut7.ForeColor = Color.Black;
            txtBrut8.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut8.ForeColor = Color.Black;
            txtBrut9.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut9.ForeColor = Color.Black;
            txtBrut10.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut10.ForeColor = Color.Black;
            txtBrut11.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut11.ForeColor = Color.Black;
            txtBrut12.Font = new Font(txtBrut1.Font, FontStyle.Regular);
            txtBrut12.ForeColor = Color.Black;
        }

        public Form3()
        {
            InitializeComponent();

            //this.FormClosed += new FormClosedEventHandler(Form3_FormClosed);

            foreach (Control item in this.panel3.Controls)
            {
                if (item is TextBox && item.Tag != null && item.Tag.ToString().StartsWith("b"))
                {
                    item.Text = "Brüt Ücret";
                    item.Font = new Font(item.Font, FontStyle.Italic);
                    item.ForeColor = Color.Silver;
                }
            }

        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void txtBrut1_TextChanged(object sender, EventArgs e)
        {
        }


        // textbox'lara tıklanıp ayrılındığında (leave) olacak olaylar -- tıklayınca (enter) boş ayrılınca brüt ücret yazacak
        private void txtBrut1_Enter(object sender, EventArgs e)
        {
            if (txtBrut1.Text == "Brüt Ücret")
            {
                txtBrut1.Text = "";
                txtBrut1.Font = new Font(txtBrut1.Font, FontStyle.Regular);
                txtBrut1.ForeColor = Color.Black;
            }
        }

        private void txtBrut1_Leave(object sender, EventArgs e)
        {
            if (txtBrut1.Text == "")
            {
                txtBrut1.Text = "Brüt Ücret";
                txtBrut1.Font = new Font(txtBrut1.Font, FontStyle.Italic);
                txtBrut1.ForeColor = Color.Silver;

            }
        }

        private void txtBrut2_Enter(object sender, EventArgs e)
        {
            if (txtBrut2.Text == "Brüt Ücret")
            {
                txtBrut2.Text = "";
                txtBrut2.Font = new Font(txtBrut2.Font, FontStyle.Regular);
                txtBrut2.ForeColor = Color.Black;
            }
        }

        private void txtBrut2_Leave(object sender, EventArgs e)
        {
            if (txtBrut2.Text == "")
            {
                txtBrut2.Text = "Brüt Ücret";
                txtBrut2.Font = new Font(txtBrut2.Font, FontStyle.Italic);
                txtBrut2.ForeColor = Color.Silver;

            }
        }

        private void txtBrut3_Enter(object sender, EventArgs e)
        {
            if (txtBrut3.Text == "Brüt Ücret")
            {
                txtBrut3.Text = "";
                txtBrut3.Font = new Font(txtBrut3.Font, FontStyle.Regular);
                txtBrut3.ForeColor = Color.Black;
            }
        }

        private void txtBrut3_Leave(object sender, EventArgs e)
        {
            if (txtBrut3.Text == "")
            {
                txtBrut3.Text = "Brüt Ücret";
                txtBrut3.Font = new Font(txtBrut3.Font, FontStyle.Italic);
                txtBrut3.ForeColor = Color.Silver;

            }
        }

        private void txtBrut4_Enter(object sender, EventArgs e)
        {
            if (txtBrut4.Text == "Brüt Ücret")
            {
                txtBrut4.Text = "";
                txtBrut4.Font = new Font(txtBrut4.Font, FontStyle.Regular);
                txtBrut4.ForeColor = Color.Black;
            }
        }

        private void txtBrut4_Leave(object sender, EventArgs e)
        {
            if (txtBrut4.Text == "")
            {
                txtBrut4.Text = "Brüt Ücret";
                txtBrut4.Font = new Font(txtBrut4.Font, FontStyle.Italic);
                txtBrut4.ForeColor = Color.Silver;

            }
        }

        private void txtBrut5_Enter(object sender, EventArgs e)
        {
            if (txtBrut5.Text == "Brüt Ücret")
            {
                txtBrut5.Text = "";
                txtBrut5.Font = new Font(txtBrut5.Font, FontStyle.Regular);
                txtBrut5.ForeColor = Color.Black;
            }
        }

        private void txtBrut5_Leave(object sender, EventArgs e)
        {
            if (txtBrut5.Text == "")
            {
                txtBrut5.Text = "Brüt Ücret";
                txtBrut5.Font = new Font(txtBrut5.Font, FontStyle.Italic);
                txtBrut5.ForeColor = Color.Silver;

            }
        }

        private void txtBrut6_Enter(object sender, EventArgs e)
        {
            if (txtBrut6.Text == "Brüt Ücret")
            {
                txtBrut6.Text = "";
                txtBrut6.Font = new Font(txtBrut6.Font, FontStyle.Regular);
                txtBrut6.ForeColor = Color.Black;
            }
        }

        private void txtBrut6_Leave(object sender, EventArgs e)
        {
            if (txtBrut6.Text == "")
            {
                txtBrut6.Text = "Brüt Ücret";
                txtBrut6.Font = new Font(txtBrut6.Font, FontStyle.Italic);
                txtBrut6.ForeColor = Color.Silver;

            }
        }

        private void txtBrut7_Enter(object sender, EventArgs e)
        {
            if (txtBrut7.Text == "Brüt Ücret")
            {
                txtBrut7.Text = "";
                txtBrut7.Font = new Font(txtBrut7.Font, FontStyle.Regular);
                txtBrut7.ForeColor = Color.Black;
            }
        }

        private void txtBrut7_Leave(object sender, EventArgs e)
        {
            if (txtBrut7.Text == "")
            {
                txtBrut7.Text = "Brüt Ücret";
                txtBrut7.Font = new Font(txtBrut7.Font, FontStyle.Italic);
                txtBrut7.ForeColor = Color.Silver;

            }
        }

        private void txtBrut8_Enter(object sender, EventArgs e)
        {
            if (txtBrut8.Text == "Brüt Ücret")
            {
                txtBrut8.Text = "";
                txtBrut8.Font = new Font(txtBrut8.Font, FontStyle.Regular);
                txtBrut8.ForeColor = Color.Black;
            }
        }

        private void txtBrut8_Leave(object sender, EventArgs e)
        {
            if (txtBrut8.Text == "")
            {
                txtBrut8.Text = "Brüt Ücret";
                txtBrut8.Font = new Font(txtBrut8.Font, FontStyle.Italic);
                txtBrut8.ForeColor = Color.Silver;

            }
        }

        private void txtBrut9_Enter(object sender, EventArgs e)
        {
            if (txtBrut9.Text == "Brüt Ücret")
            {
                txtBrut9.Text = "";
                txtBrut9.Font = new Font(txtBrut9.Font, FontStyle.Regular);
                txtBrut9.ForeColor = Color.Black;
            }
        }

        private void txtBrut9_Leave(object sender, EventArgs e)
        {
            if (txtBrut9.Text == "")
            {
                txtBrut9.Text = "Brüt Ücret";
                txtBrut9.Font = new Font(txtBrut9.Font, FontStyle.Italic);
                txtBrut9.ForeColor = Color.Silver;

            }
        }

        private void txtBrut10_Enter(object sender, EventArgs e)
        {
            if (txtBrut10.Text == "Brüt Ücret")
            {
                txtBrut10.Text = "";
                txtBrut10.Font = new Font(txtBrut10.Font, FontStyle.Regular);
                txtBrut10.ForeColor = Color.Black;
            }
        }

        private void txtBrut10_Leave(object sender, EventArgs e)
        {
            if (txtBrut10.Text == "")
            {
                txtBrut10.Text = "Brüt Ücret";
                txtBrut10.Font = new Font(txtBrut10.Font, FontStyle.Italic);
                txtBrut10.ForeColor = Color.Silver;

            }
        }

        private void txtBrut11_Enter(object sender, EventArgs e)
        {
            if (txtBrut11.Text == "Brüt Ücret")
            {
                txtBrut11.Text = "";
                txtBrut11.Font = new Font(txtBrut11.Font, FontStyle.Regular);
                txtBrut11.ForeColor = Color.Black;
            }
        }

        private void txtBrut11_Leave(object sender, EventArgs e)
        {
            if (txtBrut11.Text == "")
            {
                txtBrut11.Text = "Brüt Ücret";
                txtBrut11.Font = new Font(txtBrut11.Font, FontStyle.Italic);
                txtBrut11.ForeColor = Color.Silver;

            }
        }

        private void txtBrut12_Enter(object sender, EventArgs e)
        {
            if (txtBrut12.Text == "Brüt Ücret")
            {
                txtBrut12.Text = "";
                txtBrut12.Font = new Font(txtBrut12.Font, FontStyle.Regular);
                txtBrut12.ForeColor = Color.Black;
            }
        }

        private void txtBrut12_Leave(object sender, EventArgs e)
        {
            if (txtBrut12.Text == "")
            {
                txtBrut12.Text = "Brüt Ücret";
                txtBrut12.Font = new Font(txtBrut12.Font, FontStyle.Italic);
                txtBrut12.ForeColor = Color.Silver;

            }
        }

        private void txtBrut1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
             {
                 e.Handled = false; //eğer rakamsa  yazdır.
             }
             else if ((int)e.KeyChar == 8 || (int)e.KeyChar == 44  )
             {
                 e.Handled = false; //eğer basılan tuş backspace ise yazdır. Silme tuşu devre
             }
             else
             {
                 e.Handled = true;// 0 ile 9 aralığı dışında tuş basılırsa klavye kontolü devre dışı kalır
             }*/

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

        }




        private void btnHesapla_Click(object sender, EventArgs e)
        {

            try
            {
                // Brüt Ücretlerin textBox'ındaki mouseClick ve Leave olaylarına göre Brüt Ücret yazdırılmasının kontrolü
                // Hesaplama yaparken Brüt yazmasından dolayı convert işlemi hata fırlatıyor

                


                // Brüt Ücretlerin textBox'lardan kontrollü alınıp değişkenlere atanması
                if (1 == 1)
                {
                    if (txtBrut1.Text == "" || Convert.ToDouble(txtBrut1.Text) < abrut)
                    {
                        brut1 = 0;
                        aubrut1 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut1.Text) >= abrut)
                    {
                        brut1 = Convert.ToDouble(txtBrut1.Text);
                        aubrut1 = abrut;
                    }

                    if (txtBrut2.Text != "Brüt Ücret")
                    {
                        if (txtBrut2.Text == "" || Convert.ToDouble(txtBrut2.Text) < abrut)
                        {
                            brut2 = 0;
                            aubrut2 = 0;
                        }
                        else if (Convert.ToDouble(txtBrut2.Text) >= abrut)
                        {
                            brut2 = Convert.ToDouble(txtBrut2.Text);
                            aubrut2 = abrut;
                        }
                    }

                    if (txtBrut3.Text == "" || Convert.ToDouble(txtBrut3.Text) < abrut)
                    {
                        brut3 = 0;
                        aubrut3 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut3.Text) >= abrut)
                    {
                        brut3 = Convert.ToDouble(txtBrut3.Text);
                        aubrut3 = abrut;
                    }

                    if (txtBrut4.Text == "" || Convert.ToDouble(txtBrut4.Text) < abrut)
                    {
                        brut4 = 0;
                        aubrut4 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut4.Text) >= abrut)
                    {
                        brut4 = Convert.ToDouble(txtBrut4.Text);
                        aubrut4 = abrut;
                    }

                    if (txtBrut5.Text == "" || Convert.ToDouble(txtBrut5.Text) < abrut)
                    {
                        brut5 = 0;
                        aubrut5 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut5.Text) >= abrut)
                    {
                        brut5 = Convert.ToDouble(txtBrut5.Text);
                        aubrut5 = abrut;
                    }

                    if (txtBrut6.Text == "" || Convert.ToDouble(txtBrut6.Text) < abrut)
                    {
                        brut6 = 0;
                        aubrut6 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut6.Text) >= abrut)
                    {
                        brut6 = Convert.ToDouble(txtBrut6.Text);
                        aubrut6 = abrut;

                    }

                    if (txtBrut7.Text == "" || Convert.ToDouble(txtBrut7.Text) < abrut)
                    {
                        brut7 = 0;
                        aubrut7 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut7.Text) >= abrut)
                    {
                        brut7 = Convert.ToDouble(txtBrut7.Text);
                        aubrut7 = abrut;
                    }

                    if (txtBrut8.Text == "" || Convert.ToDouble(txtBrut8.Text) < abrut)
                    {
                        brut8 = 0;
                        aubrut8 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut8.Text) >= abrut)
                    {
                        brut8 = Convert.ToDouble(txtBrut8.Text);
                        aubrut8 = abrut;
                    }

                    if (txtBrut9.Text == "" || Convert.ToDouble(txtBrut9.Text) < abrut)
                    {
                        brut9 = 0;
                        aubrut9 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut9.Text) >= abrut)
                    {
                        brut9 = Convert.ToDouble(txtBrut9.Text);
                        aubrut9 = abrut;
                    }

                    if (txtBrut10.Text == "" || Convert.ToDouble(txtBrut10.Text) < abrut)
                    {
                        brut10 = 0;
                        aubrut10 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut10.Text) >= abrut)
                    {
                        brut10 = Convert.ToDouble(txtBrut10.Text);
                        aubrut10 = abrut;
                    }

                    if (txtBrut11.Text == "" || Convert.ToDouble(txtBrut11.Text) < abrut)
                    {
                        brut11 = 0;
                        aubrut11 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut11.Text) >= abrut)
                    {
                        brut11 = Convert.ToDouble(txtBrut11.Text);
                        aubrut11 = abrut;
                    }

                    if (txtBrut12.Text == "" || Convert.ToDouble(txtBrut12.Text) < abrut)
                    {
                        brut12 = 0;
                        aubrut12 = 0;
                    }
                    else if (Convert.ToDouble(txtBrut12.Text) >= abrut)
                    {
                        brut12 = Convert.ToDouble(txtBrut12.Text);
                        aubrut12 = abrut;
                    }
                }



                // Çalışan SGK Primi ve Çalışan İssizlik Sigortası
                if (1 == 1)
                {
                    if (brut1 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi1 = brut1 * 0.14;
                        txtCSP1.Text = string.Format("{0:C}", calisanSgkPrimi1).ToString();

                        aucalisanSgkPrimi1 = aubrut1 * 0.14;

                        calisanIssizlikSigortasi1 = brut1 * 0.01;
                        txtCIS1.Text = string.Format("{0:C}", calisanIssizlikSigortasi1).ToString();

                        aucalisanIssizlikSigortasi1 = aubrut1 * 0.01;

                    }
                    else
                    {
                        calisanSgkPrimi1 = aylikTavanUcret * 0.14;
                        txtCSP1.Text = string.Format("{0:C}", calisanSgkPrimi1).ToString();

                        aucalisanSgkPrimi1 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi1 = aylikTavanUcret * 0.01;
                        txtCIS1.Text = string.Format("{0:C}", calisanIssizlikSigortasi1).ToString();

                        aucalisanIssizlikSigortasi1 = aylikTavanUcret * 0.01;
                    }

                    if (brut2 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi2 = brut2 * 0.14;
                        txtCSP2.Text = string.Format("{0:C}", calisanSgkPrimi2).ToString();

                        aucalisanSgkPrimi2 = aubrut2 * 0.14;

                        calisanIssizlikSigortasi2 = brut2 * 0.01;
                        txtCIS2.Text = string.Format("{0:C}", calisanIssizlikSigortasi2).ToString();

                        aucalisanIssizlikSigortasi2 = aubrut2 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi2 = aylikTavanUcret * 0.14;
                        txtCSP2.Text = string.Format("{0:C}", calisanSgkPrimi2).ToString();

                        aucalisanSgkPrimi2 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi2 = aylikTavanUcret * 0.01;
                        txtCIS2.Text = string.Format("{0:C}", calisanIssizlikSigortasi2).ToString();

                        aucalisanIssizlikSigortasi2 = aylikTavanUcret * 0.01;
                    }

                    if (brut3 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi3 = brut3 * 0.14;
                        txtCSP3.Text = string.Format("{0:C}", calisanSgkPrimi3).ToString();

                        aucalisanSgkPrimi3 = aubrut3 * 0.14;

                        calisanIssizlikSigortasi3 = brut3 * 0.01;
                        txtCIS3.Text = string.Format("{0:C}", calisanIssizlikSigortasi3).ToString();

                        aucalisanIssizlikSigortasi3 = aubrut3 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi3 = aylikTavanUcret * 0.14;
                        txtCSP3.Text = string.Format("{0:C}", calisanSgkPrimi3).ToString();

                        aucalisanSgkPrimi3 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi3 = aylikTavanUcret * 0.01;
                        txtCIS3.Text = string.Format("{0:C}", calisanIssizlikSigortasi3).ToString();

                        aucalisanIssizlikSigortasi3 = aylikTavanUcret * 0.01;
                    }

                    if (brut4 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi4 = brut4 * 0.14;
                        txtCSP4.Text = string.Format("{0:C}", calisanSgkPrimi4).ToString();

                        aucalisanSgkPrimi4 = aubrut4 * 0.14;

                        calisanIssizlikSigortasi4 = brut4 * 0.01;
                        txtCIS4.Text = string.Format("{0:C}", calisanIssizlikSigortasi4).ToString();

                        aucalisanIssizlikSigortasi4 = aubrut4 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi4 = aylikTavanUcret * 0.14;
                        txtCSP4.Text = string.Format("{0:C}", calisanSgkPrimi4).ToString();

                        aucalisanSgkPrimi4 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi4 = aylikTavanUcret * 0.01;
                        txtCIS4.Text = string.Format("{0:C}", calisanIssizlikSigortasi4).ToString();

                        aucalisanIssizlikSigortasi4 = aylikTavanUcret * 0.01;
                    }

                    if (brut5 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi5 = brut5 * 0.14;
                        txtCSP5.Text = string.Format("{0:C}", calisanSgkPrimi5).ToString();

                        aucalisanSgkPrimi5 = aubrut5 * 0.14;

                        calisanIssizlikSigortasi5 = brut5 * 0.01;
                        txtCIS5.Text = string.Format("{0:C}", calisanIssizlikSigortasi5).ToString();

                        aucalisanIssizlikSigortasi5 = aubrut5 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi5 = aylikTavanUcret * 0.14;
                        txtCSP5.Text = string.Format("{0:C}", calisanSgkPrimi5).ToString();

                        aucalisanSgkPrimi5 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi5 = aylikTavanUcret * 0.01;
                        txtCIS5.Text = string.Format("{0:C}", calisanIssizlikSigortasi5).ToString();

                        aucalisanIssizlikSigortasi5 = aylikTavanUcret * 0.01;
                    }

                    if (brut6 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi6 = brut6 * 0.14;
                        txtCSP6.Text = string.Format("{0:C}", calisanSgkPrimi6).ToString();

                        aucalisanSgkPrimi6 = aubrut6 * 0.14;

                        calisanIssizlikSigortasi6 = brut6 * 0.01;
                        txtCIS6.Text = string.Format("{0:C}", calisanIssizlikSigortasi6).ToString();

                        aucalisanIssizlikSigortasi6 = aubrut6 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi6 = aylikTavanUcret * 0.14;
                        txtCSP6.Text = string.Format("{0:C}", calisanSgkPrimi6).ToString();

                        aucalisanSgkPrimi6 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi6 = aylikTavanUcret * 0.01;
                        txtCIS6.Text = string.Format("{0:C}", calisanIssizlikSigortasi6).ToString();

                        aucalisanIssizlikSigortasi6 = aylikTavanUcret * 0.01;
                    }

                    if (brut7 <= aylikTavanUcret) //aylikTavanUcret ilk 6 ay
                    {
                        calisanSgkPrimi7 = brut7 * 0.14;
                        txtCSP7.Text = string.Format("{0:C}", calisanSgkPrimi7).ToString();

                        aucalisanSgkPrimi7 = aubrut7 * 0.14;

                        calisanIssizlikSigortasi7 = brut7 * 0.01;
                        txtCIS7.Text = string.Format("{0:C}", calisanIssizlikSigortasi7).ToString();

                        aucalisanIssizlikSigortasi7 = aubrut7 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi7 = aylikTavanUcret * 0.14;
                        txtCSP7.Text = string.Format("{0:C}", calisanSgkPrimi7).ToString();

                        aucalisanSgkPrimi7 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi7 = aylikTavanUcret * 0.01;
                        txtCIS7.Text = string.Format("{0:C}", calisanIssizlikSigortasi7).ToString();

                        aucalisanIssizlikSigortasi7 = aylikTavanUcret * 0.01;
                    }

                    if (brut8 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi8 = brut8 * 0.14;
                        txtCSP8.Text = string.Format("{0:C}", calisanSgkPrimi8).ToString();

                        aucalisanSgkPrimi8 = aubrut8 * 0.14;

                        calisanIssizlikSigortasi8 = brut8 * 0.01;
                        txtCIS8.Text = string.Format("{0:C}", calisanIssizlikSigortasi8).ToString();

                        aucalisanIssizlikSigortasi8 = aubrut8 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi8 = aylikTavanUcret * 0.14;
                        txtCSP8.Text = string.Format("{0:C}", calisanSgkPrimi8).ToString();

                        aucalisanSgkPrimi8 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi8 = aylikTavanUcret * 0.01;
                        txtCIS8.Text = string.Format("{0:C}", calisanIssizlikSigortasi8).ToString();

                        aucalisanIssizlikSigortasi8 = aylikTavanUcret * 0.01;
                    }

                    if (brut9 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi9 = brut9 * 0.14;
                        txtCSP9.Text = string.Format("{0:C}", calisanSgkPrimi9).ToString();

                        aucalisanSgkPrimi9 = aubrut9 * 0.14;

                        calisanIssizlikSigortasi9 = brut9 * 0.01;
                        txtCIS9.Text = string.Format("{0:C}", calisanIssizlikSigortasi9).ToString();

                        aucalisanIssizlikSigortasi9 = aubrut9 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi9 = aylikTavanUcret * 0.14;
                        txtCSP9.Text = string.Format("{0:C}", calisanSgkPrimi9).ToString();

                        aucalisanSgkPrimi9 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi9 = aylikTavanUcret * 0.01;
                        txtCIS9.Text = string.Format("{0:C}", calisanIssizlikSigortasi9).ToString();

                        aucalisanIssizlikSigortasi9 = aylikTavanUcret * 0.01;
                    }

                    if (brut10 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi10 = brut10 * 0.14;
                        txtCSP10.Text = string.Format("{0:C}", calisanSgkPrimi10).ToString();

                        aucalisanSgkPrimi10 = aubrut10 * 0.14;

                        calisanIssizlikSigortasi10 = brut10 * 0.01;
                        txtCIS10.Text = string.Format("{0:C}", calisanIssizlikSigortasi10).ToString();

                        aucalisanIssizlikSigortasi10 = aubrut10 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi10 = aylikTavanUcret * 0.14;
                        txtCSP10.Text = string.Format("{0:C}", calisanSgkPrimi10).ToString();

                        aucalisanSgkPrimi10 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi10 = aylikTavanUcret * 0.01;
                        txtCIS10.Text = string.Format("{0:C}", calisanIssizlikSigortasi10).ToString();

                        aucalisanIssizlikSigortasi10 = aylikTavanUcret * 0.01;
                    }

                    if (brut11 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi11 = brut11 * 0.14;
                        txtCSP11.Text = string.Format("{0:C}", calisanSgkPrimi11).ToString();

                        aucalisanSgkPrimi11 = aubrut11 * 0.14;

                        calisanIssizlikSigortasi11 = brut11 * 0.01;
                        txtCIS11.Text = string.Format("{0:C}", calisanIssizlikSigortasi11).ToString();

                        aucalisanIssizlikSigortasi11 = aubrut11 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi11 = aylikTavanUcret * 0.14;
                        txtCSP11.Text = string.Format("{0:C}", calisanSgkPrimi11).ToString();

                        aucalisanSgkPrimi11 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi11 = aylikTavanUcret * 0.01;
                        txtCIS11.Text = string.Format("{0:C}", calisanIssizlikSigortasi11).ToString();

                        aucalisanIssizlikSigortasi11 = aylikTavanUcret * 0.01;
                    }

                    if (brut12 <= aylikTavanUcret)
                    {
                        calisanSgkPrimi12 = brut12 * 0.14;
                        txtCSP12.Text = string.Format("{0:C}", calisanSgkPrimi12).ToString();

                        aucalisanSgkPrimi12 = aubrut12 * 0.14;

                        calisanIssizlikSigortasi12 = brut12 * 0.01;
                        txtCIS12.Text = string.Format("{0:C}", calisanIssizlikSigortasi12).ToString();

                        aucalisanIssizlikSigortasi12 = aubrut12 * 0.01;
                    }
                    else
                    {
                        calisanSgkPrimi12 = aylikTavanUcret * 0.14;
                        txtCSP12.Text = string.Format("{0:C}", calisanSgkPrimi12).ToString();

                        aucalisanSgkPrimi12 = aylikTavanUcret * 0.14;

                        calisanIssizlikSigortasi12 = aylikTavanUcret * 0.01;
                        txtCIS12.Text = string.Format("{0:C}", calisanIssizlikSigortasi12).ToString();

                        aucalisanIssizlikSigortasi12 = aylikTavanUcret * 0.01;
                    }
                }



                // Gelir Vergisi Matrahı Hesaplaması
                if (1 == 1)
                {
                    if (brut1 >= abrut)
                    {
                        gvMatrahi1 = brut1 - (calisanSgkPrimi1 + calisanIssizlikSigortasi1);
                        txtGVMatrahi1.Text = string.Format("{0:C}", gvMatrahi1).ToString();

                        augvMatrahi1 = aubrut1 - (aucalisanSgkPrimi1 + aucalisanIssizlikSigortasi1);

                    }
                    else
                    {
                        gvMatrahi1 = 0;
                        txtGVMatrahi1.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi1 = 0;
                    }

                    if (brut2 >= abrut)
                    {
                        gvMatrahi2 = brut2 - (calisanSgkPrimi2 + calisanIssizlikSigortasi2);
                        txtGVMatrahi2.Text = string.Format("{0:C}", gvMatrahi2).ToString();

                        augvMatrahi2 = aubrut2 - (aucalisanSgkPrimi2 + aucalisanIssizlikSigortasi2);

                    }
                    else
                    {
                        gvMatrahi2 = 0;
                        txtGVMatrahi2.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi2 = 0;
                    }

                    if (brut3 >= abrut)
                    {
                        gvMatrahi3 = brut3 - (calisanSgkPrimi3 + calisanIssizlikSigortasi3);
                        txtGVMatrahi3.Text = string.Format("{0:C}", gvMatrahi3).ToString();

                        augvMatrahi3 = aubrut3 - (aucalisanSgkPrimi3 + aucalisanIssizlikSigortasi3);

                    }
                    else
                    {
                        gvMatrahi3 = 0;
                        txtGVMatrahi3.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi3 = 0;
                    }

                    if (brut4 >= abrut)
                    {
                        gvMatrahi4 = brut4 - (calisanSgkPrimi4 + calisanIssizlikSigortasi4);
                        txtGVMatrahi4.Text = string.Format("{0:C}", gvMatrahi4).ToString();

                        augvMatrahi4 = aubrut4 - (aucalisanSgkPrimi4 + aucalisanIssizlikSigortasi4);

                    }
                    else
                    {
                        gvMatrahi4 = 0;
                        txtGVMatrahi4.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi4 = 0;
                    }

                    if (brut5 >= abrut)
                    {
                        gvMatrahi5 = brut5 - (calisanSgkPrimi5 + calisanIssizlikSigortasi5);
                        txtGVMatrahi5.Text = string.Format("{0:C}", gvMatrahi5).ToString();

                        augvMatrahi5 = aubrut5 - (aucalisanSgkPrimi5 + aucalisanIssizlikSigortasi5);

                    }
                    else
                    {
                        gvMatrahi5 = 0;
                        txtGVMatrahi5.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi5 = 0;
                    }

                    if (brut6 >= abrut)
                    {
                        gvMatrahi6 = brut6 - (calisanSgkPrimi6 + calisanIssizlikSigortasi6);
                        txtGVMatrahi6.Text = string.Format("{0:C}", gvMatrahi6).ToString();

                        augvMatrahi6 = aubrut6 - (aucalisanSgkPrimi6 + aucalisanIssizlikSigortasi6);

                    }
                    else
                    {
                        gvMatrahi6 = 0;
                        txtGVMatrahi6.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi6 = 0;
                    }

                    if (brut7 >= abrut)
                    {
                        gvMatrahi7 = brut7 - (calisanSgkPrimi7 + calisanIssizlikSigortasi7);
                        txtGVMatrahi7.Text = string.Format("{0:C}", gvMatrahi7).ToString();

                        augvMatrahi7 = aubrut7 - (aucalisanSgkPrimi7 + aucalisanIssizlikSigortasi7);

                    }
                    else
                    {
                        gvMatrahi7 = 0;
                        txtGVMatrahi7.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi7 = 0;
                    }

                    if (brut8 >= abrut)
                    {
                        gvMatrahi8 = brut8 - (calisanSgkPrimi8 + calisanIssizlikSigortasi8);
                        txtGVMatrahi8.Text = string.Format("{0:C}", gvMatrahi8).ToString();

                        augvMatrahi8 = aubrut8 - (aucalisanSgkPrimi8 + aucalisanIssizlikSigortasi8);

                    }
                    else
                    {
                        gvMatrahi8 = 0;
                        txtGVMatrahi8.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi8 = 0;
                    }

                    if (brut9 >= abrut)
                    {
                        gvMatrahi9 = brut9 - (calisanSgkPrimi9 + calisanIssizlikSigortasi9);
                        txtGVMatrahi9.Text = string.Format("{0:C}", gvMatrahi9).ToString();

                        augvMatrahi9 = aubrut9 - (aucalisanSgkPrimi9 + aucalisanIssizlikSigortasi9);

                    }
                    else
                    {
                        gvMatrahi9 = 0;
                        txtGVMatrahi9.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi9 = 0;
                    }

                    if (brut10 >= abrut)
                    {
                        gvMatrahi10 = brut10 - (calisanSgkPrimi10 + calisanIssizlikSigortasi10);
                        txtGVMatrahi10.Text = string.Format("{0:C}", gvMatrahi10).ToString();

                        augvMatrahi10 = aubrut10 - (aucalisanSgkPrimi10 + aucalisanIssizlikSigortasi10);

                    }
                    else
                    {
                        gvMatrahi10 = 0;
                        txtGVMatrahi10.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi10 = 0;
                    }

                    if (brut11 >= abrut)
                    {
                        gvMatrahi11 = brut11 - (calisanSgkPrimi11 + calisanIssizlikSigortasi11);
                        txtGVMatrahi11.Text = string.Format("{0:C}", gvMatrahi11).ToString();

                        augvMatrahi11 = aubrut11 - (aucalisanSgkPrimi11 + aucalisanIssizlikSigortasi11);

                    }
                    else
                    {
                        gvMatrahi11 = 0;
                        txtGVMatrahi11.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi11 = 0;
                    }

                    if (brut12 >= abrut)
                    {
                        gvMatrahi12 = brut12 - (calisanSgkPrimi12 + calisanIssizlikSigortasi12);
                        txtGVMatrahi12.Text = string.Format("{0:C}", gvMatrahi12).ToString();

                        augvMatrahi12 = aubrut12 - (aucalisanSgkPrimi12 + aucalisanIssizlikSigortasi12);

                    }
                    else
                    {
                        gvMatrahi12 = 0;
                        txtGVMatrahi12.Text = string.Format("{0:C}", 0).ToString();

                        augvMatrahi12 = 0;
                    }
                }


                // Kümülatif Gelir Vergisi Hesaplaması
                if (1 == 1)
                {
                    gvKumulatif1 = gvMatrahi1;
                    gvKumulatif2 = gvKumulatif1 + gvMatrahi2;
                    gvKumulatif3 = gvKumulatif2 + gvMatrahi3;
                    gvKumulatif4 = gvKumulatif3 + gvMatrahi4;
                    gvKumulatif5 = gvKumulatif4 + gvMatrahi5;
                    gvKumulatif6 = gvKumulatif5 + gvMatrahi6;
                    gvKumulatif7 = gvKumulatif6 + gvMatrahi7;
                    gvKumulatif8 = gvKumulatif7 + gvMatrahi8;
                    gvKumulatif9 = gvKumulatif8 + gvMatrahi9;
                    gvKumulatif10 = gvKumulatif9 + gvMatrahi10;
                    gvKumulatif11 = gvKumulatif10 + gvMatrahi11;
                    gvKumulatif12 = gvKumulatif11 + gvMatrahi12;

                    augvKumulatif1 = augvMatrahi1;
                    augvKumulatif2 = augvKumulatif1 + augvMatrahi2;
                    augvKumulatif3 = augvKumulatif2 + augvMatrahi3;
                    augvKumulatif4 = augvKumulatif3 + augvMatrahi4;
                    augvKumulatif5 = augvKumulatif4 + augvMatrahi5;
                    augvKumulatif6 = augvKumulatif5 + augvMatrahi6;
                    augvKumulatif7 = augvKumulatif6 + augvMatrahi7;
                    augvKumulatif8 = augvKumulatif7 + augvMatrahi8;
                    augvKumulatif9 = augvKumulatif8 + augvMatrahi9;
                    augvKumulatif10 = augvKumulatif9 + augvMatrahi10;
                    augvKumulatif11 = augvKumulatif10 + augvMatrahi11;
                    augvKumulatif12 = augvKumulatif11 + augvMatrahi12;
                }

                // 12 ay eksiksiz maaş girişi varsa, gelir vergisi muafiyeti ve damga vergisi muafiyeti bu şekildedir
                // gvMuafiyeti1 : 01-06 aylar için 1276.02 ; 07.ay için 1710.35  ; 8.ay için 1902.62  ; 9-12 aylar için 2280.47  
                // dvMuafiyeti1 = 01-06 aylar için 75.9607 ; 07-12 aylar için dvMuafiyeti7  101.8161
                // Herhangi bir eksik ay varsa muafiyetler kümülatif gv'ye göre değişecektir



                // Gelir Vergisi ve Damga Vergisi Muafiyetleri Brüt Ücret kontrolü yapılarak değişkenlere atanıyor
                if (1 == 1)
                {
                    if (brut1 >= abrut)
                    {
                        gvMuafiyeti1 = 1276.02;
                        dvMuafiyeti1 = 75.9607;
                    }
                    else
                    {
                        gvMuafiyeti1 = 0;
                        dvMuafiyeti1 = 0;
                    }


                    if (brut2 >= abrut)
                    {
                        gvMuafiyeti2 = 1276.02;
                        dvMuafiyeti2 = 75.9607;
                    }
                    else
                    {
                        gvMuafiyeti2 = 0;
                        dvMuafiyeti2 = 0;
                    }


                    if (brut3 >= abrut)
                    {
                        gvMuafiyeti3 = 1276.02;
                        dvMuafiyeti3 = 75.9607;
                    }
                    else
                    {
                        gvMuafiyeti3 = 0;
                        dvMuafiyeti3 = 0;
                    }


                    if (brut4 >= abrut)
                    {
                        gvMuafiyeti4 = 1276.02;
                        dvMuafiyeti4 = 75.9607;
                    }
                    else
                    {
                        gvMuafiyeti4 = 0;
                        dvMuafiyeti4 = 0;
                    }


                    if (brut5 >= abrut)
                    {
                        gvMuafiyeti5 = 1276.02;
                        dvMuafiyeti5 = 75.9607;
                    }
                    else
                    {
                        gvMuafiyeti5 = 0;
                        dvMuafiyeti5 = 0;
                    }


                    if (brut6 >= abrut)
                    {
                        gvMuafiyeti6 = 1276.02;
                        dvMuafiyeti6 = 75.9607;
                    }
                    else
                    {
                        gvMuafiyeti6 = 0;
                        dvMuafiyeti6 = 0;
                    }


                    if (brut7 >= 13414.4)
                    {
                        gvMuafiyeti7 = 1710.35;
                        dvMuafiyeti7 = 101.8161;
                    }
                    else
                    {
                        gvMuafiyeti7 = 0;
                        dvMuafiyeti7 = 0;
                    }


                    if (brut8 >= abrut)
                    {
                        gvMuafiyeti8 = 1902.62;
                        dvMuafiyeti8 = 101.8161;
                    }
                    else
                    {
                        gvMuafiyeti8 = 0;
                        dvMuafiyeti8 = 0;
                    }


                    if (brut9 >= abrut)
                    {
                        gvMuafiyeti9 = 2280.47;
                        dvMuafiyeti9 = 101.8161;
                    }
                    else
                    {
                        gvMuafiyeti9 = 0;
                        dvMuafiyeti9 = 0;
                    }


                    if (brut10 >= abrut)
                    {
                        gvMuafiyeti10 = 2280.47;
                        dvMuafiyeti10 = 101.8161;
                    }
                    else
                    {
                        gvMuafiyeti10 = 0;
                        dvMuafiyeti10 = 0;
                    }


                    if (brut11 >= abrut)
                    {
                        gvMuafiyeti11 = 2280.47;
                        dvMuafiyeti11 = 101.8161;
                    }
                    else
                    {
                        gvMuafiyeti11 = 0;
                        dvMuafiyeti11 = 0;
                    }


                    if (brut12 >= abrut)
                    {
                        gvMuafiyeti12 = 2280.47;
                        dvMuafiyeti12 = 101.8161;
                    }
                    else
                    {
                        gvMuafiyeti12 = 0;
                        dvMuafiyeti12 = 0;
                    }
                }



                // Asgari Ücret Gelir Vergisi Hesaplaması

                if (1 == 1)
                {
                    if (aubrut1 >= abrut)
                    {
                        // Ocak Ayı Gelir Vergisi Hesaplamaları

                        if (augvKumulatif1 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi1 = (augvMatrahi1 * 0.15);
                        }
                        else if (augvKumulatif1 > gelirVergisiDilimi1 && augvKumulatif1 <= gelirVergisiDilimi2)
                        {
                            augelirVergisi1 = ((((augvKumulatif1 - gelirVergisiDilimi1) * 0.20) + gelirVergisiDilimi2Fazlaligi));
                        }
                        else if (augvKumulatif1 > gelirVergisiDilimi2 && augvKumulatif1 <= gelirVergisiDilimi3)
                        {
                            augelirVergisi1 = ((((augvKumulatif1 - gelirVergisiDilimi2) * 0.27) + gelirVergisiDilimi3Fazlaligi));
                        }
                    }
                    else
                    {
                        augelirVergisi1 = 0;
                    }


                    // Şubat Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut2 >= abrut)
                    {
                        if (augvKumulatif2 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi2 = (augvMatrahi2 * 0.15);
                        }
                        else if (augvKumulatif2 > gelirVergisiDilimi1 && augvKumulatif2 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif1 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi2 = ((gelirVergisiDilimi1 - augvKumulatif1) * 0.15) + ((augvKumulatif2 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi2 = (augvMatrahi2 * 0.20);
                            }
                        }
                        else if (augvKumulatif2 > gelirVergisiDilimi2 && augvKumulatif2 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif1 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi2 = ((gelirVergisiDilimi2 - augvKumulatif1) * 0.20) + ((augvKumulatif2 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi2 = (augvMatrahi2 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi2 = 0;
                    }


                    // Mart Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut3 >= abrut)
                    {
                        if (augvKumulatif3 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi3 = (augvMatrahi3 * 0.15);
                        }
                        else if (augvKumulatif3 > gelirVergisiDilimi1 && augvKumulatif3 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif2 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi3 = ((gelirVergisiDilimi1 - augvKumulatif2) * 0.15) + ((augvKumulatif3 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi3 = (augvMatrahi3 * 0.20);
                            }
                        }
                        else if (augvKumulatif3 > gelirVergisiDilimi2 && augvKumulatif3 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif2 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi3 = ((gelirVergisiDilimi2 - augvKumulatif2) * 0.20) + ((augvKumulatif3 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi3 = (augvMatrahi3 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi3 = 0;
                    }

                    // Nisan Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut4 >= abrut)
                    {
                        if (augvKumulatif4 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi4 = (augvMatrahi4 * 0.15);
                        }
                        else if (augvKumulatif4 > gelirVergisiDilimi1 && augvKumulatif4 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif3 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi4 = ((gelirVergisiDilimi1 - augvKumulatif3) * 0.15) + ((augvKumulatif4 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi4 = (augvMatrahi4 * 0.20);
                            }
                        }
                        else if (augvKumulatif4 > gelirVergisiDilimi2 && augvKumulatif4 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif3 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi4 = ((gelirVergisiDilimi2 - augvKumulatif3) * 0.20) + ((augvKumulatif4 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi4 = (augvMatrahi4 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi4 = 0;
                    }


                    // Mayıs Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut5 >= abrut)
                    {

                        if (augvKumulatif5 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi5 = (augvMatrahi5 * 0.15);
                        }
                        else if (augvKumulatif5 > gelirVergisiDilimi1 && augvKumulatif5 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif4 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi5 = ((gelirVergisiDilimi1 - augvKumulatif4) * 0.15) + ((augvKumulatif5 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi5 = (augvMatrahi5 * 0.20);
                            }
                        }
                        else if (augvKumulatif5 > gelirVergisiDilimi2 && augvKumulatif5 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif4 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi5 = ((gelirVergisiDilimi2 - augvKumulatif4) * 0.20) + ((augvKumulatif5 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi5 = (augvMatrahi5 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi5 = 0;
                    }

                    // Haziran Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut6 >= abrut)
                    {
                        if (augvKumulatif6 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi6 = (augvMatrahi6 * 0.15);
                        }
                        else if (augvKumulatif6 > gelirVergisiDilimi1 && augvKumulatif6 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif5 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi6 = ((gelirVergisiDilimi1 - augvKumulatif5) * 0.15) + ((augvKumulatif6 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi6 = (augvMatrahi6 * 0.20);
                            }
                        }
                        else if (augvKumulatif6 > gelirVergisiDilimi2 && augvKumulatif6 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif5 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi6 = ((gelirVergisiDilimi2 - augvKumulatif5) * 0.20) + ((augvKumulatif6 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi6 = (augvMatrahi6 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi6 = 0;
                    }


                    // Temmuz Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut7 >= abrut)
                    {
                        if (augvKumulatif7 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi7 = (augvMatrahi7 * 0.15);
                        }
                        else if (augvKumulatif7 > gelirVergisiDilimi1 && augvKumulatif7 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif6 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi7 = ((gelirVergisiDilimi1 - augvKumulatif6) * 0.15) + ((augvKumulatif7 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi7 = (augvMatrahi7 * 0.20);
                            }
                        }
                        else if (augvKumulatif7 > gelirVergisiDilimi2 && augvKumulatif7 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif6 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi7 = ((gelirVergisiDilimi2 - augvKumulatif6) * 0.20) + ((augvKumulatif7 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi7 = (augvMatrahi7 * 0.27);
                            }
                        }
                        else
                        {
                            augelirVergisi7 = 0;
                        }
                    }

                    // Ağustos Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut8 >= abrut)
                    {
                        if (augvKumulatif8 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi8 = (augvMatrahi8 * 0.15);
                        }
                        else if (augvKumulatif8 > gelirVergisiDilimi1 && augvKumulatif8 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif7 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi8 = ((gelirVergisiDilimi1 - augvKumulatif7) * 0.15) + ((augvKumulatif8 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi8 = (augvMatrahi8 * 0.20);
                            }
                        }
                        else if (augvKumulatif8 > gelirVergisiDilimi2 && augvKumulatif8 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif7 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi8 = ((gelirVergisiDilimi2 - augvKumulatif7) * 0.20) + ((augvKumulatif8 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi8 = (augvMatrahi8 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi8 = 0;
                    }

                    // ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

                    // Eylül Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut9 >= abrut)
                    {
                        if (augvKumulatif9 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi9 = (augvMatrahi9 * 0.15);
                        }
                        else if (augvKumulatif9 > gelirVergisiDilimi1 && augvKumulatif9 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif8 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi9 = ((gelirVergisiDilimi1 - augvKumulatif8) * 0.15) + ((augvKumulatif9 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi9 = (augvMatrahi9 * 0.20);
                            }
                        }
                        else if (augvKumulatif9 > gelirVergisiDilimi2 && augvKumulatif9 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif8 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi9 = ((gelirVergisiDilimi2 - augvKumulatif8) * 0.20) + ((augvKumulatif9 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi9 = (augvMatrahi9 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi9 = 0;
                    }

                    // Ekim Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut10 >= abrut)
                    {
                        if (augvKumulatif10 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi10 = (augvMatrahi10 * 0.15);
                        }
                        else if (augvKumulatif10 > gelirVergisiDilimi1 && augvKumulatif10 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif9 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi10 = ((gelirVergisiDilimi1 - augvKumulatif9) * 0.15) + ((augvKumulatif10 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi10 = (augvMatrahi10 * 0.20);
                            }
                        }
                        else if (augvKumulatif10 > gelirVergisiDilimi2 && augvKumulatif10 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif9 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi10 = ((gelirVergisiDilimi2 - augvKumulatif9) * 0.20) + ((augvKumulatif10 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi10 = (augvMatrahi10 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi10 = 0;
                    }


                    // Kasım Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut11 >= abrut)
                    {
                        if (augvKumulatif11 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi11 = (augvMatrahi11 * 0.15);
                        }
                        else if (augvKumulatif11 > gelirVergisiDilimi1 && augvKumulatif11 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif10 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi11 = ((gelirVergisiDilimi1 - augvKumulatif10) * 0.15) + ((augvKumulatif11 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi11 = (augvMatrahi11 * 0.20);
                            }
                        }
                        else if (augvKumulatif11 > gelirVergisiDilimi2 && augvKumulatif11 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif10 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi11 = ((gelirVergisiDilimi2 - augvKumulatif10) * 0.20) + ((augvKumulatif11 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi11 = (augvMatrahi11 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi11 = 0;
                    }


                    // Aralık Ayı Gelir Vergisi Hesaplamaları

                    if (aubrut12 >= abrut)
                    {

                        if (augvKumulatif12 <= gelirVergisiDilimi1)
                        {
                            augelirVergisi12 = (augvMatrahi12 * 0.15);
                        }
                        else if (augvKumulatif12 > gelirVergisiDilimi1 && augvKumulatif12 <= gelirVergisiDilimi2)
                        {
                            if (augvKumulatif11 <= gelirVergisiDilimi1)
                            {
                                augelirVergisi12 = ((gelirVergisiDilimi1 - augvKumulatif11) * 0.15) + ((augvKumulatif12 - gelirVergisiDilimi1) * 0.20);
                            }
                            else
                            {
                                augelirVergisi12 = (augvMatrahi12 * 0.20);
                            }
                        }
                        else if (augvKumulatif12 > gelirVergisiDilimi2 && augvKumulatif12 <= gelirVergisiDilimi3)
                        {
                            if (augvKumulatif11 <= gelirVergisiDilimi2)
                            {
                                augelirVergisi12 = ((gelirVergisiDilimi2 - augvKumulatif11) * 0.20) + ((augvKumulatif12 - gelirVergisiDilimi2) * 0.27);
                            }
                            else
                            {
                                augelirVergisi12 = (augvMatrahi12 * 0.27);
                            }
                        }
                    }
                    else
                    {
                        augelirVergisi12 = 0;
                    }

                }



                // Gelir Vergisi Dilimi ve Gelir Vergisi Hesaplama

                if (1 == 1)
                {
                    if (brut1 >= abrut)
                    {
                        // Ocak Ayı Gelir Vergisi Hesaplamaları

                        if (gvKumulatif1 <= gelirVergisiDilimi1)
                        {
                            txtDilim1.Text = "%15".ToString();
                            gelirVergisi1 = (gvMatrahi1 * 0.15) - augelirVergisi1;
                            txtGelirVergisi1.Text = string.Format("{0:C}", gelirVergisi1).ToString();
                        }
                        else if (gvKumulatif1 > gelirVergisiDilimi1 && gvKumulatif1 <= gelirVergisiDilimi2)
                        {
                            txtDilim1.Text = "%15-20".ToString();
                            gelirVergisi1 = ((((gvKumulatif1 - gelirVergisiDilimi1) * 0.20) + gelirVergisiDilimi2Fazlaligi) - augelirVergisi1);
                            txtGelirVergisi1.Text = string.Format("{0:C}", gelirVergisi1).ToString();
                        }
                        else if (gvKumulatif1 > gelirVergisiDilimi2 && gvKumulatif1 <= gelirVergisiDilimi3)
                        {
                            txtDilim1.Text = "%15-27".ToString();
                            gelirVergisi1 = ((((gvKumulatif1 - gelirVergisiDilimi2) * 0.27) + gelirVergisiDilimi3Fazlaligi) - augelirVergisi1);
                            txtGelirVergisi1.Text = string.Format("{0:C}", gelirVergisi1).ToString();
                        }
                        else if (gvKumulatif1 > gelirVergisiDilimi2 && gvKumulatif1 <= gelirVergisiDilimi3)
                        {
                            txtDilim1.Text = "%15-35".ToString();
                            gelirVergisi1 = ((((gvKumulatif1 - gelirVergisiDilimi3) * 0.35) + gelirVergisiDilimi4Fazlaligi) - augelirVergisi1);
                            txtGelirVergisi1.Text = string.Format("{0:C}", gelirVergisi1).ToString();
                        }
                        else if (gvKumulatif1 > gelirVergisiDilimi4)
                        {
                            txtDilim1.Text = "%15-40".ToString();
                            gelirVergisi1 = ((((gvKumulatif1 - gelirVergisiDilimi4) * 0.40) + gelirVergisiDilimi5Fazlaligi) - augelirVergisi1);
                            txtGelirVergisi1.Text = string.Format("{0:C}", gelirVergisi1).ToString();
                        }
                    }
                    else
                    {
                        txtDilim1.Text = "--";
                        txtGelirVergisi1.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Şubat Ayı Gelir Vergisi Hesaplamaları

                    if (brut2 >= abrut)
                    {
                        if (gvKumulatif2 <= gelirVergisiDilimi1)
                        {
                            txtDilim2.Text = "%15".ToString();
                            gelirVergisi2 = (gvMatrahi2 * 0.15) - augelirVergisi2;
                            txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                        }
                        else if (gvKumulatif2 > gelirVergisiDilimi1 && gvKumulatif2 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif1 <= gelirVergisiDilimi1)
                            {
                                txtDilim2.Text = "%15-20".ToString();
                                gelirVergisi2 = ((gelirVergisiDilimi1 - gvKumulatif1) * 0.15) + ((gvKumulatif2 - gelirVergisiDilimi1) * 0.20) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                            else
                            {
                                txtDilim2.Text = "%20".ToString();
                                gelirVergisi2 = (gvMatrahi2 * 0.20) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                        }
                        else if (gvKumulatif2 > gelirVergisiDilimi2 && gvKumulatif2 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif1 <= gelirVergisiDilimi2)
                            {
                                txtDilim2.Text = "%20-27".ToString();
                                gelirVergisi2 = ((gelirVergisiDilimi2 - gvKumulatif1) * 0.20) + ((gvKumulatif2 - gelirVergisiDilimi2) * 0.27) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                            else
                            {
                                txtDilim2.Text = "%27".ToString();
                                gelirVergisi2 = (gvMatrahi2 * 0.27) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                        }
                        else if (gvKumulatif2 > gelirVergisiDilimi3 && gvKumulatif2 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif1 <= gelirVergisiDilimi3)
                            {
                                txtDilim2.Text = "%27-35".ToString();
                                gelirVergisi2 = ((gelirVergisiDilimi3 - gvKumulatif1) * 0.27) + ((gvKumulatif2 - gelirVergisiDilimi3) * 0.35) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                            else
                            {
                                txtDilim2.Text = "%35".ToString();
                                gelirVergisi2 = (gvMatrahi2 * 0.35) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                        }
                        else if (gvMatrahi2 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi1 <= gelirVergisiDilimi4)
                            {
                                txtDilim2.Text = "%35-40".ToString();
                                gelirVergisi2 = ((gelirVergisiDilimi4 - gvKumulatif1) * 0.35) + ((gvKumulatif2 - gelirVergisiDilimi3) * 0.40) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                            else
                            {
                                txtDilim2.Text = "%40".ToString();
                                gelirVergisi2 = (gvMatrahi2 * 0.40) - augelirVergisi2;
                                txtGelirVergisi2.Text = string.Format("{0:C}", gelirVergisi2).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim2.Text = "--";
                        txtGelirVergisi2.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Mart Ayı Gelir Vergisi Hesaplamaları

                    if (brut3 >= abrut)
                    {


                        if (gvKumulatif3 <= gelirVergisiDilimi1)
                        {
                            txtDilim3.Text = "%15".ToString();
                            gelirVergisi3 = (gvMatrahi3 * 0.15) - augelirVergisi3;
                            txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                        }
                        else if (gvKumulatif3 > gelirVergisiDilimi1 && gvKumulatif3 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif2 <= gelirVergisiDilimi1)
                            {
                                txtDilim3.Text = "%15-20".ToString();
                                gelirVergisi3 = ((gelirVergisiDilimi1 - gvKumulatif2) * 0.15) + ((gvKumulatif3 - gelirVergisiDilimi1) * 0.20) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                            else
                            {
                                txtDilim3.Text = "%20".ToString();
                                gelirVergisi3 = (gvMatrahi3 * 0.20) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                        }
                        else if (gvKumulatif3 > gelirVergisiDilimi2 && gvKumulatif3 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif2 <= gelirVergisiDilimi2)
                            {
                                txtDilim3.Text = "%20-27".ToString();
                                gelirVergisi3 = ((gelirVergisiDilimi2 - gvKumulatif2) * 0.20) + ((gvKumulatif3 - gelirVergisiDilimi2) * 0.27) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                            else
                            {
                                txtDilim3.Text = "%27".ToString();
                                gelirVergisi3 = (gvMatrahi3 * 0.27) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                        }
                        else if (gvKumulatif3 > gelirVergisiDilimi3 && gvKumulatif3 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif2 <= gelirVergisiDilimi3)
                            {
                                txtDilim3.Text = "%27-35".ToString();
                                gelirVergisi3 = ((gelirVergisiDilimi3 - gvKumulatif2) * 0.27) + ((gvKumulatif3 - gelirVergisiDilimi3) * 0.35) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                            else
                            {
                                txtDilim3.Text = "%35".ToString();
                                gelirVergisi3 = (gvMatrahi3 * 0.35) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                        }
                        else if (gvMatrahi3 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi2 <= gelirVergisiDilimi4)
                            {
                                txtDilim3.Text = "%35-40".ToString();
                                gelirVergisi3 = ((gelirVergisiDilimi4 - gvKumulatif2) * 0.35) + ((gvKumulatif3 - gelirVergisiDilimi3) * 0.40) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                            else
                            {
                                txtDilim3.Text = "%40".ToString();
                                gelirVergisi3 = (gvMatrahi3 * 0.40) - augelirVergisi3;
                                txtGelirVergisi3.Text = string.Format("{0:C}", gelirVergisi3).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim3.Text = "--";
                        txtGelirVergisi3.Text = string.Format("{0:C}", 0).ToString();
                    }

                    // Nisan Ayı Gelir Vergisi Hesaplamaları

                    if (brut4 >= abrut)
                    {


                        if (gvKumulatif4 <= gelirVergisiDilimi1)
                        {
                            txtDilim4.Text = "%15".ToString();
                            gelirVergisi4 = (gvMatrahi4 * 0.15) - augelirVergisi4;
                            txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                        }
                        else if (gvKumulatif4 > gelirVergisiDilimi1 && gvKumulatif4 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif3 <= gelirVergisiDilimi1)
                            {
                                txtDilim4.Text = "%15-20".ToString();
                                gelirVergisi4 = ((gelirVergisiDilimi1 - gvKumulatif3) * 0.15) + ((gvKumulatif4 - gelirVergisiDilimi1) * 0.20) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                            else
                            {
                                txtDilim4.Text = "%20".ToString();
                                gelirVergisi4 = (gvMatrahi4 * 0.20) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                        }
                        else if (gvKumulatif4 > gelirVergisiDilimi2 && gvKumulatif4 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif3 <= gelirVergisiDilimi2)
                            {
                                txtDilim4.Text = "%20-27".ToString();
                                gelirVergisi4 = ((gelirVergisiDilimi2 - gvKumulatif3) * 0.20) + ((gvKumulatif4 - gelirVergisiDilimi2) * 0.27) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                            else
                            {
                                txtDilim4.Text = "%27".ToString();
                                gelirVergisi4 = (gvMatrahi4 * 0.27) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                        }
                        else if (gvKumulatif4 > gelirVergisiDilimi3 && gvKumulatif4 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif3 <= gelirVergisiDilimi3)
                            {
                                txtDilim4.Text = "%27-35".ToString();
                                gelirVergisi4 = ((gelirVergisiDilimi3 - gvKumulatif3) * 0.27) + ((gvKumulatif4 - gelirVergisiDilimi3) * 0.35) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                            else
                            {
                                txtDilim4.Text = "%35".ToString();
                                gelirVergisi4 = (gvMatrahi4 * 0.35) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                        }
                        else if (gvMatrahi4 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi3 <= gelirVergisiDilimi4)
                            {
                                txtDilim4.Text = "%35-40".ToString();
                                gelirVergisi4 = ((gelirVergisiDilimi4 - gvKumulatif3) * 0.35) + ((gvKumulatif4 - gelirVergisiDilimi3) * 0.40) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                            else
                            {
                                txtDilim4.Text = "%40".ToString();
                                gelirVergisi4 = (gvMatrahi4 * 0.40) - augelirVergisi4;
                                txtGelirVergisi4.Text = string.Format("{0:C}", gelirVergisi4).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim4.Text = "--";
                        txtGelirVergisi4.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Mayıs Ayı Gelir Vergisi Hesaplamaları

                    if (brut5 >= abrut)
                    {

                        if (gvKumulatif5 <= gelirVergisiDilimi1)
                        {
                            txtDilim5.Text = "%15".ToString();
                            gelirVergisi5 = (gvMatrahi5 * 0.15) - augelirVergisi5;
                            txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                        }
                        else if (gvKumulatif5 > gelirVergisiDilimi1 && gvKumulatif5 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif4 <= gelirVergisiDilimi1)
                            {
                                txtDilim5.Text = "%15-20".ToString();
                                gelirVergisi5 = ((gelirVergisiDilimi1 - gvKumulatif4) * 0.15) + ((gvKumulatif5 - gelirVergisiDilimi1) * 0.20) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                            else
                            {
                                txtDilim5.Text = "%20".ToString();
                                gelirVergisi5 = (gvMatrahi5 * 0.20) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                        }
                        else if (gvKumulatif5 > gelirVergisiDilimi2 && gvKumulatif5 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif4 <= gelirVergisiDilimi2)
                            {
                                txtDilim5.Text = "%20-27".ToString();
                                gelirVergisi5 = ((gelirVergisiDilimi2 - gvKumulatif4) * 0.20) + ((gvKumulatif5 - gelirVergisiDilimi2) * 0.27) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                            else
                            {
                                txtDilim5.Text = "%27".ToString();
                                gelirVergisi5 = (gvMatrahi5 * 0.27) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                        }
                        else if (gvKumulatif5 > gelirVergisiDilimi3 && gvKumulatif5 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif4 <= gelirVergisiDilimi3)
                            {
                                txtDilim5.Text = "%27-35".ToString();
                                gelirVergisi5 = ((gelirVergisiDilimi3 - gvKumulatif4) * 0.27) + ((gvKumulatif5 - gelirVergisiDilimi3) * 0.35) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                            else
                            {
                                txtDilim5.Text = "%35".ToString();
                                gelirVergisi5 = (gvMatrahi5 * 0.35) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                        }
                        else if (gvMatrahi5 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi4 <= gelirVergisiDilimi4)
                            {
                                txtDilim5.Text = "%35-40".ToString();
                                gelirVergisi5 = ((gelirVergisiDilimi4 - gvKumulatif4) * 0.35) + ((gvKumulatif5 - gelirVergisiDilimi3) * 0.40) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                            else
                            {
                                txtDilim5.Text = "%40".ToString();
                                gelirVergisi5 = (gvMatrahi5 * 0.40) - augelirVergisi5;
                                txtGelirVergisi5.Text = string.Format("{0:C}", gelirVergisi5).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim5.Text = "--";
                        txtGelirVergisi5.Text = string.Format("{0:C}", 0).ToString();
                    }

                    // Haziran Ayı Gelir Vergisi Hesaplamaları

                    if (brut6 >= abrut)
                    {

                        if (gvKumulatif6 <= gelirVergisiDilimi1)
                        {
                            txtDilim6.Text = "%15".ToString();
                            gelirVergisi6 = (gvMatrahi6 * 0.15) - augelirVergisi6;
                            txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                        }
                        else if (gvKumulatif6 > gelirVergisiDilimi1 && gvKumulatif6 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif5 <= gelirVergisiDilimi1)
                            {
                                txtDilim6.Text = "%15-20".ToString();
                                gelirVergisi6 = ((gelirVergisiDilimi1 - gvKumulatif5) * 0.15) + ((gvKumulatif6 - gelirVergisiDilimi1) * 0.20) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                            else
                            {
                                txtDilim6.Text = "%20".ToString();
                                gelirVergisi6 = (gvMatrahi6 * 0.20) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                        }
                        else if (gvKumulatif6 > gelirVergisiDilimi2 && gvKumulatif6 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif5 <= gelirVergisiDilimi2)
                            {
                                txtDilim6.Text = "%20-27".ToString();
                                gelirVergisi6 = ((gelirVergisiDilimi2 - gvKumulatif5) * 0.20) + ((gvKumulatif6 - gelirVergisiDilimi2) * 0.27) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                            else
                            {
                                txtDilim6.Text = "%27".ToString();
                                gelirVergisi6 = (gvMatrahi6 * 0.27) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                        }
                        else if (gvKumulatif6 > gelirVergisiDilimi3 && gvKumulatif6 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif5 <= gelirVergisiDilimi3)
                            {
                                txtDilim6.Text = "%27-35".ToString();
                                gelirVergisi6 = ((gelirVergisiDilimi3 - gvKumulatif5) * 0.27) + ((gvKumulatif6 - gelirVergisiDilimi3) * 0.35) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                            else
                            {
                                txtDilim6.Text = "%35".ToString();
                                gelirVergisi6 = (gvMatrahi6 * 0.35) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                        }
                        else if (gvMatrahi6 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi5 <= gelirVergisiDilimi4)
                            {
                                txtDilim6.Text = "%35-40".ToString();
                                gelirVergisi6 = ((gelirVergisiDilimi4 - gvKumulatif5) * 0.35) + ((gvKumulatif6 - gelirVergisiDilimi3) * 0.40) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                            else
                            {
                                txtDilim6.Text = "%40".ToString();
                                gelirVergisi6 = (gvMatrahi6 * 0.40) - augelirVergisi6;
                                txtGelirVergisi6.Text = string.Format("{0:C}", gelirVergisi6).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim6.Text = "--";
                        txtGelirVergisi6.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Temmuz Ayı Gelir Vergisi Hesaplamaları

                    if (brut7 >= abrut)
                    {


                        if (gvKumulatif7 <= gelirVergisiDilimi1)
                        {
                            txtDilim7.Text = "%15".ToString();
                            gelirVergisi7 = (gvMatrahi7 * 0.15) - augelirVergisi7;
                            txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                        }
                        else if (gvKumulatif7 > gelirVergisiDilimi1 && gvKumulatif7 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif6 <= gelirVergisiDilimi1)
                            {
                                txtDilim7.Text = "%15-20".ToString();
                                gelirVergisi7 = ((gelirVergisiDilimi1 - gvKumulatif6) * 0.15) + ((gvKumulatif7 - gelirVergisiDilimi1) * 0.20) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                            else
                            {
                                txtDilim7.Text = "%20".ToString();
                                gelirVergisi7 = (gvMatrahi7 * 0.20) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                        }
                        else if (gvKumulatif7 > gelirVergisiDilimi2 && gvKumulatif7 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif6 <= gelirVergisiDilimi2)
                            {
                                txtDilim7.Text = "%20-27".ToString();
                                gelirVergisi7 = ((gelirVergisiDilimi2 - gvKumulatif6) * 0.20) + ((gvKumulatif7 - gelirVergisiDilimi2) * 0.27) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                            else
                            {
                                txtDilim7.Text = "%27".ToString();
                                gelirVergisi7 = (gvMatrahi7 * 0.27) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                        }
                        else if (gvKumulatif7 > gelirVergisiDilimi3 && gvKumulatif7 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif6 <= gelirVergisiDilimi3)
                            {
                                txtDilim7.Text = "%27-35".ToString();
                                gelirVergisi7 = ((gelirVergisiDilimi3 - gvKumulatif6) * 0.27) + ((gvKumulatif7 - gelirVergisiDilimi3) * 0.35) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                            else
                            {
                                txtDilim7.Text = "%35".ToString();
                                gelirVergisi7 = (gvMatrahi7 * 0.35) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                        }
                        else if (gvMatrahi7 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi6 <= gelirVergisiDilimi4)
                            {
                                txtDilim7.Text = "%35-40".ToString();
                                gelirVergisi7 = ((gelirVergisiDilimi4 - gvKumulatif6) * 0.35) + ((gvKumulatif7 - gelirVergisiDilimi3) * 0.40) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                            else
                            {
                                txtDilim7.Text = "%40".ToString();
                                gelirVergisi7 = (gvMatrahi7 * 0.40) - augelirVergisi7;
                                txtGelirVergisi7.Text = string.Format("{0:C}", gelirVergisi7).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim7.Text = "--";
                        txtGelirVergisi7.Text = string.Format("{0:C}", 0).ToString();
                    }

                    // Ağustos Ayı Gelir Vergisi Hesaplamaları

                    if (brut8 >= abrut)
                    {

                        if (gvKumulatif8 <= gelirVergisiDilimi1)
                        {
                            txtDilim8.Text = "%15".ToString();
                            gelirVergisi8 = (gvMatrahi8 * 0.15) - augelirVergisi8;
                            txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                        }
                        else if (gvKumulatif8 > gelirVergisiDilimi1 && gvKumulatif8 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif7 <= gelirVergisiDilimi1)
                            {
                                txtDilim8.Text = "%15-20".ToString();
                                gelirVergisi8 = ((gelirVergisiDilimi1 - gvKumulatif7) * 0.15) + ((gvKumulatif8 - gelirVergisiDilimi1) * 0.20) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                            else
                            {
                                txtDilim8.Text = "%20".ToString();
                                gelirVergisi8 = (gvMatrahi8 * 0.20) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                        }
                        else if (gvKumulatif8 > gelirVergisiDilimi2 && gvKumulatif8 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif7 <= gelirVergisiDilimi2)
                            {
                                txtDilim8.Text = "%20-27".ToString();
                                gelirVergisi8 = ((gelirVergisiDilimi2 - gvKumulatif7) * 0.20) + ((gvKumulatif8 - gelirVergisiDilimi2) * 0.27) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                            else
                            {
                                txtDilim8.Text = "%27".ToString();
                                gelirVergisi8 = (gvMatrahi8 * 0.27) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                        }
                        else if (gvKumulatif8 > gelirVergisiDilimi3 && gvKumulatif8 <= gelirVergisiDilimi4) // 612000 > 580000 && 612000 <= 230000
                        {
                            if (gvKumulatif7 <= gelirVergisiDilimi3)
                            {
                                txtDilim8.Text = "%27-35".ToString();
                                gelirVergisi8 = ((gelirVergisiDilimi3 - gvKumulatif7) * 0.27) + ((gvKumulatif8 - gelirVergisiDilimi3) * 0.35) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                            else
                            {
                                txtDilim8.Text = "%35".ToString();
                                gelirVergisi8 = (gvMatrahi8 * 0.35) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                        }
                        else if (gvMatrahi8 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi9 <= gelirVergisiDilimi4)
                            {
                                txtDilim8.Text = "%35-40".ToString();
                                gelirVergisi8 = ((gelirVergisiDilimi4 - gvKumulatif7) * 0.35) + ((gvKumulatif8 - gelirVergisiDilimi3) * 0.40) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                            else
                            {
                                txtDilim8.Text = "%40".ToString();
                                gelirVergisi8 = (gvMatrahi8 * 0.40) - augelirVergisi8;
                                txtGelirVergisi8.Text = string.Format("{0:C}", gelirVergisi8).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim8.Text = "--";
                        txtGelirVergisi8.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Eylül Ayı Gelir Vergisi Hesaplamaları

                    if (brut9 >= abrut)
                    {

                        if (gvKumulatif9 <= gelirVergisiDilimi1)
                        {
                            txtDilim9.Text = "%15".ToString();
                            gelirVergisi9 = (gvMatrahi9 * 0.15) - augelirVergisi9;
                            txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                        }
                        else if (gvKumulatif9 > gelirVergisiDilimi1 && gvKumulatif9 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif8 <= gelirVergisiDilimi1)
                            {
                                txtDilim9.Text = "%15-20".ToString();
                                gelirVergisi9 = ((gelirVergisiDilimi1 - gvKumulatif8) * 0.15) + ((gvKumulatif9 - gelirVergisiDilimi1) * 0.20) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                            else
                            {
                                txtDilim9.Text = "%20".ToString();
                                gelirVergisi9 = (gvMatrahi9 * 0.20) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                        }
                        else if (gvKumulatif9 > gelirVergisiDilimi2 && gvKumulatif9 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif8 <= gelirVergisiDilimi2)
                            {
                                txtDilim9.Text = "%20-27".ToString();
                                gelirVergisi9 = ((gelirVergisiDilimi2 - gvKumulatif8) * 0.20) + ((gvKumulatif9 - gelirVergisiDilimi2) * 0.27) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                            else
                            {
                                txtDilim9.Text = "%27".ToString();
                                gelirVergisi9 = (gvMatrahi9 * 0.27) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                        }
                        else if (gvKumulatif9 > gelirVergisiDilimi3 && gvKumulatif9 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif8 <= gelirVergisiDilimi3)
                            {
                                txtDilim9.Text = "%27-35".ToString();
                                gelirVergisi9 = ((gelirVergisiDilimi3 - gvKumulatif8) * 0.27) + ((gvKumulatif9 - gelirVergisiDilimi3) * 0.35) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                            else
                            {
                                txtDilim9.Text = "%35".ToString();
                                gelirVergisi9 = (gvMatrahi9 * 0.35) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                        }
                        else if (gvMatrahi9 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi8 <= gelirVergisiDilimi4)
                            {
                                txtDilim9.Text = "%35-40".ToString();
                                gelirVergisi9 = ((gelirVergisiDilimi4 - gvKumulatif8) * 0.35) + ((gvKumulatif9 - gelirVergisiDilimi3) * 0.40) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                            else
                            {
                                txtDilim9.Text = "%40".ToString();
                                gelirVergisi9 = (gvMatrahi9 * 0.40) - augelirVergisi9;
                                txtGelirVergisi9.Text = string.Format("{0:C}", gelirVergisi9).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim9.Text = "--";
                        txtGelirVergisi9.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Ekim Ayı Gelir Vergisi Hesaplamaları

                    if (brut10 >= abrut)
                    {

                        if (gvKumulatif10 <= gelirVergisiDilimi1)
                        {
                            txtDilim10.Text = "%15".ToString();
                            gelirVergisi10 = (gvMatrahi10 * 0.15) - augelirVergisi10;
                            txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                        }
                        else if (gvKumulatif10 > gelirVergisiDilimi1 && gvKumulatif10 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif9 <= gelirVergisiDilimi1)
                            {
                                txtDilim10.Text = "%15-20".ToString();
                                gelirVergisi10 = ((gelirVergisiDilimi1 - gvKumulatif9) * 0.15) + ((gvKumulatif10 - gelirVergisiDilimi1) * 0.20) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                            else
                            {
                                txtDilim10.Text = "%20".ToString();
                                gelirVergisi10 = (gvMatrahi10 * 0.20) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                        }
                        else if (gvKumulatif10 > gelirVergisiDilimi2 && gvKumulatif10 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif9 <= gelirVergisiDilimi2)
                            {
                                txtDilim10.Text = "%20-27".ToString();
                                gelirVergisi10 = ((gelirVergisiDilimi2 - gvKumulatif9) * 0.20) + ((gvKumulatif10 - gelirVergisiDilimi2) * 0.27) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();

                            }
                            else
                            {
                                txtDilim10.Text = "%27".ToString();
                                gelirVergisi10 = (gvMatrahi10 * 0.27) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                        }
                        else if (gvKumulatif10 > gelirVergisiDilimi3 && gvKumulatif10 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif9 <= gelirVergisiDilimi3)
                            {
                                txtDilim10.Text = "%27-35".ToString();
                                gelirVergisi10 = ((gelirVergisiDilimi3 - gvKumulatif9) * 0.27) + ((gvKumulatif10 - gelirVergisiDilimi3) * 0.35) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                            else
                            {
                                txtDilim10.Text = "%35".ToString();
                                gelirVergisi10 = (gvMatrahi10 * 0.35) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                        }
                        else if (gvMatrahi10 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi9 <= gelirVergisiDilimi4)
                            {
                                txtDilim10.Text = "%35-40".ToString();
                                gelirVergisi10 = ((gelirVergisiDilimi4 - gvKumulatif9) * 0.35) + ((gvKumulatif10 - gelirVergisiDilimi3) * 0.40) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                            else
                            {
                                txtDilim10.Text = "%40".ToString();
                                gelirVergisi10 = (gvMatrahi10 * 0.40) - augelirVergisi10;
                                txtGelirVergisi10.Text = string.Format("{0:C}", gelirVergisi10).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim10.Text = "--";
                        txtGelirVergisi10.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Kasım Ayı Gelir Vergisi Hesaplamaları

                    if (brut11 >= abrut)
                    {


                        if (gvKumulatif11 <= gelirVergisiDilimi1)
                        {
                            txtDilim11.Text = "%15".ToString();
                            gelirVergisi11 = (gvMatrahi11 * 0.15) - augelirVergisi11;
                            txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                        }
                        else if (gvKumulatif11 > gelirVergisiDilimi1 && gvKumulatif11 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif10 <= gelirVergisiDilimi1)
                            {
                                txtDilim11.Text = "%15-20".ToString();
                                gelirVergisi11 = ((gelirVergisiDilimi1 - gvKumulatif10) * 0.15) + ((gvKumulatif11 - gelirVergisiDilimi1) * 0.20) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                            else
                            {
                                txtDilim11.Text = "%20".ToString();
                                gelirVergisi11 = (gvMatrahi11 * 0.20) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                        }
                        else if (gvKumulatif11 > gelirVergisiDilimi2 && gvKumulatif11 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif10 <= gelirVergisiDilimi2)
                            {
                                txtDilim11.Text = "%20-27".ToString();
                                gelirVergisi11 = ((gelirVergisiDilimi2 - gvKumulatif10) * 0.20) + ((gvKumulatif11 - gelirVergisiDilimi2) * 0.27) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                            else
                            {
                                txtDilim11.Text = "%27".ToString();
                                gelirVergisi11 = (gvMatrahi11 * 0.27) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                        }
                        else if (gvKumulatif11 > gelirVergisiDilimi3 && gvKumulatif11 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif10 <= gelirVergisiDilimi3)
                            {
                                txtDilim11.Text = "%27-35".ToString();
                                gelirVergisi11 = ((gelirVergisiDilimi3 - gvKumulatif10) * 0.27) + ((gvKumulatif11 - gelirVergisiDilimi3) * 0.35) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                            else
                            {
                                txtDilim11.Text = "%35".ToString();
                                gelirVergisi11 = (gvMatrahi11 * 0.35) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                        }
                        else if (gvMatrahi11 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi10 <= gelirVergisiDilimi4)
                            {
                                txtDilim11.Text = "%35-40".ToString();
                                gelirVergisi11 = ((gelirVergisiDilimi4 - gvKumulatif10) * 0.35) + ((gvKumulatif11 - gelirVergisiDilimi3) * 0.40) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                            else
                            {
                                txtDilim11.Text = "%40".ToString();
                                gelirVergisi11 = (gvMatrahi11 * 0.40) - augelirVergisi11;
                                txtGelirVergisi11.Text = string.Format("{0:C}", gelirVergisi11).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim11.Text = "--";
                        txtGelirVergisi11.Text = string.Format("{0:C}", 0).ToString();
                    }


                    // Aralık Ayı Gelir Vergisi Hesaplamaları

                    if (brut12 >= abrut)
                    {

                        if (gvKumulatif12 <= gelirVergisiDilimi1)
                        {
                            txtDilim12.Text = "%15".ToString();
                            gelirVergisi12 = (gvMatrahi12 * 0.15) - augelirVergisi12;
                            txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                        }
                        else if (gvKumulatif12 > gelirVergisiDilimi1 && gvKumulatif12 <= gelirVergisiDilimi2)
                        {
                            if (gvKumulatif11 <= gelirVergisiDilimi1)
                            {
                                txtDilim12.Text = "%15-20".ToString();
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                                gelirVergisi12 = ((gelirVergisiDilimi1 - gvKumulatif11) * 0.15) + ((gvKumulatif12 - gelirVergisiDilimi1) * 0.20) - augelirVergisi12;
                            }
                            else
                            {
                                txtDilim12.Text = "%20".ToString();
                                gelirVergisi12 = (gvMatrahi12 * 0.20) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                        }
                        else if (gvKumulatif12 > gelirVergisiDilimi2 && gvKumulatif12 <= gelirVergisiDilimi3)
                        {
                            if (gvKumulatif11 <= gelirVergisiDilimi2)
                            {
                                txtDilim12.Text = "%20-27".ToString();
                                gelirVergisi12 = ((gelirVergisiDilimi2 - gvKumulatif11) * 0.20) + ((gvKumulatif12 - gelirVergisiDilimi2) * 0.27) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                            else
                            {
                                txtDilim12.Text = "%27".ToString();
                                gelirVergisi12 = (gvMatrahi12 * 0.27) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                        }
                        else if (gvKumulatif12 > gelirVergisiDilimi3 && gvKumulatif12 <= gelirVergisiDilimi4)
                        {
                            if (gvKumulatif11 <= gelirVergisiDilimi3)
                            {
                                txtDilim12.Text = "%27-35".ToString();
                                gelirVergisi12 = ((gelirVergisiDilimi3 - gvKumulatif11) * 0.27) + ((gvKumulatif12 - gelirVergisiDilimi3) * 0.35) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                            else
                            {
                                txtDilim12.Text = "%35".ToString();
                                gelirVergisi12 = (gvMatrahi12 * 0.35) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                        }
                        else if (gvMatrahi12 > gelirVergisiDilimi4)
                        {
                            if (gvMatrahi11 <= gelirVergisiDilimi4)
                            {
                                txtDilim12.Text = "%35-40".ToString();
                                gelirVergisi12 = ((gelirVergisiDilimi4 - gvKumulatif11) * 0.35) + ((gvKumulatif12 - gelirVergisiDilimi3) * 0.40) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                            else
                            {
                                txtDilim12.Text = "%40".ToString();
                                gelirVergisi12 = (gvMatrahi12 * 0.40) - augelirVergisi12;
                                txtGelirVergisi12.Text = string.Format("{0:C}", gelirVergisi12).ToString();
                            }
                        }
                    }
                    else
                    {
                        txtDilim12.Text = "--";
                        txtGelirVergisi12.Text = string.Format("{0:C}", 0).ToString();
                    }
                }



                // Asgari Ücret Damga Vergisi Hesaplaması
                if (1 == 1)
                {

                    if (aubrut1 >= abrut)
                    {
                        audamgaVergisi1 = Math.Round((aubrut1 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi1 = 0;
                    }

                    if (aubrut2 >= abrut)
                    {
                        audamgaVergisi2 = Math.Round((aubrut2 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi2 = 0;
                    }
                    if (aubrut3 >= abrut)
                    {
                        audamgaVergisi3 = Math.Round((aubrut3 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi3 = 0;
                    }
                    if (aubrut4 >= abrut)
                    {
                        audamgaVergisi4 = Math.Round((aubrut4 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi4 = 0;
                    }
                    if (aubrut5 >= abrut)
                    {
                        audamgaVergisi5 = Math.Round((aubrut5 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi5 = 0;
                    }
                    if (aubrut6 >= abrut)
                    {
                        audamgaVergisi6 = Math.Round((aubrut6 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi6 = 0;
                    }
                    if (aubrut7 >= abrut)
                    {
                        audamgaVergisi7 = Math.Round((aubrut7 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi7 = 0;
                    }
                    if (aubrut8 >= abrut)
                    {
                        audamgaVergisi8 = Math.Round((aubrut8 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi8 = 0;
                    }
                    if (aubrut9 >= abrut)
                    {
                        audamgaVergisi9 = Math.Round((aubrut9 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi9 = 0;
                    }
                    if (aubrut10 >= abrut)
                    {
                        audamgaVergisi10 = Math.Round((aubrut10 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi10 = 0;
                    }
                    if (aubrut11 >= abrut)
                    {
                        audamgaVergisi11 = Math.Round((aubrut11 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi11 = 0;
                    }
                    if (aubrut12 >= abrut)
                    {
                        audamgaVergisi12 = Math.Round((aubrut12 * 0.00759), 2);
                    }
                    else
                    {
                        audamgaVergisi12 = 0;
                    }
                }



                // Damga Vergisi Hesaplaması

                if (1 == 1)
                {

                    if (txtBrut1.Text != "" && brut1 >= abrut)
                    {
                        damgaVergisi1 = Math.Round((brut1 * 0.00759) - audamgaVergisi1, 2);
                        txtDamgaVergisi1.Text = string.Format("{0:C}", damgaVergisi1).ToString();
                    }
                    else
                    {
                        damgaVergisi1 = 0;
                        txtDamgaVergisi1.Text = string.Format("{0:C}", damgaVergisi1).ToString();
                    }

                    if (txtBrut2.Text != "" && brut2 >= abrut)
                    {
                        damgaVergisi2 = Math.Round((brut2 * 0.00759) - audamgaVergisi2, 2);
                        txtDamgaVergisi2.Text = string.Format("{0:C}", damgaVergisi1).ToString();
                    }
                    else
                    {
                        damgaVergisi2 = 0;
                        txtDamgaVergisi2.Text = string.Format("{0:C}", damgaVergisi2).ToString();
                    }
                    if (txtBrut3.Text != "" && brut3 >= abrut)
                    {
                        damgaVergisi3 = Math.Round((brut3 * 0.00759) - audamgaVergisi3, 2);
                        txtDamgaVergisi3.Text = string.Format("{0:C}", damgaVergisi3).ToString();
                    }
                    else
                    {
                        damgaVergisi3 = 0;
                        txtDamgaVergisi3.Text = string.Format("{0:C}", damgaVergisi3).ToString();
                    }
                    if (txtBrut4.Text != "" && brut4 >= abrut)
                    {
                        damgaVergisi4 = Math.Round((brut4 * 0.00759) - audamgaVergisi4, 2);
                        txtDamgaVergisi4.Text = string.Format("{0:C}", damgaVergisi4).ToString();
                    }
                    else
                    {
                        damgaVergisi4 = 0;
                        txtDamgaVergisi4.Text = string.Format("{0:C}", damgaVergisi4).ToString();
                    }
                    if (txtBrut5.Text != "" && brut5 >= abrut)
                    {
                        damgaVergisi5 = Math.Round((brut5 * 0.00759) - audamgaVergisi5, 2);
                        txtDamgaVergisi5.Text = string.Format("{0:C}", damgaVergisi5).ToString();
                    }
                    else
                    {
                        damgaVergisi5 = 0;
                        txtDamgaVergisi5.Text = string.Format("{0:C}", damgaVergisi5).ToString();
                    }
                    if (txtBrut6.Text != "" && brut6 >= abrut)
                    {
                        damgaVergisi6 = Math.Round((brut6 * 0.00759) - audamgaVergisi6, 2);
                        txtDamgaVergisi6.Text = string.Format("{0:C}", damgaVergisi6).ToString();
                    }
                    else
                    {
                        damgaVergisi6 = 0;
                        txtDamgaVergisi6.Text = string.Format("{0:C}", damgaVergisi6).ToString();
                    }
                    if (txtBrut7.Text != "" && brut7 >= abrut)
                    {
                        damgaVergisi7 = Math.Round((brut7 * 0.00759) - audamgaVergisi7, 2);
                        txtDamgaVergisi7.Text = string.Format("{0:C}", damgaVergisi7).ToString();
                    }
                    else
                    {
                        damgaVergisi7 = 0;
                        txtDamgaVergisi7.Text = string.Format("{0:C}", damgaVergisi7).ToString();
                    }
                    if (txtBrut8.Text != "" && brut8 >= abrut)
                    {
                        damgaVergisi8 = Math.Round((brut8 * 0.00759) - audamgaVergisi8, 2);
                        txtDamgaVergisi8.Text = string.Format("{0:C}", damgaVergisi8).ToString();
                    }
                    else
                    {
                        damgaVergisi8 = 0;
                        txtDamgaVergisi8.Text = string.Format("{0:C}", damgaVergisi8).ToString();
                    }
                    if (txtBrut9.Text != "" && brut9 >= abrut)
                    {
                        damgaVergisi9 = Math.Round((brut9 * 0.00759) - audamgaVergisi9, 2);
                        txtDamgaVergisi9.Text = string.Format("{0:C}", damgaVergisi9).ToString();
                    }
                    else
                    {
                        damgaVergisi9 = 0;
                        txtDamgaVergisi9.Text = string.Format("{0:C}", damgaVergisi9).ToString();
                    }
                    if (txtBrut10.Text != "" && brut10 >= abrut)
                    {
                        damgaVergisi10 = Math.Round((brut10 * 0.00759) - audamgaVergisi10, 2);
                        txtDamgaVergisi10.Text = string.Format("{0:C}", damgaVergisi10).ToString();
                    }
                    else
                    {
                        damgaVergisi10 = 0;
                        txtDamgaVergisi10.Text = string.Format("{0:C}", damgaVergisi10).ToString();
                    }
                    if (txtBrut11.Text != "" && brut11 >= abrut)
                    {
                        damgaVergisi11 = Math.Round((brut11 * 0.00759) - audamgaVergisi11, 2);
                        txtDamgaVergisi11.Text = string.Format("{0:C}", damgaVergisi11).ToString();
                    }
                    else
                    {
                        damgaVergisi11 = 0;
                        txtDamgaVergisi11.Text = string.Format("{0:C}", damgaVergisi11).ToString();
                    }
                    if (txtBrut12.Text != "" && brut12 >= abrut)
                    {
                        damgaVergisi12 = Math.Round((brut12 * 0.00759) - audamgaVergisi12, 2);
                        txtDamgaVergisi12.Text = string.Format("{0:C}", damgaVergisi12).ToString();
                    }
                    else
                    {
                        damgaVergisi12 = 0;
                        txtDamgaVergisi12.Text = string.Format("{0:C}", damgaVergisi12).ToString();
                    }
                }



                // Gelir Vergisi Muafiyeti textBox'lara aktarımı

                if (1 == 1)
                {
                    if (brut1 >= abrut)
                    {
                        txtGVMuafiyet1.Text = string.Format("{0:C}", augelirVergisi1).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet1.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut2 >= abrut)
                    {
                        txtGVMuafiyet2.Text = string.Format("{0:C}", augelirVergisi2).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet2.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut3 >= abrut)
                    {
                        txtGVMuafiyet3.Text = string.Format("{0:C}", augelirVergisi3).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet3.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut4 >= abrut)
                    {
                        txtGVMuafiyet4.Text = string.Format("{0:C}", augelirVergisi4).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet4.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut5 >= abrut)
                    {
                        txtGVMuafiyet5.Text = string.Format("{0:C}", augelirVergisi5).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet5.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut6 >= abrut)
                    {
                        txtGVMuafiyet6.Text = string.Format("{0:C}", augelirVergisi6).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet6.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut7 >= abrut)
                    {
                        txtGVMuafiyet7.Text = string.Format("{0:C}", augelirVergisi7).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet7.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut8 >= abrut)
                    {
                        txtGVMuafiyet8.Text = string.Format("{0:C}", augelirVergisi8).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet8.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut9 >= abrut)
                    {
                        txtGVMuafiyet9.Text = string.Format("{0:C}", augelirVergisi9).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet9.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut10 >= abrut)
                    {
                        txtGVMuafiyet10.Text = string.Format("{0:C}", augelirVergisi10).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet10.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut11 >= abrut)
                    {
                        txtGVMuafiyet11.Text = string.Format("{0:C}", augelirVergisi11).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet11.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut12 >= abrut)
                    {
                        txtGVMuafiyet12.Text = string.Format("{0:C}", augelirVergisi12).ToString();
                    }
                    else
                    {
                        txtGVMuafiyet12.Text = string.Format("{0:C}", 0).ToString();
                    }
                }



                // Damga Vergisi Muafiyetinin textBox'lara Atanması

                if (1 == 1)
                {
                    if (brut1 >= abrut)
                    {
                        txtDVMuafiyeti1.Text = string.Format("{0:C}", audamgaVergisi1).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti1.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut2 >= abrut)
                    {
                        txtDVMuafiyeti2.Text = string.Format("{0:C}", audamgaVergisi2).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti2.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut3 >= abrut)
                    {
                        txtDVMuafiyeti3.Text = string.Format("{0:C}", audamgaVergisi3).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti3.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut4 >= abrut)
                    {
                        txtDVMuafiyeti4.Text = string.Format("{0:C}", audamgaVergisi4).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti4.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut5 >= abrut)
                    {
                        txtDVMuafiyeti5.Text = string.Format("{0:C}", audamgaVergisi5).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti5.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut6 >= abrut)
                    {
                        txtDVMuafiyeti6.Text = string.Format("{0:C}", audamgaVergisi6).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti6.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut7 >= abrut)
                    {
                        txtDVMuafiyeti7.Text = string.Format("{0:C}", audamgaVergisi7).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti7.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut8 >= abrut)
                    {
                        txtDVMuafiyeti8.Text = string.Format("{0:C}", audamgaVergisi8).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti8.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut9 >= abrut)
                    {
                        txtDVMuafiyeti9.Text = string.Format("{0:C}", audamgaVergisi9).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti9.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut10 >= abrut)
                    {
                        txtDVMuafiyeti10.Text = string.Format("{0:C}", audamgaVergisi10).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti10.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut11 >= abrut)
                    {
                        txtDVMuafiyeti11.Text = string.Format("{0:C}", audamgaVergisi11).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti11.Text = string.Format("{0:C}", 0).ToString();
                    }

                    if (brut12 >= abrut)
                    {
                        txtDVMuafiyeti12.Text = string.Format("{0:C}", audamgaVergisi12).ToString();
                    }
                    else
                    {
                        txtDVMuafiyeti12.Text = string.Format("{0:C}", 0).ToString();
                    }
                }




                // Kestinler Toplamlarının Hesaplanması

                if (1 == 1)
                {

                    if (brut1 >= abrut)
                    {
                        kesintilerToplami1 = calisanSgkPrimi1 + calisanIssizlikSigortasi1 + gelirVergisi1 + damgaVergisi1;
                        txtKesintilerToplami1.Text = string.Format("{0:C}", kesintilerToplami1).ToString();
                    }
                    else
                    {
                        kesintilerToplami1 = 0;
                        txtKesintilerToplami1.Text = string.Format("{0:C}", kesintilerToplami1).ToString();
                    }

                    if (brut2 >= abrut)
                    {
                        kesintilerToplami2 = calisanSgkPrimi2 + calisanIssizlikSigortasi2 + gelirVergisi2 + damgaVergisi2;
                        txtKesintilerToplami2.Text = string.Format("{0:C}", kesintilerToplami2).ToString();
                    }
                    else
                    {
                        kesintilerToplami2 = 0;
                        txtKesintilerToplami2.Text = string.Format("{0:C}", kesintilerToplami2).ToString();
                    }

                    if (brut3 >= abrut)
                    {
                        kesintilerToplami3 = calisanSgkPrimi3 + calisanIssizlikSigortasi3 + gelirVergisi3 + damgaVergisi3;
                        txtKesintilerToplami3.Text = string.Format("{0:C}", kesintilerToplami3).ToString();
                    }
                    else
                    {
                        kesintilerToplami3 = 0;
                        txtKesintilerToplami3.Text = string.Format("{0:C}", kesintilerToplami3).ToString();
                    }

                    if (brut4 >= abrut)
                    {
                        kesintilerToplami4 = calisanSgkPrimi4 + calisanIssizlikSigortasi4 + gelirVergisi4 + damgaVergisi4;
                        txtKesintilerToplami4.Text = string.Format("{0:C}", kesintilerToplami4).ToString();
                    }
                    else
                    {
                        kesintilerToplami4 = 0;
                        txtKesintilerToplami4.Text = string.Format("{0:C}", kesintilerToplami4).ToString();
                    }

                    if (brut5 >= abrut)
                    {
                        kesintilerToplami5 = calisanSgkPrimi5 + calisanIssizlikSigortasi5 + gelirVergisi5 + damgaVergisi5;
                        txtKesintilerToplami5.Text = string.Format("{0:C}", kesintilerToplami5).ToString();
                    }
                    else
                    {
                        kesintilerToplami5 = 0;
                        txtKesintilerToplami5.Text = string.Format("{0:C}", kesintilerToplami5).ToString();
                    }

                    if (brut6 >= abrut)
                    {
                        kesintilerToplami6 = calisanSgkPrimi6 + calisanIssizlikSigortasi6 + gelirVergisi6 + damgaVergisi6;
                        txtKesintilerToplami6.Text = string.Format("{0:C}", kesintilerToplami6).ToString();
                    }
                    else
                    {
                        kesintilerToplami6 = 0;
                        txtKesintilerToplami6.Text = string.Format("{0:C}", kesintilerToplami6).ToString();
                    }

                    if (brut7 >= abrut)
                    {
                        kesintilerToplami7 = calisanSgkPrimi7 + calisanIssizlikSigortasi7 + gelirVergisi7 + damgaVergisi7;
                        txtKesintilerToplami7.Text = string.Format("{0:C}", kesintilerToplami7).ToString();
                    }
                    else
                    {
                        kesintilerToplami7 = 0;
                        txtKesintilerToplami7.Text = string.Format("{0:C}", kesintilerToplami7).ToString();
                    }

                    if (brut8 >= abrut)
                    {
                        kesintilerToplami8 = calisanSgkPrimi8 + calisanIssizlikSigortasi8 + gelirVergisi8 + damgaVergisi8;
                        txtKesintilerToplami8.Text = string.Format("{0:C}", kesintilerToplami8).ToString();
                    }
                    else
                    {
                        kesintilerToplami8 = 0;
                        txtKesintilerToplami8.Text = string.Format("{0:C}", kesintilerToplami8).ToString();
                    }

                    if (brut9 >= abrut)
                    {
                        kesintilerToplami9 = calisanSgkPrimi9 + calisanIssizlikSigortasi9 + gelirVergisi9 + damgaVergisi9;
                        txtKesintilerToplami9.Text = string.Format("{0:C}", kesintilerToplami9).ToString();
                    }
                    else
                    {
                        kesintilerToplami9 = 0;
                        txtKesintilerToplami9.Text = string.Format("{0:C}", kesintilerToplami9).ToString();
                    }

                    if (brut10 >= abrut)
                    {
                        kesintilerToplami10 = calisanSgkPrimi10 + calisanIssizlikSigortasi10 + gelirVergisi10 + damgaVergisi10;
                        txtKesintilerToplami10.Text = string.Format("{0:C}", kesintilerToplami10).ToString();
                    }
                    else
                    {
                        kesintilerToplami10 = 0;
                        txtKesintilerToplami10.Text = string.Format("{0:C}", kesintilerToplami10).ToString();
                    }

                    if (brut11 >= abrut)
                    {
                        kesintilerToplami11 = calisanSgkPrimi11 + calisanIssizlikSigortasi11 + gelirVergisi11 + damgaVergisi11;
                        txtKesintilerToplami11.Text = string.Format("{0:C}", kesintilerToplami11).ToString();
                    }
                    else
                    {
                        kesintilerToplami11 = 0;
                        txtKesintilerToplami11.Text = string.Format("{0:C}", kesintilerToplami11).ToString();
                    }

                    if (brut12 >= abrut)
                    {
                        kesintilerToplami12 = calisanSgkPrimi12 + calisanIssizlikSigortasi12 + gelirVergisi12 + damgaVergisi12;
                        txtKesintilerToplami12.Text = string.Format("{0:C}", kesintilerToplami12).ToString();
                    }
                    else
                    {
                        kesintilerToplami12 = 0;
                        txtKesintilerToplami12.Text = string.Format("{0:C}", kesintilerToplami12).ToString();
                    }
                }




                // Net Ücret Hesaplanması

                if (1 == 1)
                {

                    netUcret1 = brut1 - kesintilerToplami1;
                    txtNetUcret1.Text = string.Format("{0:C}", netUcret1).ToString();

                    netUcret2 = brut2 - kesintilerToplami2;
                    txtNetUcret2.Text = string.Format("{0:C}", netUcret2).ToString();

                    netUcret3 = brut3 - kesintilerToplami3;
                    txtNetUcret3.Text = string.Format("{0:C}", netUcret3).ToString();

                    netUcret4 = brut4 - kesintilerToplami4;
                    txtNetUcret4.Text = string.Format("{0:C}", netUcret4).ToString();

                    netUcret5 = brut5 - kesintilerToplami5;
                    txtNetUcret5.Text = string.Format("{0:C}", netUcret5).ToString();

                    netUcret6 = brut6 - kesintilerToplami6;
                    txtNetUcret6.Text = string.Format("{0:C}", netUcret6).ToString();

                    netUcret7 = brut7 - kesintilerToplami7;
                    txtNetUcret7.Text = string.Format("{0:C}", netUcret7).ToString();

                    netUcret8 = brut8 - kesintilerToplami8;
                    txtNetUcret8.Text = string.Format("{0:C}", netUcret8).ToString();

                    netUcret9 = brut9 - kesintilerToplami9;
                    txtNetUcret9.Text = string.Format("{0:C}", netUcret9).ToString();

                    netUcret10 = brut10 - kesintilerToplami10;
                    txtNetUcret10.Text = string.Format("{0:C}", netUcret10).ToString();

                    netUcret11 = brut11 - kesintilerToplami11;
                    txtNetUcret11.Text = string.Format("{0:C}", netUcret11).ToString();

                    netUcret12 = brut12 - kesintilerToplami12;
                    txtNetUcret12.Text = string.Format("{0:C}", netUcret12).ToString();

                }




                // Alt toplam textboxlarının hesaplanıp dldurulması

                if (1 == 1)
                {
                    txtBrutToplam.Text =
                                        string.Format("{0:C}", (
                                        brut1 +
                                        brut2 +
                                        brut3 +
                                        brut4 +
                                        brut5 +
                                        brut6 +
                                        brut7 +
                                        brut8 +
                                        brut9 +
                                        brut10 +
                                        brut11 +
                                        brut12)).ToString();

                    txtCSPToplam.Text =
                                        string.Format("{0:C}", (
                                        calisanSgkPrimi1 +
                                        calisanSgkPrimi2 +
                                        calisanSgkPrimi3 +
                                        calisanSgkPrimi4 +
                                        calisanSgkPrimi5 +
                                        calisanSgkPrimi6 +
                                        calisanSgkPrimi7 +
                                        calisanSgkPrimi8 +
                                        calisanSgkPrimi9 +
                                        calisanSgkPrimi10 +
                                        calisanSgkPrimi11 +
                                        calisanSgkPrimi12)).ToString();

                    txtCISToplam.Text = string.Format("{0:C}", (
                                        calisanIssizlikSigortasi1 +
                                        calisanIssizlikSigortasi2 +
                                        calisanIssizlikSigortasi3 +
                                        calisanIssizlikSigortasi4 +
                                        calisanIssizlikSigortasi5 +
                                        calisanIssizlikSigortasi6 +
                                        calisanIssizlikSigortasi7 +
                                        calisanIssizlikSigortasi8 +
                                        calisanIssizlikSigortasi9 +
                                        calisanIssizlikSigortasi10 +
                                        calisanIssizlikSigortasi11 +
                                        calisanIssizlikSigortasi12)).ToString();

                    txtGVMatrahToplam.Text =
                                        string.Format("{0:C}", (
                                        gvMatrahi1 +
                                        gvMatrahi2 +
                                        gvMatrahi3 +
                                        gvMatrahi4 +
                                        gvMatrahi5 +
                                        gvMatrahi6 +
                                        gvMatrahi7 +
                                        gvMatrahi8 +
                                        gvMatrahi9 +
                                        gvMatrahi10 +
                                        gvMatrahi11 +
                                        gvMatrahi12)).ToString();

                    txtGVMToplam.Text =
                                        string.Format("{0:C}", (
                                        augelirVergisi1 +
                                        augelirVergisi2 +
                                        augelirVergisi3 +
                                        augelirVergisi4 +
                                        augelirVergisi5 +
                                        augelirVergisi6 +
                                        augelirVergisi7 +
                                        augelirVergisi8 +
                                        augelirVergisi9 +
                                        augelirVergisi10 +
                                        augelirVergisi11 +
                                        augelirVergisi12)).ToString();

                    txtDVMToplam.Text =
                                       string.Format("{0:C}", (
                                       audamgaVergisi1 +
                                       audamgaVergisi2 +
                                       audamgaVergisi3 +
                                       audamgaVergisi4 +
                                       audamgaVergisi5 +
                                       audamgaVergisi6 +
                                       audamgaVergisi7 +
                                       audamgaVergisi8 +
                                       audamgaVergisi9 +
                                       audamgaVergisi10 +
                                       audamgaVergisi11 +
                                       audamgaVergisi12)).ToString();

                    txtGVToplam.Text =
                                       string.Format("{0:C}", (
                                       gelirVergisi1 +
                                       gelirVergisi2 +
                                       gelirVergisi3 +
                                       gelirVergisi4 +
                                       gelirVergisi5 +
                                       gelirVergisi6 +
                                       gelirVergisi7 +
                                       gelirVergisi8 +
                                       gelirVergisi9 +
                                       gelirVergisi10 +
                                       gelirVergisi11 +
                                       gelirVergisi12)).ToString();

                    txtDVToplam.Text =
                                       string.Format("{0:C}", (
                                       damgaVergisi1 +
                                       damgaVergisi2 +
                                       damgaVergisi3 +
                                       damgaVergisi4 +
                                       damgaVergisi5 +
                                       damgaVergisi6 +
                                       damgaVergisi7 +
                                       damgaVergisi8 +
                                       damgaVergisi9 +
                                       damgaVergisi10 +
                                       damgaVergisi11 +
                                       damgaVergisi12)).ToString();

                    txtKesintilerToplami.Text =
                                       string.Format("{0:C}", (
                                       kesintilerToplami1 +
                                       kesintilerToplami2 +
                                       kesintilerToplami3 +
                                       kesintilerToplami4 +
                                       kesintilerToplami5 +
                                       kesintilerToplami6 +
                                       kesintilerToplami7 +
                                       kesintilerToplami8 +
                                       kesintilerToplami9 +
                                       kesintilerToplami10 +
                                       kesintilerToplami11 +
                                       kesintilerToplami12)).ToString();

                    txtNetToplam.Text =
                                        string.Format("{0:C}", (
                                        netUcret1 +
                                        netUcret2 +
                                        netUcret3 +
                                        netUcret4 +
                                        netUcret5 +
                                        netUcret6 +
                                        netUcret7 +
                                        netUcret8 +
                                        netUcret9 +
                                        netUcret10 +
                                        netUcret11 +
                                        netUcret12)).ToString();
                }




                // kodun başında aynı döngü ile textboxlardaki değer Brüt Ücret iken 0 ile değiştirilip burada hesaplama bittikten sonra
                // textbox hala boş ise tekrar Brüt Ücret yapılıyor

                //foreach (Control item in this.panel3.Controls)
                //{
                //    if (item.Text == "0")
                //    {
                //        item.Text = "Brüt Ücret";
                //    }
                //}




            }
            catch
            {
                MessageBox.Show("Bilinmeyen Bir Hata Meydana Geldi !!!");

            }









        }


    }
}
