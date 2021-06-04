using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using ImageProcessor;
using ImageProcessor.Imaging;
using Library;

namespace Controller
{
    /// <summary>
    /// This class is responsible for Processing the images using the ImageProcessor OS library
    /// </summary>
    public class ImgProcessor : IImgProcessor, IEditorProcessor
    {
        //DECLARE ImageFactory and call it _imgFactory
        private ImageFactory _imgFactory;
        

        public ImgProcessor()
        {
            //INSTANTIATE _imgFactory as new ImageFactory
            _imgFactory = new ImageFactory();
        }

        #region IMPLEMENTATION of IEditorProcessor interface
        /// <summary>
        /// This method is responsible for flipping the Image using a ImageProcessor OS Library
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be flipped</param>
        /// <param name="flipV">hold a bool that determines whether the image is to be flipped horizontally or vertically</param>
        /// <returns>A flipped Image</returns>
        public Image FlipImage(Image img, bool flipV)
        {
            //Load image
            _imgFactory.Load(img);

            //Flip image, passign flipV as a parameter. 
            //If flipV is true, image will be flipped vertically, if it is false it will be flipped horizontally
            _imgFactory.Flip(flipV);

            //RETURN a flipped image
            return _imgFactory.Image;
        }

        /// <summary>
        /// This method is responsible for rotating the Image using a ImageProcessor OS Library
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be rotated</param>
        /// <param name="degree">holds an int that is a number of degrees that image needs to be rotated</param>
        /// <returns>A rotated Image</returns>
        public Image RotateImage(Image img, int angle)
        {
            //Load image
            _imgFactory.Load(img);

            //Rotate image, passing angle as parameter, that is the number of degrees the image should be rotated to the right
            _imgFactory.Rotate(angle);

            //RETURN rotated image
            return _imgFactory.Image;
        }

        /// <summary>
        /// This method is responsible for resizing the Image using a ImageProcessor OS Library
        /// </summary>
        /// <param name="img">holds a reference to image that need resizing</param>
        /// <param name="size">holds the Size that the image need to be resized to</param>
        /// <returns>A resized image</returns>
        public Image ResizeImage(Image img, Size size)
        {
            //Load image
            _imgFactory.Load(img);

            //Resize image, by creating a new ResizeLayer, passing size as parameter and setting ResizeMode to Stretch.
            //Not setting ResizeMode to Stretch, causes the Padding to change instead of the image size
            _imgFactory.Resize(new ResizeLayer(size, ResizeMode.Stretch));

            //RETURN resized image
            return _imgFactory.Image;
        }
        #endregion


        #region IMPLEMENTATION of IImgProcessor
        //This is an altered code by me (Julia Wos) from COMP3304_Milestone01

        /// <summary>
        /// Resizes the image using Constrain method to create an accurate thumbnail
        /// </summary>
        /// <param name="filepath">path of the image file</param>
        /// <param name="newImgSize">new size of the thumbnail</param>
        /// <returns>Returns a resized Image from ImageProcessor library</returns>
        public Image ResizeImg(string filepath, Size newImgSize)
        {
            //LOAD the image from the filepath
            _imgFactory.Load(filepath);

            //RESIZE the image to a newImgSize using the Constrain method, which allows to keep the original ratio
            _imgFactory.Constrain(newImgSize);

            //RETURN the thumbnail
            return _imgFactory.Image;
        }

        /// <summary>
        /// Loads the current image
        /// </summary>
        /// <param name="filepath">path of the image file</param>
        /// <returns> Returns Image from ImageProcessor library</returns>
        public Image LoadImg(string filepath)
        {
            //LOAD the image from the filepath
            _imgFactory.Load(filepath);

            //RETURN loaded image
            return _imgFactory.Image;
        }
        #endregion
    }
}
