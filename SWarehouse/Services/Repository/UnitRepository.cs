using SWarehouse.Models;
using Dapper;
using SWarehouse.Services.Base;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace SWarehouse.Services.Repository
{
    public class UnitRepository : Repository<Unit>, IUnitRepository
    {
        public UnitRepository(SQLiteConnection connection): base(connection) { }

        public IEnumerable<Unit> GetListWithPagePaging(string contentSearch, int limit, int offset)
        {
            int actualOffset = offset == 0 ? 0 : offset * limit;
            return DBServices.Query<Unit>($@" SELECT * FROM Unit
                                              Where Name LIKE @contentSearch
                                              LIMIT {limit} OFFSET {actualOffset}", new { contentSearch = $@"%{contentSearch}%" });
        }

       
        public int GetTotalCountWithName(string name) => DBServices.QueryFirst<int>("Select Count(*) From Unit Where Name Like @name", new { name = $@"%{name}%" });
    }
}
