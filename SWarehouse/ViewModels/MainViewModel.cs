using MaterialDesignThemes.Wpf;
using SWarehouse.Internationalization;
using SWarehouse.Models;
using SWarehouse.Services;
using SWarehouse.ViewModels.Accounts;
using SWarehouse.ViewModels.Base;
using SWarehouse.ViewModels.Categorys;
using SWarehouse.ViewModels.Home;
using SWarehouse.ViewModels.Products;
using SWarehouse.ViewModels.Setting;
using SWarehouse.ViewModels.Statistic;
using SWarehouse.ViewModels.Suppliers;
using SWarehouse.ViewModels.Units;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWarehouse.ViewModels
{
    public class MainViewModel : BindableBase
    {
        #region [ViewModel]
        public HomeViewModel HomeViewModel { get; set; }
        public AccountViewModel AccountViewModel { get; set; }
        public CategoryViewModel CategoryViewModel { get; set; }
        public ProductViewModel ProductViewModel { get; set; }
        public SupplierViewModel SupplierViewModel { get; set; }
        public UnitViewModel UnitViewModel { get; set; }
        public StatisticViewModel StatisticViewModel { get; set; }
        public SettingViewModel SettingViewModel { get; set; }
        #endregion
        #region [Bindable Prop]
        private object _viewCurrent;
        private object _dialogContent;
        private ItemNavigate _selectedView;




        public ItemNavigate SelectedView
        {
            get { return _selectedView; }
            set { _selectedView = value; OnPropertyChanged(); ChangeView(value); }
        }
        public object ViewCurrent
        {
            get { return _viewCurrent; }
            set { _viewCurrent = value; OnPropertyChanged(); }
        }
        public object DialogContent
        {
            get { return _dialogContent; }
            set { _dialogContent = value; OnPropertyChanged(); }
        }
        #endregion
        #region [Collections]
        private ObservableCollection<ItemNavigate> _listItemNavigate;



        public ObservableCollection<ItemNavigate> ListItemNavigate
        {
            get { return _listItemNavigate; }
            set { _listItemNavigate = value; OnPropertyChanged(); }
        }
        #endregion
        #region [Commands]
        public ICommand ChangeViewCMD { get { return new CommandHelper<ItemNavigate>((i) => i != null, ((i) => ChangeView(i))); } }
        #endregion

        public MainViewModel()
        {
            LoadListItemNavigate();
            ChangeView(ListItemNavigate[0]); // Defualt Home View
            DbHelper.Instance.CreateDatabase();
        }
        public void LoadListItemNavigate()
        {
            StringResources.ApplyLanguage(Enums.ALL_ENUM.Language.VN);
            ListItemNavigate = new ObservableCollection<ItemNavigate>()
            {
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("HOME"),
                     Type = Enums.ALL_ENUM.ViewType.HOME,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.HomeOutline,
                     IsSelected = true
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("PRODUCT"),
                     Type = Enums.ALL_ENUM.ViewType.PRODUCT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.PackageVariantClosed

                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("CATEGORYS"),
                     Type = Enums.ALL_ENUM.ViewType.CATEGORY,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Buffer
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("UNITS"),
                     Type = Enums.ALL_ENUM.ViewType.UNIT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.Blur
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("SUPPLIER"),
                     Type = Enums.ALL_ENUM.ViewType.SUPPLIER,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.HumanHandsup
                },
                new ItemNavigate()
                {
                     DisplayName = StringResources.Find("ACCOUNTS"),
                     Type = Enums.ALL_ENUM.ViewType.ACCOUNT,
                     Icon = MaterialDesignThemes.Wpf.PackIconKind.AccountBoxOutline
                },
            };
        }

        public void ChangeView(ItemNavigate itemNavigate)
        {
            foreach (var item in ListItemNavigate)
                item.IsSelected = false;

            
            itemNavigate.IsSelected = true;


            switch (itemNavigate.Type)
            {
                case Enums.ALL_ENUM.ViewType.HOME:
                    ViewCurrent = HomeViewModel == null ? new HomeViewModel(): HomeViewModel;
                    break;
                case Enums.ALL_ENUM.ViewType.PRODUCT:
                    ViewCurrent = ProductViewModel == null ? ProductViewModel = new ProductViewModel() : ProductViewModel;
                    break;
                case Enums.ALL_ENUM.ViewType.UNIT:
                    ViewCurrent = UnitViewModel == null ? UnitViewModel = new UnitViewModel() : UnitViewModel;
                    break;
                case Enums.ALL_ENUM.ViewType.SUPPLIER:
                    ViewCurrent = SupplierViewModel == null ? SupplierViewModel = new SupplierViewModel() : SupplierViewModel;
                    break;
                case Enums.ALL_ENUM.ViewType.CATEGORY:
                    ViewCurrent = CategoryViewModel == null ? CategoryViewModel = new CategoryViewModel() : CategoryViewModel;
                    break;
                case Enums.ALL_ENUM.ViewType.ACCOUNT:
                    ViewCurrent = AccountViewModel == null ? AccountViewModel = new AccountViewModel() : AccountViewModel;
                    break;               
                default:
                    break;
            }
        }

        public void OpenDiaLog(object content) => DialogHost.Show(content, "MainDialog");

        public void CloseDialog() => DialogHost.Close("MainDialog");
    }
}
