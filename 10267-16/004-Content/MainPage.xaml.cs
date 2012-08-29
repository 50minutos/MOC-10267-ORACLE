using System;
using System.Windows;
using System.Windows.Media;

namespace _004_Content
{
    public partial class MainPage
    {
        Random r = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            LayoutRoot.Background = new SolidColorBrush(Color.FromArgb(255, (byte)r.Next(0, 256), (byte)r.Next(0, 256), (byte)r.Next(0, 256)));
        }
    }
}
