using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JANL
{
    public class ObservableObject : INotifyPropertyChanged
    {
        /// <summary>
        /// Уведомляет клиентов об изменении значения свойства
        /// </summary>
        /// <param name="propertyName">Имя свойства</param>
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = null) => OnPropertyChanged(new PropertyChangedEventArgs(propertyName));

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>
        /// </summary>
        protected void OnPropertyChanged(PropertyChangedEventArgs e) => PropertyChanged?.Invoke(this, e);

        /// <summary>
        /// Изменяет значение свойства и вызывает событие <see cref="PropertyChanged"/>
        /// </summary>
        /// <typeparam name="T">Тип свойства</typeparam>
        /// <param name="propertyName">Имя свойства</param>
        /// <param name="field">Поле по ссылке</param>
        /// <param name="value">Значение</param>
        protected void SetPropertyField<T>(string propertyName, ref T field, T value)
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) { return; }
            field = value;
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Изменяет значение свойства и вызывает событие <see cref="PropertyChanged"/>
        /// </summary>
        /// <typeparam name="T">Тип свойства</typeparam>
        /// <param name="field">Поле по ссылке</param>
        /// <param name="value">Значение</param>
        /// <param name="propertyName">Имя свойства</param>
        protected void SetPropertyField<T>(ref T field, T value, [CallerMemberName] string propertyName = null) => SetPropertyField(propertyName, ref field, value);

        /// <summary>
        /// Происходит при изменении значения свойства
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}