using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD
{
    public partial class ctrlPersonInfoWithFilter : UserControl
    {
        public event Action<int> OnPersonSelected;

        protected virtual void PersonSelected(int PersonID)
        {
            Action<int> handler = OnPersonSelected;

            if (handler != null)
                handler(PersonID);
        }

        public ctrlPersonInfoWithFilter()
        {
            InitializeComponent();
        }

        private void dplFilterItems_ItemSelected(object sender, SiticoneNetFrameworkUI.SiticoneDropdown.DropdownItemSelectedEventArgs e)
        {
            mtxtInputFilter.Clear();

            switch (dplFilterItems.SelectedItem.ToString())
            {
                case "Person ID":
                    mtxtInputFilter.Mask = "0000";
                    break;
                case "Phone":
                    mtxtInputFilter.Mask = "0000-000-0000";
                    break;
                default:
                    mtxtInputFilter.Mask = "";
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mtxtInputFilter.Text == "")
            {
                MessageBox.Show("Error: You Must Fill The Input First.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsPerson Person = new clsPerson();

            switch (dplFilterItems.SelectedItem.ToString())
            {
                case "Person ID":
                    Person = clsPerson.Find(int.Parse(mtxtInputFilter.Text));
                    break;
                case "Phone":
                    Person = clsPerson.FindByPhone(mtxtInputFilter.Text);
                    break;
                case "National ID Number":
                    Person = clsPerson.Find(mtxtInputFilter.Text);
                    break;
            }

            if (Person == null)
            {
                MessageBox.Show("Can't Find This Person Info", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ctrlPersonInfo1.SelectPerson(Person);

            mtxtInputFilter.Text = "";

            if (OnPersonSelected != null)
            {
                PersonSelected(Person.PersonID);
            }
        }

        public void Form_DataBack(int PersonID)
        {
            mtxtInputFilter.Text = "";
            ctrlPersonInfo1.SelectPerson(PersonID);

            if (OnPersonSelected != null)
            {
                PersonSelected(PersonID);
            }
        }

        public void AfterPersonSelected(clsPerson Person)
        {
            DisableFilters();
            ctrlPersonInfo1.SelectPerson(Person);
        }

        private void DisableFilters()
        {
            dplFilterItems.Enabled = false;
            mtxtInputFilter.Enabled = false;
            btnAddNewPerson.Enabled = false;
            btnSearch.Enabled = false;

            mtxtInputFilter.Text = "";
        }

        private void btnAddNewPerson_Click(object sender, EventArgs e)
        {
            frmAddAndEditPerson AddPersonForm = new frmAddAndEditPerson();

            AddPersonForm.DataBack += Form_DataBack;

            AddPersonForm.ShowDialog();
        }

        public void ClearSelectedPerson()
        {
            ctrlPersonInfo1.DeleteDataFromCard();
        }
    }
}
