using System;
using System.Linq;

namespace ProyectoFinal_PNT1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se agrega banda
            using (var prueba = new RecitalesContext())
            {
                var banda1 = new Banda()
                {
                    nombre = "Guns and Roses"

                };
                prueba.bandas.Add(banda1);
                prueba.SaveChanges();
            }
            Console.WriteLine("Banda agregada con exito!");
            Console.ReadKey(); 
        }
    }
}
