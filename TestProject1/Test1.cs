using LibreriaScuola;
using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
namespace TestProject1
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
      
        public void GetMedia_RitornaMediaCorretta()
        {
            Materia italiano = new Materia { Nome = "Italiano", Sigla = "IT" };
            Materia edcivica = new Materia { Nome = "Eucazione civica", Sigla = "Ed.civica" };

            var studente = new Studente
            {
                Voti = new List<Voto>
                {
                    new Voto { Valore = 6, Data = new DateTime(2024, 1, 10), Materia = italiano },
                    new Voto { Valore = 8, Data = new DateTime(2026, 2, 10), Materia = edcivica }
                }
            };

            Scuola scuola = new Scuola();

            float risultato = scuola.GetMedia(studente);

            Assert.AreEqual((float)7, risultato);
        }

        [TestMethod]
        public void GetMediaAnno_RitornaMediaCorretta()
        {
            Materia italiano = new Materia { Nome = "Italiano", Sigla = "IT" };
            Materia edcivica = new Materia { Nome = "Eucazione civica", Sigla = "Ed.civica" };

            var studente = new Studente
            {
                Voti = new List<Voto>
                {
                    new Voto { Valore = 6, Data = new DateTime(2024, 1, 10), Materia = italiano },
                    new Voto { Valore = 8, Data = new DateTime(2024, 2, 10), Materia = edcivica }
                }
            };

            Scuola scuola = new Scuola();

            float risultato = scuola.GetMediaAnno(studente, 2024);

            Assert.AreEqual((float)7, risultato);
        }


    }
    

}
    
    

