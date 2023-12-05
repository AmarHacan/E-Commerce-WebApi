using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoommerce.Repository.HttpClientContext
{
    internal interface IGenericHttpClientContext<T> where T :class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int Id);
        Task<T> AddAsync(T item);
        Task<T> UpdateAsync(T item);
        Task<int> DeleteAsync(T item);


    }
}
