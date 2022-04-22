using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using wpfLabs.Memento;
using wpfLabs.Command;
using System;
using System.Windows;

namespace wpfLabs
{
    public class ViewModel : INotifyPropertyChanged
    {
        private Page _categoryPage;
        private Page _productPage;
        private Page _editProductPage;
        private Product _selectedProduct;
        private ObservableCollection<Product> _productsCategory;
        private CategoryCommand _chooseCommand;
        private CategoryCommand _removeCommand;
        private CategoryCommand _editCommand;
        private CategoryCommand _submitCommand;
        private CategoryCommand _changeLanguage;
        private CategoryCommand _changeTheme;
        private Page _currentPage;
        private static string _currentLanguage;
        private static string _currentTheme;
        private static bool isUndoProccess = false;
        private static bool isRedoProccess = false;
        static Stack<(object Obj, string Prop, object OldValue)> undoHistory = new Stack<(object Obj, string Prop, object OldValue)>();
        static Stack<(object Obj, string Prop, object OldValue)> redoHistory = new Stack<(object Obj, string Prop, object OldValue)>();

        public event PropertyChangedEventHandler PropertyChanged;
      
        public Page CurrentPage
        {
            get { return _currentPage; }
            set
            {
                _currentPage = value;
                OnPropertyChanged();
                
            }
        }
        public ObservableCollection<Product> Products { get; set; }
        public ObservableCollection<Product> ProductsCategory 
        {
            get { return _productsCategory; }
            set 
            {
                _productsCategory = value;
                OnPropertyChanged();
                CurrentPage = _categoryPage;
                
            } 
        }
        public Product SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                if (value != null)
                {
                    _selectedProduct = value;
                    OnPropertyChanged();
                    CurrentPage = _productPage;
                }
                 else
                {
                    _selectedProduct = null;
                    OnPropertyChanged();
                }
            }
        }

        public CategoryCommand ChooseCommand
        {
            get
            {
                return _chooseCommand ??
                    (_chooseCommand = new CategoryCommand(obj =>
                    {
                       if(obj as string == "all")
                        {
                            ProductsCategory = Products;
                        }
                        else
                        {
                            ProductsCategory = new ObservableCollection<Product>(Products.Where(x => x.category == obj as string));
                        }
                        SelectedProduct = null;
                    }));
               
            }
        }

        public CategoryCommand RemoveCommand
        {
            get
            {
                return _removeCommand ??
                    (_removeCommand = new CategoryCommand(obj =>
                    {
                        ProductsCategory.Remove(SelectedProduct);
                        Products.Remove(SelectedProduct);
                        CurrentPage = _categoryPage;
                    }));
            }
        }

        public CategoryCommand EditCommand
        {
            get
            {
                return _editCommand ??
                    (_editCommand = new CategoryCommand(obj =>
                    {
                        CurrentPage = _editProductPage;
                    }));
            }
        }
        public CategoryCommand SubmitCommand
        {
            get
            {
                return _submitCommand ??
                    (_submitCommand = new CategoryCommand(obj =>
                    {
                        CurrentPage = _productPage;
                    }));
            }
        }
        public CategoryCommand ChangeLanguage 
        {
            get
            {
                return _changeLanguage ??
                    ( _changeLanguage = new CategoryCommand(o =>
                    {
                        _currentLanguage = _currentLanguage == $"ru" ? $"en" : $"ru";
                        var dict = new ResourceDictionary { Source = new Uri($"../Resources/lang.{_currentLanguage}.xaml", UriKind.Relative) };
                        Application.Current.Resources.MergedDictionaries.Add(dict);
                    }));
            }
        } 

        public CategoryCommand ChangeTheme
        {
            get
            {
                return _changeTheme ??
                    (_changeTheme = new CategoryCommand(o =>
                    {
                        _currentTheme = _currentTheme == "dark" ? "light" : "dark";
                        var dict = new ResourceDictionary { Source = new Uri($"../Resources/{_currentTheme}Theme.xaml", UriKind.Relative) };
                        Application.Current.Resources.MergedDictionaries.Add(dict);
                    }));
            }
        }

        public ViewModel()
        {
            _categoryPage = new Views.CategoryPage(this);
            _productPage = new Views.ProductPage(this);
            _editProductPage = new Views.EditProductPage(this);
            Products = new ObservableCollection<Product>(Repository.LoadProducts());
            ProductsCategory = new ObservableCollection<Product>(Products);
            CurrentPage = _categoryPage;
            _currentLanguage = "ru";
            _currentTheme = "light";
        } 

        

        public void OnPropertyChanged( [CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
/*            if (pr != null)
                SaveState(pr, 1);*/
        }

        protected bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, value))
                return false;
            field = value;
            OnPropertyChanged();
            return true;
        }


        public ProductMemento SaveState(Product product, int id)
        {
            return new ProductMemento(product, id);
        }

/*        static void Undo()
        {
            if (undoHistory.Count == 0) return;
            var undo = undoHistory.Pop();
            UndoCommand.RaiseCanExecuteChanged();
            // Обернуто для того чтобы в случае исключения флаг всё равно снимался
            try
            {
                isUndoProcess = true;
                undo.Obj.GetType().GetProperty(undo.Prop).SetValue(undo.Obj, undo.OldValue);
            }
            finally
            {
                isUndoProcess = false;
            }
        }

        static void Redo()
        {
            if (redoHistory.Count == 0) return;
            var redo = redoHistory.Pop();
            RedoCommand.RaiseCanExecuteChanged();
            try
            {
                isRedoProcess = true;
                redo.Obj.GetType().GetProperty(redo.Prop).SetValue(redo.Obj, redo.OldValue);
            }
            finally
            {
                isRedoProcess = false;
            }
        }

        static void SaveHistory(object obj, string propertyName, object value)
        {
            if (isUndoProcess)
            {
                redoHistory.Push((obj, propertyName, value));
                RedoCommand.RaiseCanExecuteChanged();
            }
            else if (isRedoProcess)
            {
                undoHistory.Push((obj, propertyName, value));
                UndoCommand.RaiseCanExecuteChanged();
            }
            else
            {
                undoHistory.Push((obj, propertyName, value));
                UndoCommand.RaiseCanExecuteChanged();
                redoHistory.Clear();
                RedoCommand.RaiseCanExecuteChanged();
            }
        }

        static void ClearHistory()
        {
            undoHistory.Clear();
            UndoCommand.RaiseCanExecuteChanged();
            redoHistory.Clear();
            RedoCommand.RaiseCanExecuteChanged();
        }

        public static CategoryCommand UndoCommand { get; }
           = new CategoryCommand(_ => Undo(), _ => undoHistory.Count > 0);
        public static CategoryCommand RedoCommand { get; }
            = new CategoryCommand(_ => Redo(), _ => redoHistory.Count > 0);
        public static CategoryCommand ClearHistoryCommand { get; }
            = new CategoryCommand(_ => ClearHistory());
*/
    }
        
}
