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

namespace SWarehouse.ViewModels.Products
{
    public class ProductViewModel : BindableBase
    {
        #region [Props]
        private String _contentSearch;

        public String ContentSearch
        {
            get { return _contentSearch; }
            set { _contentSearch = value; OnPropertyChanged(); }
        }

        public PagingViewmodel PagingViewmodel { get; set; }
        private IProductRepository ProductServices { get; set; }
        #endregion

        #region [Commans]
        public ICommand AddNewProductCMD { get { return new CommandHelper(AddNewProduct); } }
        public ICommand EditProductCMD { get { return new CommandHelper<Product>((p) => p != null, ((p) => EditProduct(p))); } }
        public ICommand DeleteProductCMD { get { return new CommandHelper<Product>((p) => p != null, ((p) => ConfirmProduct(p))); } }
        public ICommand SearchProductCMD { get { return new CommandHelper(SearchProduct); } }
        #endregion

        #region [Collections]
        private ObservableCollection<Product> _products;

        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set { _products = value; OnPropertyChanged(); }
        }
        #endregion

        public ProductViewModel()
        {
            ProductServices = new ProductRepository(DbHelper.Instance.GetConnection());
            PagingViewmodel = new PagingViewmodel(LoadProduct);
            SearchProduct();
        }

        public void LoadProduct(int limit, int offset)
        {
            var data = ProductServices.GetListWithPagePaging(ContentSearch, offset, limit);
            if (data != null)
                Products = new ObservableCollection<Product>(data);
            else
                Products?.Clear();
        }

        public void SearchProduct()
        {
            PagingViewmodel.TotalCountItem = GetCountProduct();
            PagingViewmodel.GotoFirstPage();
            PagingViewmodel.TotalCountDisplay = Products == null ? 0 : Products.Count;
        }

        public int GetCountProduct() => ProductServices.GetTotalCountWithName(ContentSearch);

        public void AddNewProduct() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ProductAddOrUpdateViewModel());

        public void EditProduct(Product product) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ProductAddOrUpdateViewModel(product));

        public void ConfirmProduct(Product product) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteProduct(product); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, product.Name));

        public void DeleteProduct(Product product)
        {
            ProductServices.Delete(product);
            SearchProduct();
        }
    }
}
