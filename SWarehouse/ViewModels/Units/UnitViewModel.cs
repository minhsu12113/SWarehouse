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

namespace SWarehouse.ViewModels.Units
{
    public class UnitViewModel : BindableBase
    {
        #region [Prop]
        private String _contentSearch = String.Empty;



        private IUnitRepository UnitServices { get; set; }
        public PagingViewmodel PagingViewmodel { get; set; }
        public String ContentSearch
        {
            get { return _contentSearch; }
            set { _contentSearch = value; OnPropertyChanged(); }
        }

        #endregion
        #region [Collections]
        private ObservableCollection<Models.Unit> _units;

        public ObservableCollection<Models.Unit> Units
        {
            get { return _units; }
            set { _units = value; OnPropertyChanged(); }
        }
        #endregion
        #region [Commands]
        public ICommand AddNewUnitCMD { get { return new CommandHelper(AddNewUnit); } }
        public ICommand EditUnitCMD { get { return new CommandHelper<Unit>((u) => u != null, ((u) => EditUnit(u))); } }
        public ICommand DeleteUnitCMD { get { return new CommandHelper<Unit>((u) => u != null, ((u) => ConfirmDeleteUnit(u))); } }
        public ICommand SearchUnitCMD { get { return new CommandHelper(SearchUnit); } }
        #endregion

        public UnitViewModel()
        {
            UnitServices = new UnitRepository(DbHelper.Instance.GetConnection());
            PagingViewmodel = new PagingViewmodel(LoadUnit);
            SearchUnit();
        }

        public void LoadUnit(int limit,int offset)
        {
            var data = UnitServices.GetListWithPagePaging(ContentSearch, offset, limit);
            if (data != null)
                Units = new ObservableCollection<Unit>(data);
            else
                Units?.Clear();
        }

        public void SearchUnit()
        {
            PagingViewmodel.TotalCountItem = GetCountUnit();
            PagingViewmodel.GotoFirstPage();
            PagingViewmodel.TotalCountDisplay = Units == null ? 0 : Units.Count;            
        }

        public int GetCountUnit() => UnitServices.GetTotalCountWithName(ContentSearch);

        public void AddNewUnit() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new UnitAddOrUpdateViewModel());

        public void EditUnit(Unit unit) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new UnitAddOrUpdateViewModel(unit));

        public void ConfirmDeleteUnit(Unit unit) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteUnit(unit); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, unit.Name));

        public void DeleteUnit(Unit unit)
        {
            UnitServices.Delete(unit);
            SearchUnit();
        }
    }
}
