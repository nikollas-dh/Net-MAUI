namespace Telas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await Task.Delay(4000);

            App.Current.MainPage = new LoginPage();
        }
        
        
    }
}
