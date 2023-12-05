using E_Commerce_WebApi.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECoommerce.Services.Service
{
    public class UoWService : IUoWService
    {

        public UoWService(IColorService colorService) {
            Colors = colorService;
        }

        public IColorService Colors { get; }
    }
}
