﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace app_guiads.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Contato : ContentPage
    {
        public Contato()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:01936560052"));
        }
    }
}