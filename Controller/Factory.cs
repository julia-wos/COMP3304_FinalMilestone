using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    //Factory Pattern provided by Marc Price
    class Factory<E> : IFactory<E>
    {
        public E Create<T>() where T : E, new()
        {
            return new T();
        }
    }
}
