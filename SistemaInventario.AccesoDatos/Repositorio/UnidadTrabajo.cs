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
        public IBodegaRepositorio bodega { get; private set; }

        public UnidadTrabajo(ApplicationDbContext bd)
        {
            _bd = bd;
            bodega = new BodegaRepositorio(_bd);
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
