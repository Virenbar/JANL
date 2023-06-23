using System;
using System.Drawing;

namespace JANL.Interfaces
{
    public interface IAnimator
    {
        /// <summary>
        /// Исходное изображение
        /// </summary>
        Image SourceImage { get; set; }

        /// <summary>
        /// Текущий кадр
        /// </summary>
        Image CurrentImage { get; }

        /// <summary>
        /// Частота кадров (FPS)
        /// </summary>
        int Framerate { get; set; }

        /// <summary>
        /// Активна ли анимация
        /// </summary>
        [Obsolete("Use Enabled")]
        bool IsAnimated { get; }

        /// <summary>
        /// Активна ли анимация
        /// </summary>
        bool Enabled { get; }

        /// <summary>
        /// Длительность анимации
        /// </summary>
        int Duration { get; set; }

        /// <summary>
        /// Запуск анимации
        /// </summary>
        void StartAnimation();

        /// <summary>
        /// Сброс состояния анимации
        /// </summary>
        void ResetAnimation();

        /// <summary>
        /// Остановка анимации
        /// </summary>
        void StopAnimation();

        /// <summary>
        /// Высота текущего кадра
        /// </summary>
        int Height { get; }

        /// <summary>
        /// Ширина текущего кадра
        /// </summary>
        int Width { get; }

        event EventHandler CurrentImageChanged;
    }
}