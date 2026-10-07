using DVLD.Properties;
using SiticoneNetFrameworkUI;
using System.Windows.Forms;

namespace DVLD
{
    public class clsUiGlobal
    {
        public static void TogglePassword(PictureBox pictureBox, SiticoneTextBoxAdvanced textBox)
        {
            if (bool.Parse(pictureBox.Tag.ToString()))
            {
                pictureBox.Tag = false;
                pictureBox.Image = Resources.HidePassword;
                textBox.InputType = AdvancedTextBoxInputType.String;
            }
            else
            {
                pictureBox.Tag = true;
                pictureBox.Image = Resources.ShowPassword;
                textBox.InputType = AdvancedTextBoxInputType.Password;
            }
        }

        public static void SetError(System.ComponentModel.CancelEventArgs e, SiticoneTextBoxAdvanced txtBox, string message, ErrorProvider errorProvider1)
        {
            e.Cancel = true;
            errorProvider1.SetError(txtBox, message);
            txtBox.Focus();
        }

        public static void CancelError(System.ComponentModel.CancelEventArgs e, SiticoneTextBoxAdvanced txtBox, ErrorProvider errorProvider1)
        {
            e.Cancel = false;
            errorProvider1.SetError(txtBox, "");
        }
    }
}
