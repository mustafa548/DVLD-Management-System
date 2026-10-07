using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class frmRequestDetails : Form
    {
        private int _RequestID;

        public frmRequestDetails(int RequestID)
        {
            InitializeComponent();

            _RequestID = RequestID;
        }

        private void frmRequestDetails_Load(object sender, EventArgs e)
        {
            ctrlRequestInfo1.SelectRequest(_RequestID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
