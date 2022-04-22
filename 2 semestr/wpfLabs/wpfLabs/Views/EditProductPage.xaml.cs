using System.Windows.Controls;

namespace wpfLabs.Views
{
    /// <summary>
    /// Логика взаимодействия для EditProductPage.xaml
    /// </summary>
    public partial class EditProductPage : Page
    {
        public EditProductPage(ViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
