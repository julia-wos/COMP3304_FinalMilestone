using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Model

{
    /// <summary>
    /// INTERFACE implemented in ImgCollection, responsible for subscribing listeners to th eevent
    /// </summary>
    public interface IEventPublisher
    {
        /// <summary>
        /// Subscribes a listener to an event
        /// </summary>
        /// <param name="listener">listener that needs subscribing</param>
        void Subscribe(EventHandler<DisplayImageArgs> listener);


    }
}
