using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

namespace Controller
{
    /// <summary>
    /// INTERFACE implemented in the ImgEditor class, responsible for Subscribing listeners to the events
    /// </summary>
    public interface IEditorPublisher
    {
        /// <summary>
        /// Subscribes a listener to an event
        /// </summary>
        /// <param name="listener">holds a reference to an EventHandler that needs to be Subscribed</param>
        void Subscribe(EventHandler<UpdateImageArgs> listener);
    }
}
