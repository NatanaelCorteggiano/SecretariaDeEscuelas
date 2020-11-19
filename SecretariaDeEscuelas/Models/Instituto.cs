using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecretariaDeEscuelas.Models
{
    public class Instituto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public Carrera Carrera { get; set; }
    }
}
