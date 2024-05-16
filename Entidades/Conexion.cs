using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Conexion
    {
        public static string ConectarABaseDeDato(bool conectar) 
        {
            string respuesta = string.Empty;
            if (conectar)
            {
                respuesta = conectar.ToString();
            }
            else 
            {
                throw new ErrorDeConexionException();
            }

            return respuesta;

        }

    }
}
