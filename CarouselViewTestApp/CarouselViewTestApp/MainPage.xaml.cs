namespace CarouselViewTestApp;

public partial class MainPage : ContentPage
{
	int count = 0;
	List<string> testStringList;

	public MainPage()
	{
		InitializeComponent();
		testStringList = new List<string>();
		testStringList.Add("ONE");
        testStringList.Add("TWO");
        testStringList.Add("THREE");
        testStringList.Add("FOUR");

		carousel.ItemsSource = testStringList;	
    }


}

