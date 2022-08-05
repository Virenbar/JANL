using JANL.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL
{
    [Obsolete]
    public abstract class BaseRepository
    {
        private const string RepositoryError = "Некорректная конфигурация репозитория";

        protected BaseRepository(string Name, string KeyName, string ValueName) : this(Name, KeyName, ValueName, new List<string> { ValueName }) { }

        protected BaseRepository(string Name, string KeyName, string ValueName, IEnumerable<string> DGVFilter)
        {
            this.Name = Name;
            this.KeyName = KeyName;
            this.ValueName = ValueName;
            this.DGVFilter = DGVFilter;
        }

        public delegate void FilterChangedEventHandler();

        public bool CanCreate => GetType().IsOverride(nameof(CreateItem));

        public bool CanDelete => GetType().IsOverride(nameof(DeleteItem));

        public bool CanEdit => GetType().IsOverride(nameof(EditItem));

        /// <summary>
        /// Получить форму для создания
        /// <remarks>Не вызывать отображение формы!</remarks>
        /// </summary>
        public virtual Form CreateItem => throw new NotImplementedException(RepositoryError);

        /// <summary>
        /// Столбцы для локального фильтра
        /// </summary>
        public IEnumerable<string> DGVFilter { get; }

        public string DGVTemplate { get; protected set; } = "";

        public bool HasFilter => GetType().IsOverride(nameof(GetFilter));

        public bool HasMenu => GetType().IsOverride(nameof(GetMenu));

        public Icon Icon { get; protected set; }

        /// <summary>
        /// Имя поля ключа
        /// </summary>
        public string KeyName { get; }

        /// <summary>
        /// Наименование репозитория
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Имя поля значения
        /// </summary>
        public string ValueName { get; }

        /// <summary>
        /// Выполнить удаление
        /// </summary>
        public virtual void DeleteItem(int Key) => throw new NotImplementedException(RepositoryError);

        /// <summary>
        /// Получить форму для редактирования
        /// <remarks>Не вызывать отображение формы!</remarks>
        /// </summary>
        public virtual Form EditItem(int Key) => throw new NotImplementedException(RepositoryError);

        /// <summary>
        /// Получить элемент управления с фильтрами
        /// </summary>
        public virtual UserControl GetFilter() => throw new NotImplementedException(RepositoryError);

        /// <summary>
        /// Получить список
        /// </summary>
        public abstract Task<DataTable> GetList();

        /// <summary>
        /// Получить пункты меню
        /// </summary>
        /// <returns></returns>
        public virtual List<MenuItem> GetMenu() => throw new NotImplementedException(RepositoryError);

        /// <summary>
        /// Получить текстовое значение для ключа
        /// </summary>
        /// <returns></returns>
        public virtual string GetValue(int Key) => Key.ToString();

        public void OnFilterChanged() => FilterChanged?.Invoke();

        public class MenuItem
        {
            public Action<int> Action { get; set; }
            public Image Image { get; set; }
            public string Text { get; set; }
        }

        public event FilterChangedEventHandler FilterChanged;
    }
}