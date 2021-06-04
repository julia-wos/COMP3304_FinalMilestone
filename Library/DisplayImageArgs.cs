using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Library

{
    /// <summary>
    /// This class is responsible for updating the event arguments
    /// </summary>
    public class DisplayImageArgs : EventArgs
    {
        //DECLARE a String, to hold the id/filepath of the image, call it _displayId
        private String _displayId;

        //DECLARE Image to hold the image that needs to be displayed, call it _displayImages 
        private Image _displayImages;

        public Image DisplayImageArg => _displayImages;
        public String DisplayImageArg1 => _displayId;

        /// <summary>
        /// Updates the event arguments, id of the image and the image itself
        /// </summary>
        /// <param name="displayId"></param>
        /// <param name="displayImages"></param>
        public DisplayImageArgs(String displayId, Image displayImages) 
        {
            _displayImages = displayImages;
            _displayId = displayId;
        }


    }
}
