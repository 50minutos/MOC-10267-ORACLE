using System;
using System.Windows;
using System.Windows.Controls;

namespace _003_xxxDefinition
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(String.Format("Você clicou no {0}!!!", ((Control)sender).Name));
        }
    }
}
