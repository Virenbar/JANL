using System.Windows.Forms.Design;

namespace JANL.Designers
{
    public class HResizeOnly : ControlDesigner
    {
        public HResizeOnly()
        {
            AutoResizeHandles = true;
        }

        public override SelectionRules SelectionRules => SelectionRules.LeftSizeable | SelectionRules.RightSizeable | SelectionRules.Moveable;
    }
}