using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Reflection;
using System.Windows.Forms;

namespace JANL.Extensions
{
    /// <summary>
    /// Extensions for Types inheriting Control
    /// </summary>
    public static class ControlExtensions
    {
        private readonly static HashSet<Type> CTR = new HashSet<Type> { typeof(Button), typeof(ComboBox), typeof(NumericUpDown), typeof(DateTimePicker), typeof(TextBox) };

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
        /// Отключает автогенерацию колонок и включает двойную буферизацию
        /// </summary>
        /// <param name="dgv"></param>
        public static void FixDGV(this DataGridView dgv)
        {
            dgv.AutoGenerateColumns = false;
            DoubleBuffered(dgv, true);
        }

        /// <summary>
        /// Если выбранный индекс больше 0, то возвращает выбранное значение иначе Nothing
        /// </summary>
        /// <param name="CB"></param>
        /// <returns></returns>
        public static string GetString(this ComboBox CB) => CB.SelectedIndex > 0 ? Convert.ToString(CB.SelectedValue) : null;

        /// <summary>
        /// Если текст больше 0, то возвращает его иначе Nothing
        /// </summary>
        /// <param name="TB"></param>
        /// <returns></returns>
        public static string GetString(this TextBox TB) => TB.Text.Length > 0 ? TB.Text : null;

        /// <summary>
        /// Если выбранный индекс больше 0, то возвращает выбранное значение иначе Nothing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CB"></param>
        /// <returns></returns>
        public static T? GetValue<T>(this ComboBox CB) where T : struct => CB.SelectedIndex > 0 ? new T?((T)CB.SelectedValue) : default;

        /// <summary>
        /// Если выбранный индекс больше 0, то возвращает выбранное значение иначе Nothing
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CB"></param>
        /// <returns></returns>
        public static T? GetValue<T>(this ToolStripComboBox CB) where T : struct => CB.SelectedIndex > 0 ? new T?((T)CB.ComboBox.SelectedValue) : default;

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

        public static void SetEnableRecursive(Control cont, bool state) => SetEnableRecursive(cont, state, new Control[] { });

        /// <summary>
        /// Рекурсивно меняет состояние контролов, кроме исключённых
        /// </summary>
        /// <param name="state">Состояние</param>
        /// <param name="excl">Исключения</param>
        public static void SetEnableRecursive(this Control cont, bool state, Control[] excl) => SetEnableRecursive(cont, state, new HashSet<Control>(excl));

        /// <summary>
        /// Рекурсивно меняет состояние контролов, кроме исключённых
        /// </summary>
        /// <param name="state">Состояние</param>
        /// <param name="excl">Исключения</param>
        public static void SetEnableRecursive(this Control cont, bool state, HashSet<Control> excl)
        {
            foreach (Control C in cont.Controls)
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

        public static void SetIntegerValue(this ComboBox CB, object value) => SetIntegerValue(CB, value, -1);

        public static void SetIntegerValue(this ComboBox CB, object value, int def)
        {
            if (value == DBNull.Value || value == null)
            {
                CB.SelectedValue = def;
            }
            else
            {
                CB.SelectedValue = (int)value;
            }
        }

        /// <summary>
        /// Вызывает метод в текущем потоке
        /// </summary>
        /// <param name="control"></param>
        /// <param name="action">Метод для вызова</param>
        public static void InvokeAction(this ISynchronizeInvoke control, Action action)
        {
            if (control.InvokeRequired) { control.Invoke(action, null); } else { action(); }
        }
    }
}