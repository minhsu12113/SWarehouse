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
using System.Windows.Forms;
using System.Windows.Input;

namespace SWarehouse.ViewModels.Accounts
{
    public class AccountAddOrUpdateViewModel : BindableBase
    {
        #region [Props]
        private Account _accountCurrent;
        private String _header;
        private String _imagePath;
        private String _confirmPassword;
        private bool _isErrorPassword;




        public bool IsErrorPassword
        {
            get { return _isErrorPassword; }
            set { _isErrorPassword = value; OnPropertyChanged(); }
        }
        public String ConfirmPassword
        {
            get { return _confirmPassword; }
            set { _confirmPassword = value; OnPropertyChanged(); CheckValidPassword(); }
        }
        public String ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChanged(); }
        }
        public String Header
        {
            get { return _header; }
            set { _header = value; OnPropertyChanged(); }
        }
        public Account AccountCurrent
        {
            get { return _accountCurrent; }
            set { _accountCurrent = value; OnPropertyChanged(); }
        }
        public Account Accountbackup { get; set; }
        public IAccountRepository AccountServives { get; set; }
        #endregion

        #region [Commands]
        public ICommand OpenDialogChooseImageCMD { get { return new CommandHelper(OpenDialogChooseImage); } }
        public ICommand SaveCMD { get { return new CommandHelper(Save); } }
        public ICommand CancelCMD { get { return new CommandHelper(() => { (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog(); }); } }
        #endregion

        public AccountAddOrUpdateViewModel(Account account = null)
        {
            if (account != null)
            {
                Accountbackup = account;
                AccountCurrent = account.Clone();
                Header = "Chỉnh Sửa";
            }
            else
            {
                Header = "Thêm Mới";
                AccountCurrent = new Account();
            }

            AccountServives = new AccountRepository(DbHelper.Instance.GetConnection());
        }
        public void OpenDialogChooseImage()
        {
            OpenFileDialog fileDialog = new OpenFileDialog() { Filter = "Image files (*.jpg, *.png) | *.jpg; *.png" };
            if (fileDialog.ShowDialog() == DialogResult.OK)
                AccountCurrent.ImagePath = fileDialog.FileName;
        }
        public void CheckValidPassword() => IsErrorPassword = ConfirmPassword == AccountCurrent.Password ? false : true;
        public void Save()
        {
            if (Accountbackup == null)
            {
                AccountCurrent.UserCreated = "Admin";
                AccountCurrent.TimeCreated = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                AccountServives.Insert(AccountCurrent);
            }
            else
            {
                AccountCurrent.UserModified = "Admin";
                AccountCurrent.TimeModified = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                AccountServives.Update(AccountCurrent);
            }

           (App.Current.MainWindow.DataContext as MainViewModel).AccountViewModel.SearchAccount();
           (App.Current.MainWindow.DataContext as MainViewModel).CloseDialog();
        }
    }
}
