using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Maestro : ContentPage
    {
        public Maestro()
        {
            InitializeComponent();
        }

        private void IrStoryline(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail.Navigation.PushAsync(new Pagina1());
        }

        private void IrFotos(object sender, EventArgs e)
        {
            App.MasterD.IsPresented = false;
            App.MasterD.Detail.Navigation.PushAsync(new Pagina2());
        }
    }
}