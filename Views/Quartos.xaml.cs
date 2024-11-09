namespace MauiAppHotel.Views;

    public partial class Quartos : ContentPage
    {
        public Quartos()
        {
            InitializeComponent();

        }
       	private async void Button_Clicked(object sender, EventArgs e)
	{
		try
		{
            Navigation.PushAsync(new Views.ContratacaoHospedagem());
        } catch (Exception ex)
		{
			await DisplayAlert("Erro!", ex.Message, "OK");
		}
	} 
    }
