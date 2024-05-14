﻿using FoodRecipeApp_24.View.UserControls;
using System.Windows;

namespace FoodRecipeApp_24
{
    
    public partial class Mainwindow : Window
    {
        public Mainwindow()
        {
            InitializeComponent();

            MenuBarView = new MenuBarView();
            Content = MenuBarView;
            MenuBarView.ButtonClicked += MenuBarView_ButtonClicked;
        }

        public MenuBarView MenuBarView { get; }

        private void MenuBarView_ButtonClicked(object sender, string pageName)
        {
            switch(pageName)
            {
                case "prof":
                    homeMainFrame.Navigate(new Uri("UserProfilePage.xaml", UriKind.Relative));
                    break;

                case "fridge":
                    homeMainFrame.Navigate(new Uri("MyFridge.xaml", UriKind.Relative));
                    break;

                case "fav":
                    homeMainFrame.Navigate(new Uri("MyFavourites.xaml", UriKind.Relative));
                    break;

                case "addRecipe":
                    homeMainFrame.Navigate(new Uri("AddRecipe.xaml", UriKind.Relative));
                    break;

                case "faqs":
                    homeMainFrame.Navigate(new Uri("FAQs.xaml", UriKind.Relative));
                    break;

                case "stngs":
                    homeMainFrame.Navigate(new Uri("Settings.xaml", UriKind.Relative));
                    break;

                case "abt":
                    homeMainFrame.Navigate(new Uri("AboutUs.xaml", UriKind.Relative));
                    break;

                case "revs":
                    homeMainFrame.Navigate(new Uri("Reviews.xaml", UriKind.Relative));
                    break;
            }
        }
    }
}
