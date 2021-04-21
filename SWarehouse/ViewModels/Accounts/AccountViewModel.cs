using SWarehouse.Models;
using SWarehouse.Services;
using SWarehouse.Services.Base;
using SWarehouse.Services.Repository;
using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SWarehouse.ViewModels.Accounts
{
    public class AccountViewModel : BindableBase
    {
        #region [Props]
        private String _contentSearch;


        public String ContentSearch
        {
            get { return _contentSearch; }
            set { _contentSearch = value; OnPropertyChanged(); }
        }

        public PagingViewmodel PagingViewmodel { get; set; }
        public IAccountRepository AccountServices { get; set; }

        #endregion

        #region [Commans]
        public ICommand AddNewAccountCMD { get { return new CommandHelper(AddNewAccount); } }
        public ICommand SearchAccountCMD { get { return new CommandHelper(SearchAccount); } }
        public ICommand EditAccountCMD { get { return new CommandHelper<Account>((u) => u != null, ((u) => EditAccount(u))); } }
        public ICommand DeleteAccountCMD { get { return new CommandHelper<Account>((u) => u != null, ((u) => ConfirmAccount(u))); } }
        #endregion

        #region [Collections]
        private ObservableCollection<Account> _accounts;

        public ObservableCollection<Account> Accounts
        {
            get { return _accounts; }
            set { _accounts = value; OnPropertyChanged(); }
        }
        #endregion

        public AccountViewModel()
        {
            AccountServices = new AccountRepository(DbHelper.Instance.GetConnection());
            PagingViewmodel = new PagingViewmodel(LoadAccount);
        }

        public void LoadAccount(int limit, int offset)
        {
            var data = AccountServices.GetListWithPagePaging(ContentSearch, offset, limit);
            if (data != null)
                Accounts = new ObservableCollection<Account>(data);
            else
                Accounts?.Clear();
        }

        public void SearchAccount()
        {
            PagingViewmodel.TotalCountItem = GetCountAccount();
            PagingViewmodel.GotoFirstPage();
            PagingViewmodel.TotalCountDisplay = Accounts == null ? 0 : Accounts.Count;
        }

        public int GetCountAccount() => AccountServices.GetTotalCountWithName(ContentSearch);

        public void AddNewAccount() => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new AccountAddOrUpdateViewModel());

        public void EditAccount(Account account) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new AccountAddOrUpdateViewModel(account));

        public void ConfirmAccount(Account account) => (App.Current.MainWindow.DataContext as MainViewModel).OpenDiaLog(new ConfirmDeleteItemViewModel(() => { DeleteAccount(account); (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }, account.UserName));

        public void DeleteAccount(Account account)
        {
            AccountServices.Delete(account);
            SearchAccount();
        }
    }
}
