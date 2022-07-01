using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JANL
{
    public class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Уведомляет клиентов об изменении значения свойства
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Происходит при изменении значения свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}