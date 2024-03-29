﻿using System;
using System.Threading;

namespace JANL
{
    /// <summary>
    /// Захватывает контекст синхронизации текущего потока и вызывает события в нём.
    /// </summary>
    public class SyncEvent
    {
        private readonly SynchronizationContext Context;
        private readonly object Sender;

        public SyncEvent(object sender)
        {
            Sender = sender;
            Context = SynchronizationContext.Current;
        }

        /// <summary>
        /// Отправить асинхронное сообщение в контекст синхронизации.
        /// </summary>
        public void PostEvent<T>(EventHandler<T> Handler, T Args) where T : EventArgs => Context.Post(GetCallback(Handler), Args);

        /// <summary>
        /// Отправить синхронное сообщение в контекст синхронизации.
        /// </summary>
        public void SendEvent<T>(EventHandler<T> Handler, T Args) where T : EventArgs => Context.Send(GetCallback(Handler), Args);

        private SendOrPostCallback GetCallback<T>(EventHandler<T> Handler)
        {
            return (state) =>
            {
                T E = (T)state;
                Handler?.Invoke(Sender, E);
            };
        }
    }
}