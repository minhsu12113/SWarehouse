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

namespace SWarehouse.ViewModels.Units
{
    public class UnitAddOrUpdateViewModel : BindableBase
    {
        #region [Props]
        private String _header;
        private Unit _currentUnit;
        private Unit _backuptUnit;


        private IUnitRepository UnitServices { get; set; }
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }
        public Unit CurrentUnit
        {
            get { return _currentUnit; }
            set { _currentUnit = value; }
        }
        #endregion

        #region [Commands]
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        #endregion

      
        public UnitAddOrUpdateViewModel(Unit unit = null)
        {
            if (unit != null) // Edit
            {
                _backuptUnit = unit;
                CurrentUnit = unit.Clone();
                Header = StringResources.Find("EDIT");
            }
            else // Add new
            {
                CurrentUnit = new Unit();
                Header = StringResources.Find("ADD_NEW");
            }
            UnitServices = new UnitRepository(DbHelper.Instance.GetConnection());
        }
        public void Save()
        {
            if (_backuptUnit == null)
            {
                CurrentUnit.UserCreated = "Admin";
                CurrentUnit.CreatedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                UnitServices.Insert(CurrentUnit);
            }
            else
            {
                CurrentUnit.UserModified = "Admin";
                CurrentUnit.ModifiedTime = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                UnitServices.Update(CurrentUnit);
            }
            
            (App.Current.MainWindow.DataContext as MainViewModel).UnitViewModel.SearchUnit();
            (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
