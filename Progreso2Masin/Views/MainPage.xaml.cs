using System.Threading.Tasks;
using Progreso2Masin.Views;

namespace Progreso2Masin
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void IrAChistes_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Chistes());

        }

        private void IrAAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());

        }
    }

}
