using System.Windows.Forms;
using DVLD_Business;

namespace DVLD
{
    public partial class ctrlApplicationInfo : UserControl
    {
        private clsApplication _Application;

        public ctrlApplicationInfo()
        {
            InitializeComponent();
        }

        public void SelectApplication(clsApplication Application)
        {
            if (Application != null)
            {
                _Application = Application;

                llbViewPersonInfo.Visible = true;

                lbIDValue.Text = Application.ApplicationNumber.ToString();
                lbStatusValue.Text = Application.GetStatusAsString();
                lbFeesValue.Text = Application.ApplicationType.ApplicationFees.ToString();
                lbTypeValue.Text = Application.ApplicationType.ApplicationName;
                lbApplicantValue.Text = Application.PersonInfo.GetFullName();
                lbDateValue.Text = Application.Date.ToString("dd/MM/yyyy");
                lbStatusDateValue.Text = Application.StatusDate.ToString("dd/MM/yyyy");
                lbCreatedByValue.Text = Application.CreatedByUser.UserName;
            }
        }

        public void SelectApplication(int ApplicationNumber)
        {
            _Application = clsApplication.Find(ApplicationNumber);

            if (_Application != null)
                SelectApplication(_Application);
        }

        private void llbViewPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_Application != null)
            {
                frmPersonDetails PersonDetailsForm = new frmPersonDetails(_Application.PersonID);
                PersonDetailsForm.ShowDialog();
            }
        }


    }
}
