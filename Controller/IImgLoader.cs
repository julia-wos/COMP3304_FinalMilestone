using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Controller
{
    /// <summary>
    /// INTERFACE for loading the images, implemented in ImgLoader
    /// </summary>
    public interface IImgLoader
    {
        /// <summary>
        /// Loads the images from the list
        /// </summary>
        /// <param name="ofdList">list of images that need to be loaded</param>
        void LoadImg(IList<String> ofdList);
    }
}
