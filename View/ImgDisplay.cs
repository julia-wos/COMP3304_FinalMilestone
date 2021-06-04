using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library;

namespace View
{
    public partial class ImgDisplay : Form
    {
        //DECLARE Image to hold an Image of the current image, call it _currentImg
        private Image _currentImg;

        //DECLARE ints to hold height and width ot the image, call them _imgHeight and _imgWidth
        private int _imgWidth, _imgHeight;

        //DECLARE and Action<Image, bool> to hold a flip command, call it _flip
        private Action<Image, bool> _flip;

        //DECLARE an Action<Image, int> to hold the rotate command, call it _rotate
        private Action<Image, int> _rotate;

        //DECLATE Action<Image, Size> to hold a resize command, call it _resize
        private Action<Image, Size> _resize;

        //DECLARE ExecuteCommand, to hold reference to the Execute command, call it _execute
        private ExecuteCommand _execute;

        /// <summary>
        /// Contructor
        /// </summary>
        /// <param name="img">image that needs to be displayed</param>
        /// <param name="execute">reference to Execute() method</param>
        /// <param name="flip">hold command to flip the image</param>
        /// <param name="rotate">hold command to rotate the image</param>
        /// <param name="resize">hold command to resize the image</param>
        public ImgDisplay(Image img, ExecuteCommand execute, Action<Image, bool> flip, Action<Image, int> rotate, Action<Image, Size> resize)
        {
            InitializeComponent();

            //INSTANTIATE the Image in the PictureBox called ImgBox to img
            imgBox.Image = img;

            //INSTANTIATE _imgWidth as the width of the image
            _imgWidth = imgBox.Image.Size.Width;

            //INSTANTIATE _imgHeight as the height of the image
            _imgHeight = imgBox.Image.Size.Height;

            //INSTANTIATE _currentImg as the Image in the PictureBox
            _currentImg = imgBox.Image;

            //INSTANTIATE _execute as execute
            _execute = execute;

            //INSTANTIATE _flip as flip
            _flip = flip;

            //INSTANTIATE _rotate as rotate
            _rotate = rotate;

            //INSTANTIATE _resize as resize
            _resize = resize;
        }

        /// <summary>
        /// Instantiate a Command when the image needs to be rotated left and call Execute through _execute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateLeft(object sender, EventArgs e)
        {
            //DECLARE and INSTANTIATE ICommand as new Command<Image, int>, passing _rotate, IimgBox.Image and -90 as parameters, call it RotateL
            // setting the rotation degree to a negative number couses the image to rotate to the left
            ICommand RotateL = new Command<Image, int>(_rotate, imgBox.Image, -90);

            //CALL Execute
            _execute(RotateL);
        }

        /// <summary>
        /// Instantiate a Command when the image needs to be rotated right and call Execute through _execute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RotateRight(object sender, EventArgs e)
        {
            //DECLARE and INSTANTIATE ICommand as new Command<Image, int>, passing _rotate, IimgBox.Image and 90 as parameters, call it RotateR
            ICommand RotateR = new Command<Image, int>(_rotate, imgBox.Image, 90);

            //CALL Execute, passing through the command
            _execute(RotateR);
        }

        /// <summary>
        /// Instantiate a Command when the image needs to be flipped vertically and call Execute through _execute
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FlipV(object sender, EventArgs e)
        {
            //DECLARE and INSTANTIATE ICommand as new Command<Image, bool>, passing _flip, IimgBox.Image and true as parameters, call it FlipV
            //Setting the bool to true, causes the imaqge to flip vertically
            ICommand FlipV = new Command<Image, bool>(_flip,imgBox.Image, true);

            //CALL Execute, passing through the command
            _execute(FlipV);

        }

        private void FlipH(object sender, EventArgs e)
        {
            //DECLARE and INSTANTIATE ICommand as new Command<Image, bool>, passing _flip, IimgBox.Image and false as parameters, call it FlipH
            //Setting the bool to false, causes the imaage to flip horizontally
            ICommand FlipH = new Command<Image, bool>(_flip, imgBox.Image, false);

            //CALL Execute, passing through the command
            _execute(FlipH);

        }
        
        private void ChangeHeight(object sender, EventArgs e)
        {
            //DECLARE and INSTANTIATE a decimal, which holds the value of the newHeightInput input field, call it _heightDecimal
            decimal _heightDecimal = newHeightInput.Value;

            //DECLARE and INSTANTIATE an int to convert the value from the input field to ineger, call it _hight
            int _hight = Convert.ToInt32(_heightDecimal);

            //DECLARE and INSTANTIATE a new Size, passing the cuurent image width and the new height, call it _newSize
            Size _newSize = new Size(_imgWidth, _hight);

            //DECLARE and INSTANTIATE ICommand as new Command<Image, Size>, passing _resize, IimgBox.Image and _newSize as parameters, call it ChangeH
            ICommand ChangeH = new Command<Image, Size>(_resize, imgBox.Image, _newSize);

            //CALL Execute, passing through the command
            _execute(ChangeH);
        }

        private void ChangeWiedth(object sender, EventArgs e)
        {
            //DECLARE and INSTANTIATE a decimal, which holds the value of the newWiedthInput input field, call it _widthDecimal
            decimal _widthDecimal = newWiedthInput.Value;

            //DECLARE and INSTANTIATE an int to convert the value from the input field to ineger, call it _width
            int _width = Convert.ToInt32(_widthDecimal);

            //DECLARE and INSTANTIATE a new Size, passing the cuurent image height and the new width, call it _newSize
            Size _newSize = new Size(_width, _imgHeight);

            //DECLARE and INSTANTIATE ICommand as new Command<Image, Size>, passing _resize, IimgBox.Image and _newSize as parameters, call it ChangeH
            ICommand ChangeW = new Command<Image, Size>(_resize, imgBox.Image, _newSize);

            //CALL Execute, passing through the command
            _execute(ChangeW);
        }

        /// <summary>
        /// Method responsible foe Saving the edited image
        /// Contains altered code from MSDN, availabale at: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-save-files-using-the-savefiledialog-component?view=netframeworkdesktop-4.8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveImage(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|PNG Image|*.png";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                System.IO.FileStream fs =
                    (System.IO.FileStream)saveFileDialog1.OpenFile();
                // Saves the Image in the appropriate ImageFormat based upon the
                // File type selected in the dialog box.
                // NOTE that the FilterIndex property is one-based.
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        this.imgBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;

                    case 2:
                        this.imgBox.Image.Save(fs,
                          System.Drawing.Imaging.ImageFormat.Png);
                        break;
                }

                fs.Close();
            }
        }

        /// <summary>
        /// Method that update the currently displayed image to the edited image
        /// </summary>
        /// <param name="source"></param>
        /// <param name="args"></param>
        public void UpdateDisplay(object source, UpdateImageArgs args)
        {
            //SET _currentImg and the image in the ImgBox PictureBox to the UpdateImageArg
            _currentImg = imgBox.Image = args.UpdateImageArg;

            //Update the width of the image
            _imgWidth = imgBox.Image.Size.Width;

            //Update the hight of the image
            _imgHeight = imgBox.Image.Size.Height;
        }
    }
}
