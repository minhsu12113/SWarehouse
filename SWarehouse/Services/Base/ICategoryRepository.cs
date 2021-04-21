using SWarehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Services.Base
{
    public interface ICategoryRepository : IRepository<Category>
    {
        IEnumerable<Category> GetListWithPagePaging(string contentSearch, int limit, int offset);
        int GetTotalCountWithName(string name);
    }
}
