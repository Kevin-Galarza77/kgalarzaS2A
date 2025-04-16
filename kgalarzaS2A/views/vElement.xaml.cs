namespace kgalarzaS2A.views;

public partial class vElement : ContentPage
{
	public vElement()
	{
		InitializeComponent();
	}

    private void countryBtn_Clicked(object sender, EventArgs e)
    { 
        if (countryPicker.SelectedIndex != -1)
        {
            string country = countryPicker.Items[countryPicker.SelectedIndex];
            DisplayAlert("Country", "The country selected is " + country, "Ok");
        }
        else
        {
            DisplayAlert("Error", "Please select a country first.", "Ok");
        }
    }

}