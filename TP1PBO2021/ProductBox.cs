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
    public partial class ProductBox : UserControl
    {

        public ProductBox()
        {
            InitializeComponent();
        }

        private String _title;
        private String _price;
        private Image _picture;

        [Category("Custom Properties")]
        public String Title
        {
            get { return _title; }
            set { _title = value; title.Text = value; }
        }

        [Category("Custom Properties")]
        public String Price
        {
            get { return _price; }
            set { _price = value; price.Text = value; }
        }

        [Category("Custom Properties")]
        public Image Picture
        {
            get { return _picture; }
            set { _picture = value; picture.Image = value; }
        }
    }
}
