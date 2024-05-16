using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ErrorDeConexionException:Exception
    {
        public ErrorDeConexionException()
            :base("Error al conectar la base de datos")
        {
            
        }

    }
}
