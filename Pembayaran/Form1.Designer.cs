
namespace Pembayaran
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bnyaknya = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTambahBarang = new System.Windows.Forms.TextBox();
            this.btnTambah = new System.Windows.Forms.Button();
            this.cbItemBarang = new System.Windows.Forms.ComboBox();
            this.cbHarga = new System.Windows.Forms.ComboBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.btnBeli = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.picGetuk = new System.Windows.Forms.PictureBox();
            this.picPecel = new System.Windows.Forms.PictureBox();
            this.picSoto = new System.Windows.Forms.PictureBox();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bnyaknya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGetuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPecel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoto)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(325, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Penjualan";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "item Barang";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sebanyak";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tambah Barang";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Gambar Barang";
            // 
            // bnyaknya
            // 
            this.bnyaknya.Location = new System.Drawing.Point(193, 112);
            this.bnyaknya.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.bnyaknya.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.bnyaknya.Name = "bnyaknya";
            this.bnyaknya.Size = new System.Drawing.Size(64, 27);
            this.bnyaknya.TabIndex = 5;
            this.bnyaknya.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Harga";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(450, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total Harga";
            // 
            // tbTambahBarang
            // 
            this.tbTambahBarang.Location = new System.Drawing.Point(193, 160);
            this.tbTambahBarang.Name = "tbTambahBarang";
            this.tbTambahBarang.Size = new System.Drawing.Size(234, 27);
            this.tbTambahBarang.TabIndex = 9;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(443, 159);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(94, 29);
            this.btnTambah.TabIndex = 10;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // cbItemBarang
            // 
            this.cbItemBarang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbItemBarang.FormattingEnabled = true;
            this.cbItemBarang.Items.AddRange(new object[] {
            "Getuk",
            "Pecel Pakis",
            "Soto"});
            this.cbItemBarang.Location = new System.Drawing.Point(193, 68);
            this.cbItemBarang.Name = "cbItemBarang";
            this.cbItemBarang.Size = new System.Drawing.Size(234, 28);
            this.cbItemBarang.TabIndex = 11;
            // 
            // cbHarga
            // 
            this.cbHarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHarga.FormattingEnabled = true;
            this.cbHarga.Items.AddRange(new object[] {
            "10000",
            "6000"});
            this.cbHarga.Location = new System.Drawing.Point(576, 68);
            this.cbHarga.Name = "cbHarga";
            this.cbHarga.Size = new System.Drawing.Size(151, 28);
            this.cbHarga.TabIndex = 12;
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(576, 119);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(151, 27);
            this.tbHarga.TabIndex = 13;
            // 
            // btnBeli
            // 
            this.btnBeli.Location = new System.Drawing.Point(393, 293);
            this.btnBeli.Name = "btnBeli";
            this.btnBeli.Size = new System.Drawing.Size(94, 29);
            this.btnBeli.TabIndex = 14;
            this.btnBeli.Text = "Beli";
            this.btnBeli.UseVisualStyleBackColor = true;
            this.btnBeli.Click += new System.EventHandler(this.btnBeli_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(393, 341);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(94, 29);
            this.btnBayar.TabIndex = 15;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // picGetuk
            // 
            this.picGetuk.Image = global::Pembayaran.Properties.Resources.getuk;
            this.picGetuk.Location = new System.Drawing.Point(193, 193);
            this.picGetuk.Name = "picGetuk";
            this.picGetuk.Size = new System.Drawing.Size(98, 90);
            this.picGetuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGetuk.TabIndex = 16;
            this.picGetuk.TabStop = false;
            this.picGetuk.Visible = false;
            this.picGetuk.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // picPecel
            // 
            this.picPecel.Image = ((System.Drawing.Image)(resources.GetObject("picPecel.Image")));
            this.picPecel.Location = new System.Drawing.Point(193, 193);
            this.picPecel.Name = "picPecel";
            this.picPecel.Size = new System.Drawing.Size(98, 90);
            this.picPecel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPecel.TabIndex = 17;
            this.picPecel.TabStop = false;
            this.picPecel.Visible = false;
            // 
            // picSoto
            // 
            this.picSoto.Image = ((System.Drawing.Image)(resources.GetObject("picSoto.Image")));
            this.picSoto.Location = new System.Drawing.Point(193, 193);
            this.picSoto.Name = "picSoto";
            this.picSoto.Size = new System.Drawing.Size(98, 90);
            this.picSoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSoto.TabIndex = 18;
            this.picSoto.TabStop = false;
            this.picSoto.Visible = false;
            this.picSoto.Click += new System.EventHandler(this.picSoto_Click);
            // 
            // LB1
            // 
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 20;
            this.LB1.Location = new System.Drawing.Point(37, 293);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(331, 124);
            this.LB1.TabIndex = 19;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(393, 388);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 29);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.picSoto);
            this.Controls.Add(this.picPecel);
            this.Controls.Add(this.picGetuk);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.btnBeli);
            this.Controls.Add(this.tbHarga);
            this.Controls.Add(this.cbHarga);
            this.Controls.Add(this.cbItemBarang);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.tbTambahBarang);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bnyaknya);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bnyaknya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGetuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPecel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown bnyaknya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTambahBarang;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.ComboBox cbItemBarang;
        private System.Windows.Forms.ComboBox cbHarga;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Button btnBeli;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.PictureBox picGetuk;
        private System.Windows.Forms.PictureBox picPecel;
        private System.Windows.Forms.PictureBox picSoto;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button btnClear;
    }
}

