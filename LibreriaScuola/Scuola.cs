namespace LibreriaScuola
{
    public class Scuola
    {
        public List<Insegnante> Insegnanti { get; set; } = new List<Insegnante>();
        public List<Studente> Studenti { get; set; } = new List<Studente>();
        public List<Materia> Materie { get; set; } = new List<Materia>();
        public float GetMedia(Studente studente)
        {
            if (studente.Voti.Count == 0) throw new Exception("errore,lo studente non ha voti.");
            float somma = 0;
         
            foreach (var voto in studente.Voti)
            {
                
               
                    somma += voto.Valore;
                    
                
            }
            return somma / (float)studente.Voti.Count;
        }
        public float GetMediaAnno(Studente s , int anno)
        {
            if (s.Voti.Count == 0) throw new Exception("errore,lo studente non ha voti.");
            float somma = 0;
        
            int count = 0;
            foreach (var voto in s.Voti)
            {

                if (voto.Data.Year == anno) { 
                        somma += voto.Valore;
                        count++;
                }

            }
            if (count == 0) throw new Exception($"errore,lo studente non risulta avere voti nell'anno {anno}.");
            return somma / (float)count;
        }
    }
}
