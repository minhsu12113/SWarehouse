﻿using SWarehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Services.Base
{
    public interface IProductRepository : IRepository<Product>
    {
        IEnumerable<Product> GetListWithPagePaging(string contentSearch, int limit, int offset);
        int GetTotalCountWithName(string name);
    }
}
