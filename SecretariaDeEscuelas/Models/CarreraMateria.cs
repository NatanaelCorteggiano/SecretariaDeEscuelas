using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class CarreraMateria
    {
        public int CarreraId { get; set; }
        public int MateriaId { get; set; }
        public Carrera Carrera { get; set; }
        public Materia Materia { get; set; }
    }
}
