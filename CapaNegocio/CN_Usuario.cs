using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario objcd_usuario = new CD_Usuario();
        public List<Usuario> Listar()
        {
            return objcd_usuario.Listar();
        }

        public int Registrar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "") {
                Mensaje += "Es necesaio el documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesaio el Nombre del usuario\n";
            }

            if(obj.Clave == "")
            {
                Mensaje += "Es necesaio la clave del usuario\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }

            return objcd_usuario.Registrar(obj, out Mensaje);
        }

        public bool Editar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesaio el documento del usuario\n";
            }

            if (obj.NombreCompleto == "")
            {
                Mensaje += "Es necesaio el Nombre del usuario\n";
            }

            if (obj.Clave == "")
            {
                Mensaje += "Es necesaio la clave del usuario\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }

            return objcd_usuario.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Usuario obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            return objcd_usuario.Eliminar(obj, out Mensaje);
        }
    }
}
