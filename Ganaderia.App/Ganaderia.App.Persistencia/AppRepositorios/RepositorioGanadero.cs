using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;
using System.Linq;

namespace Ganaderia.App.Persistencia
{
    public class RepositorioGanadero : IRepositorioGanadero
    { 

        private readonly AppContext _appContext;

        public RepositorioGanadero(AppContext appContext)
        {
            _appContext = appContext;
        }

        Ganadero IRepositorioGanadero.AddGanadero(Ganadero ganadero)
        {
            var ganaderoAdicionado = _appContext.Ganaderos.Add(ganadero);
            _appContext.SaveChanges();
            return ganaderoAdicionado.Entity;
        }

        IEnumerable<Ganadero> IRepositorioGanadero.GetAllGanaderos()
        {
            return _appContext.Ganaderos;
        }

        Ganadero IRepositorioGanadero.UpdateGanadero(Ganadero ganadero)
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == ganadero.Id);
            if (ganaderoEncontrado != null)
            {
                ganaderoEncontrado.Nombres = ganadero.Nombres;
                ganaderoEncontrado.Apellidos = ganadero.Apellidos;
                ///////////////
                _appContext.SaveChanges();
            }
            return ganaderoEncontrado;
        }

        Boolean IRepositorioGanadero.DeleteGanadero(int idGanadero) {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);
            if (ganaderoEncontrado != null)
            {
                _appContext.Ganaderos.Remove(ganaderoEncontrado);
                _appContext.SaveChanges();

                return true;
            } 
            return false;
        }

        Ganadero IRepositorioGanadero.GetGanadero(int idGanadero) 
        {
            var ganaderoEncontrado = _appContext.Ganaderos.FirstOrDefault(g => g.Id == idGanadero);
            return ganaderoEncontrado;
        }
    }
}