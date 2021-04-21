using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Services
{
    public class DbHelper
    {
        #region [Implementation Singleton]
        private DbHelper() { }
        private static DbHelper _instance;
        public static DbHelper Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DbHelper();
                return _instance;
            }
        }
        #endregion


        private List<String> SQLTableList { get; set; } = new List<string>()
        {
             @"Create Table Account(
               Id text,
               UserName text,
               Password text,
               UserCreated text,
               TimeCreated text,
               UserModified text,
               TimeModified text,
               ImagePath text)",
             @"Create Table Supplier(
               Id text,
               Name text,
               Phone text,
               Address text,
               UserCreated text,
               UserModified text,
               CreatedTime text,
               ModifiedTime text)",
             @"Create Table Unit(
               Id text,
               Name text,
               UserCreated text,
               UserModified text,
               CreatedTime text,
               ModifiedTime text)",
             @"Create Table Category(
               Id text,
               Name text,
               UserCreated text,
               UserModified text,
               CreatedTime text,
               ModifiedTime text)",
             @"Create Table Product(
               Id text,
               Name text,
               CatId text,
               UnitId text,
               SupId text,
               UserCreated text,
               UserModified text,
               CreatedTime text,
               ModifiedTime text,
               ImagePath text)"
        };
        private String DbFile { get; set; } = Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6), "Warehouse_DB.sqlite");
        
        private String ConnectString { get; set; } = "Data Source =" + Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase).Substring(6), "Warehouse_DB.sqlite");
        public bool IsExistsDb() => File.Exists(DbFile);
        public void CreateDatabase()
        {
            if (!IsExistsDb())
            {
                SQLiteConnection.CreateFile(DbFile);
                using (var connection = new SQLiteConnection(ConnectString))
                {
                    connection.Open();
                    SQLTableList?.ForEach((sql) => new SQLiteCommand(sql, connection).ExecuteNonQuery());
                    connection.Close();
                }
            }
        }
        public SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(ConnectString);
        }
    }
}
