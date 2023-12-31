# Progetto WPF Stampante

## Descrizione

Questo progetto implementa due classi principali, `Stampante` e `Pagina`, che simulano il funzionamento di una stampante a colori. La stampante ha quattro serbatoi di inchiostro per i colori Ciano, Magenta, Giallo e Nero (abbreviati come CMYB) e un cassetto di fogli. La classe `Pagina` rappresenta una pagina da stampare con attributi CMYB.

## Struttura del Codice

### MainWindow.xaml.cs

Il file `MainWindow.xaml.cs` contiene la logica dietro l'interfaccia utente dell'applicazione, inclusi i gestori degli eventi dei pulsanti e i metodi di interazione con la classe `Stampante` e `Pagina`.

#### `MainWindow()`

Il costruttore inizializza la finestra principale e crea un'istanza della classe `Stampante`.

#### `Stampa_Click(object sender, RoutedEventArgs e)`

Gestisce l'evento di clic sul pulsante "Stampa". Crea una nuova istanza della classe `Pagina` utilizzando i valori inseriti dall'utente e chiama il metodo `Stampa` della stampante.

#### `StampaRandom_Click(object sender, RoutedEventArgs e)`

Gestisce l'evento di clic sul pulsante "Stampa Random". Crea una nuova istanza casuale della classe `Pagina` e chiama il metodo `Stampa` della stampante.

#### `ControlloValore(object sender, TextCompositionEventArgs e)`

Gestisce l'evento di composizione del testo nei campi di input, limitando i caratteri consentiti.

#### `riempiCiano_Click(object sender, RoutedEventArgs e)`, `riempiGiallo_Click(object sender, RoutedEventArgs e)`, `riempiMagenta_Click(object sender, RoutedEventArgs e)`, `riempiNero_Click(object sender, RoutedEventArgs e)`

Gestiscono gli eventi di clic sui pulsanti di ricarica colore, chiamando i rispettivi metodi di `SostituisciColore` della stampante.

#### `RicaricaFogli_Click(object sender, RoutedEventArgs e)`

Gestisce l'evento di clic sul pulsante "Ricarica Fogli", aggiornando la quantità di fogli nel cassetto chiamando il metodo `AggiungiCarta` della stampante.

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
