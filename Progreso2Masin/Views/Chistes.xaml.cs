using Progreso2Masin.Repository;

namespace Progreso2Masin.Views;

public partial class Chistes : ContentPage
{
    private readonly ChisteRepository _chistesRepository;

    public Chistes()
    {
        InitializeComponent();
        _chistesRepository = new ChisteRepository();
        CargarChiste();
    }

    private async void CargarChiste()
    {
        try
        {
            var chiste = await _chistesRepository.GetChisteAsync();
            ChisteLabel.Text = chiste;
        }
        catch (Exception ex)
        {
            ChisteLabel.Text = $"Error al cargar el chiste: {ex.Message}";
        }
    }
        
    private void OnOtroChisteClicked(object sender, EventArgs e)
    {
        CargarChiste();
    }
}