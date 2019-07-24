using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cthulhu.BL
{
    public class UsuariosBL
    {
        public List<Usuario> ObtenerUsuario()

        {
            var usuario = new Usuario();
            usuario.Nickname = "Mariale";
            usuario.Nombre = "Alejandra";
            usuario.Apellido = "Fajardo";
            usuario.Correo = "Maryalecf@gmail.com";
            usuario.Pass= "hola";
            var ListaUsuarios = new List<Usuario>();

            return ListaUsuarios;
        }
    }
}
