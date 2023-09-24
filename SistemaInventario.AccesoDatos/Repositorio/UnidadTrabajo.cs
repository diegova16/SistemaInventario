using SistemaInventario.AccesoDatos.Data;
using SistemaInventario.AccesoDatos.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio
{
    public class UnidadTrabajo : IUnidadTrabajo
    {
        
        private readonly ApplicationDbContext _bd;
        
        public IBodegaRepositorio Bodega { get; private set; }

        public ICategoriaRepositorio Categoria { get; private set; }

        public IMarcaRepositorio Marca { get; private set; }

        public IProductoRepositorio Producto { get; private set; }

        public UnidadTrabajo(ApplicationDbContext bd)
        {
            _bd = bd;
            Bodega = new BodegaRepositorio(_bd);
            Categoria = new CategoriaRepositorio(_bd);
            Marca = new MarcaRepositorio(_bd);
            Producto = new ProductoRepositorio(_bd);
        }

        public void Dispose()
        {
            _bd.Dispose();
        }

        public async Task Guardar()
        {
            await _bd.SaveChangesAsync();
        }
    }
}
