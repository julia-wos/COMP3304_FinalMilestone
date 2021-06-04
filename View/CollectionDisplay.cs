using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageProcessor;
using Library;


namespace View
{
    public partial class CollectionDisplay : Form, IPictureBoxEventPublisher
    {
        //DECLARE and INSTANTIATE Size to new Size(100,100) to hold the sie of the image thumbnails, call it _thumbnailSize
        private Size _thumbnailSize = new Size(100, 100);

        //DECLARE an IList<String> to hold a list of files from file directory
        private IList<String> _ofdList;

        //DECLARE  a LoadImg to hold a referance, call it _loadImg
        private LoadImg _loadImg;

        //DECLARE a ExecuteCommand to hold a reference to the ExecuteCommand, call it _command
        private ExecuteCommand _command;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="loadImg">LoadImg referance to a method</param>
        /// <param name="command">ExecuteCommand reference to a method</param>
        public CollectionDisplay(LoadImg loadImg, ExecuteCommand command)
        {
            InitializeComponent();

            //INITIATE _loadImg to loadImg
            _loadImg = loadImg;

            //INITIATE _command to command
            _command = command;
        }

        /// <summary>
        /// Creates a new PictureBox whenever an image is added to the collection
        /// </summary>
        /// <param name="image">image to be displayed in a PictureBox</param>
        /// <param name="id">id of the image</param>
        /// <param name="pBSize">size of the PictureBox</param>
        private void NewPictureBox(Image image, String id, Size pBSize)
        {
            //CREATE a new PictureBox, call it _pB
            PictureBox _pB = new PictureBox();

            //INSTANTIATE the Size of the PictureBox to pbSize
            _pB.Size = pBSize;

            //INSTANTIATE the image of the PictureBox to image
            _pB.Image = image;

            //INSTANTIATE the name of the PictureBox to id 
            _pB.Name = id;

            //ADD the PictureBox to the flowLayoutPanel
            layoutPanel.Controls.Add(_pB);

            //ADD an event for when the PictureBox is clicked, pass id as parameter
            _pB.DoubleClick += delegate (object sender, EventArgs e) { PictureBoxClicked(id); };
        }

        /// <summary>
        /// event handler for when PictureBox is clicked
        /// </summary>
        public event EventHandler<PictureBoxClickArgs> NewImageId;


        /// <summary>
        /// method that is called when PictureBox is clicked
        /// </summary>
        /// <param name="imageId">the filepath/id of the image</param>
        private void PictureBoxClicked(String imageId)
        {
            //INSTANTIATE PicktureBoxClickArgs as new PictureBoxXkixkArgs, pass imageId as parameter
            PictureBoxClickArgs pictureBoxClickArgs = new PictureBoxClickArgs(imageId);

            //CALL the NewImageId event, pass pictureBoxClickArgs as parameter
            NewImageId(this, pictureBoxClickArgs);
        }

        
        /// <summary>
        /// This method is called when new images has been added to the collection and need displaying 
        /// </summary>
        /// <param name="source">source of the event</param>
        /// <param name="args"><DisplayImageArgs, contain Image and the id of an Image/param>
        public void NewImages(object source, DisplayImageArgs args)
        {
            //CALL NewPictureBox to create a new PictureBox, passing both DisplayImageArgs arguments and _thumbnailSize
            NewPictureBox(args.DisplayImageArg, args.DisplayImageArg1, _thumbnailSize);
        }

        /// <summary>
        /// Loads new images
        /// This method contains altered code form MSDN, available at: https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=net-5.0
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoadNewImages(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                //SET the Filter to allow only .bmp, .jpg, .gif and .png files
                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

                //SET Filte Index to 1
                openFileDialog.FilterIndex = 1;

                //SET Restore Directory to true - open the last opened directory instead of c:\\
                openFileDialog.RestoreDirectory = true;

                //SET Multiselect to true
                openFileDialog.Multiselect = true;

                //OPEN the file dialog box
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _ofdList = new List<String>();

                    //SET _ofdList to a List of paths/filemanes 
                    _ofdList = openFileDialog.FileNames.ToList();

                    //CALL the LoadImg method from ImgLoader
                    _loadImg(_ofdList);
                }
            }
        }
        #region IMPLEMENTATION of the PictureBoxEventPublisher
        /// <summary>
        /// Subscribes listeners to the event
        /// </summary>
        /// <param name="listener">listener that needs subscribing</param>
        public void Subscribe(EventHandler<PictureBoxClickArgs> listener)
        {
            //ADD the listener
            NewImageId += listener;
        }
        #endregion
    }
}
