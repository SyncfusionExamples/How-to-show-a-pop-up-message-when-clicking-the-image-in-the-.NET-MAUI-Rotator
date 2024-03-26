namespace RotatorSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            DisplayAlert("Image", "Rotator Item has been tapped", "Ok");
        }
    }

    public class RotatorModel
    {
        public RotatorModel(string image)
        {
            Image = image;
        }
        private string _image;
        public string Image
        {
            get { return _image; }
            set { _image = value; }
        }
    }

    public class RotatorViewModel
    {
        public RotatorViewModel()
        {
            ImageCollection.Add(new RotatorModel("image1.png"));
            ImageCollection.Add(new RotatorModel("image2.png"));
            ImageCollection.Add(new RotatorModel("image3.png"));
            ImageCollection.Add(new RotatorModel("image4.png"));
            ImageCollection.Add(new RotatorModel("image5.png"));
        }
        private List<RotatorModel> imageCollection = new List<RotatorModel>();
        public List<RotatorModel> ImageCollection
        {
            get { return imageCollection; }
            set { imageCollection = value; }
        }
    }

}
