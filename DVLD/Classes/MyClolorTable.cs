using System.Windows.Forms;
using System.Drawing;

namespace DVLD
{
    public class MyColorTable : ProfessionalColorTable
    {
        public override Color MenuItemSelected
            => Color.FromArgb(35, 100, 180);

        public override Color MenuItemBorder
            => Color.Transparent;

        public override Color ToolStripDropDownBackground
            => Color.FromArgb(45, 55, 70);

        public override Color MenuBorder
            => Color.FromArgb(45, 55, 70);

        public override Color ImageMarginGradientBegin
            => Color.FromArgb(45, 55, 70);

        public override Color ImageMarginGradientMiddle
            => Color.FromArgb(45, 55, 70);

        public override Color ImageMarginGradientEnd
            => Color.FromArgb(45, 55, 70);
    }
}
