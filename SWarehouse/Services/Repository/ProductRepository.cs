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
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(SQLiteConnection connection) : base(connection) {  }

        public IEnumerable<Product> GetListWithPagePaging(string contentSearch, int limit, int offset)
        {
            int actualOffset = offset == 0 ? 0 : offset * limit;
            return DBServices.Query<Product>($@" Select p.id, p.Name, c.Name as CatName, 
                                                 s.Name as SupName, u.Name as UnitName, 
                                                 p.ImagePath , p.CatId, p.UnitId, p.SupId,
                                                 p.UserCreated, p.CreatedTime, p.UserModified, p.ModifiedTime 
                                                 From Product as p 
                                                 Join Category as c on c.Id = p.CatId
                                                 Join Supplier as s on s.Id = p.SupId
                                                 Join Unit as u on u.Id = p.UnitId 
                                                 Where p.Name LIKE @contentSearch
                                                 LIMIT {limit} OFFSET {actualOffset}", new { contentSearch = $@"%{contentSearch}%" });
        }

        public int GetTotalCountWithName(string name) => DBServices.QueryFirst<int>("Select Count(*) From Product Where Name Like @name", new { name = $@"%{name}%" });
    }
}
