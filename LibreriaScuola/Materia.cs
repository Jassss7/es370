using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaScuola
{

    public class Materia
    {
        public string Nome { get; set; }
        public string Sigla { get; set; }
            public override string ToString()
            {
                return $"Materia :{Nome} ({Sigla})";
        }
    }
}
