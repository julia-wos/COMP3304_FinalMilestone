using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    /// <summary>
    /// Updates the event arguments
    /// </summary>
    public class PictureBoxClickArgs : EventArgs
    {
        private String _imageId;

        public String ImageId => _imageId;

        public PictureBoxClickArgs(String imageId)
        {
            _imageId = imageId;
        }
    }
}
