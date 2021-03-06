
namespace TP1PBO2021
{
    partial class MainMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbJenisBrg = new System.Windows.Forms.ComboBox();
            this.cbHarga = new System.Windows.Forms.ComboBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(188, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 391);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 55);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnCari);
            this.panel2.Controls.Add(this.cbHarga);
            this.panel2.Controls.Add(this.cbJenisBrg);
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(182, 391);
            this.panel2.TabIndex = 2;
            // 
            // cbJenisBrg
            // 
            this.cbJenisBrg.FormattingEnabled = true;
            this.cbJenisBrg.Items.AddRange(new object[] {
            "Elektronik",
            "Baju",
            "Makanan"});
            this.cbJenisBrg.Location = new System.Drawing.Point(13, 27);
            this.cbJenisBrg.Name = "cbJenisBrg";
            this.cbJenisBrg.Size = new System.Drawing.Size(155, 21);
            this.cbJenisBrg.TabIndex = 0;
            this.cbJenisBrg.Text = "Jenis Barang";
            this.cbJenisBrg.SelectedIndexChanged += new System.EventHandler(this.cbJenisBrg_SelectedIndexChanged);
            // 
            // cbHarga
            // 
            this.cbHarga.FormattingEnabled = true;
            this.cbHarga.Items.AddRange(new object[] {
            "Rp. 100rb - Rp. 200rb",
            "Rp. 200rb - Rp. 500rb",
            "Rp. 500rb - Rp. 1jt"});
            this.cbHarga.Location = new System.Drawing.Point(13, 77);
            this.cbHarga.Name = "cbHarga";
            this.cbHarga.Size = new System.Drawing.Size(155, 21);
            this.cbHarga.TabIndex = 1;
            this.cbHarga.Text = "Harga";
            // 
            // btnCari
            // 
            this.btnCari.Location = new System.Drawing.Point(13, 128);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(155, 23);
            this.btnCari.TabIndex = 2;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.ComboBox cbHarga;
        private System.Windows.Forms.ComboBox cbJenisBrg;
    }
}