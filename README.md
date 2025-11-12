# agRiB
# Sistema Gestionale Casere

Un'applicazione Windows Forms in VB.NET per la gestione di un caseificio, inclusa la gestione di lotti, tipologie di vino e vendite.

## Caratteristiche

- **Gestione Lotti**: Tracciamento della produzione e inventario
- **Gestione Tipologie**: Diverse categorie di prodotti vinicoli
- **Gestione Vendite**: Tracciamento delle vendite programmate ed effettuate
- **Controllo Scadenze**: Monitoraggio delle date di vendita
- **Export Excel**: Esportazione dati in formato Excel tramite ClosedXML
- **Database MySQL**: Integrazione completa con database MySQL

## Tecnologie Utilizzate

- .NET 9.0 (Windows Forms)
- VB.NET
- MySQL Database
- ClosedXML per export Excel
- Aspose.Cells
- CsvHelper per gestione CSV
- Microsoft.Data.Analysis per analisi dati

## Setup del Progetto

### Prerequisiti

- .NET 9.0 SDK

- Visual Studio 2022 o superiore
- MySQL Server

### Configurazione Database

1. Creare un database MySQL
2. Copiare il file `paswd_example.txt` in `paswd.txt`
3. Modificare `paswd.txt` con le proprie credenziali:
   ```
   Server=localhost;Database=nome_database;Uid=username;Pwd=password;
   ```

### Installazione

1. Clonare il repository
   ```bash
   git clone https://github.com/tuousername/agRiB.git
   ```

2. Aprire la solution in Visual Studio

3. Configurare il file delle credenziali come descritto sopra

4. Compilare ed eseguire il progetto

## Struttura del Progetto

- `funzioni.vb` - Modulo principale con funzioni database e business logic
- `Main.vb` - Form principale dell'applicazione
- Altri form per gestione specifica (lotti, vendite, tipologie)

## Sicurezza

?? **Importante**: 
- Non committare mai il file `paswd.txt` con credenziali reali
- Utilizzare sempre parametri SQL per prevenire SQL injection
- Mantenere aggiornate le dipendenze per sicurezza

## Contribuire

1. Fork del progetto
2. Creare un branch per la feature (`git checkout -b feature/AmazingFeature`)
3. Commit delle modifiche (`git commit -m 'Add some AmazingFeature'`)
4. Push al branch (`git push origin feature/AmazingFeature`)
5. Aprire una Pull Request

## Licenza

Questo progetto � rilasciato sotto licenza MIT. Vedere il file `LICENSE` per dettagli.

## Contatti

Riccardo Buso - agRiB Team

Link Progetto: [https://github.com/tuousername/agRiB](https://github.com/tuousername/agRiB)
