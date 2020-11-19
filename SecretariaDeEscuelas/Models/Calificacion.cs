using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class Calificacion
    {
        public int Id { get; set; }
        public double Nota { get; set; }        
        public int EstudianteId { get; set; }        
    }
}
