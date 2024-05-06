using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freelancer
{
    public partial class Login : Form
    {
        private UserData userData;

        //constructor
        public Login(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = loginUsername.Text;
            string password = loginPassword.Text;
        }

        private void toRegForm_click(object sender, EventArgs e)
        {
            Registration registration = new Registration(userData);
            registration.Show();
            this.Hide();
        }
    }
}