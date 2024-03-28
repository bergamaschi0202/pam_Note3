namespace pam_Note3;

public partial class AboutPage : ContentPage
{


	public AboutPage()
	{
        InitializeComponent();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void LearnMore_Clicked(object sender, EventArgs e)
	{
        Launcher.OpenAsync("https://www.google.com.br");
	}

}