using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoommerce.Repository.HttpClientContext
{
    internal class GenericHttpClientContext<T> : IGenericHttpClientContext<T> where T : class
    {
        public Task<T> AddAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(T item)
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<T> UpdateAsync(T item)
        {
            throw new NotImplementedException();
        }
    }
}
