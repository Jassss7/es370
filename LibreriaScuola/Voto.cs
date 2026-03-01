using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScuola
{
    public class Voto
    {
        public DateTime Data { get; set; }
        public Materia Materia { get; set; }
        public float Valore { get; set; }
            public override string ToString()
            {
                return $"Voto :{Valore} in {Materia.Nome} il {Data.ToShortDateString()}";
        }
    }
}
