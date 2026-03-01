using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScuola
{
    public class Studente : Persona
    {
        public List<Voto> Voti { get; set; }
        public override string ToString()
        {
            return $"Studente :{Nome} {Cognome}, nato il {DataDiNascita.ToShortDateString()}";
        }
    }
}
