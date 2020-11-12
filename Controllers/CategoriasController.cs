using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Supermercado.APÍ.domain.models;
using Supermercado.APÍ.domain.models.services;

namespace Supermercado.API.Controllers
{
    [Route("/api/[controller]")]

    public class CategoriasController : Controller
    {
        private readonly ICategoriaService _categoriaService;

        public CategoriasController(ICategoriaService _categoriaService)
        {
            _categoriaService = categoriaService;
        }

        [HttpGet]

        public async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            var categorias = await _categoriaService.ListAsync();
            return categorias;
        }
    }

}

