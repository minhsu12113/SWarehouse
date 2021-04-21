using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models
{
    public class Category : BindableBase
    {
        private String _id = Guid.NewGuid().ToString();
        private String _name;
        private String _userCreated;
        private String _timeCreated;
        private String _userModified;
        private String _timeModified;


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
        public String UserCreated
        {
            get { return _userCreated; }
            set { _userCreated = value; OnPropertyChanged(); }
        }
        public String CreatedTime
        {
            get { return _timeCreated; }
            set { _timeCreated = value; OnPropertyChanged(); }
        }
        public String UserModified
        {
            get { return _userModified; }
            set { _userModified = value; OnPropertyChanged(); }
        }
        public String ModifiedTime
        {
            get { return _timeModified; }
            set { _timeModified = value; OnPropertyChanged(); }
        }
    }
}
