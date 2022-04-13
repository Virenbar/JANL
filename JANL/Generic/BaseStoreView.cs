using JANL.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JANL.Generic
{
    /// <summary>
    ///
    /// </summary>
    public abstract class BaseStoreView
    {
        public abstract Task<DataTable> GetList();

        //public K CurretKey { get; set; }
        public DataRow CurrentRow { get; set; }

        #region Properties
        public IEnumerable<string> FilterCollumns { get; protected set; }
        public string DGVTemplate { get; protected set; }
        public Icon Icon { get; protected set; }

        /// <summary>
        /// Имя поля ключа
        /// </summary>
        public string KeyName { get; }

        /// <summary>
        /// Наименование хранилища
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// Имя поля значения
        /// </summary>
        public string ValueName { get; }

        #region Reflection
        public bool CanCreate => GetType().IsOverride(nameof(CreateItem));
        public bool CanEdit => GetType().IsOverride(nameof(EditItem));
        public bool CanDelete => GetType().IsOverride(nameof(DeleteItem));
        #endregion Reflection

        #endregion Properties

        #region Virtual
        private const string RepositoryError = "Некорректная конфигурация";

        public virtual Form CreateItem() => throw new NotImplementedException(RepositoryError);

        public virtual Form EditItem() => throw new NotImplementedException(RepositoryError);

        public virtual Form DeleteItem() => throw new NotImplementedException(RepositoryError);

        public virtual UserControl GetHeader() => null;

        #endregion Virtual

        #region Events

        protected void OnFilterChanged() => FilterChanged?.Invoke(this, EventArgs.Empty);

        public event EventHandler FilterChanged;

        #endregion Events
    }
}