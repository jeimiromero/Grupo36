using System;
using Ganaderia.App.Dominio;
using Ganaderia.App.Persistencia;

namespace Ganaderia.App.Consola
{
    class Program
    {

        private static IRepositorioGanadero _repoGanadero = new RepositorioGanadero(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddGanadero();
            //GetAllGanaderos();
            //UpdateGanadero();
            DeleteGanadero(1003);
            //GetGanadero(1);
        }

        private static void AddGanadero() 
        {
            var ganadero = new Ganadero
            {
                Nombres = "Mario",
                Apellidos = "Herrera",
                NumeroTelefono = "3148596563",
                Direccion = "Kra 4 #45-12",
                Correo = "sergio.mintic@ucaldas.edu.co",
                Contrasena = "123456",
                Latitude = 7455,
                Longitud = 5333
            };
            _repoGanadero.AddGanadero(ganadero);
        }

        private static void GetAllGanaderos()
        {
            var ganaderos = _repoGanadero.GetAllGanaderos();
            foreach(Ganadero item in ganaderos)
            {
                Console.WriteLine(item.Nombres);
            }
        }

        private static void UpdateGanadero()
        {
            var ganadero = new Ganadero
            {
                Id = 2,
                Nombres = "Pedro",
                Apellidos = "Sanchez",
                NumeroTelefono = "3148596563",
                Direccion = "Kra 4 #45-12",
                Correo = "sergio.mintic@ucaldas.edu.co",
                Contrasena = "123456",
                Latitude = 7455,
                Longitud = 5333
            };

            _repoGanadero.UpdateGanadero(ganadero);
        }

        private static void DeleteGanadero(int idGanadero)
        {
            //var response = _repoGanadero.DeleteGanadero(idGanadero);
            string message = _repoGanadero.DeleteGanadero(idGanadero) ? "El ganadero se ha eliminado correctamemte" : "El ganadero no ha sido encontrado";
            Console.WriteLine(message);
            // if (response) 
            // {
            //     Console.WriteLine("El ganadero se ha eliminado correctamemte");
            // } else
            // {
            //     Console.WriteLine("El ganadero no ha sido encontrado");
            // }
        }

        private static void GetGanadero(int idGanadero)
        {
            var ganadero = _repoGanadero.GetGanadero(idGanadero);
            Console.WriteLine("El nombre del ganadero es: " + ganadero.Nombres);
        }
    }
}
