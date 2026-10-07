using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            while (true)
            {
                string UserName = clsGlobal.GetUserNameFromRegistry();

                if (UserName == "")
                {
                    frmLogin loginForm = new frmLogin();

                    if (loginForm.ShowDialog() != DialogResult.OK)
                        break;
                }
                else
                {
                    clsUser User = clsUser.Find(UserName);

                    if (User == null || !User.IsActive)
                    {
                        clsGlobal.SetValueOfUserNameInRegistry("");

                        frmLogin loginForm = new frmLogin();

                        if (loginForm.ShowDialog() != DialogResult.OK)
                            break;
                    }
                    else
                    {
                        clsGlobal.CurrentUser = User; 
                    }
                }

                frmMain mainForm = new frmMain();
                Application.Run(mainForm);

                if (mainForm.DialogResult != DialogResult.Retry)
                    break;
            }

        }
    }
}
