using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioVeterinario : IRepositorioVeterinario
    { 

        private readonly AppContext _appContext;

        public RepositorioVeterinario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Veterinario IRepositorioVeterinario.AddVeterinario(Veterinario veterinario)
        {
            var veterinarioAdicionado = _appContext.Veterinarios.Add(veterinario);
            _appContext.SaveChanges();
            return veterinarioAdicionado.Entity;
        }

        // IEnumerable<Veterinario> IRepositorioVeterinario.GetAllVeterinarios()
        // {
        //     return _appContext.Veterinarios;
        // }

        // Veterinario IRepositorioVeterinario.UpdateVeterinario(Veterinario veterinario)
        // {
        //     var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.Id == veterinario.Id);
        //     if (veterinarioEncontrado != null)
        //     {
        //         veterinarioEncontrado.Nombres = veterinario.Nombres;
        //         veterinarioEncontrado.Apellidos = veterinario.Apellidos;
        //         ///////////////
        //         _appContext.SaveChanges();
        //     }
        //     return veterinarioEncontrado;
        // }

        // Boolean IRepositorioVeterinario.DeleteVeterinario(int idVeterinario) {
        //     var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.Id == idVeterinario);
        //     if (veterinarioEncontrado != null)
        //     {
        //         _appContext.Veterinarios.Remove(veterinarioEncontrado);
        //         _appContext.SaveChanges();

        //         return true;
        //     } 
        //     return false;
        // }

        // Veterinario IRepositorioVeterinario.GetVeterinario(int idVeterinario) 
        // {
        //     var veterinarioEncontrado = _appContext.Veterinarios.FirstOrDefault(g => g.Id == idVeterinario);
        //     return veterinarioEncontrado;
        // }
    }
}