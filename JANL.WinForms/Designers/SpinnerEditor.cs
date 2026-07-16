using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using JANL.Animators;
using JANL.Controls;
using JANL.Forms;

namespace JANL.Designers
{
    /// <summary>
    /// Редактор для дизайнера
    /// </summary>
    public class SpinnerEditor : UITypeEditor
    {
        /// <summary>
        /// Получить список спиннеров
        /// </summary>
        public static List<SpinnerLVI> CreateSpinnerItems()
        {
            var types = GetTypes();
            var spinners = types.Where(IsSpinner)
                .Select(T => (Spinner)Activator.CreateInstance(T));
            return spinners.Select(S => new SpinnerLVI(S)).ToList();

        }

        /// <summary>
        /// Проверяет является ли тип спиннером
        /// </summary>
        /// <param name="T">Тип</param>
        public static bool IsSpinner(Type T) => T.IsClass && !T.IsAbstract && T.IsSubclassOf(typeof(Spinner));

        /// <summary>
        ///
        /// </summary>
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {
            var svc = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
            //using (var form = new FormSpinnerEditor())
            //{
            //    if (value is Spinner spinner)
            //    {
            //        form.Value = spinner;
            //    }
            //    if (svc.ShowDialog(form) == DialogResult.OK)
            //    {
            //        return form.Value;
            //    }
            //}
            var items = CreateSpinnerItems();
            items.ForEach(I => I.Start());
            using (var form = new FormItemSelector())
            {
                form.Items = items;
                if (svc.ShowDialog(form) == DialogResult.OK)
                {
                    var item = (SpinnerLVI)form.SelectedItems.FirstOrDefault();
                    return item?.Tag;
                }
            }
            return value;
            // return base.EditValue(context, provider, value);
        }

        /// <summary>
        /// Абоба
        /// </summary>
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context) => UITypeEditorEditStyle.Modal;

        /// <summary>
        /// Not working in designer
        /// </summary>
        private static Type[] GetDomainTypes()
        {
            var types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(A =>
            {
                try
                {
                    return A.GetTypes();
                }
                catch (ReflectionTypeLoadException ex)
                {
                    return ex.Types.Where(t => t != null);
                }
            });
            return types.ToArray();
        }

        private static Type[] GetTypes() => Assembly.GetExecutingAssembly().GetTypes();
    }
}