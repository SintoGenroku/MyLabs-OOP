using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace wpfLabs
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private ICommand _langCommand;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
        }
/*        public ICommand LangCommand
        {
            get
            {
                return _langCommand ??
                    (_langCommand = new CategoryCommand(obj =>
                    {
                        Resources.MergedDictionaries.Clear();
                        Resources.MergedDictionaries.Add(Models.Resources.Languages[obj as string]);
                    }
                    ));
            }
        }
*/
    }
}
    