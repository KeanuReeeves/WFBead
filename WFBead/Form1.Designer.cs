namespace WFBead
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.adatok = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.hozzaAdpekaru = new System.Windows.Forms.Button();
            this.PekaruLista2 = new System.Windows.Forms.ListBox();
            this.PeksegLista = new System.Windows.Forms.ListBox();
            this.PeksegHozzaAd = new System.Windows.Forms.Button();
            this.peksegNev = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.torles = new System.Windows.Forms.Button();
            this.PekaruLista = new System.Windows.Forms.ListBox();
            this.pekaruHozzaAd = new System.Windows.Forms.Button();
            this.laktozmentes = new System.Windows.Forms.CheckBox();
            this.pekaruAr = new System.Windows.Forms.TextBox();
            this.pekaruNev = new System.Windows.Forms.TextBox();
            this.statisztikak = new System.Windows.Forms.TabPage();
            this.PeksegStat = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.adatok.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statisztikak.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.adatok);
            this.tabControl1.Controls.Add(this.statisztikak);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 439);
            this.tabControl1.TabIndex = 0;
            // 
            // adatok
            // 
            this.adatok.Controls.Add(this.groupBox2);
            this.adatok.Controls.Add(this.groupBox1);
            this.adatok.Location = new System.Drawing.Point(4, 22);
            this.adatok.Name = "adatok";
            this.adatok.Padding = new System.Windows.Forms.Padding(3);
            this.adatok.Size = new System.Drawing.Size(777, 413);
            this.adatok.TabIndex = 0;
            this.adatok.Text = "Adatok";
            this.adatok.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.hozzaAdpekaru);
            this.groupBox2.Controls.Add(this.PekaruLista2);
            this.groupBox2.Controls.Add(this.PeksegLista);
            this.groupBox2.Controls.Add(this.PeksegHozzaAd);
            this.groupBox2.Controls.Add(this.peksegNev);
            this.groupBox2.Location = new System.Drawing.Point(6, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(765, 277);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pékségek";
            // 
            // hozzaAdpekaru
            // 
            this.hozzaAdpekaru.Location = new System.Drawing.Point(583, 236);
            this.hozzaAdpekaru.Name = "hozzaAdpekaru";
            this.hozzaAdpekaru.Size = new System.Drawing.Size(75, 22);
            this.hozzaAdpekaru.TabIndex = 4;
            this.hozzaAdpekaru.Text = "+";
            this.hozzaAdpekaru.UseVisualStyleBackColor = true;
            this.hozzaAdpekaru.Click += new System.EventHandler(this.hozzaAdpekaru_Click);
            // 
            // PekaruLista2
            // 
            this.PekaruLista2.FormattingEnabled = true;
            this.PekaruLista2.Location = new System.Drawing.Point(472, 25);
            this.PekaruLista2.Name = "PekaruLista2";
            this.PekaruLista2.Size = new System.Drawing.Size(287, 186);
            this.PekaruLista2.TabIndex = 3;
            // 
            // PeksegLista
            // 
            this.PeksegLista.FormattingEnabled = true;
            this.PeksegLista.Location = new System.Drawing.Point(151, 25);
            this.PeksegLista.Name = "PeksegLista";
            this.PeksegLista.Size = new System.Drawing.Size(315, 251);
            this.PeksegLista.TabIndex = 2;
            // 
            // PeksegHozzaAd
            // 
            this.PeksegHozzaAd.Location = new System.Drawing.Point(7, 47);
            this.PeksegHozzaAd.Name = "PeksegHozzaAd";
            this.PeksegHozzaAd.Size = new System.Drawing.Size(75, 23);
            this.PeksegHozzaAd.TabIndex = 1;
            this.PeksegHozzaAd.Text = "Hozzáadás";
            this.PeksegHozzaAd.UseVisualStyleBackColor = true;
            this.PeksegHozzaAd.Click += new System.EventHandler(this.PeksegHozzaAd_Click);
            // 
            // peksegNev
            // 
            this.peksegNev.Location = new System.Drawing.Point(8, 20);
            this.peksegNev.Name = "peksegNev";
            this.peksegNev.Size = new System.Drawing.Size(100, 20);
            this.peksegNev.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.torles);
            this.groupBox1.Controls.Add(this.PekaruLista);
            this.groupBox1.Controls.Add(this.pekaruHozzaAd);
            this.groupBox1.Controls.Add(this.laktozmentes);
            this.groupBox1.Controls.Add(this.pekaruAr);
            this.groupBox1.Controls.Add(this.pekaruNev);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(764, 120);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pékáruk";
            // 
            // torles
            // 
            this.torles.Location = new System.Drawing.Point(89, 90);
            this.torles.Name = "torles";
            this.torles.Size = new System.Drawing.Size(53, 23);
            this.torles.TabIndex = 5;
            this.torles.Text = "Törlés";
            this.torles.UseVisualStyleBackColor = true;
            this.torles.Visible = false;
            this.torles.Click += new System.EventHandler(this.torles_Click);
            // 
            // PekaruLista
            // 
            this.PekaruLista.FormattingEnabled = true;
            this.PekaruLista.Location = new System.Drawing.Point(148, 20);
            this.PekaruLista.Name = "PekaruLista";
            this.PekaruLista.Size = new System.Drawing.Size(610, 82);
            this.PekaruLista.TabIndex = 4;
            this.PekaruLista.SelectedValueChanged += new System.EventHandler(this.PekaruLista_SelectedValueChanged);
            // 
            // pekaruHozzaAd
            // 
            this.pekaruHozzaAd.Location = new System.Drawing.Point(7, 90);
            this.pekaruHozzaAd.Name = "pekaruHozzaAd";
            this.pekaruHozzaAd.Size = new System.Drawing.Size(75, 23);
            this.pekaruHozzaAd.TabIndex = 3;
            this.pekaruHozzaAd.Text = "Hozzáadás";
            this.pekaruHozzaAd.UseVisualStyleBackColor = true;
            this.pekaruHozzaAd.Click += new System.EventHandler(this.pekaruHozzaAd_Click);
            // 
            // laktozmentes
            // 
            this.laktozmentes.AutoSize = true;
            this.laktozmentes.Location = new System.Drawing.Point(7, 74);
            this.laktozmentes.Name = "laktozmentes";
            this.laktozmentes.Size = new System.Drawing.Size(88, 17);
            this.laktozmentes.TabIndex = 2;
            this.laktozmentes.Text = "laktózmentes";
            this.laktozmentes.UseVisualStyleBackColor = true;
            // 
            // pekaruAr
            // 
            this.pekaruAr.Location = new System.Drawing.Point(7, 47);
            this.pekaruAr.Name = "pekaruAr";
            this.pekaruAr.Size = new System.Drawing.Size(100, 20);
            this.pekaruAr.TabIndex = 1;
            // 
            // pekaruNev
            // 
            this.pekaruNev.Location = new System.Drawing.Point(7, 20);
            this.pekaruNev.Name = "pekaruNev";
            this.pekaruNev.Size = new System.Drawing.Size(100, 20);
            this.pekaruNev.TabIndex = 0;
            // 
            // statisztikak
            // 
            this.statisztikak.Controls.Add(this.label7);
            this.statisztikak.Controls.Add(this.label6);
            this.statisztikak.Controls.Add(this.label5);
            this.statisztikak.Controls.Add(this.label4);
            this.statisztikak.Controls.Add(this.label3);
            this.statisztikak.Controls.Add(this.label2);
            this.statisztikak.Controls.Add(this.label1);
            this.statisztikak.Controls.Add(this.PeksegStat);
            this.statisztikak.Location = new System.Drawing.Point(4, 22);
            this.statisztikak.Name = "statisztikak";
            this.statisztikak.Padding = new System.Windows.Forms.Padding(3);
            this.statisztikak.Size = new System.Drawing.Size(777, 413);
            this.statisztikak.TabIndex = 1;
            this.statisztikak.Text = "Statisztikák";
            this.statisztikak.UseVisualStyleBackColor = true;
            // 
            // PeksegStat
            // 
            this.PeksegStat.FormattingEnabled = true;
            this.PeksegStat.Location = new System.Drawing.Point(10, 12);
            this.PeksegStat.Name = "PeksegStat";
            this.PeksegStat.Size = new System.Drawing.Size(312, 264);
            this.PeksegStat.TabIndex = 0;
            this.PeksegStat.SelectedIndexChanged += new System.EventHandler(this.PeksegStat_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(340, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alapítva:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pékáruk:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(340, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Átlagos ár:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Logolcsóbb termék:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Legrágább termék:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(340, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Laktózmentes termékek:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.adatok.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statisztikak.ResumeLayout(false);
            this.statisztikak.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage adatok;
        private System.Windows.Forms.TabPage statisztikak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox PekaruLista;
        private System.Windows.Forms.Button pekaruHozzaAd;
        private System.Windows.Forms.CheckBox laktozmentes;
        private System.Windows.Forms.TextBox pekaruAr;
        private System.Windows.Forms.TextBox pekaruNev;
        private System.Windows.Forms.Button torles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button hozzaAdpekaru;
        private System.Windows.Forms.ListBox PekaruLista2;
        private System.Windows.Forms.ListBox PeksegLista;
        private System.Windows.Forms.Button PeksegHozzaAd;
        private System.Windows.Forms.TextBox peksegNev;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox PeksegStat;
    }
}

