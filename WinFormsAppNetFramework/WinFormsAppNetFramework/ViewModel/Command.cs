using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace WinFormsAppNetFramework.ViewModel
{
    public class Command : ICommand
    {
        private readonly Func<object, bool> _canExecute;

        private readonly Action<object> _execute;

        private readonly WeakEventManager _weakEventManager = new WeakEventManager();

        public event EventHandler CanExecuteChanged
        {
            add
            {
                _weakEventManager.AddEventHandler(value, "CanExecuteChanged");
            }
            remove
            {
                _weakEventManager.RemoveEventHandler(value, "CanExecuteChanged");
            }
        }

        public Command(Action<object> execute)
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            _execute = execute;
        }

        public Command(Action execute)
            : this((Action<object>)delegate
            {
                execute();
            })
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }
        }

        public Command(Action<object> execute, Func<object, bool> canExecute)
            : this(execute)
        {
            if (canExecute == null)
            {
                throw new ArgumentNullException("canExecute");
            }

            _canExecute = canExecute;
        }

        public Command(Action execute, Func<bool> canExecute)
            : this(delegate
            {
                execute();
            }, (object o) => canExecute())
        {
            if (execute == null)
            {
                throw new ArgumentNullException("execute");
            }

            if (canExecute == null)
            {
                throw new ArgumentNullException("canExecute");
            }
        }

        public bool CanExecute(object parameter)
        {
            if (_canExecute != null)
            {
                return _canExecute(parameter);
            }

            return true;
        }

        public void Execute(object parameter)
        {
            _execute(parameter);
        }

        public void ChangeCanExecute()
        {
            _weakEventManager.HandleEvent(this, EventArgs.Empty, "CanExecuteChanged");
        }
    }

    public class WeakEventManager
    {
        private struct Subscription
        {
            public readonly WeakReference Subscriber;

            public readonly MethodInfo Handler;

            public Subscription(WeakReference subscriber, MethodInfo handler)
            {
                Subscriber = subscriber;
                Handler = (handler ?? throw new ArgumentNullException("handler"));
            }
        }

        private readonly Dictionary<string, List<Subscription>> _eventHandlers = new Dictionary<string, List<Subscription>>();

        public void AddEventHandler<TEventArgs>(EventHandler<TEventArgs> handler, [CallerMemberName] string eventName = null) where TEventArgs : EventArgs
        {
            if (string.IsNullOrEmpty(eventName))
            {
                throw new ArgumentNullException("eventName");
            }

            if (handler == null)
            {
                throw new ArgumentNullException("handler");
            }

            AddEventHandler(eventName, handler.Target, handler.GetMethodInfo());
        }

        public void AddEventHandler(EventHandler handler, [CallerMemberName] string eventName = null)
        {
            if (string.IsNullOrEmpty(eventName))
            {
                throw new ArgumentNullException("eventName");
            }

            if (handler == null)
            {
                throw new ArgumentNullException("handler");
            }

            AddEventHandler(eventName, handler.Target, handler.GetMethodInfo());
        }

        public void HandleEvent(object sender, object args, string eventName)
        {
            List<(object, MethodInfo)> list = new List<(object, MethodInfo)>();
            List<Subscription> list2 = new List<Subscription>();
            if (_eventHandlers.TryGetValue(eventName, out List<Subscription> value))
            {
                for (int i = 0; i < value.Count; i++)
                {
                    Subscription item = value[i];
                    if (item.Subscriber == null)
                    {
                        list.Add((null, item.Handler));
                        continue;
                    }

                    object target = item.Subscriber.Target;
                    if (target == null)
                    {
                        list2.Add(item);
                    }
                    else
                    {
                        list.Add((target, item.Handler));
                    }
                }

                for (int j = 0; j < list2.Count; j++)
                {
                    Subscription item2 = list2[j];
                    value.Remove(item2);
                }
            }

            for (int k = 0; k < list.Count; k++)
            {
                (object, MethodInfo) tuple = list[k];
                object item3 = tuple.Item1;
                tuple.Item2.Invoke(item3, new object[2]
                {
                    sender,
                    args
                });
            }
        }

        public void RemoveEventHandler<TEventArgs>(EventHandler<TEventArgs> handler, [CallerMemberName] string eventName = null) where TEventArgs : EventArgs
        {
            if (string.IsNullOrEmpty(eventName))
            {
                throw new ArgumentNullException("eventName");
            }

            if (handler == null)
            {
                throw new ArgumentNullException("handler");
            }

            RemoveEventHandler(eventName, handler.Target, handler.GetMethodInfo());
        }

        public void RemoveEventHandler(EventHandler handler, [CallerMemberName] string eventName = null)
        {
            if (string.IsNullOrEmpty(eventName))
            {
                throw new ArgumentNullException("eventName");
            }

            if (handler == null)
            {
                throw new ArgumentNullException("handler");
            }

            RemoveEventHandler(eventName, handler.Target, handler.GetMethodInfo());
        }

        private void AddEventHandler(string eventName, object handlerTarget, MethodInfo methodInfo)
        {
            if (!_eventHandlers.TryGetValue(eventName, out List<Subscription> value))
            {
                value = new List<Subscription>();
                _eventHandlers.Add(eventName, value);
            }

            if (handlerTarget == null)
            {
                value.Add(new Subscription(null, methodInfo));
            }
            else
            {
                value.Add(new Subscription(new WeakReference(handlerTarget), methodInfo));
            }
        }

        private void RemoveEventHandler(string eventName, object handlerTarget, MemberInfo methodInfo)
        {
            if (!_eventHandlers.TryGetValue(eventName, out List<Subscription> value))
            {
                return;
            }

            for (int num = value.Count; num > 0; num--)
            {
                Subscription item = value[num - 1];
                if (item.Subscriber?.Target == handlerTarget && !(item.Handler.Name != methodInfo.Name))
                {
                    value.Remove(item);
                    break;
                }
            }
        }
    }
}
