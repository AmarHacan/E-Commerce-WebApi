using E_Commerce_WebApi.Models.Color;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ECoommerce.Repository.HttpClientContext
{
    internal class ColorContext : IColorContext
    {
        private readonly HttpClient _httpClient;

        public ColorContext(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public Task<Color> AddAsync(Color item)
        {
            throw new NotImplementedException();
        }

        public Task<int> DeleteAsync(Color item)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Color>> GetAllAsync()
        {
            List<Color> colorList = new();
            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://localhost:7036/api/Color'");
            httpRequestMessage.Method = HttpMethod.Get;

            HttpResponseMessage response = await _httpClient.SendAsync(httpRequestMessage);
            if(response.IsSuccessStatusCode)
            {
                colorList = await response.Content.ReadFromJsonAsync<List<Color>>();
            }

            return colorList!;
        }

        public Task<Color> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<Color> UpdateAsync(Color item)
        {
            throw new NotImplementedException();
        }
    }
}
