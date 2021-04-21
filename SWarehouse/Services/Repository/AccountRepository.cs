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
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(SQLiteConnection connection): base(connection) { }

        public int ChangePassword(Account acc)
        {
            throw new NotImplementedException();
        }

        public int SetRoles(Account ac)
        {
            throw new NotImplementedException();
        }

        public bool CheckValidAccount(Account acc) => true;

        public IEnumerable<Account> GetListWithPagePaging(string contentSearch, int limit, int offset)
        {
            int actualOffset = offset == 0 ? 0 : offset * limit;
            return DBServices.Query<Account>($@" SELECT * FROM Account
                                              Where UserName LIKE @contentSearch
                                              LIMIT {limit} OFFSET {actualOffset}", new { contentSearch = $@"%{contentSearch}%" });
        }

        public int GetTotalCountWithName(string name) => DBServices.QueryFirst<int>("Select Count(*) From Account Where UserName Like @name", new { name = $@"%{name}%" });
    }
}
