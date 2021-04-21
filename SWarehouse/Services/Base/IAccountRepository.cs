using SWarehouse.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Services.Base
{
   public interface IAccountRepository : IRepository<Account>
   {
        int ChangePassword(Account acc);
        int SetRoles(Account ac);
        bool CheckValidAccount(Account acc);
        IEnumerable<Account> GetListWithPagePaging(string contentSearch, int limit, int offset);
        int GetTotalCountWithName(string name);
    }
}
