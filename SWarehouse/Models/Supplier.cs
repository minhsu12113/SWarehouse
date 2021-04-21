using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models
{
    public class Supplier : BindableBase
    {
        private String _id = Guid.NewGuid().ToString();
        private String _name;
        private String _phone;
        private String _address;
        private String _userCreated;
        private String _userModified;
        private String _createdTime;
        private String _modifiedTime;



        public String Id
        {
            get { return _id; }
            set { _id = value; OnPropertyChanged(); }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; OnPropertyChanged(); }
        }
        public String Phone
        {
            get { return _phone; }
            set { _phone = value; OnPropertyChanged(); }
        }
        public String Address
        {
            get { return _address; }
            set { _address = value; OnPropertyChanged(); }
        }
        public String UserCreated
        {
            get { return _userCreated; }
            set { _userCreated = value; OnPropertyChanged(); }
        }
        public String UserModified
        {
            get { return _userModified; }
            set { _userModified = value; OnPropertyChanged(); }
        }
        public String ModifiedTime
        {
            get { return _modifiedTime; }
            set { _modifiedTime = value; OnPropertyChanged(); }
        }
        public String CreatedTime
        {
            get { return _createdTime; }
            set { _createdTime = value; OnPropertyChanged(); }
        }
    }
}
