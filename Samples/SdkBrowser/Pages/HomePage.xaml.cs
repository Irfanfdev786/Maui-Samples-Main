﻿using Microsoft.Maui.Controls;
using SDKBrowserMaui.Common;
using SDKBrowserMaui.ViewModels;
using System;
using System.ComponentModel;

namespace SDKBrowserMaui.Pages
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            this.BindingContext = new HomeViewModel();
        }
    }
}
