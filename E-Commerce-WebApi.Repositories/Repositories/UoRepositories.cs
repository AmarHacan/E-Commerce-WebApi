using E_Commerce_WebApi.Repositories.Interfaces;

namespace E_Commerce_WebApi.Repositories.Repositories
{
    public class UoRepositories :IUoRepositories
    {

        public UoRepositories(IColorRepository colorRepository) {
            Colors = colorRepository;
        }
        public IColorRepository Colors { get;}
    }
}
