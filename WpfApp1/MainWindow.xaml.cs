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
using WpfApp1.ViewModels;

namespace WpfApp1
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        ClienteViewModel viewModel = new MainViewModel();

        public MainWindow()
        {
            DataContext = viewModel;

            InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.BotaoAcionado();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
