# MANUALE D'USO
## GESTIONALE CANTINA
### Versione 1.0

---

## INDICE

1. [Introduzione](#introduzione)
2. [Accesso al Sistema](#accesso-al-sistema)
3. [Gestione Lotti](#gestione-lotti)
4. [Gestione Tipologie](#gestione-tipologie)
5. [Gestione Vendite](#gestione-vendite)
6. [Operazioni di Ricerca](#operazioni-di-ricerca)
7. [Report e Stampe](#report-e-stampe)
8. [Risoluzione Problemi](#risoluzione-problemi)
9. [Domande Frequenti](#domande-frequenti)

---

## 1. INTRODUZIONE

### 1.1 Scopo del Software
Il Gestionale Cantina è un'applicazione progettata per gestire:
- **Lotti di produzione** del vino
- **Tipologie** di vino prodotte
- **Vendite** e ordini
- **Inventario** delle bottiglie

### 1.2 A Chi è Rivolto
Questo manuale è destinato alle segretarie e al personale amministrativo che utilizza quotidianamente il software per:
- Registrare nuovi lotti
- Inserire ordini e vendite
- Consultare lo stato delle giacenze
- Generare report

### 1.3 Requisiti di Sistema
- **Sistema Operativo**: Windows 10 o superiore
- **Database**: MySQL Server installato e configurato
- **Connessione**: Rete aziendale per accesso al database

---

## 2. ACCESSO AL SISTEMA

### 2.1 Avvio del Programma
1. Fare doppio clic sull'icona **Gestionale Cantina** sul desktop
2. Attendere il caricamento dell'interfaccia principale
3. Verificare la connessione al database (indicatore in basso a sinistra)

⚠️ **IMPORTANTE**: Se appare il messaggio "Errore connessione MySQL", contattare il supporto tecnico.

### 2.2 Schermata Principale
La schermata principale è suddivisa in sezioni:

---

## 3. GESTIONE LOTTI

### 3.1 Cosa Sono i Lotti
Un **lotto** rappresenta una produzione specifica di vino, identificata da:
- **Codice Lotto**: Numero univoco (es. 2024001)
- **Data di Produzione**: Quando è stato imbottigliato
- **Numero Bottiglie**: Quantità totale prodotta

### 3.2 Inserire un Nuovo Lotto

#### Procedura Passo-Passo

1️⃣ **Accedere alla Gestione Lotti**
   - Cliccare su **"Gestione Lotti"** nel menu principale
   - Selezionare **"Nuovo Lotto"**

2️⃣ **Compilare i Campi Obbligatori**

| Campo | Descrizione | Esempio |
|-------|-------------|---------|
| **Codice Lotto** | Numero univoco progressivo | 2024001 |
| **Data Produzione** | Data imbottigliamento | 15/12/2024 |
| **Numero Bottiglie** | Quantità totale prodotta | 5000 |

3️⃣ **Salvare il Lotto**
   - Cliccare su **"Salva"**
   - Confermare l'operazione
   - Apparirà il messaggio: *"Inserimento riuscito"*

⚠️ **ATTENZIONE**: 
- Il codice lotto deve essere **univoco** (non può esistere già)
- Il numero di bottiglie deve essere **maggiore di zero**

### 3.3 Modificare un Lotto Esistente

1. Aprire **"Gestione Lotti"** → **"Modifica Lotto"**
2. Selezionare il lotto dal menu a tendina
3. Modificare i campi necessari:
   - Data di produzione
   - Numero bottiglie
4. Cliccare **"Salva Modifiche"**

📝 **NOTA**: Non è possibile modificare il codice lotto una volta creato.

### 3.4 Eliminare un Lotto

⚠️ **OPERAZIONE CRITICA**: Un lotto può essere eliminato solo se:
- Non è collegato a vendite
- Non è associato a tipologie

**Procedura:**
1. Aprire **"Gestione Lotti"** → **"Elimina Lotto"**
2. Selezionare il lotto da eliminare
3. Confermare l'eliminazione
4. Se il lotto è collegato, apparirà: *"Non puoi cancellare un lotto se è collegato"*

### 3.5 Visualizzare i Lotti

**Vista Tabellare**
- Aprire **"Gestione Lotti"** → **"Visualizza Tutti"**
- La tabella mostra:
  - Codice Lotto
  - Data Produzione
  - Numero Bottiglie Disponibili
  - Tipologie Associate

**Ordinamento:**
- Cliccare sulle intestazioni per ordinare
- Freccia ↑ = Ordine crescente
- Freccia ↓ = Ordine decrescente

### 3.6 Lotti da Rifornire

Il sistema avvisa automaticamente quando un lotto ha **meno di 1000 bottiglie**.

**Come Visualizzarli:**
1. Menu principale → **"Alert Lotti"**
2. Appare la lista dei lotti con giacenze basse
3. Contattare la produzione per rifornimento

🔔 **ALERT**: L'icona ⚠️ indica lotti critici.

---

## 4. GESTIONE TIPOLOGIE

### 4.1 Cosa Sono le Tipologie
Le **tipologie** rappresentano i diversi vini prodotti (es. Merlot, Chardonnay, Prosecco).

### 4.2 Inserire una Nuova Tipologia

1. Menu → **"Gestione Tipologie"** → **"Nuova Tipologia"**
2. Inserire il nome (es. "Merlot Riserva 2023")
3. Cliccare **"Salva"**

### 4.3 Collegare Lotto e Tipologia

⚠️ **CONCETTO IMPORTANTE**: 
Un lotto può contenere più tipologie. Ad esempio:
- Lotto 2024001 → 3000 bottiglie di Merlot
- Lotto 2024001 → 2000 bottiglie di Cabernet

**Procedura di Collegamento:**

1️⃣ Aprire **"Collega Lotto-Tipologia"**

2️⃣ Selezionare:
   - **Lotto**: Scegliere il codice lotto (es. 2024001)
   - **Tipologia**: Scegliere il vino (es. Merlot)
   - **Numero Bottiglie**: Quante bottiglie di quella tipologia

3️⃣ Cliccare **"Collega"**

**Esempio Pratico:**
- Si desidera collegare 1000 bottiglie di "Merlot Riserva 2023" al lotto 2024001.
- Seguire la procedura di collegamento selezionando il lotto e la tipologia appropriati.
- Dopo aver cliccato "Collega", il sistema aggiornerà le informazioni del lotto.

📝 **NOTE SUL COLLEGAMENTO**:
- È possibile collegare più tipologie allo stesso lotto.
- Assicurarsi che il totale delle bottiglie non superi il "Numero Bottiglie" del lotto.

⚠️ **CONTROLLO**: Il sistema verifica che il numero di bottiglie non superi il totale del lotto.

### 4.4 Modificare un Collegamento

1. Menu → **"Gestione Tipologie"** → **"Modifica Collegamento"**
2. Selezionare il collegamento da modificare
3. Cambiare il numero di bottiglie
4. Salvare

### 4.5 Eliminare una Tipologia

1. Menu → **"Gestione Tipologie"** → **"Elimina Tipologia"**
2. Selezionare la tipologia
3. Confermare

⚠️ **ATTENZIONE**: Non è possibile eliminare una tipologia se:
- È collegata a lotti
- È presente in vendite

---

## 5. GESTIONE VENDITE

### 5.1 Registrare una Nuova Vendita

#### 5.1.1 Vendita Effettuata

Una **vendita effettuata** è un ordine già spedito/consegnato.

**Procedura:**
1️⃣ **Accedere alle Vendite**
   - Menu → **"Gestione Vendite"** → **"Nuova Vendita"**

2️⃣ **Compilare i Dati**

| Campo | Descrizione | Esempio |
|-------|-------------|---------|
| **Cliente** | Nome cliente o azienda | Ristorante Da Mario |
| **Lotto** | Codice lotto da cui prelevare | 2024001 |
| **Tipologia** | Tipo di vino | Merlot |
| **Numero Bottiglie** | Quantità venduta | 100 |
| **Data Vendita** | Data spedizione | 20/12/2024 |
| **Stato** | Effettuata / Programmata | Effettuata |
| **Note** | Informazioni aggiuntive | Pagamento con bonifico |

3️⃣ **Confermare la Vendita**
   - Cliccare **"Salva Vendita"**
   - Il sistema sottrae automaticamente le bottiglie dal lotto

✅ **CONFERMA**: Apparirà *"Vendita registrata con successo"*

#### 5.1.2 Vendita Programmata

Una **vendita programmata** è un ordine futuro non ancora spedito.

**Differenze:**
- Stato = "Programmata"
- Data vendita = Data prevista di spedizione
- Le bottiglie vengono **prenotate** ma non ancora sottratte

**Quando Marcare come Effettuata:**
1. Menu → **"Gestione Vendite"** → **"Modifica Vendita"**
2. Selezionare la vendita programmata
3. Cambiare stato da **"Programmata"** a **"Effettuata"**
4. Salvare

### 5.2 Visualizzare Tutte le Vendite

1. Menu → **"Gestione Vendite"** → **"Visualizza Vendite"**
2. La tabella mostra:
   - Codice Vendita
   - Cliente
   - Data
   - Lotto e Tipologia
   - Numero Bottiglie
   - Stato (Effettuata/Programmata)

**Filtri Disponibili:**
- Per data (dalla più recente)
- Per cliente
- Per stato (Effettuate/Programmate)

### 5.3 Modificare una Vendita

1. Selezionare la vendita dalla lista
2. Cliccare **"Modifica"**
3. Cambiare i dati necessari
4. Salvare

⚠️ **LIMITAZIONI**:
- Non è possibile modificare lotto e tipologia
- Per cambiarli, eliminare la vendita e ricrearla

### 5.4 Eliminare una Vendita

⚠️ **ATTENZIONE**: Eliminando una vendita, le bottiglie vengono **riaggiunte** al lotto.

**Procedura:**
1. Menu → **"Gestione Vendite"** → **"Elimina Vendita"**
2. Selezionare la vendita
3. Confermare l'eliminazione
4. Le bottiglie tornano disponibili

### 5.5 Controllo Scadenze

Il sistema avvisa delle vendite programmate in scadenza (entro 7 giorni).

**Come Visualizzare:**
1. Menu → **"Alert Vendite"**
2. Appare la lista delle vendite programmate in scadenza
3. Verificare con la produzione la disponibilità

🔔 **PROMEMORIA AUTOMATICO**: All'avvio del programma, se ci sono vendite in scadenza, appare una notifica.

---

## 6. OPERAZIONI DI RICERCA

### 6.1 Ricerca per Codice Lotto

**Quando Usarla**: Per trovare tutte le tipologie e vendite di un lotto specifico.

**Procedura:**
1. Menu → **"Ricerche"** → **"Ricerca per Lotto"**
2. Inserire il codice lotto (es. 2024001)
3. Cliccare **"Cerca"**
4. Risultati mostrano:
   - Tipologie collegate
   - Numero bottiglie per tipologia
   - Vendite associate

### 6.2 Ricerca per Tipologia

**Quando Usarla**: Per vedere tutti i lotti che contengono una specifica tipologia di vino.

**Procedura:**
1. Menu → **"Ricerche"** → **"Ricerca per Tipologia"**
2. Selezionare la tipologia dal menu (es. Merlot)
3. Cliccare **"Cerca"**
4. Risultati mostrano:
   - Tutti i lotti con quella tipologia
   - Numero bottiglie disponibili per lotto

### 6.3 Ricerca Vendite per Cliente

1. Menu → **"Ricerche"** → **"Ricerca per Cliente"**
2. Inserire il nome del cliente
3. Visualizzare tutte le vendite storiche

### 6.4 Ricerca per Data

1. Menu → **"Ricerche"** → **"Ricerca per Data"**
2. Selezionare:
   - Data inizio
   - Data fine
3. Visualizzare vendite/lotti in quel periodo

---

## 7. REPORT E STAMPE

### 7.1 Esportare in Excel

**Per Qualsiasi Tabella:**
1. Visualizzare i dati desiderati (lotti, vendite, tipologie)
2. Cliccare su **"Esporta in Excel"**
3. Scegliere dove salvare il file
4. Il file Excel si apre automaticamente

📊 **FORMATO**: Il file mantiene tutte le colonne e i filtri applicati.

### 7.2 Stampare un Report

1. Visualizzare i dati da stampare
2. Cliccare su **"Stampa"**
3. Selezionare la stampante
4. Configurare:
   - Orientamento (Verticale/Orizzontale)
   - Margini
5. Cliccare **"Stampa"**

### 7.3 Report Disponibili

#### 7.3.1 Report Giacenze
Mostra per ogni lotto:
- Bottiglie totali
- Bottiglie vendute
- Bottiglie disponibili

#### 7.3.2 Report Vendite Mensili
- Totale vendite per mese
- Suddivisione per tipologia
- Fatturato (se configurato)

#### 7.3.3 Report Clienti
- Lista clienti ordinati per volume acquisti
- Ultimo ordine
- Totale bottiglie acquistate

---

## 8. RISOLUZIONE PROBLEMI

### 8.1 Problemi di Connessione

**Sintomo**: "Errore connessione MySQL"

**Soluzioni:**
1. Verificare che il server MySQL sia in esecuzione
2. Controllare la connessione di rete
3. Verificare credenziali nel file `paswd.txt`
4. Riavviare il programma
5. Se persiste, contattare l'amministratore di sistema

### 8.2 "Codice Lotto Già Esistente"

**Causa**: Si sta tentando di creare un lotto con un codice già usato.

**Soluzione**:
- Verificare l'ultimo codice lotto utilizzato
- Usare un codice progressivo successivo
- Controllare nell'archivio lotti

### 8.3 "Non Puoi Cancellare..."

**Causa**: Si sta tentando di eliminare un elemento collegato ad altri dati.

**Soluzione**:
1. Eliminare prima i collegamenti
   - Per lotti: eliminare vendite e tipologie associate
   - Per tipologie: eliminare vendite e collegamenti
2. Poi eliminare l'elemento principale

### 8.4 Programma Lento

**Possibili Cause e Soluzioni:**

| Problema | Soluzione |
|----------|-----------|
| Troppe vendite nel database | Archiviare vendite vecchie |
| Connessione lenta | Verificare rete aziendale |
| Computer sovraccarico | Chiudere altri programmi |

**Contatto Tecnico**: admin@azienda.it

### 8.5 Dati Non Salvati

**Sintomo**: Modifiche non vengono salvate

**Verifiche:**
1. Cliccare sempre su **"Salva"** dopo le modifiche
2. Attendere il messaggio di conferma
3. Non chiudere il programma durante il salvataggio
4. Verificare i permessi di scrittura sul database

---

## 9. DOMANDE FREQUENTI (FAQ)

### 9.1 Gestione Lotti

**Q: Posso modificare il codice di un lotto dopo averlo creato?**  
A: No, il codice lotto è immutabile. Se serve cambiarlo, bisogna eliminare il lotto (se non ha vendite) e ricrearlo.

**Q: Quante tipologie posso associare a un lotto?**  
A: Infinite, purché la somma delle bottiglie non superi il totale del lotto.

**Q: Come faccio a vedere quante bottiglie ho disponibili in un lotto?**  
A: Menu → Ricerche → Ricerca per Lotto → Mostra bottiglie disponibili per tipologia.

### 9.2 Gestione Vendite

**Q: Cosa succede se registro una vendita con più bottiglie di quelle disponibili?**  
A: Il sistema impedisce l'operazione e mostra: "Bottiglie insufficienti".

**Q: Posso eliminare una vendita già effettuata?**  
A: Sì, ma le bottiglie torneranno disponibili nel lotto. Eliminare solo in caso di errore.

**Q: Come marco una vendita programmata come effettuata?**  
A: Menu → Gestione Vendite → Modifica Vendita → Cambia stato in "Effettuata".

### 9.3 Esportazioni e Report

**Q: Posso esportare solo alcune righe?**  
A: Sì, seleziona le righe desiderate prima di cliccare "Esporta".

**Q: Il file Excel non si apre automaticamente**  
A: Aprilo manualmente dalla cartella scelta durante l'esportazione.

**Q: Posso personalizzare i report?**  
A: No, i report hanno un formato standard. Per personalizzazioni, contattare l'amministratore.

### 9.4 Altro

**Q: Posso usare il gestionale da casa?**  
A: Solo se configurato VPN aziendale. Contattare IT.

**Q: Dove vengono salvati i backup?**  
A: I backup automatici sono sul server MySQL. Per copie locali, contattare l'amministratore.

**Q: Il programma funziona senza internet?**  
A: Sì, se il server MySQL è sulla rete locale aziendale.

---

## 10. GLOSSARIO

| Termine | Definizione |
|---------|-------------|
| **Lotto** | Gruppo di bottiglie prodotte insieme, identificato da un codice univoco |
| **Tipologia** | Tipo specifico di vino (es. Merlot, Chardonnay) |
| **Combo** | Collegamento tra lotto e tipologia con numero bottiglie |
| **Vendita Effettuata** | Ordine già spedito/consegnato |
| **Vendita Programmata** | Ordine futuro non ancora evaso |
| **Giacenze** | Numero di bottiglie ancora disponibili |
| **Dataset** | Insieme di dati visualizzati in tabella |

---

## 11. CONTATTI E SUPPORTO

### Supporto Tecnico
- **Email**: supporto@azienda.it
- **Telefono**: +39 xxx xxx xxxx
- **Orari**: Lunedì-Venerdì, 9:00-18:00

### Amministratore Sistema
- **Email**: admin@azienda.it
- **Per**: Problemi di connessione, permessi, backup

### Formazione
- **Email**: formazione@azienda.it
- **Per**: Richieste di formazione aggiuntiva, chiarimenti

---

## 12. APPENDICI

### Appendice A: Scorciatoie da Tastiera

| Scorciatoia | Azione |
|-------------|--------|
| Ctrl + N | Nuovo elemento |
| Ctrl + S | Salva |
| Ctrl + F | Ricerca |
| Ctrl + P | Stampa |
| Ctrl + E | Esporta Excel |
| F5 | Aggiorna visualizzazione |
| Esc | Annulla operazione |

### Appendice B: Struttura Database

**Tabelle Principali:**
- `lotto`: Informazioni sui lotti
- `tipologia`: Tipi di vino
- `tipologia_lotto`: Collegamenti lotto-tipologia
- `vendita`: Registro vendite

### Appendice C: Codici Errore

| Codice | Significato | Azione |
|--------|-------------|--------|
| E1001 | Connessione DB fallita | Verificare rete |
| E1002 | Codice duplicato | Usare codice diverso |
| E1003 | Dati mancanti | Compilare tutti i campi |
| E1004 | Bottiglie insufficienti | Verificare giacenze |

---

## VERSIONE E AGGIORNAMENTI

**Versione Manuale**: 1.0  
**Data**: Dicembre 2024  
**Ultima Modifica**: 30/12/2024

**Changelog:**
- v1.0 (30/12/2024): Prima versione del manuale

---

## NOTE FINALI

Questo manuale viene aggiornato periodicamente. Per suggerimenti o segnalazioni di errori, contattare: formazione@azienda.it

---

© 2024 Azienda Vinicola - Tutti i diritti riservati

