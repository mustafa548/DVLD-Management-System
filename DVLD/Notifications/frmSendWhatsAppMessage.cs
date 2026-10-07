using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmSendWhatsAppMessage : Form
    {
        private clsPerson Person;

        public frmSendWhatsAppMessage(int PersonID)
        {
            InitializeComponent();

            Person = clsPerson.Find(PersonID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSendWhatsAppMessage_Load(object sender, EventArgs e)
        {
            lbToValue.Text = Person.Phone;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                MessageBox.Show("Please Write Message First", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsGlobal.OpenWhatsApp(Person.Phone, txtMessage.Text, Person.CountryInfo.CountryCode);
            this.Close();
        }
    }
}
