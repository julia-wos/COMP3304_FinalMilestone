using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Library;

namespace Model
{
    public class ImgCollection : IImgCollection, IEventPublisher
    {
        //DECLARE a dictionary to hold the images, call it _imgCollection
        private IDictionary<String, Image> _imgCollection;

        //DECLARE a bool to validate images, call it _imgValid
        private bool _imgValid;

        /// <summary>
        /// constructor
        /// </summary>
        public ImgCollection()
        {
            //INSTANTIATE _imgCollection as a dictionairy
            _imgCollection = new Dictionary<String, Image>();

            //INSTANTIATE _imgValid as false
            _imgValid = false;
        }

        /// <summary>
        /// event for when new images are added to the colection
        /// </summary>
        public event EventHandler<DisplayImageArgs> NewDisplayImages;

        /// <summary>
        /// MEthod that raises the event when new images are added
        /// </summary>
        /// <param name="displayId">Id of th eimage</param>
        /// <param name="displayImage">the Image that was added to the collection</param>
        private void NewImagesAdded(String displayId, Image displayImage)
        {
            DisplayImageArgs args = new DisplayImageArgs(displayId, displayImage);
            NewDisplayImages(this, args);
        }

        /// <summary>
        /// Subscribes the listeners to the NewDisplayImages event
        /// </summary>
        /// <param name="listener">listener that needs subscribing</param>
        public void Subscribe(EventHandler<DisplayImageArgs> listener)
        {
            //ADD a listener
            NewDisplayImages += listener;
        }

        /// <summary>
        /// Gets the image fromthe collection based on the id/key
        /// </summary>
        /// <param name="key">the id if the image</param>
        /// <returns></returns>
        public Image GetImage(String key)
        {
            return _imgCollection[key];
        }

        #region IMPLEMENTATION of IImgCollection

        /// <summary>
        /// Add's an image to the dictionary
        /// </summary>
        /// <param name="key"></param>
        /// <param name="img"></param>
        public void AddImg(String key, Image img, Image thumbnail)
        {
            //ADD key and img to the dictionairy _imgCollection
            _imgCollection.Add(key, img);

            //RAISE the NewImagesAdded event, pass the id and thumbnail as parameters
            NewImagesAdded(key, thumbnail);
        }


        /// <summary>
        /// Checks if the image key(filepath) already exists in the dictionairy, which ensures that no duplicates are added
        /// </summary>
        /// <param name="key"></param>
        /// <returns> Returns true or false </returns>
        public bool ValidateImg(String key)
        {
            //IF the key does not exist in the dictionairy set _imgValid to true
            if (!_imgCollection.ContainsKey(key))
            {
                _imgValid = true;
            }
            //IF the key already exists withing the dictionairy set _imgValid to false
            else
            {
                _imgValid = false;
            }

            return _imgValid;
        }
        #endregion
    }
}
