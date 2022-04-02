using System.Windows.Controls;

namespace wpfLabs.Views
{
    /// <summary>
    /// Логика взаимодействия для CategoryPage.xaml
    /// </summary>
    public partial class CategoryPage : Page
    {
        public CategoryPage(ViewModel vm)
        {
            InitializeComponent();
            DataContext = vm;
        }
    }
}
