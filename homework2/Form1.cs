using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace homework2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void tekSayiSirala(int bas, int bit)
        {
            for (int i = bas; i < bit; i++)
            {
                if ((i%2) == 1)
                {
                    lvlTekSayilarSirala.Items.Add(i.ToString());
                }
            }
        }

        public double tekSayilarToplam(int bas,int bit)
        {
            double tekToplam = 0;

            for (double i = bas; i < bit; i++)
            {
                if ((i%2) == 1)
                {
                    tekToplam += i;
                }
            }
            return tekToplam;
        }

        public long tekSayilarCarpim(int bas,int bit)
        {
            long tekCarpim = 1;

            for (int i = bas; i < bit; i++)
            {
                if ((i%2) == 1)
                {
                    tekCarpim *= i;
                }
            }
            return tekCarpim;
        }

        public void ciftSayiSirala(int bas, int bit)
        {
            for (int i = bas; i <= bit; i++)
            {
                if ((i%2) == 0)
                {
                    lvlCiftSayilarSirala.Items.Add(i.ToString());
                }
            }
        }

        public double ciftSayilarToplam(int bas,int bit)
        {
            double ciftToplam = 0;

            for (int i = bas; i <= bit; i++)
            {
                if ((i%2) == 0)
                {
                    ciftToplam += i;
                }
            }
            return ciftToplam;
        }

        public  long ciftSayilarCarpim(int bas, int bit)
        {
            long ciftCarpim = 1;

            for (int i = bas; i <= bit; i++)
            {
                if ((i%2) == 0)
                {
                     ciftCarpim *= i;
                }
            }
            return ciftCarpim;
        }

        public void asalSayiSirala(int bas, int bit)
        {
            for (int i = 2; i <= bit; i++)
            {
                int sayac = 0;
                for (int j = i - 1; j > 1; j--)
                {
                    if (i % j == 0)
                    {
                        sayac++;
                    }
                }
                if (sayac == 0)
                {
                    lvlAsalSayilarSirala.Items.Add(i.ToString());
                }
            }
        }

        public double asalSayilarToplam(int bas, int bit)
        {
            double asalToplam = 0;

            for(int i=2;i<=bit;i++)
            {
                int sayac = 0;
                for(int j = i-1; j > 1 ; j --)
                {
                    if (i%j==0)
                    {
                        sayac++;
                    }
                }
                if(sayac == 0)
                {
                    asalToplam += i;
                }
            }
            return asalToplam;
        }

        public long asalSayilarCarpim(int bas, int bit)
        {
            long asalCarpim = 1;

            for(int i=2;i<=bit;i++)
            {
                int sayac = 0;
                for (int j = i-1; j > 1; j --)
                {
                    if (i%j==0)
                    {
                        sayac++;
                    }
                }
                if(sayac == 0)
                {
                    asalCarpim *= i;
                }
            }
            return asalCarpim;
        }

        public void armstrongSayiSirala(int bas, int bit)
        {
            int birlerBasamagi, onlarBasamagi, yuzlerBasamagi, binlerBasamagi;

            for (int i = bas; i <= bit; i++)
            {
                if (i > 1000 && i < 10000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    binlerBasamagi = (i - (100 * yuzlerBasamagi) - (10 * onlarBasamagi) - birlerBasamagi) / 1000;
                    if (i == Math.Pow(birlerBasamagi, 4) + Math.Pow(onlarBasamagi, 4) + Math.Pow(yuzlerBasamagi, 4) + Math.Pow(binlerBasamagi, 4))
                    {
                        lvlAmstrongSayilarSirala.Items.Add(i.ToString());
                    }
                }
                if (i > 100 && i < 1000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    if (i == Math.Pow(birlerBasamagi, 3) + Math.Pow(onlarBasamagi, 3) + Math.Pow(yuzlerBasamagi, 3))
                    {
                        lvlAmstrongSayilarSirala.Items.Add(i.ToString());
                    }
                }
                if (i > 10 && i < 100)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    if (i == Math.Pow(birlerBasamagi, 2) + Math.Pow(onlarBasamagi, 2))
                    {
                        lvlAmstrongSayilarSirala.Items.Add(i.ToString());
                    }
                }
                if (i < 10)
                {
                    birlerBasamagi = i;
                    if (i == 1)
                    {
                        lvlAmstrongSayilarSirala.Items.Add(i.ToString());
                    }
                }
            }
        }

        public double armstrongSayilarToplam(int bas, int bit)
        {
            int birlerBasamagi, onlarBasamagi, yuzlerBasamagi, binlerBasamagi;
            double armstrongToplam = 0;

            for (int i = bas; i <= bit; i++)
            {
                if(i >1000 && i < 10000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    binlerBasamagi = (i - (100 * yuzlerBasamagi) - (10 * onlarBasamagi) - birlerBasamagi) / 1000;
                    if (i == Math.Pow(birlerBasamagi, 4) + Math.Pow(onlarBasamagi, 4) + Math.Pow(yuzlerBasamagi, 4) + Math.Pow(binlerBasamagi, 4))
                    {
                        armstrongToplam += i;
                    }
                }
                if (i > 100 && i<1000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    if (i == Math.Pow(birlerBasamagi, 3) + Math.Pow(onlarBasamagi, 3) + Math.Pow(yuzlerBasamagi, 3))
                    {
                        armstrongToplam += i;
                    }
                }
                if (i > 10 && i < 100)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    if (i == Math.Pow(birlerBasamagi, 2) + Math.Pow(onlarBasamagi, 2))
                    {
                        armstrongToplam += i;
                    }
                }
                if (i < 10)
                {
                    birlerBasamagi = i;
                    if(i == 1)
                    {
                        armstrongToplam += i;
                    }
                }
            }
            return armstrongToplam;
        }

        public long armstrongSayilarCarpim(int bas, int bit)
        {
            int birlerBasamagi, onlarBasamagi, yuzlerBasamagi, binlerBasamagi;
            long armstrongCarpim = 1;
            for (int i = bas; i <= bit; i++)
            {
                if (i > 1000 && i < 10000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    binlerBasamagi = (i - (100 * yuzlerBasamagi) - (10 * onlarBasamagi) - birlerBasamagi) / 1000;
                    if (i == Math.Pow(birlerBasamagi, 4) + Math.Pow(onlarBasamagi, 4) + Math.Pow(yuzlerBasamagi, 4) + Math.Pow(binlerBasamagi, 4))
                    {
                        armstrongCarpim *= i;
                    }
                }
                if (i > 100 && i < 1000)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    yuzlerBasamagi = ((i - (onlarBasamagi * 10) - birlerBasamagi) / 100) % 10;
                    if (i == Math.Pow(birlerBasamagi, 3) + Math.Pow(onlarBasamagi, 3) + Math.Pow(yuzlerBasamagi, 3))
                    {
                        armstrongCarpim *= i;
                    }
                }
                if (i > 10 && i < 100)
                {
                    birlerBasamagi = i % 10;
                    onlarBasamagi = ((i - birlerBasamagi) / 10) % 10;
                    if (i == Math.Pow(birlerBasamagi, 2) + Math.Pow(onlarBasamagi, 2))
                    {
                        armstrongCarpim *= i;
                    }
                }

                if (i < 10)
                {
                    birlerBasamagi = i;
                    if (i == 1)
                    {
                        armstrongCarpim *= i;
                    }
                }
            }
            return armstrongCarpim;
        }

        public void ekranHazirla()
        {
            lvlTekSayilarSirala.Clear();
            lvlTekSayilarToplam.Clear();
            lvlTekSayilarCarpim.Clear();
            lvlCiftSayilarSirala.Clear();
            lvlCiftSayilarToplam.Clear();
            lvlCiftSayilarCarpim.Clear();
            lvlAsalSayilarSirala.Clear();
            lvlAsalSayilarToplam.Clear();
            lvlAsalSayilarCarpim.Clear();
            lvlAmstrongSayilarSirala.Clear();
            lvlAmstrongSayilarToplam.Clear();
            lvlAmstrongSayilarCarpim.Clear();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            if(tabIslemler.SelectedTab == tbAmstrongSayilar)
            (tabIslemler.SelectedIndex) -= 1;
            else if (tabIslemler.SelectedTab == tbAsalSayilar)
            (tabIslemler.SelectedIndex) -= 1;
            else if (tabIslemler.SelectedTab == tbCiftSayilar)
                (tabIslemler.SelectedIndex) -= 1;
        }

        private void btnIleri_Click(object sender, EventArgs e)
        {
            if(tabIslemler.SelectedTab == tbTekSayilar)
            (tabIslemler.SelectedIndex) += 1;
            else if(tabIslemler.SelectedTab == tbCiftSayilar)
            (tabIslemler.SelectedIndex) += 1;
            else if (tabIslemler.SelectedTab == tbAsalSayilar)
            (tabIslemler.SelectedIndex) += 1;
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
                int baslangic = Convert.ToInt32(mtbBaslangic.Text);
                int bitis = Convert.ToInt32(mtbBitis.Text);

                if (tabIslemler.SelectedTab == tbTekSayilar)
                {
                    ekranHazirla();
                    tekSayiSirala(baslangic, bitis);
                    lvlTekSayilarToplam.Items.Add("Tek toplam:" + tekSayilarToplam(baslangic, bitis));
                    lvlTekSayilarCarpim.Items.Add("Tek carpim:" + tekSayilarCarpim(baslangic, bitis));
                }
                else if (tabIslemler.SelectedTab == tbCiftSayilar)
                {
                    ekranHazirla();
                    ciftSayiSirala(baslangic, bitis);
                    lvlCiftSayilarToplam.Items.Add("Cift toplam:" + ciftSayilarToplam(baslangic, bitis));
                    lvlCiftSayilarCarpim.Items.Add("Cift carpim:" +ciftSayilarCarpim(baslangic, bitis));
                }
                else if(tabIslemler.SelectedTab == tbAsalSayilar)
                {
                    ekranHazirla();
                    asalSayiSirala(baslangic, bitis);
                    lvlAsalSayilarToplam.Items.Add("Asal toplam:" +asalSayilarToplam(baslangic, bitis));
                    lvlAsalSayilarCarpim.Items.Add("Asal carpim:" +asalSayilarCarpim(baslangic, bitis));
                }
                else if(tabIslemler.SelectedTab == tbAmstrongSayilar)
                {
                    ekranHazirla();
                    armstrongSayiSirala(baslangic, bitis);
                    lvlAmstrongSayilarToplam.Items.Add("Amstrong toplam:" +armstrongSayilarToplam(baslangic,bitis));
                    lvlAmstrongSayilarCarpim.Items.Add("Amstrong carpim:" +armstrongSayilarCarpim(baslangic, bitis));
                }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            mtbBaslangic.Text = "1";
            mtbBitis.Text = "10000";
            mtbBaslangic.Focus();

            string islemTipi = System.Configuration.ConfigurationManager.AppSettings["islem_tipi"];
            this.tabIslemler.SelectTab(islemTipi);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bildirim.Icon = SystemIcons.Exclamation;
            bildirim.BalloonTipTitle = "Programa hoş geldiniz!";
            bildirim.BalloonTipText = "Nesne Yönelimli Programlama Ödev 1";
            bildirim.BalloonTipIcon = ToolTipIcon.Info;
            this.Click += new EventHandler(Form1_Load);

            bildirim.Visible = true;
            bildirim.ShowBalloonTip(30000);
        }
    }
}