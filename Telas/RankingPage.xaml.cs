
using System.Collections.ObjectModel;
using Telas.Models;
using Telas.Services; // Substitua pelo caminho real da pasta Services
namespace Telas.Properties;

public partial class RankingPage : ContentPage
{
	ObservableCollection<ParticipanteViewModel> listaRanking {  get; set; } = new ObservableCollection<ParticipanteViewModel>();
	public RankingPage()
	{
		InitializeComponent();
		BindingContext = this;
	}
	protected override void OnAppearing()
	{
		base.OnAppearing();
		LoadData();
	}

	private async void LoadData()
	{
		var listaRanking = await ApiService<ParticipanteViewModel>.GetList("Ranking");
		foreach (var item in listaRanking.OrderBy(x => x.Pontos))
		{
			listaRanking.Add(item);
		}
	}
}