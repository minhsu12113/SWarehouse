using Dapper;
using SWarehouse.Internationalization;
using SWarehouse.Models;
using SWarehouse.Services;
using SWarehouse.Services.Base;
using SWarehouse.Services.Repository;
using SWarehouse.ViewModels.Base;
using SWarehouse.Views;
using SWarehouse.Views.Dialogs;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace SWarehouse.ViewModels
{
    public class LoginViewModel : BindableBase
    {
        #region [Props]
        private SWarehouse.Models.Account _currentAccount = new SWarehouse.Models.Account();
        private WindowState _windowState = WindowState.Normal;
        private bool _showTextWhenLoginFailed;


        public IAccountRepository AccountRepository { get; set; } = new AccountRepository(DbHelper.Instance.GetConnection());
        public bool ShowTextWhenLoginFailed
        {
            get { return _showTextWhenLoginFailed; }
            set { _showTextWhenLoginFailed = value; OnPropertyChanged(); }
        }
        public WindowState WindowState
        {
            get { return _windowState; }
            set { _windowState = value; OnPropertyChanged(); }
        }
        public SWarehouse.Models.Account CurrentAccount
        {
            get { return _currentAccount; }
            set { _currentAccount = value; OnPropertyChanged(); }
        }
        #endregion
        #region [Commands]
        public ICommand LoginCMD { get { return new CommandHelper(Login); } }
        public ICommand MinimizedWindowCMD { get { return new CommandHelper(MinimizedWindow); } }
        public ICommand CloseWindowCMD { get { return new CommandHelper(CloseWindow); } }
        public ICommand DragMoveCMD { get { return new CommandHelper<Window>((w) => w != null, ((p) => { try { p.DragMove(); } catch { } })); } }
        #endregion

        public LoginViewModel() => StringResources.ApplyLanguage(Enums.ALL_ENUM.Language.EN);
        public void Login()
        {
            ShowTextWhenLoginFailed = !AccountRepository.CheckValidAccount(CurrentAccount);
            if (!ShowTextWhenLoginFailed)
            {
                App.Current.MainWindow = new MainWindow();
                App.Current.MainWindow.DataContext = new MainViewModel();
                App.Current.MainWindow.Show();

                foreach (var item in App.Current.Windows)
                {
                    if (item.GetType() == typeof(LoginWindow))
                        (item as Window).Hide();
                }
            }
        }
        public void MinimizedWindow() => WindowState = WindowState.Minimized;
        public void CloseWindow() => Environment.Exit(0);
    }
}
