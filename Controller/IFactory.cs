using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    //Factory Pattern Interface provided by Marc Price
    public interface IFactory<E>
    {
        E Create<T>() where T : E, new();
    }
}
