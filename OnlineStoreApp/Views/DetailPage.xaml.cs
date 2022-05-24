using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace OnlineStoreApp.Views
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new ViewModels.DetailViewModel();
        }
    }
}
