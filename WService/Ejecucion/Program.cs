using Entidades;
using Negocios;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Users> us = new List<Users>();
            Service1 serv = new Service1();
            us = serv.user();
        }
    }
}
