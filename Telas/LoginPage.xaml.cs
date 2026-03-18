namespace Telas;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
		if(usuarioInput.Text == "nikollas" && senhaInput.Text == "123")
		{
			App.Current.MainPage = new TelaLogada();
		}
		else
		{
			await DisplayAlert("Alerta", "usuário ou senha inválidos", "OK");
		}
    }
}