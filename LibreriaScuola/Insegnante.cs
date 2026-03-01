using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScuola
{

    public class Insegnante : Persona
    {
        public List<Materia> Materie { get; set; }
        public override string ToString()
        {
            return $"Insegnante :{Nome} {Cognome}, nato il {DataDiNascita.ToShortDateString()}";
        }
    }
}
