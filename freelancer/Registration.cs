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
    public partial class Registration : Form
    {
        private UserData userData;

        //constructor
        public Registration(UserData userData)
        {
            InitializeComponent();
            this.userData = userData;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string username = regUsername.Text;
            string password = regPassword.Text;
            string confirmPassword = regConfirmPassword.Text;
            string typeOfUser = regUserType.Text;
            UserType userType = UserType.Freelancer; // Default value

            if (typeOfUser == "Freelancer")
            {
                userType = UserType.Freelancer;
            }
            else if (typeOfUser == "Client")
            {
                userType = UserType.Client;
            }
            else
            {
                MessageBox.Show("Invalid user type."); // Handle invalid user type
                return; // Exit the method to prevent further execution
            }

            if (userData.registerUser(username, password, confirmPassword, userType))
            {
                // Registration successful, provide feedback to the user
                MessageBox.Show("Registration successful!");
                // Optionally, clear form fields for the next registration
                ClearFormFields();

                if (userType == UserType.Client)
                {
                    //open client profile creation form
                    ClientProfileCreation clientProfile = new ClientProfileCreation();
                    clientProfile.Show();
                }else if (userType == UserType.Freelancer)
                {
                    // open freelancer profile creation form
                    FreelancerProfileCreation freelancerProfile = new FreelancerProfileCreation();
                    freelancerProfile.Show();
                }
            }
            else
            {
                // Registration failed, provide feedback to the user
                MessageBox.Show("Registration failed. Please check your inputs and try again.");
            }
        }

        private void ClearFormFields()
        {
            // Clear form fields
            regUsername.Text = "";
            regPassword.Text = "";
            regConfirmPassword.Text = "";
            regUserType.SelectedIndex = -1; // Reset selected index for user type ListBox
        }

        private void toLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login(userData);
            login.Show();
            this.Hide();
        }
    }
}