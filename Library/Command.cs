using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Command Pattren composed of 3 classes, each for a different amout of parameters required.
    /// </summary>
    public class Command : ICommand
    {
        private Action _action;

        public Command(Action action)
        {
            _action = action;
        }

        public void Execute()
        {
            _action();
        }
    }

    public class Command<T> : ICommand
    {
        private Action<T> _action;

        private T _t;

        public Command(Action<T> action, T t)
        {
            _action = action;
            _t = t;
        }

        public void Execute()
        {
            _action(_t);
        }
    }

    public class Command <T, T1> : ICommand
    {
        private Action<T, T1> _action;
        private T _t;
        private T1 _t1;

        public Command(Action<T, T1> action, T t, T1 t1)
        {
            _action = action;
            _t = t;
            _t1 = t1;
        }

        public void Execute()
        {
            _action(_t, _t1);
        }
    }
}
