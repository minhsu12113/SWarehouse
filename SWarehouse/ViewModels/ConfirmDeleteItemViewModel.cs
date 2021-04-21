using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWarehouse.ViewModels
{
    public class ConfirmDeleteItemViewModel : BindableBase
    {
        private String _contentItemDelete;

        public String ContentItemDelete
        {
            get { return _contentItemDelete; }
            set { _contentItemDelete = value; OnPropertyChanged(); }
        }

        public ICommand DeleteItemCommand { get { return new CommandHelper(CallBackDelete); } }
        public ICommand CancelDeleteCommand { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        public Action CallBackDelete { get; set; }
        public ConfirmDeleteItemViewModel(Action callbackDelete, String content)
        {
            CallBackDelete = callbackDelete;
            ContentItemDelete = content;
        }
    }
}
