namespace homework2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbIslem = new System.Windows.Forms.GroupBox();
            this.btnIleri = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.mtbBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.mtbBitis = new System.Windows.Forms.MaskedTextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.tabIslemler = new System.Windows.Forms.TabControl();
            this.tbTekSayilar = new System.Windows.Forms.TabPage();
            this.lvlTekSayilarCarpim = new System.Windows.Forms.ListView();
            this.lvlTekSayilarToplam = new System.Windows.Forms.ListView();
            this.lvlTekSayilarSirala = new System.Windows.Forms.ListView();
            this.tbCiftSayilar = new System.Windows.Forms.TabPage();
            this.lvlCiftSayilarCarpim = new System.Windows.Forms.ListView();
            this.lvlCiftSayilarToplam = new System.Windows.Forms.ListView();
            this.lvlCiftSayilarSirala = new System.Windows.Forms.ListView();
            this.tbAsalSayilar = new System.Windows.Forms.TabPage();
            this.lvlAsalSayilarCarpim = new System.Windows.Forms.ListView();
            this.lvlAsalSayilarToplam = new System.Windows.Forms.ListView();
            this.lvlAsalSayilarSirala = new System.Windows.Forms.ListView();
            this.tbAmstrongSayilar = new System.Windows.Forms.TabPage();
            this.lvlAmstrongSayilarCarpim = new System.Windows.Forms.ListView();
            this.lvlAmstrongSayilarToplam = new System.Windows.Forms.ListView();
            this.lvlAmstrongSayilarSirala = new System.Windows.Forms.ListView();
            this.bildirim = new System.Windows.Forms.NotifyIcon(this.components);
            this.gbIslem.SuspendLayout();
            this.tabIslemler.SuspendLayout();
            this.tbTekSayilar.SuspendLayout();
            this.tbCiftSayilar.SuspendLayout();
            this.tbAsalSayilar.SuspendLayout();
            this.tbAmstrongSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbIslem
            // 
            this.gbIslem.Controls.Add(this.btnIleri);
            this.gbIslem.Controls.Add(this.btnGeri);
            this.gbIslem.Controls.Add(this.mtbBaslangic);
            this.gbIslem.Controls.Add(this.mtbBitis);
            this.gbIslem.Controls.Add(this.btnHesapla);
            this.gbIslem.Controls.Add(this.lblBitis);
            this.gbIslem.Controls.Add(this.lblBaslangic);
            this.gbIslem.Location = new System.Drawing.Point(6, 12);
            this.gbIslem.Name = "gbIslem";
            this.gbIslem.Size = new System.Drawing.Size(929, 100);
            this.gbIslem.TabIndex = 0;
            this.gbIslem.TabStop = false;
            this.gbIslem.Text = "Giriş Bilgileri";
            // 
            // btnIleri
            // 
            this.btnIleri.Location = new System.Drawing.Point(809, 41);
            this.btnIleri.Name = "btnIleri";
            this.btnIleri.Size = new System.Drawing.Size(80, 27);
            this.btnIleri.TabIndex = 8;
            this.btnIleri.Text = "İleri>>";
            this.btnIleri.UseVisualStyleBackColor = true;
            this.btnIleri.Click += new System.EventHandler(this.btnIleri_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.Location = new System.Drawing.Point(704, 41);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(82, 27);
            this.btnGeri.TabIndex = 7;
            this.btnGeri.Text = "<<Geri";
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // mtbBaslangic
            // 
            this.mtbBaslangic.Location = new System.Drawing.Point(121, 42);
            this.mtbBaslangic.Mask = "00000";
            this.mtbBaslangic.Name = "mtbBaslangic";
            this.mtbBaslangic.Size = new System.Drawing.Size(100, 26);
            this.mtbBaslangic.TabIndex = 6;
            this.mtbBaslangic.Text = "1";
            this.mtbBaslangic.ValidatingType = typeof(int);
            // 
            // mtbBitis
            // 
            this.mtbBitis.Location = new System.Drawing.Point(338, 41);
            this.mtbBitis.Mask = "00000";
            this.mtbBitis.Name = "mtbBitis";
            this.mtbBitis.Size = new System.Drawing.Size(100, 26);
            this.mtbBitis.TabIndex = 5;
            this.mtbBitis.Text = "10000";
            this.mtbBitis.ValidatingType = typeof(int);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(524, 34);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(116, 34);
            this.btnHesapla.TabIndex = 4;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.AutoSize = true;
            this.lblBitis.Location = new System.Drawing.Point(293, 41);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(39, 20);
            this.lblBitis.TabIndex = 3;
            this.lblBitis.Text = "Bitiş";
            // 
            // lblBaslangic
            // 
            this.lblBaslangic.AutoSize = true;
            this.lblBaslangic.Location = new System.Drawing.Point(37, 41);
            this.lblBaslangic.Name = "lblBaslangic";
            this.lblBaslangic.Size = new System.Drawing.Size(78, 20);
            this.lblBaslangic.TabIndex = 2;
            this.lblBaslangic.Text = "Başlangıç";
            // 
            // tabIslemler
            // 
            this.tabIslemler.Controls.Add(this.tbTekSayilar);
            this.tabIslemler.Controls.Add(this.tbCiftSayilar);
            this.tabIslemler.Controls.Add(this.tbAsalSayilar);
            this.tabIslemler.Controls.Add(this.tbAmstrongSayilar);
            this.tabIslemler.Location = new System.Drawing.Point(6, 118);
            this.tabIslemler.Name = "tabIslemler";
            this.tabIslemler.SelectedIndex = 0;
            this.tabIslemler.Size = new System.Drawing.Size(929, 411);
            this.tabIslemler.TabIndex = 1;
            // 
            // tbTekSayilar
            // 
            this.tbTekSayilar.Controls.Add(this.lvlTekSayilarCarpim);
            this.tbTekSayilar.Controls.Add(this.lvlTekSayilarToplam);
            this.tbTekSayilar.Controls.Add(this.lvlTekSayilarSirala);
            this.tbTekSayilar.Location = new System.Drawing.Point(4, 29);
            this.tbTekSayilar.Name = "tbTekSayilar";
            this.tbTekSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbTekSayilar.Size = new System.Drawing.Size(921, 378);
            this.tbTekSayilar.TabIndex = 0;
            this.tbTekSayilar.Text = "Tek Sayılar";
            this.tbTekSayilar.UseVisualStyleBackColor = true;
            // 
            // lvlTekSayilarCarpim
            // 
            this.lvlTekSayilarCarpim.HideSelection = false;
            this.lvlTekSayilarCarpim.Location = new System.Drawing.Point(610, 0);
            this.lvlTekSayilarCarpim.Name = "lvlTekSayilarCarpim";
            this.lvlTekSayilarCarpim.Size = new System.Drawing.Size(311, 378);
            this.lvlTekSayilarCarpim.TabIndex = 2;
            this.lvlTekSayilarCarpim.UseCompatibleStateImageBehavior = false;
            // 
            // lvlTekSayilarToplam
            // 
            this.lvlTekSayilarToplam.HideSelection = false;
            this.lvlTekSayilarToplam.Location = new System.Drawing.Point(316, 0);
            this.lvlTekSayilarToplam.Name = "lvlTekSayilarToplam";
            this.lvlTekSayilarToplam.Size = new System.Drawing.Size(297, 375);
            this.lvlTekSayilarToplam.TabIndex = 1;
            this.lvlTekSayilarToplam.UseCompatibleStateImageBehavior = false;
            // 
            // lvlTekSayilarSirala
            // 
            this.lvlTekSayilarSirala.HideSelection = false;
            this.lvlTekSayilarSirala.Location = new System.Drawing.Point(-4, 0);
            this.lvlTekSayilarSirala.Name = "lvlTekSayilarSirala";
            this.lvlTekSayilarSirala.Size = new System.Drawing.Size(318, 375);
            this.lvlTekSayilarSirala.TabIndex = 0;
            this.lvlTekSayilarSirala.UseCompatibleStateImageBehavior = false;
            // 
            // tbCiftSayilar
            // 
            this.tbCiftSayilar.Controls.Add(this.lvlCiftSayilarCarpim);
            this.tbCiftSayilar.Controls.Add(this.lvlCiftSayilarToplam);
            this.tbCiftSayilar.Controls.Add(this.lvlCiftSayilarSirala);
            this.tbCiftSayilar.Location = new System.Drawing.Point(4, 29);
            this.tbCiftSayilar.Name = "tbCiftSayilar";
            this.tbCiftSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbCiftSayilar.Size = new System.Drawing.Size(921, 378);
            this.tbCiftSayilar.TabIndex = 1;
            this.tbCiftSayilar.Text = "Çift Sayılar";
            this.tbCiftSayilar.UseVisualStyleBackColor = true;
            // 
            // lvlCiftSayilarCarpim
            // 
            this.lvlCiftSayilarCarpim.HideSelection = false;
            this.lvlCiftSayilarCarpim.Location = new System.Drawing.Point(625, 0);
            this.lvlCiftSayilarCarpim.Name = "lvlCiftSayilarCarpim";
            this.lvlCiftSayilarCarpim.Size = new System.Drawing.Size(296, 378);
            this.lvlCiftSayilarCarpim.TabIndex = 2;
            this.lvlCiftSayilarCarpim.UseCompatibleStateImageBehavior = false;
            // 
            // lvlCiftSayilarToplam
            // 
            this.lvlCiftSayilarToplam.HideSelection = false;
            this.lvlCiftSayilarToplam.Location = new System.Drawing.Point(303, 0);
            this.lvlCiftSayilarToplam.Name = "lvlCiftSayilarToplam";
            this.lvlCiftSayilarToplam.Size = new System.Drawing.Size(325, 375);
            this.lvlCiftSayilarToplam.TabIndex = 1;
            this.lvlCiftSayilarToplam.UseCompatibleStateImageBehavior = false;
            // 
            // lvlCiftSayilarSirala
            // 
            this.lvlCiftSayilarSirala.HideSelection = false;
            this.lvlCiftSayilarSirala.Location = new System.Drawing.Point(-4, 0);
            this.lvlCiftSayilarSirala.Name = "lvlCiftSayilarSirala";
            this.lvlCiftSayilarSirala.Size = new System.Drawing.Size(315, 375);
            this.lvlCiftSayilarSirala.TabIndex = 0;
            this.lvlCiftSayilarSirala.UseCompatibleStateImageBehavior = false;
            // 
            // tbAsalSayilar
            // 
            this.tbAsalSayilar.Controls.Add(this.lvlAsalSayilarCarpim);
            this.tbAsalSayilar.Controls.Add(this.lvlAsalSayilarToplam);
            this.tbAsalSayilar.Controls.Add(this.lvlAsalSayilarSirala);
            this.tbAsalSayilar.Location = new System.Drawing.Point(4, 29);
            this.tbAsalSayilar.Name = "tbAsalSayilar";
            this.tbAsalSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAsalSayilar.Size = new System.Drawing.Size(921, 378);
            this.tbAsalSayilar.TabIndex = 2;
            this.tbAsalSayilar.Text = "Asal Sayılar";
            this.tbAsalSayilar.UseVisualStyleBackColor = true;
            // 
            // lvlAsalSayilarCarpim
            // 
            this.lvlAsalSayilarCarpim.HideSelection = false;
            this.lvlAsalSayilarCarpim.Location = new System.Drawing.Point(609, 0);
            this.lvlAsalSayilarCarpim.Name = "lvlAsalSayilarCarpim";
            this.lvlAsalSayilarCarpim.Size = new System.Drawing.Size(312, 378);
            this.lvlAsalSayilarCarpim.TabIndex = 2;
            this.lvlAsalSayilarCarpim.UseCompatibleStateImageBehavior = false;
            // 
            // lvlAsalSayilarToplam
            // 
            this.lvlAsalSayilarToplam.HideSelection = false;
            this.lvlAsalSayilarToplam.Location = new System.Drawing.Point(293, 0);
            this.lvlAsalSayilarToplam.Name = "lvlAsalSayilarToplam";
            this.lvlAsalSayilarToplam.Size = new System.Drawing.Size(320, 378);
            this.lvlAsalSayilarToplam.TabIndex = 1;
            this.lvlAsalSayilarToplam.UseCompatibleStateImageBehavior = false;
            // 
            // lvlAsalSayilarSirala
            // 
            this.lvlAsalSayilarSirala.HideSelection = false;
            this.lvlAsalSayilarSirala.Location = new System.Drawing.Point(0, 0);
            this.lvlAsalSayilarSirala.Name = "lvlAsalSayilarSirala";
            this.lvlAsalSayilarSirala.Size = new System.Drawing.Size(294, 378);
            this.lvlAsalSayilarSirala.TabIndex = 0;
            this.lvlAsalSayilarSirala.UseCompatibleStateImageBehavior = false;
            // 
            // tbAmstrongSayilar
            // 
            this.tbAmstrongSayilar.Controls.Add(this.lvlAmstrongSayilarCarpim);
            this.tbAmstrongSayilar.Controls.Add(this.lvlAmstrongSayilarToplam);
            this.tbAmstrongSayilar.Controls.Add(this.lvlAmstrongSayilarSirala);
            this.tbAmstrongSayilar.Location = new System.Drawing.Point(4, 29);
            this.tbAmstrongSayilar.Name = "tbAmstrongSayilar";
            this.tbAmstrongSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tbAmstrongSayilar.Size = new System.Drawing.Size(921, 378);
            this.tbAmstrongSayilar.TabIndex = 3;
            this.tbAmstrongSayilar.Text = "Amstrong Sayılar";
            this.tbAmstrongSayilar.UseVisualStyleBackColor = true;
            // 
            // lvlAmstrongSayilarCarpim
            // 
            this.lvlAmstrongSayilarCarpim.HideSelection = false;
            this.lvlAmstrongSayilarCarpim.Location = new System.Drawing.Point(622, 0);
            this.lvlAmstrongSayilarCarpim.Name = "lvlAmstrongSayilarCarpim";
            this.lvlAmstrongSayilarCarpim.Size = new System.Drawing.Size(303, 382);
            this.lvlAmstrongSayilarCarpim.TabIndex = 2;
            this.lvlAmstrongSayilarCarpim.UseCompatibleStateImageBehavior = false;
            // 
            // lvlAmstrongSayilarToplam
            // 
            this.lvlAmstrongSayilarToplam.HideSelection = false;
            this.lvlAmstrongSayilarToplam.Location = new System.Drawing.Point(313, 0);
            this.lvlAmstrongSayilarToplam.Name = "lvlAmstrongSayilarToplam";
            this.lvlAmstrongSayilarToplam.Size = new System.Drawing.Size(314, 382);
            this.lvlAmstrongSayilarToplam.TabIndex = 1;
            this.lvlAmstrongSayilarToplam.UseCompatibleStateImageBehavior = false;
            // 
            // lvlAmstrongSayilarSirala
            // 
            this.lvlAmstrongSayilarSirala.HideSelection = false;
            this.lvlAmstrongSayilarSirala.Location = new System.Drawing.Point(0, 0);
            this.lvlAmstrongSayilarSirala.Name = "lvlAmstrongSayilarSirala";
            this.lvlAmstrongSayilarSirala.Size = new System.Drawing.Size(320, 382);
            this.lvlAmstrongSayilarSirala.TabIndex = 0;
            this.lvlAmstrongSayilarSirala.UseCompatibleStateImageBehavior = false;
            // 
            // bildirim
            // 
            this.bildirim.Text = "ntfIcon";
            this.bildirim.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 543);
            this.Controls.Add(this.tabIslemler);
            this.Controls.Add(this.gbIslem);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tek, Çift, Asal ve Amstrong Sayılar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.gbIslem.ResumeLayout(false);
            this.gbIslem.PerformLayout();
            this.tabIslemler.ResumeLayout(false);
            this.tbTekSayilar.ResumeLayout(false);
            this.tbCiftSayilar.ResumeLayout(false);
            this.tbAsalSayilar.ResumeLayout(false);
            this.tbAmstrongSayilar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbIslem;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblBitis;
        private System.Windows.Forms.Label lblBaslangic;
        private System.Windows.Forms.TabControl tabIslemler;
        private System.Windows.Forms.TabPage tbTekSayilar;
        private System.Windows.Forms.ListView lvlTekSayilarSirala;
        private System.Windows.Forms.TabPage tbCiftSayilar;
        private System.Windows.Forms.ListView lvlCiftSayilarSirala;
        private System.Windows.Forms.TabPage tbAsalSayilar;
        private System.Windows.Forms.ListView lvlAsalSayilarSirala;
        private System.Windows.Forms.TabPage tbAmstrongSayilar;
        private System.Windows.Forms.ListView lvlAmstrongSayilarSirala;
        private System.Windows.Forms.MaskedTextBox mtbBaslangic;
        private System.Windows.Forms.MaskedTextBox mtbBitis;
        private System.Windows.Forms.Button btnIleri;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ListView lvlTekSayilarCarpim;
        private System.Windows.Forms.ListView lvlTekSayilarToplam;
        private System.Windows.Forms.ListView lvlCiftSayilarCarpim;
        private System.Windows.Forms.ListView lvlCiftSayilarToplam;
        private System.Windows.Forms.ListView lvlAsalSayilarCarpim;
        private System.Windows.Forms.ListView lvlAsalSayilarToplam;
        private System.Windows.Forms.ListView lvlAmstrongSayilarCarpim;
        private System.Windows.Forms.ListView lvlAmstrongSayilarToplam;
        private System.Windows.Forms.NotifyIcon bildirim;
    }
}

