using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP1PBO2021.Properties;

namespace TP1PBO2021
{
    public partial class MainMenu : Form
    {
        private ProductBox[] productBoxes = new ProductBox[5];
        
        public MainMenu()
        {
            InitializeComponent();
            Console.WriteLine("Hello");

            #region Initialize products data

            productBoxes[0] = new ProductBox();
            productBoxes[0].Title = "Supreme KW";
            productBoxes[0].Kategori = "Baju";
            productBoxes[0].Price = 100000;
            productBoxes[0].Picture = Resources.product0;

            productBoxes[1] = new ProductBox();
            productBoxes[1].Title = "Playstation Series X";
            productBoxes[1].Kategori = "Elektronik";
            productBoxes[1].Price = 1000000;
            productBoxes[1].Picture = Resources.product1;

            productBoxes[2] = new ProductBox();
            productBoxes[2].Title = "iPhone Galaxy S21";
            productBoxes[2].Kategori = "Elektronik";
            productBoxes[2].Price = 400000;
            productBoxes[2].Picture = Resources.product2;

            productBoxes[3] = new ProductBox();
            productBoxes[3].Title = "Deus KW";
            productBoxes[3].Kategori = "Baju";
            productBoxes[3].Price = 200000;
            productBoxes[3].Picture = Resources.product3;

            productBoxes[4] = new ProductBox();
            productBoxes[4].Title = "Gomu Gomu no Mi";
            productBoxes[4].Kategori = "Makanan";
            productBoxes[4].Price = 150000;
            productBoxes[4].Picture = Resources.product4;

            foreach (var product in productBoxes)
            {
                product.buttonBeli.Click += new EventHandler(clickBeli);
            }
            #endregion
        }

        /// <summary>
        /// Method to perform an action when one of button of ProductBox is clicked 
        /// </summary>
        private void clickBeli(object sender, EventArgs e)
        {
            Control c = (Control) sender;
            ProductBox parent = (ProductBox) c.Parent;

            parentHomePanel.Visible = false;
            parentDetailPanel.Visible = true;

            productDetail.Title = parent.Title;
            productDetail.Price = parent.Price;
            productDetail.Picture = parent.Picture;
        }

        private void Product_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Display list of data when this window is loaded
        /// </summary>
        private void MainMenu_Load(object sender, EventArgs e)
        {
            displayList();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        /// <summary>
        /// Method to display product boxes depends on the filter
        /// </summary>
        private void displayList(String jenisBarang = "", String rangeHarga = "")
        {
            homePanel.Controls.Clear();
            Console.WriteLine(jenisBarang + " " + rangeHarga);

            foreach (var product in productBoxes)
            {
                if (jenisBarang == product.Kategori || jenisBarang == "")
                {
                    if ((rangeHarga == "") || 
                        (((rangeHarga == "Rp. 100rb - Rp. 200rb") && 
                        (product.Price >= 100000) && (product.Price <= 200000)) ||
                        ((rangeHarga == "Rp. 200rb - Rp. 500rb") &&
                        (product.Price >= 200000) && (product.Price <= 500000)) ||
                        ((rangeHarga == "Rp. 500rb - Rp. 1jt") &&
                        (product.Price >= 500000) && (product.Price <= 1000000))))
                    {
                        homePanel.Controls.Add(product);
                    }
                }
            }
        }

        private void cbJenisBrg_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            String jenisBarang = cbJenisBrg.Text;
            String rangeHarga = cbHarga.Text;

            if (jenisBarang != "Jenis Barang" && rangeHarga != "Harga")
                displayList(jenisBarang, rangeHarga);
        }

        private void detailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            parentHomePanel.Visible = true;
            parentDetailPanel.Visible = false;
            displayList();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://tokopedia.com");
        }

        private void panel8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tokopedia.com");
        }

        private void panel7_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }
    }
}
