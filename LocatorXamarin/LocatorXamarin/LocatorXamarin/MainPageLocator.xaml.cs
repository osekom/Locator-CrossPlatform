using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LocatorXamarin
{
    public partial class MainPageLocator : ContentPage
    {
        public string URL = AppConst.Constantes.URL;

        public MainPageLocator()
        {
            InitializeComponent();
            Browser.Source = URL;
        }
    }
}