using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinForm3.Modelo;

namespace WinForm3.Informacion
{
    public class Usuario
    {
        List<UsuarioModel> lista = new List<UsuarioModel>();
        /// <summary>
        /// Guarda los usuarios
        /// </summary>
        /// <param name="modelo">datos del usuario</param>
        public void Guardar(UsuarioModel modelo)
        {
            lista.Add(modelo);
        }
        /// <summary>
        /// consulta todos los usuarios 
        /// </summary>
        /// <returns>datos de usuario </returns>
        public List<UsuarioModel> Consultar()
        {
            return lista;
        }
    }
}
