using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using View;
using Model;
using Library;
using System.Drawing;

namespace Controller
{
    //This class is responsible for running the program
    public class Controller
    {
        //DECLARE an IFactory<IImgColelction> as a Factory<IImgCollection>, call it _imgColelctionFactory
        private IFactory<IImgCollection> _imgColelctionFactory;

        //DECLARE an IFactory<IImgProcessor> as a IFactory<IImgProcessor>, call it _imgCollection
        private IFactory<IImgProcessor> _imgProcessorFactory;

        //DECLARE an IImgCollection, call it _imgDatabase
        private IImgCollection _imgDatabase;

        //DECLARE an IEditorPublisher, call it _editorPublisher
        private IEditorPublisher _editorPublisher;

        //DECLARE an IImgEditor, call it _imgEditor
        private IImgEditor _imgEditor;

        //DECLARE an IImgProcessor, call it _imgProcessor
        private IImgProcessor _imgProcessor;

        //DECLARE an IImgLoader, call it _imgLoader
        private IImgLoader _imgLoader;

        //DECLARE an ExecuteCommand, call it _executeCommand
        private ExecuteCommand _executeCommand;

        //DECLARE an IEditorProcesso, call it _processorEditor
        private IEditorProcessor _processorEditor;

        public Controller()
        {
            //INSTANTIATE an _imgColelctionFactory as a new Factory<IImgCollection>, call it _imgColelctionFactory
            _imgColelctionFactory = new Factory<IImgCollection>();

            //INSTANTIATE an _imgDatabase as a new IImgCollection by using the method Create<> in Factory, call it _imgCollection
            _imgDatabase = _imgColelctionFactory.Create<ImgCollection>();

            //INSTANTIATEe _imgProcessorFactory IFactory<IImgProcessor> as a new Factory<IImgProcessor>(), call it _imgProcessorFactory
            _imgProcessorFactory = new Factory<IImgProcessor>();

            //INSTANTIATE _imgProcessor as a new IImgProcessor by using the method Create<> in Factory, call it _imgProcessor
            _imgProcessor = _imgProcessorFactory.Create<ImgProcessor>();

            //INSTANTIATE _imgLoader as new ImgLoader, pass _imgProcessor and _imgDatabase
            _imgLoader = new ImgLoader(_imgProcessor, _imgDatabase);

            //DECLARE a LoadImg and INSTANTIATE it as a LoadImg method from _imgLoader
            LoadImg _loadImg = _imgLoader.LoadImg;

            //INSTANTIATE _executeCommand as this.RunCommand
            _executeCommand = this.RunCommand;

            //INSTANTIATE _processorEditor as _imgProcessor of type IEditorProcessor
            _processorEditor = (IEditorProcessor)_imgProcessor;

            //EXECUTE CreateCollectionDisplay method, which will create UI with the Collection of images, pass _loadImg as paramenter
            CreateCollectionDisplay(_loadImg);
        }

        /// <summary>
        /// This method creates the main Form that displays the collection of images in a form of thumbnails
        /// </summary>
        /// <param name="loadImg">a referance to the delegate method implemented in ImgLoader class</param>
        public void CreateCollectionDisplay(LoadImg loadImg)
        {
            //DECLARE and INSTANTIATE LoadImg to loadImg, call it _loadImg
            LoadImg _loadImg = loadImg;

            //DECLARE and INSTANTIATE CollectionDisplay as a new CollectionDisplay, passing _loadImg and _executeCommand as paramenters, call it _collectionDisplay
            CollectionDisplay _collectionDisplay = new CollectionDisplay(_loadImg, _executeCommand);

            //DECLARE an IEventPublisher, call it _imgColE;
            IEventPublisher _imgColE;

            //INSTANTIATE _imgColE as _imgDatabase of type IEventPublisher
            _imgColE = (IEventPublisher)_imgDatabase;

            //Subscribe CollectionDisplay.NewImages() to ImgCallection class event
            _imgColE.Subscribe(_collectionDisplay.NewImages);

            //INSTANTIATE IPictureBoxEventPublisher, call it _collectionDisplayE
            IPictureBoxEventPublisher _collectionDisplayE;

            //INSTANTIATE _collectionDisplayE, as _collectionDisplay, of type IPictureBoxEventPublisher
            _collectionDisplayE = (IPictureBoxEventPublisher)_collectionDisplay;

            //CALL Subscribe method implemented in CollectionDisplay class, passing this.CreateImgDisplay as parameter
            _collectionDisplayE.Subscribe(this.CreateImgDisplay);

            //RUN the Application by creating a CollectionDisplay
            Application.Run(_collectionDisplay);
        }


        /// <summary>
        /// This method creates a Form that displays an image from the collection, corresponding to the thumbnail the User has clicked on.
        /// </summary>
        /// <param name="source">source of the event</param>
        /// <param name="args">PictureBoxClickArgs, holding a reference to the ImageId</param>
        public void CreateImgDisplay(object source, PictureBoxClickArgs args)
        {
            //DECLARE an Image, to hold to the Image that will be displayed, call it _img
            Image _img;

            //INSTANTIATE _editorPublisher as new ImgEditor, passing _processorEditor as parameter
            _editorPublisher = new ImgEditor(_processorEditor);

            //INSTANTIATE _imgEditor as _editorPublisher of type IImgEditor
            _imgEditor = (IImgEditor)_editorPublisher;

            //INSTANTIATE _img as the return value of GetImage from ImgCollection class, passing the argument ImageId as parameter
            _img = _imgDatabase.GetImage(args.ImageId);

            //DECLARE and INSTANTIATE ImgDisplay as a new ImgDisplay, passing _img, _executeCommand and Flip, Rotate, Resize from ImgEditor class as parameters, call it _imgDisplay
            ImgDisplay _imgDisplay = new ImgDisplay(_img, _executeCommand, _imgEditor.Flip, _imgEditor.Rotate, _imgEditor.Resize);

            //CALL the Subscribe method from ImgEditor, passing UpdateDisplay form ImgDisplay class as parameter
            _editorPublisher.Subscribe(_imgDisplay.UpdateDisplay);

            //SHOW the _imgDisplay Form
            _imgDisplay.Show();
        }

        /// <summary>
        /// This method is responsible for executing commands and is a part of the Command Pattern
        /// </summary>
        /// <param name="command">an ICommand parameter</param>
        public void RunCommand(ICommand command)
        {
            //CALL Execute from the Command class
            command.Execute();
        }

    }
}
