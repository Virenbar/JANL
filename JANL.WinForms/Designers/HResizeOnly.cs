using System.Windows.Forms.Design;

namespace JANL.Designers
{
    /// <summary>
    /// Разрешает изменение только ширины
    /// </summary>
    public class HResizeOnly : ControlDesigner
    {
        /// <summary>
        ///
        /// </summary>
        public HResizeOnly()
        {
            AutoResizeHandles = true;
        }

        /// <summary>
        /// Правила изменения размера
        /// </summary>
        public override SelectionRules SelectionRules => SelectionRules.LeftSizeable | SelectionRules.RightSizeable | SelectionRules.Moveable;
    }
}