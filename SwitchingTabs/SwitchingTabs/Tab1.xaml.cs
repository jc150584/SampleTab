using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwitchingTabs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tab1 : ContentPage
    {
        public Tab1()
        {
            InitializeComponent();
            BindingContext = new Tab1ViewModel();
        }
    }
}