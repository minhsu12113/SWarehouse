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

namespace SWarehouse.ViewModels.Suppliers
{
    public class SupplierAddOrUpdateViewModel : BindableBase
    {
        #region [Commands]
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        #endregion

        #region [Props]
        private String _header;
        private Supplier _currentSupplier;
        private Supplier _backuptSupplier;


        public ISupplierRepository SupplierServices { get; set; }
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }
        public Supplier CurrentSupplier
        {
            get { return _currentSupplier; }
            set { _currentSupplier = value; }
        }
        #endregion

        public SupplierAddOrUpdateViewModel(Supplier supplier = null)
        {
            if (supplier != null) // Edit
            {
                _backuptSupplier = supplier;
                CurrentSupplier = supplier.Clone();
                Header = StringResources.Find("EDIT");
            }
            else // Add new
            {
                CurrentSupplier = new Supplier();
                Header = StringResources.Find("ADD_NEW");
            }
            SupplierServices = new SupplierRepository(DbHelper.Instance.GetConnection());
        }

        public void Save()
        {
            if (_backuptSupplier == null)
            {
                CurrentSupplier.UserCreated = "Admin";
                CurrentSupplier.CreatedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                SupplierServices.Insert(CurrentSupplier);
            }
            else
            {
                CurrentSupplier.UserModified = "Admin";
                CurrentSupplier.ModifiedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                SupplierServices.Update(CurrentSupplier);
            }

            (App.Current.MainWindow.DataContext as MainViewModel).SupplierViewModel.SearchSupplier();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
