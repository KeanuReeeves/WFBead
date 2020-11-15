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
            this.statisztikak = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pekaruNev = new System.Windows.Forms.TextBox();
            this.pekaruAr = new System.Windows.Forms.TextBox();
            this.laktozmentes = new System.Windows.Forms.CheckBox();
            this.pekaruHozzaAd = new System.Windows.Forms.Button();
            this.PekaruLista = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.adatok.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.adatok);
            this.tabControl1.Controls.Add(this.statisztikak);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(653, 353);
            this.tabControl1.TabIndex = 0;
            // 
            // adatok
            // 
            this.adatok.Controls.Add(this.groupBox1);
            this.adatok.Location = new System.Drawing.Point(4, 22);
            this.adatok.Name = "adatok";
            this.adatok.Padding = new System.Windows.Forms.Padding(3);
            this.adatok.Size = new System.Drawing.Size(645, 327);
            this.adatok.TabIndex = 0;
            this.adatok.Text = "Adatok";
            this.adatok.UseVisualStyleBackColor = true;
            // 
            // statisztikak
            // 
            this.statisztikak.Location = new System.Drawing.Point(4, 22);
            this.statisztikak.Name = "statisztikak";
            this.statisztikak.Padding = new System.Windows.Forms.Padding(3);
            this.statisztikak.Size = new System.Drawing.Size(645, 327);
            this.statisztikak.TabIndex = 1;
            this.statisztikak.Text = "Statisztikák";
            this.statisztikak.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PekaruLista);
            this.groupBox1.Controls.Add(this.pekaruHozzaAd);
            this.groupBox1.Controls.Add(this.laktozmentes);
            this.groupBox1.Controls.Add(this.pekaruAr);
            this.groupBox1.Controls.Add(this.pekaruNev);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pékárúk";
            // 
            // pekaruNev
            // 
            this.pekaruNev.Location = new System.Drawing.Point(7, 20);
            this.pekaruNev.Name = "pekaruNev";
            this.pekaruNev.Size = new System.Drawing.Size(100, 20);
            this.pekaruNev.TabIndex = 0;
            // 
            // pekaruAr
            // 
            this.pekaruAr.Location = new System.Drawing.Point(7, 47);
            this.pekaruAr.Name = "pekaruAr";
            this.pekaruAr.Size = new System.Drawing.Size(100, 20);
            this.pekaruAr.TabIndex = 1;
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
            // PekaruLista
            // 
            this.PekaruLista.FormattingEnabled = true;
            this.PekaruLista.Location = new System.Drawing.Point(148, 20);
            this.PekaruLista.Name = "PekaruLista";
            this.PekaruLista.Size = new System.Drawing.Size(483, 82);
            this.PekaruLista.TabIndex = 4;
            this.PekaruLista.SelectedValueChanged += new System.EventHandler(this.PekaruLista_SelectedValueChanged);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
    }
}

