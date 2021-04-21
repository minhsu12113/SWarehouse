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

namespace SWarehouse.ViewModels.Suppliers
{
    public class SupplierViewModel : BindableBase
    {
        #region [Commands]
        public ICommand AddNewSupplierCMD { get { return new CommandHelper(AddNewSupplier); } }
        public ICommand EditSupplierCMD { get { return new CommandHelper<Supplier>((u) => u != null, ((u) => EditSupplier(u))); } }
        public ICommand DeleteSupplierCMD { get { return new CommandHelper<Supplier>((u) => u != null, ((u) => ConfirmDeleteUnit(u))); } }
        public ICommand SearchSupplierCMD { get { return new CommandHelper(SearchSupplier); } }
        #endregion

        #region [Porps]
        private String _contentSreach = String.Empty;


        private ISupplierRepository SupplierServices { get; set; }
        public PagingViewmodel PagingViewmodel { get; set; }
        public String ContentSearch
        {
            get { return _contentSreach; }
            set { _contentSreach = value; OnPropertyChanged(); }
        }
        #endregion

        #region [Collections]
        private ObservableCollection<Supplier> _suppliers;

        public ObservableCollection<Supplier> Suppliers
        {
            get { return _suppliers; }
            set { _suppliers = value; OnPropertyChanged(); }
        }
        #endregion


        public SupplierViewModel()
        {
            SupplierServices = new SupplierRepository(DbHelper.Instance.GetConnection());
            PagingViewmodel = new PagingViewmodel(LoadSupplier);
            SearchSupplier();
        }

        public void LoadSupplier(int limit, int offset)
        {
            var data = SupplierServices.GetListWithPagePaging(ContentSearch, offset, limit);
            if (data != null)
                Suppliers = new ObservableCollection<Supplier>(data);
            else
                Suppliers?.Clear();
        }

        public int GetCountUnit() => SupplierServices.GetTotalCountWithName(ContentSearch);

        public void SearchSupplier()
        {
            PagingViewmodel.TotalCountItem = GetCountUnit();
            PagingViewmodel.GotoFirstPage();
            PagingViewmodel.TotalCountDisplay = Suppliers == null ? 0 : Suppliers.Count;
        }

        public void AddNewSupplier() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new SupplierAddOrUpdateViewModel());

        public void EditSupplier(Supplier supplier) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new SupplierAddOrUpdateViewModel(supplier));

        public void DeleteSupplier(Supplier supplier)
        {
            SupplierServices.Delete(supplier);
            SearchSupplier();
        }
        
        public void ConfirmDeleteUnit(Supplier supplier) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteSupplier(supplier); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, supplier.Name));
    }
}
