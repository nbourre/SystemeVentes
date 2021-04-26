using System;
using System.Collections.Generic;
using System.Text;

namespace SystemeVentes.Services
{
    public interface IDataService<T>
    {
        IEnumerable<T> GetAll();
        bool Insert(T record);
        bool UpdateOrInsert(T record);
        bool Delete(T record);
        bool Save();
    }
}
