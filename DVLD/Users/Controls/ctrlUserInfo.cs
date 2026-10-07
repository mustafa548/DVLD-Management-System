using DVLD_Business;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlUserInfo : UserControl
    {
        public ctrlUserInfo()
        {
            InitializeComponent();
        }

        public void SelectUser(int UserID)
        {
            clsUser User = clsUser.Find(UserID);

            if (User != null)
            {
                ctrlPersonInfo1.SelectPerson(User.PersonInfo);

                lbUserIDValue.Text   = User.UserID.ToString();
                lbUserNameValue.Text = User.UserName;

                if (User.IsActive)
                    lbIsActiveValue.Text = "Yes";
                else
                    lbIsActiveValue.Text = "No";
            }
        }

    }
}
