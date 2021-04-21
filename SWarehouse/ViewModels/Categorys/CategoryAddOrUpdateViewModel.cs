using SWarehouse.Internationalization;
using SWarehouse.Models;
using SWarehouse.Services;
using SWarehouse.Services.Base;
using SWarehouse.Services.Repository;
using SWarehouse.Utilitys;
using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWarehouse.ViewModels.Categorys
{
    public class CategoryAddOrUpdateViewModel : BindableBase
    {
        private String _header;
        private Category _currentCategory;
        private Category _backuptCategory;


        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }
        public Category CurrentUnit
        {
            get { return _currentCategory; }
            set { _currentCategory = value; }
        }


        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        private ICategoryRepository CategoryServices { get; set; }
        public CategoryAddOrUpdateViewModel(Category category = null)
        {
            if (category != null) // Edit
            {
                _backuptCategory = category;
                CurrentUnit = category.Clone();
                Header = StringResources.Find("EDIT");
            }
            else // Add new
            {
                CurrentUnit = new Category();
                Header = StringResources.Find("ADD_NEW");
            }
            CategoryServices = new CategoryRepository(DbHelper.Instance.GetConnection());
        }
        public void Save()
        {
            if (_backuptCategory == null)
            {
                CurrentUnit.UserCreated = "Admin";
                CurrentUnit.CreatedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                CategoryServices.Insert(CurrentUnit);
            }
            else
            {
                CurrentUnit.UserModified = "Admin";
                CurrentUnit.ModifiedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                CategoryServices.Update(CurrentUnit);
            }

            (App.Current.MainWindow.DataContext as MainViewModel).CategoryViewModel.SearchCategory();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
