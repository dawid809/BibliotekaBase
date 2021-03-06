﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BibliotekaBase.Views;

namespace BibliotekaBase
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void HomeViewClicked(object sender, RoutedEventArgs e)
        {
            Navigation.Content = new HomePage();
        }

        private void StudentView_Clicked(object sender, RoutedEventArgs e)
        {
            Navigation.Content = new StudenciPage();
        }

        private void WypozyczeniaView_Clicked(object sender, RoutedEventArgs e)
        {
            Navigation.Content = new WypozyczeniaPage();
        }

        private void KsiazkiView_Clicked(object sender, RoutedEventArgs e)
        {
            Navigation.Content = new KsiazkiPage();
        }

        private void AutorzyView_Clicked(object sender, RoutedEventArgs e)
        {
            Navigation.Content = new AutorzyPage();
        }

        private void TypKsiazkiView_Clicked(object sender, RoutedEventArgs e)
        {
            Navigation.Content = new TypKsiazkiPage();
        }
    }
}
