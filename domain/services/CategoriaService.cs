using System.Collections.Generic;
using System.Threading.Tasks;
using supermercado.API.domain.models;
using supermercado.API.domain.services;
namespace Supermercado.API.services
{
    public class CategoriaService : IcategoriaService
    {
        public Task<IEnumerable<Categoria>> ListAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}