using Proyecto_Experiencias_Formativas4.Models;

namespace Proyecto_Experiencias_Formativas4.Servicios.Contrato
{
    public interface IUsuarioService
    {
        Task<Usuario> GetUsuario(string nombre, string clave);
        Task<Usuario> SaveUsuario(Usuario modelo);
    }
}
