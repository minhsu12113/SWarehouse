using Dapper;
using SWarehouse.Models;
using SWarehouse.Services.Base;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Services.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplierRepository
    {
        public SupplierRepository(SQLiteConnection connection) : base(connection) { }

        public IEnumerable<Supplier> GetListWithPagePaging(string contentSearch, int limit, int offset)
        {
            int actualOffset = offset == 0 ? 0 : offset * limit;
            return DBServices.Query<Supplier>($@" SELECT * FROM Supplier
                                              Where Name LIKE @contentSearch
                                              LIMIT {limit} OFFSET {actualOffset}", new { contentSearch = $@"%{contentSearch}%" });
        }

        public int GetTotalCountWithName(string name) => DBServices.QueryFirst<int>("Select Count(*) From Supplier Where Name Like @name", new { name = $@"%{name}%" });
    }
}
