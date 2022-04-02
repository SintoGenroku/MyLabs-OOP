using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

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
        private Page _currentPage;

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
                            ProductsCategory = Repository.LoadProducts();
                        }
                        else
                        {
                            ProductsCategory = new ObservableCollection<Product>(Products.Where(x => x.category == obj as string));
                        }
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
                        CurrentPage = _categoryPage;
                        ProductsCategory.Remove(SelectedProduct);
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


        public ViewModel()
        {
            _categoryPage = new Views.CategoryPage(this);
            _productPage = new Views.ProductPage(this);
            _editProductPage = new Views.EditProductPage(this);
            Products = new ObservableCollection<Product>(Repository.LoadProducts());
            ProductsCategory = new ObservableCollection<Product>(Products);
            CurrentPage = _categoryPage;
        } 

        

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }

        
    }


    public class CategoryCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
        public CategoryCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter)
        {
            return this.canExecute == null || this.canExecute(parameter);
         }

        public void Execute(object parameter)
        {
            this.execute(parameter);
        }
    }
}
