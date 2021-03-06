using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1PBO2021
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            displayList();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void displayList()
        {
            ProductBox[] productBoxes = new ProductBox[5];

            for (int i = 0; i < productBoxes.Length; i++)
            {
                productBoxes[i] = new ProductBox();
                productBoxes[i].Title = "Baju";
                productBoxes[i].Price = "Rp. " + (i * 10000);

                flowLayoutPanel1.Controls.Add(productBoxes[i]);
            }
        }
    }
}
