using SWarehouse.Utilitys;
using SWarehouse.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Models
{
    public class Product : BindableBase
    {
        private String _id = Guid.NewGuid().ToString();
        private String _name;
        private String _imagePath;
        private String _catId;
        private String _catName;
        private String _unitId;
        private String _unitName;
        private String _supId;
        private String _supName;
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

        public String CatId
        {
            get { return _catId; }
            set { _catId = value; OnPropertyChanged(); }
        }

        [CustomAttribute("Is Ignore")]
        public String CatName
        {
            get { return _catName; }
            set { _catName = value; OnPropertyChanged(); }
        }

        public String UnitId
        {
            get { return _unitId; }
            set { _unitId = value; OnPropertyChanged(); }
        }

        [CustomAttribute("Is Ignore")]
        public String UnitName
        {
            get { return _unitName; }
            set { _unitName = value; OnPropertyChanged(); }
        }

        public String SupId
        {
            get { return _supId; }
            set { _supId = value; OnPropertyChanged(); }
        }

        [CustomAttribute("Is Ignore")]
        public String SupName
        {
            get { return _supName; }
            set { _supName = value; OnPropertyChanged(); }
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

        public String CreatedTime
        {
            get { return _createdTime; }
            set { _createdTime = value; OnPropertyChanged(); }
        }

        public String ModifiedTime
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
