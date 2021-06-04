using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Drawing;

namespace Controller
{
    public interface IImgEditor
    {
        /// <summary>
        /// This method is responsible for passign the image that needs to be flipped to the ImgProcessor
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be flipped</param>
        /// <param name="flipV">hold a bool that determines whether the image is to be flipped horizontally or vertically</param>
        void Flip(Image img, bool flipV);

        /// <summary>
        /// This method is responsible for passign the image that needs to be rotated to the ImgProcessor
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be rotated</param>
        /// <param name="angle">holds an int that is a number of degrees that image needs to be rotated</param>
        void Rotate(Image img, int angle);

        /// <summary>
        /// This method is responsible for passign the image that needs to be resized to the ImgProcessor
        /// </summary>
        /// <param name="img">holds a reference to image that need resizing</param>
        /// <param name="size">holds the Size that the image need to be resized to</param>
        void Resize(Image img, Size size);
    }
}
