using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Proyecto_Experiencias_Formativas4.Models;
using Proyecto_Experiencias_Formativas4.Servicios.Contrato;

namespace Proyecto_Experiencias_Formativas4.Servicios.Implementacion
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbAccesoContext _dbContext;
        public UsuarioService(DbAccesoContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Usuario> GetUsuario(string nombre, string clave)
        {

            Usuario usuario_encontrado = await _dbContext.Usuarios.Where(u => u.Nombre == nombre && u.Clave == clave)
                 .FirstOrDefaultAsync();

            return usuario_encontrado;
        }

       public async Task<Usuario> SaveUsuario(Usuario modelo)
        {
            _dbContext.Usuarios.Add(modelo);
            await _dbContext.SaveChangesAsync();
            return modelo;
        }

    }

    
}
