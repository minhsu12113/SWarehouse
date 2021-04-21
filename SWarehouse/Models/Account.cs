using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models
{
    public class Account : BindableBase
    {
        private String _id = Guid.NewGuid().ToString();
        private String _userName;
        private String _password;
        private String _createdTime;
        private String _modifiedTime;
        private String _userModified;
        private String _userCreated;
        private String _imagePath;


        public String Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }

        public String UserName
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged(); }
        }

        public String Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }

        public String UserCreated
        {
            get { return _userCreated; }
            set { _userCreated = value; OnPropertyChanged(); }
        }

        public String TimeCreated
        {
            get { return _createdTime; }
            set { _createdTime = value; OnPropertyChanged(); }
        }

        public String UserModified
        {
            get { return _userModified; }
            set { _userModified = value; OnPropertyChanged(); }
        }

        public String TimeModified
        {
            get { return _modifiedTime; }
            set { _modifiedTime = value; OnPropertyChanged(); }
        }

        public String ImagePath
        {
            get { return _imagePath; }
            set { _imagePath = value; OnPropertyChanged(); }
        }
    }
}
