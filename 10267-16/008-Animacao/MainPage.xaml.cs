using System.Windows;

namespace _008_Animacao
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            storyboard.Begin();
        }
    }
}
