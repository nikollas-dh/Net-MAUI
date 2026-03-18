namespace Telas;

public partial class TelaLogada : ContentPage
{
	public TelaLogada()
	{
		InitializeComponent();
	}

    private void btnNav_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new TelaNavegacao();

    }
}