using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Drawing;

namespace Controller
{
    /// <summary>
    /// INTERFACE implemented in ImgProcessor class. Holds methods for editing.
    /// </summary>
    public interface IEditorProcessor
    {
        /// <summary>
        /// This method is responsible for flipping the Image using a ImageProcessor OS Library
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be flipped</param>
        /// <param name="flipV">hold a bool that determines whether the image is to be flipped horizontally or vertically</param>
        /// <returns>A flipped Image</returns>
        Image FlipImage(Image img, bool flipV);

        /// <summary>
        /// This method is responsible for rotating the Image using a ImageProcessor OS Library
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be rotated</param>
        /// <param name="degree">holds an int that is a number of degrees that image needs to be rotated</param>
        /// <returns>A rotated Image</returns>
        Image RotateImage(Image img, int degree);

        /// <summary>
        /// This method is responsible for resizing the Image using a ImageProcessor OS Library
        /// </summary>
        /// <param name="img">holds a reference to image that need resizing</param>
        /// <param name="size">holds the Size that the image need to be resized to</param>
        /// <returns>A resized image</returns>
        Image ResizeImage(Image img, Size size);
    }
}
