# How-to-show-a-pop-up-message-when-clicking-the-image-in-the-.NET-MAUI-Rotator
This section explains how to show a pop-up message when clicking the image in the .NET MAUI Rotator. We can achieve it by following the below steps,

Step 1: Initialize the Rotator control in xaml page with required assemblies.
XAML:

 <syncfusion:SfRotator x:Name="rotator" />
Step 2 : Create a Model and ViewModel classes in sample.

Step 3: Create a list of collections in the ViewModel class and add corresponding image value.

C#:

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
Step 4: Bind the list of collections into the Image property in ItemTemplate using a DataTemplate and initialize the TapGestureRecognizer to create an event method using Tapped event.
XAML:

<syncfusion:SfRotator VerticalOptions="Center"
                            x:Name="rotator"  
                            ItemsSource="{Binding ImageCollection}">

                <syncfusion:SfRotator.ItemTemplate>
                    <DataTemplate>
                        <Grid>
                            <Image Source="{Binding Image}"/>
                            <Grid.GestureRecognizers>
                                <TapGestureRecognizer Tapped="TapGestureRecognizer_Tapped" NumberOfTapsRequired="1">
                                </TapGestureRecognizer>
                            </Grid.GestureRecognizers>
                        </Grid>
                    </DataTemplate>
                </syncfusion:SfRotator.ItemTemplate>
            </syncfusion:SfRotator>
Step 5: The following event is created by TapGestureRecognizer, here you can provide the code within that event method as per your requirements.
C#:

private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
{
    DisplayAlert("Image", "Rotator Item has been tapped", "Ok");
}
