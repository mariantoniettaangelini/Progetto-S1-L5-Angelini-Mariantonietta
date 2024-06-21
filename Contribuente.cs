using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progetto
{
    enum Sesso
    {
        Uomo, Donna, Altro
    }
    internal class Contribuente
    {
        public string Nome { get; set; }
        public string  Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string CodiceFiscale { get; set; }
        public Sesso Genere { get; set; }
        public string ComuneResidenza { get; set; }
        public decimal RedditoAnnuale { get; set; }

        public Contribuente (string nome, string cognome, DateTime dataNascita, string codiceFiscale, Sesso genere, string comuneResidenza, decimal redditoAnnuale)
        {
            Nome = nome;
            Cognome = cognome;
            DataNascita = dataNascita;
            CodiceFiscale = codiceFiscale;
            Genere = genere;
            ComuneResidenza = comuneResidenza;
            RedditoAnnuale = redditoAnnuale;
        }

        //CALCOLO IMPOSTA DA PAGARE
        public decimal CalcoloImposta()
        {
            decimal imposta = 0;

            //Reddito da 0 a 15k
            if (RedditoAnnuale <= 15000)
            {
                imposta = RedditoAnnuale * 0.23m;
            }

            //Reddito da 15k a 28k
            else if (RedditoAnnuale <= 28000)
            {
                imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;            
            }

            //Reddito da 28k a 55k
            else if (RedditoAnnuale <= 55000)
            {
                imposta = 6960 + (28000 - 15000) * 0.27m + (RedditoAnnuale - 28000) * 0.38m;
            }

            //Reddito da 55k a 75k
            else if (RedditoAnnuale <= 75000)
            {
                imposta = 17200 + (28000 - 15000) * 0.27m + (55000 - 28000) * 0.38m + (RedditoAnnuale - 55000) * 0.41m;
            }

            //Reddito oltre 75k
            else {
                imposta = 25420 + (28000 - 15000) * 0.27m + (55000 - 28000) * 0.38m + (75000 - 55000) * 0.41m + (RedditoAnnuale - 75000) * 0.43m;
            }

            return imposta;
        }
    }
}
