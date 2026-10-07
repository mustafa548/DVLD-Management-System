using DVLD_Business;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmSendEmail : Form
    {
        private string _ToEmail;

        public frmSendEmail(string email)
        {
            InitializeComponent();

            _ToEmail = email;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSendEmail_Load(object sender, EventArgs e)
        {
            lbToValue.Text = _ToEmail;
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            if (txtSubject.Text == "" || txtBody.Text == "")
            {
                MessageBox.Show("Please Fill The Inputs First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnClose.Enabled = false;
            btnClose1.Enabled = false;
            btnSend.Enabled = false;
            lbWaiting.Visible = true;

            try
            {
                bool result = await Task.Run(() => clsGlobal.SendEmail(_ToEmail, txtSubject.Text, txtBody.Text));   

                if (result)
                {

                    MessageBox.Show("Email Sended Successfully", "Sended Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                    MessageBox.Show("Error: Can't Send This Email", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                lbWaiting.Visible = false;
                btnClose.Enabled = true;
                btnClose1.Enabled = true;
                btnSend.Enabled = true;
            }

        }
    }
}
