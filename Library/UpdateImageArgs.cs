using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Library
{
    /// <summary>
    /// updates the event arguments
    /// </summary>
    public class UpdateImageArgs
    {
        private Image _updateImage;

        public Image UpdateImageArg => _updateImage;

        public UpdateImageArgs(Image updateImage)
        {
            _updateImage = updateImage;
        }
    }
}
