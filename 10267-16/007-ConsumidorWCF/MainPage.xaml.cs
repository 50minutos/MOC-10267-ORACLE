using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace _007_ConsumidorWCF
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();

            ComboBox1.DisplayMemberPath = "Nome";
        }

        private void UserControlLoaded(object sender, RoutedEventArgs e)
        {
            var g = new Proxy.ServiceClient();

            g.GetCompleted += GetCompleted;

            g.GetAsync();
        }

        void GetCompleted(object sender, Proxy.GetCompletedEventArgs e)
        {
            ComboBox1.ItemsSource = e.Result;
            ComboBox1.SelectionChanged += ComboBox1SelectionChanged;
        }

        void ComboBox1SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Label1.Content = ((Proxy.Genero)((ComboBox)sender).SelectedValue).Id.ToString(CultureInfo.InvariantCulture);
        }
    }
}
