namespace MauiAppHotel.Views;

public partial class HospedagemContratada : ContentPage
{
	public HospedagemContratada()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
			Navigation.PopAsync();
		}
		catch (Exception ex)
		{
			await DisplayAlert("Erro!", ex.Message, "OK");
		}
	}
	private async void OnImageTapped(object sender, EventArgs e)
	{
		try
		{
			Navigation.PushAsync(new Views.Start_page());
		}
		catch (Exception ex)
		{
			await DisplayAlert("Erro!", ex.Message, "OK");
		}
	}
}