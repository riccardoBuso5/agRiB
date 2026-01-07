# 🍇 agRiB - Gestionale Cantina

Una soluzione completa e professionale per la gestione intelligente di una cantina vinicola. **agRiB** è un'applicazione desktop sviluppata in Visual Basic .NET che ti permette di organizzare, tracciare e ottimizzare ogni aspetto della tua produzione vinicola.

## ✨ Caratteristiche Principali

- 📦 **Gestione Lotti** - Crea, modifica ed elimina lotti di vino con tracciamento completo
- 🏷️ **Gestione Tipologie** - Classifica e organizza le diverse tipologie di vino
- 💰 **Gestione Vendite** - Registra tutte le transazioni e traccia i dati di vendita
- 🔗 **Collegamenti Intelligenti** - Associa lotti con tipologie per una gestione integrata
- 📅 **Ricerca Avanzata** - Filtra le vendite per data con ricerca precisa
- 💾 **Esportazione Dati** - Salva e archivia i dati in file per backup e analisi

## 📋 Struttura del Progetto

```
agRiB/
├── Main.vb                              # Interfaccia principale dell'applicazione
├── 
├── 📌 GESTIONE LOTTI
├── aggiungiLottoHome.vb                 # Creazione nuovi lotti
├── modificaLottoHome.vb                 # Modifica dati lotti
├── eliminaLottoHome.vb                  # Rimozione lotti
├── 
├── 📌 GESTIONE TIPOLOGIE
├── aggiungiTipologiaHome.vb             # Aggiunta nuove tipologie
├── modificaTipologiaHome.vb             # Modifica tipologie
├── eliminaTipologiaHome.vb              # Eliminazione tipologie
├── 
├── 📌 GESTIONE VENDITE
├── aggiungiVenditaHome.vb               # Registrazione vendite
├── modificaVenditaHome.vb               # Aggiornamento vendite
├── eliminaVenditaHome.vb                # Cancellazione vendite
├── 
├── 📌 FUNZIONI AVANZATE
├── CollegaLotto_tipologia.vb            # Collegamento lotto-tipologia
├── ricercaPerData.vb                    # Ricerca temporale
├── salvaFile.vb                         # Esportazione dati
├── funzioni.vb                          # Libreria funzioni comuni
├── 
├── 📂 struttura database/               # Script SQL di configurazione
│   ├── cantina_lotto.sql
│   ├── cantina_tipologia.sql
│   ├── cantina_tipologia_lotto.sql
│   └── cantina_vendita.sql
├── 
└── 📚 manuale/                          # Documentazione utente
    └── manuale.md
```

## 🛠️ Requisiti di Sistema

- **Visual Studio** 2019 o versioni successive
- **.NET Framework** 4.7.2 o superiore
- **SQL Server** Express o versioni professionali compatibili
- **Windows** 7 SP1 o versioni successive

## 🚀 Guida all'Installazione

1. **Clona il repository** dal tuo server git
   ```
   git clone <repository-url>
   ```

2. **Apri il progetto** in Visual Studio
   - Seleziona `agRiB.sln`

3. **Configura il database**
   - Esegui gli script SQL da `struttura database/`
   - Aggiorna la stringa di connessione nel codice

4. **Compila il progetto**
   - Build → Compile Solution

5. **Avvia l'applicazione**
   - Debug → Start Debugging (F5)

## 🗄️ Configurazione Database

Nella cartella `struttura database/` troverai gli script SQL necessari per creare lo schema:

| Script | Descrizione |
|--------|-------------|
| `cantina_lotto.sql` | Tabella per i lotti di vino |
| `cantina_tipologia.sql` | Tabella per le tipologie di vino |
| `cantina_tipologia_lotto.sql` | Tabella di collegamento lotti-tipologie |
| `cantina_vendita.sql` | Tabella per le transazioni di vendita |

**Esegui gli script nell'ordine indicato per garantire l'integrità referenziale.**

## 📖 Documentazione e Manuale Utente

Nella cartella **`manuale/`** è disponibile il **manuale completo** per l'utilizzo dell'applicazione:
- **`manuale.md`** - Guida dettagliata con screenshot e istruzioni passo-passo

**Consulta il manuale per:**
- Come creare e gestire lotti
- Procedure per registrare tipologie e vendite
- Guide ai filtri e alle ricerche
- Suggerimenti di best practice
- Risoluzione dei problemi comuni

## 🎯 Come Usare l'Applicazione

1. **Avvia** il programma dalla finestra principale
2. **Seleziona** la funzione desiderata dal menu
3. **Inserisci** i dati richiesti nei moduli
4. **Salva** le modifiche o **esporta** i dati
5. **Consulta** il manuale per funzioni avanzate

Per informazioni dettagliate, consulta **`manuale/manuale.md`**.

## 📄 Licenza

Questo progetto è distribuito sotto licenza. Per dettagli, consulta [LICENSE.txt](LICENSE.txt)

## 👤 Autore

**Riccardo Buso**

---

**Nota:** Questa applicazione è stata progettata per facilitare la gestione efficiente delle operazioni di una cantina vinicola. Per supporto tecnico o segnalazione di problemi, contatta lo sviluppatore.
