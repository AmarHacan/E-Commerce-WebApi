using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_WebApi.Repositories.Interfaces
{
    public interface IGenericsRepository<T> where T : class
    {
        //here i will have 5 methods to implement crud to model / buisness logic / domain model

        //query begin
        Task<T> GetByIdAsync(int id);
        List<Task<T>> GetAllAsync();
        //query end

        //execute begin
        Task<int> AddAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteAsync(int id);
        //execute end
    }
}
