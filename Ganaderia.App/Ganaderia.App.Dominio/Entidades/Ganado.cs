using System.Collections.Generic;

namespace Ganaderia.App.Dominio
{
    public class Ganado
    {
        public int Id { get; set; }
        public string Raza { get; set; }
        public string Alias { get; set; }
        public int Cantidad { get; set; }
        public Veterinario Veterinario { get; set; }
        public List<Vacuna> Vacunas { get; set; }

    }
}