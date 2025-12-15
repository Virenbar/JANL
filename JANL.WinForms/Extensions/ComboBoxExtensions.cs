using System;
using System.Windows.Forms;

namespace JANL.Extensions
{
    /// <summary>
    /// Расширения для <see cref="ComboBox"/>
    /// </summary>
    static public class ComboBoxExtensions
    {
        /// <summary>
        /// Если выбранный индекс больше 0, то возвращает выбранное значение иначе null
        /// </summary>
        /// <param name="CB"></param>
        /// <returns></returns>
        public static string GetString(this ComboBox CB) => CB.SelectedIndex > 0 ? Convert.ToString(CB.SelectedValue) : null;

        /// <summary>
        /// Если выбранный индекс больше 0, то возвращает выбранное значение иначе <see cref="null"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CB"></param>
        /// <returns></returns>
        public static T? GetValue<T>(this ComboBox CB) where T : struct => CB.SelectedIndex > 0 ? new T?((T)CB.SelectedValue) : default;

        /// <summary>
        /// Если выбранный индекс больше 0, то возвращает выбранное значение иначе null
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="CB"></param>
        /// <returns></returns>
        public static T? GetValue<T>(this ToolStripComboBox CB) where T : struct => CB.SelectedIndex > 0 ? new T?((T)CB.ComboBox.SelectedValue) : default;

        /// <summary>
        ///
        /// </summary>
        /// <param name="CB"></param>
        /// <param name="value"></param>
        public static void SetIntegerValue(this ComboBox CB, object value) => SetIntegerValue(CB, value, -1);

        /// <summary>
        ///
        /// </summary>
        /// <param name="CB"></param>
        /// <param name="value"></param>
        /// <param name="def"></param>
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
    }
}