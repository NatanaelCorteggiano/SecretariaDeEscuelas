using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int MaestroId { get; set; }
        public List<CarreraMateria> CarrerasMaterias { get; set; }
        public Maestro Maestro { get; set; }
    }
}
