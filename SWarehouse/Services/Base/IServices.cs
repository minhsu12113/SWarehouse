using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWarehouse.Services.Base
{
    public interface IServices<T>
    {
        int Insert(T data);
        int Update(T data);
        int Delete(T data);
        T FindById(String id);
        IEnumerable<T> GetAll();
    }
}
