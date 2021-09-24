using System;
using Ganaderia.App.Dominio;
using System.Collections.Generic;

namespace Ganaderia.App.Persistencia
{
    public interface IRepositorioGanadero
    {
        Ganadero AddGanadero(Ganadero ganadero);

        IEnumerable<Ganadero> GetAllGanaderos();

        Ganadero UpdateGanadero(Ganadero ganadero);

        Boolean DeleteGanadero(int idGanadero);

        Ganadero GetGanadero(int idGanadero);
    }
}