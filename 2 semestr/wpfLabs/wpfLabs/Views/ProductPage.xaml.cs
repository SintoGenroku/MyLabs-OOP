using System.Windows.Controls;

namespace wpfLabs.Views
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage(ViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
