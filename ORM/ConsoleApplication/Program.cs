using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConexionDB;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes Cliente = new Clientes();
            
            Cliente.Name = "Juan";
            Cliente.Apellidos = "german hurado";
            Cliente.Telefono = "6600118868";
            Cliente.Correo = "SrSDDEs@gmail.evil";
            Cliente.Rfc = "ALNEe548de18";
            //string format = Cliente.Telefono + " Incorreto";

            Cliente.CreaTabla2();
            Cliente.Insert();
            //Console.WriteLine(format);
            Console.ReadKey();
        }
    }
}
