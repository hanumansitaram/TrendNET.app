﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QRScanner.trendNET.WMS
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
        }

        // Navigation in Xamarin forms.////////////////////////////////////////////////////////////----------->
        private async void BtnRegistration(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainMenu());
        }
    }
}