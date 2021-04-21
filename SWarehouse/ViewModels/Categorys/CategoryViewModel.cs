using SWarehouse.Models;
using SWarehouse.Services;
using SWarehouse.Services.Base;
using SWarehouse.Services.Repository;
using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWarehouse.ViewModels.Categorys
{
    public class CategoryViewModel : BindableBase
    {
        #region [Command]
        public ICommand SearchCMD { get { return new CommandHelper(SearchCategory); } }
        public ICommand AddNewCategoryCMD { get { return new CommandHelper(AddCategory); } }
        public ICommand EditCategoryCMD { get { return new CommandHelper<Category>((u) => u != null, ((u) => EditCategory(u))); } }
        public ICommand DeleteCategoryCMD { get { return new CommandHelper<Category>((u) => u != null, ((u) => ConfirmDeleteUnit(u))); } }

        #endregion
        #region [Props]
        private String _searchContent = String.Empty;

        public PagingViewmodel PagingViewmodel { get; set; }
        public String SearchContent
        {
            get { return _searchContent; }
            set { _searchContent = value; OnPropertyChanged(); }
        }
        public ICategoryRepository CategoryServices { get; set; }
        #endregion
        #region [Collection]
        private ObservableCollection<Category> _categories;

        public ObservableCollection<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; OnPropertyChanged(); }
        }
        #endregion

        public CategoryViewModel() 
        {
            CategoryServices = new CategoryRepository(DbHelper.Instance.GetConnection());
            PagingViewmodel = new PagingViewmodel(LoadCategory);
            SearchCategory();
        }
        public void LoadCategory(int limit, int offset)
        {
            var data = CategoryServices.GetListWithPagePaging(SearchContent,offset,limit);
            if (data != null)
                Categories = new ObservableCollection<Category>(data);
            else
                Categories.Clear();
        }
        public int LoadCountCategory() => CategoryServices.GetTotalCountWithName(SearchContent);
        public void SearchCategory()
        {
            PagingViewmodel.TotalCountItem = LoadCountCategory();
            PagingViewmodel.GotoFirstPage();
            PagingViewmodel.TotalCountDisplay = Categories == null ? 0 : Categories.Count;
            
        }
        public void AddCategory() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new CategoryAddOrUpdateViewModel());
        public void EditCategory(Category category) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new CategoryAddOrUpdateViewModel(category));
        public void ConfirmDeleteUnit(Category category) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteCategory(category); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, category.Name));
        public void DeleteCategory(Category category)
        {
            CategoryServices.Delete(category);
            SearchCategory();
        }
    }
}
