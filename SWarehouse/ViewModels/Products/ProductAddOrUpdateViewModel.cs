using SWarehouse.Models;
using SWarehouse.Services;
using SWarehouse.Services.Base;
using SWarehouse.Services.Repository;
using SWarehouse.Utilitys;
using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace SWarehouse.ViewModels.Products
{
    public class ProductAddOrUpdateViewModel : BindableBase
    {
        #region [Collections]
        private List<Category> _categories;
        private List<Supplier> _suppliers;
        private List<Unit> _units;

        public List<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; OnPropertyChanged(); }
        }

        public List<Supplier> Suppliers
        {
            get { return _suppliers; }
            set { _suppliers = value; OnPropertyChanged(); }
        }

        public List<Unit> Units
        {
            get { return _units; }
            set { _units = value; OnPropertyChanged(); }
        }

        #endregion

        #region [Props]
        private Product _productCurrent;
        private Product ProductBackup { get; set; }
        private String _header;
        private Category _categorySelected;
        private Supplier _supplierSelected;
        private Unit _unitSelected;

        public Unit UnitSelected
        {
            get { return _unitSelected; }
            set { _unitSelected = value; OnPropertyChanged(); }
        }

        public Supplier SupplierSelected
        {
            get { return _supplierSelected; }
            set { _supplierSelected = value; OnPropertyChanged(); }
        }

        public Category CategorySelected
        {
            get { return _categorySelected; }
            set { _categorySelected = value; OnPropertyChanged(); }
        }

        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }

        public Product ProductCurrent
        {
            get { return _productCurrent; }
            set { _productCurrent = value; OnPropertyChanged(); }
        }

        public IProductRepository ProductServives { get; set; }

        public IUnitRepository UnitServives { get; set; }

        public ICategoryRepository CategoryServives { get; set; }

        public ISupplierRepository SupplierServives { get; set; }

        #endregion

        #region [Commands]
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        public ICommand OpenDialogChooseImageCMD { get { return new CommandHelper(OpenDialogChooseImage); } }
        #endregion

        public ProductAddOrUpdateViewModel(Product product = null)
        {

            ProductServives = new ProductRepository(DbHelper.Instance.GetConnection());
            UnitServives = new UnitRepository(DbHelper.Instance.GetConnection());
            CategoryServives = new CategoryRepository(DbHelper.Instance.GetConnection());
            SupplierServives = new SupplierRepository(DbHelper.Instance.GetConnection());

            LoadCategories();
            LoadSuppliers();
            LoadUnits();

            if (product != null)
            {
                Header = "Chỉnh Sửa";
                ProductBackup = product;
                ProductCurrent = product.Clone();

                UnitSelected = Units.FirstOrDefault((u) => u.Id == ProductCurrent.UnitId);
                CategorySelected = Categories.FirstOrDefault((u) => u.Id == ProductCurrent.CatId);
                SupplierSelected = Suppliers.FirstOrDefault((u) => u.Id == ProductCurrent.SupId);
            }
            else
            {
                Header = "Thêm Mới";
                ProductCurrent = new Product();
            }
        }

        public void LoadCategories() => Categories = CategoryServives.SelectAll()?.ToList();

        public void LoadSuppliers() => Suppliers = SupplierServives.SelectAll()?.ToList();

        public void LoadUnits() => Units = UnitServives.SelectAll()?.ToList();

        public void Save()
        {
            ProductCurrent.SupId = SupplierSelected.Id;
            ProductCurrent.CatId = CategorySelected.Id;
            ProductCurrent.UnitId = UnitSelected.Id;

            if (ProductBackup == null)
            {
                ProductCurrent.UserCreated = "Admin";
                ProductCurrent.CreatedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                ProductServives.Insert(ProductCurrent);
            }
            else
            {
                ProductCurrent.UserModified = "Admin";
                ProductCurrent.ModifiedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                ProductServives.Update(ProductCurrent);
            }

            (App.Current.MainWindow.DataContext as MainViewModel).ProductViewModel.SearchProduct();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }

        public void OpenDialogChooseImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg, *.png) | *.jpg; *.png" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                ProductCurrent.ImagePath = fileDialog.FileName;
        }
    }
}
