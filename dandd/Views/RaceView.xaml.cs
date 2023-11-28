namespace dandd.Views;

public partial class RaceView : ContentPage
{
	public RaceView()
	{
		InitializeComponent();
       // BindingContext = new RaceViewModel();
    }
    Frame frame = new Frame
    {
        BorderColor = Colors.Gray,
        CornerRadius = 10,
        Content = new Label { Text = "Frame wrapped around a Label" }
    };
}