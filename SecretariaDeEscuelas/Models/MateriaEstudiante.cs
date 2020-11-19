using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class MateriaEstudiante
    {
        public int MateriaId { get; set; }
        public int EstudianteId { get; set; }
        public int CalificacionId { get; set; }
        public Estudiante Estudiante { get; set; }
        public Materia Materia { get; set; }
        public Calificacion Calificacion { get; set; }
    }
}
