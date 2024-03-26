# How-to-show-a-pop-up-message-when-clicking-the-image-in-the-.NET-MAUI-Rotator
This section explains how to show a pop-up message when clicking the image in the .NET MAUI Rotator. We can achieve it by following the below steps,

**Step 1:** Initialize the Rotator control in xaml page with required assemblies.
**XAML:**
```
 <syncfusion:SfRotator x:Name="rotator" />
```
**Step 2 :** Create a Model and ViewModel classes in sample.

**Step 3:** Create a list of collections in the ViewModel class and add corresponding image value.

**C#:**
**Model**
```
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

```
**C#
ViewModel**
```
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

```

**Step 4:** Bind the list of collections into the Image property in ItemTemplate using a DataTemplate and initialize the TapGestureRecognizer to create an event method using Tapped event.
**XAML:**
```
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
```

**Step 5:** The following event is created by TapGestureRecognizer, here you can provide the code within that event method as per your requirements.
**C#:**
```
private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
{
    DisplayAlert("Image", "Rotator Item has been tapped", "Ok");
}
```
## How to run this application?

To run this application, you need to first clone the How-to-render-a-custom-content-to-.NET-MAUI-Carousel repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
