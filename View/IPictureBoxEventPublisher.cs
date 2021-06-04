using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace View
{
    public interface IPictureBoxEventPublisher
    {
        void Subscribe(EventHandler<PictureBoxClickArgs> listener);
    }
}
