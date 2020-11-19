using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }        
        public List<MateriaEstudiante> MateriasEstudiantes { get; set; }
        public List<Calificacion> Calificaciones { get; set; }
    }
}
