using JANL.Controls;
using JANL.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для классов наследованных от <see cref="Control"/>
    /// </summary>
    public static class ControlExtensions
    {
        private readonly static HashSet<Type> CTR = new HashSet<Type> { typeof(Button), typeof(ComboBox), typeof(NumericUpDown), typeof(DateTimePicker), typeof(TextBox) };

        /// <summary>
        /// Возвращает все дочерние элементы
        /// </summary>
        /// <param name="root"></param>
        /// <returns></returns>
        public static IEnumerable<Control> ChildControls(this Control root)
        {
            var control = root;
            var queue = new Queue<Control>();
            do
            {
                foreach (var child in control.Controls.OfType<Control>())
                {
                    queue.Enqueue(child);
                }
                control = queue.Dequeue();
                yield return control;
            } while (queue.Count > 0);
        }

        /// <summary>
        /// Включает двойную буферизацию
        /// </summary>
        public static void DoubleBuffered(this Control control) => DoubleBuffered(control, true);

        /// <summary>
        /// Включает двойную буферизацию
        /// </summary>
        public static void DoubleBuffered(this Control control, bool setting)
        {
            Type CtrlType = control.GetType();
            PropertyInfo propInfo = CtrlType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            propInfo.SetValue(control, setting, null);
        }

        /// <summary>
        /// Отключает авто-генерацию колонок и включает двойную буферизацию
        /// </summary>
        /// <param name="dgv"></param>
        public static void FixDGV(this DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DoubleBuffered(dgv, true);
        }

        /// <summary>
        /// Создаёт класс ожидания нажатия на кнопку
        /// </summary>
        /// <param name="button">Кнопка</param>
        public static ButtonAwaiter GetAwaiter(this Button button) => new ButtonAwaiter(button);

        /// <summary>
        /// Если текст больше 0, то возвращает его иначе Nothing
        /// </summary>
        /// <param name="TB"></param>
        /// <returns></returns>
        public static string GetString(this TextBox TB) => TB.Text.Length > 0 ? TB.Text : null;

        /// <summary>
        /// Вызывает метод в текущем потоке
        /// </summary>
        /// <param name="control"></param>
        /// <param name="action">Метод для вызова</param>
        public static void InvokeAction(this ISynchronizeInvoke control, Action action)
        {
            if (control.InvokeRequired) { control.Invoke(action, null); } else { action(); }
        }

        /// <summary>
        /// Устанавливает DT в качестве источника c сохранением сортировки.
        /// DGV должен иметь BindingSource.
        /// </summary>
        public static void SetDataSource(this DataGridView DGV, DataTable DT)
        {
            var SC = DGV.SortedColumn?.Name;
            var LS = DGV.SortOrder == SortOrder.Ascending ? ListSortDirection.Ascending : ListSortDirection.Descending;
            var BS = (BindingSource)DGV.DataSource;
            BS.DataSource = DT;
            if (SC != null)
            {
                DGV.Sort(DGV.Columns[SC], LS);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="control"></param>
        /// <param name="state"></param>
        public static void SetEnableRecursive(Control control, bool state) => SetEnableRecursive(control, state, new Control[] { });

        /// <summary>
        /// Рекурсивно меняет состояние контролов, кроме исключённых
        /// </summary>
        /// <param name="control"></param>
        /// <param name="state">Состояние</param>
        /// <param name="excl">Исключения</param>
        public static void SetEnableRecursive(this Control control, bool state, Control[] excl) => SetEnableRecursive(control, state, new HashSet<Control>(excl));

        /// <summary>
        /// Рекурсивно меняет состояние контролов, кроме исключённых
        /// </summary>
        /// <param name="control"></param>
        /// <param name="state">Состояние</param>
        /// <param name="excl">Исключения</param>
        public static void SetEnableRecursive(this Control control, bool state, HashSet<Control> excl)
        {
            foreach (Control C in control.Controls)
            {
                if (C.Controls.Count > 0)
                {
                    SetEnableRecursive(C, state, excl);
                }
                else if (!excl.Contains(C) && CTR.Contains(C.GetType()))
                {
                    C.Enabled = state;
                }
            }
        }

        /// <summary>
        /// Делает шрифт текста жирным
        /// </summary>
        /// <param name="control"></param>
        public static void SetFontBold(this Control control) => SetFontStyle(control, FontStyle.Bold);

        /// <summary>
        /// Меняет стиль шрифта не затрагивая шрифт дочерних элементов
        /// </summary>
        /// <param name="control"></param>
        /// <param name="style">Style of new font</param>
        public static void SetFontStyle(this Control control, FontStyle style)
        {
            var initial = control.Font;
            var styled = new Font(initial, style);
            foreach (var child in control.Controls.OfType<Control>())
            {
                child.Font = initial;
            }
            control.Font = styled;
        }

        /// <summary>
        /// Удаляет гласные из всех текстов
        /// </summary>
        /// <param name="control"></param>
        public static void VowelsBegone(this Control control) => TextHelper.VowelsBegone(control);

        /// <summary>
        /// Удаляет гласные из всех текстов
        /// </summary>
        /// <param name="control"></param>
        public static void VowelsBegone(this ToolStripItem control) => TextHelper.VowelsBegone(control);
    }
}