﻿using PlanetsMaui.Models;

namespace PlanetsMaui.Views;

public partial class PlanetDetailsPage : ContentPage
{
    public PlanetDetailsPage(Planet planet)
    {
        InitializeComponent();

        this.BindingContext = planet;
    }

    async void BackButton_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopAsync();
    }
}