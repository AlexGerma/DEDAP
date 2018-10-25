using System;
using ConexionDB;

namespace Columns
{
    class Program
    {
        static void Main(string[] args)
        {
            Clientes Cliente = new Clientes();
            
            Cliente.Name = "Alexis";
            Cliente.Apellidos = "Juhan Dragen";
            Cliente.Telefono = "666 666 666";
            Cliente.Correo = "SrOscuridad@gmail.evil";
            Cliente.Rfc = "ALEXIS007";
            string format = Cliente.Telefono + " Incorreto";

            Cliente.CreaTabla2();
            Console.WriteLine(format);
            Console.ReadKey();
        }
             
        
    }
  
}
