using Datos.Contexto;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    public class NegocioMetodos
    {
        public List<Users> user()
        {
            Contexto ctx = new Contexto();

            return ctx.Usuarios.ToList();

        }
    }
}
