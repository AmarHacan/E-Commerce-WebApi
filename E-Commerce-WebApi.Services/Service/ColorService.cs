using E_Commerce_WebApi.Models.Color;
using E_Commerce_WebApi.Repositories.Interfaces;
using E_Commerce_WebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_WebApi.Services.Service
{
    public class ColorService : IColorService
    {
        private readonly IUoRepositories _uoRepositories;

        public ColorService(IUoRepositories UoRepositories) {
            _uoRepositories = UoRepositories;
        }
        public Task<int> AddAsync(Color entity)
        {
            Console.WriteLine(this.GetType().FullName + " : _uoRepositories.Colors.AddAsync(entity)");

            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Color>> GetAllAsync()
        {
            _uoRepositories.Colors.GetAllAsync();
            Console.WriteLine(this.GetType().FullName + " : _uoRepositories.Colors.AddAsync(entity)");
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
