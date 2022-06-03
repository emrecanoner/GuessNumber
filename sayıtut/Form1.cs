using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayıtut
{
    public partial class Form1 : Form
    {
        private int sayi1 = 0;
        private int sayi2 = 0;
        private int sayi3 = 0;
        private int sayi4 = 0;
        private int sayi5 = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btntahmin_Click(object sender, EventArgs e)
        {
            int B = 0;
            int K = 0;
            bool BulunanSayi = false;

            Random rastgele = new Random();
            sayi1 = rastgele.Next(1, 100);

            DialogResult Sonuc = new DialogResult();

            Sonuc = MessageBox.Show("Tuttuğunuz sayı " + sayi1, "SONUÇ", MessageBoxButtons.YesNo);

            if (Sonuc == DialogResult.Yes)
            {
                MessageBox.Show("SAYIYI BULDUM.", "TEBRİKLER", MessageBoxButtons.OK);
                return;
            }
            else
            {
                while (BulunanSayi == true)
                {
                    Sonuc = MessageBox.Show(sayi1 + " bu sayıdan küçük ?", "SONUÇ", MessageBoxButtons.YesNo);
                    if (Sonuc == DialogResult.Yes)
                    {
                        B = sayi1 - 1;
                        sayi1 = rastgele.Next(1, B);

                        MessageBox.Show("Tuttuğunuz sayı " + sayi1, "SONUÇ", MessageBoxButtons.YesNo);

                        if (Sonuc == DialogResult.No)
                            BulunanSayi = false;
                        else
                            BulunanSayi = true;
                    }
                    else
                    {
                        K = sayi1 + 1;
                        sayi1 = rastgele.Next(1, K);

                        MessageBox.Show("Tuttuğunuz sayı " + sayi1, "SONUÇ", MessageBoxButtons.YesNo);
                        if (Sonuc == DialogResult.No)
                            BulunanSayi = false;
                        else
                            BulunanSayi = true;
                    }
                }

            }

            //while (Sonuc == DialogResult.Yes)
            //{
            //    sayi2 = rastgele.Next(sayi1, 100);
            //    //sayi2 = rastgele.Next(0, sayi2);
            //    Sonuc = MessageBox.Show(sayi2 + " bu mudur ?", "SONUÇ", MessageBoxButtons.YesNo);
            //}

            //MessageBox.Show("SAYIYI BULDUM. " + sayi2, "TEBRİKLER", MessageBoxButtons.OK);

        }

    }

}
