using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;

namespace Controller
{
    /// <summary>
    /// INTERFACE for loading the images and their thumbnails
    /// It contains altered code by me (Julia Wos) form COMP3304_Milestone01
    /// </summary>
    public interface IImgProcessor
    {
        /// <summary>
        /// Resizes the image to create a corresponding thumbnail
        /// </summary>
        /// <param name="filepath">path of the image</param>
        /// <param name="newImgSize">new size for the thumbnail</param>
        /// <returns>Returns a resized Image from ImageProcessor library</returns>
        Image ResizeImg(string filepath, Size newImgSize);

        /// <summary>
        /// Loads the current image
        /// </summary>
        /// <param name="filepath">path of the image</param>
        /// <returns> Returns Image from ImageProcessor library</returns>
        Image LoadImg(string filepath);
    }
}
