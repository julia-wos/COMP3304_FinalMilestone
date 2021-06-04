using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;
using System.Windows.Forms;
using System.Drawing;
using Model;

namespace Controller
{
    /// <summary>
    ///This class is responsible for loading images
    /// </summary>
    public class ImgLoader : IImgLoader
    {
        //DECLARE IImgProcessor, call it _imgProcessor
        private IImgProcessor _imgProcessor;

        //DECLARE IImgCollection, call it _imgCollection
        private IImgCollection _imgCollection;

        //DECLARE an IList<String> that will hold the paths of the images from file directory, call it _ofdList
        private IList<String> _ofdList;

        //DECLARE two Image variables, for holding the actual image and the thumbnail, call them _img and _imgT
        private Image _img, _imgT;

        //DECLARE and INSTATIATE Size to new Size(100,100), to hold the size of the thumbnail, call it _imgTSize
        private Size _imgTSize = new Size(100,100);

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="imgProcessor">IImgProcessor that holds a reference to ImgProcessor</param>
        /// <param name="imgCollection">IImgCollection that hold a reference to ImgColelction</param>
        public ImgLoader(IImgProcessor imgProcessor, IImgCollection imgCollection)
        {
            //INSTANTIATE _imgProcesor as imgProcessor
            _imgProcessor = imgProcessor;

            //INSTANTIAT _imgColelction as imgCollection
            _imgCollection = imgCollection;
        }

        #region IMPLEMENTATION of IImgLoader
        /// <summary>
        /// Loads the images from the list
        /// </summary>
        /// <param name="ofdList">list of images that need to be loaded</param>
        public void LoadImg(IList<String> ofdList)
        {
            foreach (String file in ofdList)
            {
                if (_imgCollection.ValidateImg(file))
                {
                    //INSTANTIATE _img as a loded image
                    _img = _imgProcessor.LoadImg(file);

                    //INSTANTIATE _imgT as a loaded thumbnail of the image using _imgTSize as its size
                    _imgT = _imgProcessor.ResizeImg(file, _imgTSize);

                    //CALL the AddImg method from ImgCollection to add the images to the collection. Pass file, _img and _imgT as parameters.
                    _imgCollection.AddImg(file, _img, _imgT);
                }
            }

        }
        #endregion
    }
}
