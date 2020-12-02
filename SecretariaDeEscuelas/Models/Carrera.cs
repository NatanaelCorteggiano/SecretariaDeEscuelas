using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int InstitutoId { get; set; }
        public Instituto Instituto { get; set; }
        public List<CarreraMateria> CarrerasMaterias { get; set; }
    }
}
