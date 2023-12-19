# Progetto WPF Stampante

Questo progetto **WPF** implementa un'applicazione di simulazione per una stampante, consentendo agli utenti di stampare pagine e monitorare lo stato.

## Struttura del Codice

### MainWindow.xaml.cs

Il file `MainWindow.xaml.cs` contiene la logica dietro l'interfaccia utente dell'applicazione, inclusi i gestori degli eventi dei pulsanti e i metodi di interazione con la classe `Stampante` e `Pagina`.

### MainWindow.xaml

Il file `MainWindow.xaml` definisce la struttura dell'interfaccia utente dell'applicazione. Qui sono presenti i controlli e gli elementi visivi che consentono agli utenti di interagire con la simulazione della stampante.

### Stampante.cs

Il file `Stampante.cs` contiene la definizione della classe `Stampante`, che rappresenta la stampante virtuale. La classe ha le seguenti caratteristiche:

- **Proprietà:**
  - `Fogli`: La quantità di fogli nel cassetto.
  - `Inchiostro`: Un array che rappresenta i quattro serbatoi di colore (Ciano, Magenta, Giallo, Nero).

- **Metodi:**
  - `Stampa(Pagina p)`: Un metodo che tenta di stampare una pagina, consumando inchiostro e fogli. Ritorna `true` se la stampa è riuscita, altrimenti `false`.
  - `StatoInchiostro(int c)`: Un metodo che restituisce la quantità di inchiostro presente in un determinato serbatoio di colore.
  - `StatoCarta()`: Un metodo che restituisce la quantità di fogli nel cassetto.
  - `SostituisciColore(int c)`: Un metodo che rimpiazza un serbatoio di inchiostro specifico, riportandolo al valore massimo (100).
  - `AggiungiCarta(int qta)`: Un metodo che aggiunge fogli fino a un massimo di 200 nel cassetto.

### Pagina.cs

Il file `Pagina.cs` contiene la definizione della classe `Pagina`, che rappresenta una pagina da stampare. La classe ha le seguenti caratteristiche:

- **Proprietà:**
  - `C`, `M`, `Y`, `B`: Attributi che rappresentano i colori (Ciano, Magenta, Giallo, Nero) della pagina.

- **Costruttori:**
  - `Pagina(int C, int M, int Y, int B)`: Un costruttore che accetta colori specifici (massimo valore 3) per la pagina.
  - `Pagina()`: Un costruttore che crea una pagina con colori generati casualmente.
