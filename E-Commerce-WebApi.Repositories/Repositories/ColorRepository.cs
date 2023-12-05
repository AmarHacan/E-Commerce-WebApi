using E_Commerce_WebApi.Models.Color;
using E_Commerce_WebApi.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_WebApi.Repositories.Repositories
{
    public class ColorRepository : IColorRepository
    {

      

        public Task<int> AddAsync(Color entity)
        {
            Console.Write(this.GetType().Name +" : AddAsync() Method of ColorRepository");
            
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public List<Task<Color>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Color> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdateAsync(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
