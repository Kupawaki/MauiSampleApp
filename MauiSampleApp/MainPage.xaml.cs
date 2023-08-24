namespace MauiSampleApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		//Adding a comment to test the included git stuffs
		InitializeComponent();
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		bool answer = await DisplayAlert("I Have A Question:", "Isn't this neat?", "Yes", "No");
		if(answer==true)
		{
			OutputLb.Text = "Answer was yes";
		}
		else
		{
            OutputLb.Text = "Answer was no";
        }
	}
}

