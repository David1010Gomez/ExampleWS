using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Contexto
{
    public interface IContext: System.IDisposable
    {
        System.Data.Entity.DbSet<Users> Usuarios { get; set; }
    }
}
