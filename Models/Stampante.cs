namespace WPFStampante.Models
{
    /*    
   - 4 serbatoi di colore: CMYB e un cassetto di fogli (tutte property int)
   - un metodo int StatoInchiostro( Colore c ) che torna la quantità di inchiostro presente nei 4 serbatoi.
   - un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
   - un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
   - un metodo void AggiungiCarta( int qta ) che aggiunge fogli fino ad un max di 200
   */
    public class Stampante
    {

        public int Fogli;
        //ciano = 0,yellow = 1, magenta = 2, nero = 3
        public int[] Inchiostro { get; set; }
        public Stampante()
        {
            Inchiostro = new int[4] { 100, 100, 100, 100 };
            Fogli = 200;
        }
        //- un metodo bool Stampa( Pagina p ) (che torna false, se l'inchiostro non è sufficiente per stampare)
        public bool Stampa(Pagina p)
        {
            if (Fogli > 0 && (Inchiostro[0] >= p.C && Inchiostro[1] >= p.Y && Inchiostro[2] >= p.M && Inchiostro[3] >= p.B))
            {
                Inchiostro[0] -= p.C;
                Inchiostro[1] -= p.Y;
                Inchiostro[2] -= p.M;
                Inchiostro[3] -= p.B;
                Fogli--;
                return true;
            }
            return false;
        }
        //un metodo int StatoInchiostro( Colore c ) che torna la quantità di inchiostro presente nei 4 serbatoi.
        public int StatoInchiostro(int c)
        {
            return Inchiostro[c];
        }
        //un metodo int StatoCarta() che mi ritorna la quantità di fogli nel cassetto
        public int StatoCarta()
        {
            return Fogli;
        }
        //un metodo void SostituisciColore( Colore c ) che rimpiazza un serbatoio di inchiostro e lo riporta a 100
        public void SostituisciColore(int c)
        {
            Inchiostro[c] = 100;
        }
        //un metodo void AggiungiCarta( int qta ) che aggiunge fogli fino ad un max di 200
        public void AggiungiCarta(int qta)
        {
            if (qta > 0 && (qta + Fogli) <= 200)
            {
                Fogli += qta;
            }

        }
    }
}
