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
    public partial class LoginForm : Form
    {
        /// <summary>
        /// Username and Password string from the input of user
        /// </summary>
        private String username;
        private String password;

        // The correct password, that will be compared with user's input
        private String correctPassword = "pbo123";
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButtonClick(object sender, EventArgs e)
        {
            this.username = Convert.ToString(usernameInput.Text);
            this.password = Convert.ToString(passwordInput.Text);

            if (password == correctPassword)
            {
                // Open new window
                MainMenu mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
            else
            {
                // Showing message box warning
                string text = "Password salah";
                MessageBox.Show(text);
            }
        }
    }
}
