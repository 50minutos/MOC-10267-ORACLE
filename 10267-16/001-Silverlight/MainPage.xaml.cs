using System.Windows;

namespace _001_Silverlight
{
    public partial class MainPage 
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello World");
        }
    }
}
