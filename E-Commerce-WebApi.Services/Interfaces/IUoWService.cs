using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_WebApi.Services.Interfaces
{
    public interface IUoWService
    {
        IColorService Colors { get; }
    }
}
