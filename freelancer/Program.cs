using System;
using System.Windows.Forms;

namespace freelancer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create an instance of UserData
            UserData userData = new UserData();

            // Pass userData to the Login form constructor
            Application.Run(new Login(userData));
        }
    }
}
