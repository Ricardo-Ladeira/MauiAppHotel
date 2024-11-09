namespace MauiAppHotel.Views;

    public partial class Start_page : ContentPage
    {
        public Start_page()
        {
            InitializeComponent();

        }
        private async void Sobre_Clicked(object sender, EventArgs e)
	{
		try
		{
            Navigation.PushAsync(new Views.Sobre());
        } catch (Exception ex)
		{
			await DisplayAlert("Erro!", ex.Message, "OK");
		}
	}
            private async void Quartos_Clicked(object sender, EventArgs e)
	{
		try
		{
            Navigation.PushAsync(new Views.Quartos());
        } catch (Exception ex)
		{
			await DisplayAlert("Erro!", ex.Message, "OK");
		}
	}
    }