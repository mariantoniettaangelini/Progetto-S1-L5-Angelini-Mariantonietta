namespace Progetto
{
    internal class Program
    {
        static void Main()
        {

            Console.Write("Inserisci il tuo nome: "); 
            string nome = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo cognome: ");
            string cognome = Console.ReadLine();

            Console.WriteLine("Inserisci la tua data di nascita(aaaa/mm/gg): ");
            string d = Console.ReadLine();
            DateTime dataNascita = DateTime.Parse(d);

            Console.WriteLine("Inserisci il tuo codice fiscale: ");
            string codiceFiscale = Console.ReadLine();

            Console.WriteLine("Genere (Uomo, Donna, Altro): ");
            string g = Console.ReadLine();
            Sesso genere = (Sesso)Enum.Parse(typeof(Sesso), g, true);

            Console.WriteLine("Inserisci il tuo comune di residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.WriteLine("Inserisci il tuo reddito annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            Contribuente c = new Contribuente(nome, cognome, dataNascita, codiceFiscale, genere, comuneResidenza, redditoAnnuale);


            //CALCOLO IMPOSTA
            decimal imposta = c.CalcoloImposta();

            Console.WriteLine($"Nome del contribuente: {nome}");
            Console.WriteLine($"Cognome del contribuente: {cognome}");
            Console.WriteLine($"Data di nascita: {dataNascita.ToShortDateString}");
            Console.WriteLine($"C.F.: {codiceFiscale}");
            Console.WriteLine($"Genere: {genere}");
            Console.WriteLine($"Residente in {comuneResidenza}");
            Console.WriteLine($"Reddito dichiarato: {redditoAnnuale}");
            Console.WriteLine($"IMPOSTA DA PAGARE: {imposta}");

        }
    }
}
