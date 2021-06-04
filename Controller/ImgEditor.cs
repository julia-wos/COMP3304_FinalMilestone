using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Drawing;

namespace Controller
{
    public class ImgEditor : IImgEditor, IEditorPublisher
    {
        //DECLARE IEditorProcessor, call it _imgProcessor
        private IEditorProcessor _imgProcessor;

        //DECLARE an Image, to hold the edited Image, call it _editedImage
        private Image _editedImage;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="imgProcessor">referance to the ImgProcessor, of type IEditorProcessor</param>
        public ImgEditor(IEditorProcessor imgProcessor)
        {
            //INSTANTIATE _imgProcessor as imgProcessor
            _imgProcessor = imgProcessor;
        }

        /// <summary>
        /// An event handler for updating the image in the view
        /// </summary>
        public event EventHandler<UpdateImageArgs> NewUpdate;

        /// <summary>
        /// This method is responsible for publishing the NewUpdate event when an image is edited
        /// </summary>
        /// <param name="img">the Image that holds the edited image</param>
        private void OnEdit(Image img)
        {
            //DECLARE and INSTANTIATE the UpdateImageArgs to new UpdateImageArgs, passign img as parameter
            UpdateImageArgs args = new UpdateImageArgs(img);
            //CALL the NewUpdate event passing args as parameter
            NewUpdate(this, args);
        }

        #region IMPLEMENTATION of IImgEditor interface
        /// <summary>
        /// This method is responsible for passign the image that needs to be flipped to the ImgProcessor
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be flipped</param>
        /// <param name="flipV">hold a bool that determines whether the image is to be flipped horizontally or vertically</param>
        public void Flip(Image img, bool flipV)
        {
            //INSTANTIATE _editeImage as the flipped image
            _editedImage = _imgProcessor.FlipImage(img, flipV);
            //Call the OnEdit event, which will update the view, pass _editedImage as parameter
            OnEdit(_editedImage);
        }

        /// <summary>
        /// This method is responsible for passign the image that needs to be rotated to the ImgProcessor
        /// </summary>
        /// <param name="img">holds an Image referance to the image that needs to be rotated</param>
        /// <param name="angle">holds an int that is a number of degrees that image needs to be rotated</param>
        public void Rotate(Image img, int angle)
        {
            //INSTANTIATE _editeImage as the rotated image
            _editedImage = _imgProcessor.RotateImage(img, angle);
            //Call the OnEdit event, which will update the view, pass _editedImage as parameter
            OnEdit(_editedImage);
        }

        /// <summary>
        /// This method is responsible for passign the image that needs to be resized to the ImgProcessor
        /// </summary>
        /// <param name="img">holds a reference to image that need resizing</param>
        /// <param name="size">holds the Size that the image need to be resized to</param>
        public void Resize(Image img, Size size)
        {
            //INSTANTIATE _editeImage as the resized image
            _editedImage = _imgProcessor.ResizeImage(img, size);
            //Call the OnEdit event, which will update the view, pass _editedImage as parameter
            OnEdit(_editedImage);
        }
        #endregion

        #region IMPLEMENTATION of IEditorPublisher interface
        /// <summary>
        /// Subscribes a listener to an event
        /// </summary>
        /// <param name="listener">holds a reference to an EventHandler that needs to be Subscribed</param>
        public void Subscribe(EventHandler<UpdateImageArgs> listener)
        {
            //ADD a listener to the NewUpdate event
            NewUpdate += listener;
        }
        #endregion

    }
}
