﻿using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Proveedor
    {
        private CD_Proveedor objcd_proveedor = new CD_Proveedor();
        public List<Proveedor> Listar()
        {
            return objcd_proveedor.Listar();
        }

        public int Registrar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesaria la Razón Social del Proveedor\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario la telefono del Proveedor\n";
            }
            if (Mensaje != string.Empty)
            {
                return 0;
            }

            return objcd_proveedor.Registrar(obj, out Mensaje);
        }

        public bool Editar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;

            if (obj.Documento == "")
            {
                Mensaje += "Es necesario el documento del Proveedor\n";
            }

            if (obj.RazonSocial == "")
            {
                Mensaje += "Es necesario la Razón Social del Proveedor\n";
            }
            if (obj.Correo == "")
            {
                Mensaje += "Es necesario el correo del Proveedor\n";
            }
            if (obj.Telefono == "")
            {
                Mensaje += "Es necesario la telefono del Proveedor\n";
            }
            if (Mensaje != string.Empty)
            {
                return false;
            }

            return objcd_proveedor.Editar(obj, out Mensaje);
        }

        public bool Eliminar(Proveedor obj, out string Mensaje)
        {
            Mensaje = string.Empty;
            return objcd_proveedor.Eliminar(obj, out Mensaje);
        }
    }
}
