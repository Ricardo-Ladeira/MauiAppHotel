namespace MauiAppHotel.Views;

public partial class Sobre: ContentPage
{
	public Sobre()
	{
		InitializeComponent();
	}
	private async void Voltar_Clicked(object sender, EventArgs e)
	{
		try
		{
		Navigation.PopAsync();
        } catch (Exception ex)
		{
			await DisplayAlert("Erro!", ex.Message, "OK");
		}
	}
}
