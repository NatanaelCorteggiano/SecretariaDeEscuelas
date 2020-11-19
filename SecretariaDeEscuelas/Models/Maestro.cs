using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class Maestro
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }        
        public List<Materia> Materias { get; set; }
    }
}
