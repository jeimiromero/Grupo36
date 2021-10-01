using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Ganaderia.App.Dominio;

namespace Ganaderia.App.Presentacion.Pages
{

    public class RegisterModel : PageModel
    {
        public List<Ganadero> Ganaderos { get; set; }

        public String tipoPerfil = "Veterinario";
        public void OnGet()
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

            var ganadero2 = new Ganadero
            {
                Nombres = "Pedro",
                Apellidos = "Rodriguez",
                NumeroTelefono = "3148596563",
                Direccion = "Kra 4 #45-12",
                Correo = "Pedro@ucaldas.edu.co",
                Contrasena = "123456",
                Latitude = 7455,
                Longitud = 5333
            };

            var ganadero3 = new Ganadero
            {
                Nombres = "James",
                Apellidos = "Sanchez",
                NumeroTelefono = "3148596563",
                Direccion = "Kra 4 #45-12",
                Correo = "James@ucaldas.edu.co",
                Contrasena = "123456",
                Latitude = 7455,
                Longitud = 5333
            };

            Ganaderos = new List<Ganadero>();
            Ganaderos.Add(ganadero);
            Ganaderos.Add(ganadero2);
            Ganaderos.Add(ganadero3);
        }
    }
}
