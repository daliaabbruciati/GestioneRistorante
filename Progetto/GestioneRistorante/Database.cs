using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace GestioneRistorante
{
    public class Database : IAccessoDati
    {
        // Attributi della classe

        // Dichiarazione del pattern Singleton
        private static Database instance = null;
        private static SqlConnection connection;


        // Costruttore della classe
        private Database()
        {
        }


        // Inizializza il database e applico il Singleton
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }


        // Apre la connessione al database
        public bool Connect(string connectionString)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore connesione al database: " + e.Message, "Errore");
                return false;
            }
        }


        // Chiude la connessione al database
        public bool Close()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore chiusura connessione al database: " + e.Message, "Errore");
                return false;
            }

        }


        // Prende la tabella del database
        private DataTable GetTable(string query)
        {
            DataTable table = new DataTable();
            try
            {
                // generazione della query
                SqlCommand cmd = new SqlCommand(query, connection);
                // prende i dati
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // mette i dati nella tabella
                da.Fill(table);
                da.Dispose();

            }
            catch (Exception e)
            {
                MessageBox.Show("Errore esecuzione query: " + query + ", " + e.Message);
            }
            return table;
        }


        // Prende la lista delle prenotazioni
        public List<Prenotazione> GetPrenotazioni()
        {
            List<Prenotazione> prenotazioni = new List<Prenotazione>();
            try
            {
                DataTable table = GetTable("USE[SmartRestaurant] Select * from Prenotazione");
                foreach (DataRow row in table.Rows)
                {
                    Prenotazione p;
                    switch (int.Parse(row["Tipologia"].ToString()))
                    {
                        case (int)Prenotazione.EnumTipologia.ASPORTO:
                            p = new Asporto();
                            ((Asporto)p).NumeroTelefono = row["NumeroTelefono"].ToString();
                            break;
                        case (int)Prenotazione.EnumTipologia.DOMICILIO:
                            p = new Domicilio();
                            ((Domicilio)p).Indirizzo = (row["Indirizzo"].ToString());
                            ((Domicilio)p).NumeroTelefono = row["NumeroTelefono"].ToString();
                            break;
                        case (int)Prenotazione.EnumTipologia.AL_TAVOLO:
                            p = new AlTavolo();
                            ((AlTavolo)p).NumeroPersone = int.Parse(row["NumeroPersone"].ToString());
                            ((AlTavolo)p).OraUltimoOrdine = DateTime.Parse(row["OraUltimoOrdine"].ToString());
                            break;
                        default:
                            p = new AlTavolo();
                            break;
                    }
                    p.IDPrenotazione = (row["IDPrenotazione"].ToString());
                    p.NomePrenotazione = row["NomePrenotazione"].ToString();
                    p.DataOra = DateTime.Parse(row["DataOra"].ToString());
                    p.Stato = int.Parse(row["Stato"].ToString());
                    p.Note = row["Note"].ToString();
                    prenotazioni.Add(p);
                }

            }
            catch (Exception e)
            {
                prenotazioni = null;
                MessageBox.Show("Errore GetPrenotazioni" + e);
            }
            return prenotazioni;
        }

       
        // Scrive sul database delle prenotazioni
        public bool SetPrenotazioni(Prenotazione p)
        {
            string query = "USE [SmartRestaurant] INSERT INTO [Prenotazione] " +
                "([IDPrenotazione],[NomePrenotazione],[NumeroPersone],[NumeroTelefono],[DataOra],[Stato],[OraUltimoOrdine],[Indirizzo],[Tipologia],[Note])" +
                "VALUES(@IDPrenotazione" +
                ",@NomePrenotazione" +
                ",@NumeroPersone" +
                ",@NumeroTelefono" +
                ",@DataOra" +
                ",@Stato" +
                ",@OraUltimoOrdine" +
                ",@Indirizzo" +
                ",@Tipologia" +
                ",@Note)";
            try
            {

                if (p.IDPrenotazione == null)
                {
                    // genera l'ID della prenotazione in modo automatico
                    DateTime n = DateTime.Now;
                    p.IDPrenotazione = "" + n.Year + n.Month + n.Day + n.Hour + n.Minute + n.Second + n.Millisecond;
                }

                SqlCommand command = new SqlCommand(query, connection);
                // campi in comune con tutti
                command.Parameters.AddWithValue("@IDPrenotazione", p.IDPrenotazione);
                command.Parameters.AddWithValue("@NomePrenotazione", p.NomePrenotazione);
                command.Parameters.AddWithValue("@DataOra", p.DataOra);
                command.Parameters.AddWithValue("@Stato", p.Stato);
                command.Parameters.AddWithValue("@Note", p.Note);

                // aggiungo o tolgo i campi in base alla tipologia
                if (p.GetType() == typeof(Asporto))
                {
                    command.Parameters.AddWithValue("@NumeroTelefono", ((Asporto)p).NumeroTelefono);
                    command.Parameters.AddWithValue("@Tipologia", Prenotazione.EnumTipologia.ASPORTO);
                    command.Parameters.AddWithValue("@NumeroPersone", DBNull.Value);
                    command.Parameters.AddWithValue("@OraUltimoOrdine", DBNull.Value);
                    command.Parameters.AddWithValue("@Indirizzo", DBNull.Value);
                }
                else if (p.GetType() == typeof(Domicilio))
                {
                    command.Parameters.AddWithValue("@NumeroTelefono", ((Domicilio)p).NumeroTelefono);
                    command.Parameters.AddWithValue("@Indirizzo", ((Domicilio)p).Indirizzo);
                    command.Parameters.AddWithValue("@Tipologia", Prenotazione.EnumTipologia.DOMICILIO);
                    command.Parameters.AddWithValue("@NumeroPersone", DBNull.Value);
                    command.Parameters.AddWithValue("@OraUltimoOrdine", DBNull.Value);
                }
                else if (p.GetType() == typeof(AlTavolo))
                {
                    command.Parameters.AddWithValue("@NumeroPersone", ((AlTavolo)p).NumeroPersone);
                    command.Parameters.AddWithValue("@OraUltimoOrdine", ((AlTavolo)p).OraUltimoOrdine);
                    command.Parameters.AddWithValue("@Tipologia", Prenotazione.EnumTipologia.AL_TAVOLO);
                    command.Parameters.AddWithValue("@NumeroTelefono", DBNull.Value);
                    command.Parameters.AddWithValue("@Indirizzo", DBNull.Value);
                }

                // esegue la query
                int result = command.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("Errore inserimento prenotazione nel database: " + p.ToString());
                    return false;
                }
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Errore inserimento prenotazione nel database" + e.Message);
                return false;
            }
        }


        // Aggiorna la lista delle prenotazioni
        public bool UpdatePrenotazione(Prenotazione p)
        {
            string query = "USE[SmartRestaurant] UPDATE [Prenotazione] SET" +
                "[NomePrenotazione] = @NomePrenotazione," +
                "[NumeroPersone] = @NumeroPersone," +
                "[NumeroTelefono] = @NumeroTelefono," +
                "[DataOra] = @DataOra," +
                "[Stato] = @Stato," +
                "[OraUltimoOrdine] = @OraUltimoOrdine," +
                "[Indirizzo] = @Indirizzo," +
                "[Tipologia] = @Tipologia," +
                "[Note] = @Note" +
                " WHERE IDPrenotazione = @IDPrenotazione";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDPrenotazione", p.IDPrenotazione);
                command.Parameters.AddWithValue("@NomePrenotazione", p.NomePrenotazione);
                command.Parameters.AddWithValue("@DataOra", p.DataOra);
                command.Parameters.AddWithValue("@Stato", p.Stato);
                command.Parameters.AddWithValue("@Note", p.Note);

                if (p.GetType() == typeof(Asporto))
                {
                    command.Parameters.AddWithValue("@NumeroTelefono", ((Asporto)p).NumeroTelefono);
                    command.Parameters.AddWithValue("@Tipologia", Prenotazione.EnumTipologia.ASPORTO);
                    command.Parameters.AddWithValue("@NumeroPersone", DBNull.Value);
                    command.Parameters.AddWithValue("@OraUltimoOrdine", DBNull.Value);
                    command.Parameters.AddWithValue("@Indirizzo", DBNull.Value);
                }
                else if (p.GetType() == typeof(Domicilio))
                {
                    command.Parameters.AddWithValue("@NumeroTelefono", ((Domicilio)p).NumeroTelefono);
                    command.Parameters.AddWithValue("@Indirizzo", ((Domicilio)p).Indirizzo);
                    command.Parameters.AddWithValue("@Tipologia", Prenotazione.EnumTipologia.DOMICILIO);
                    command.Parameters.AddWithValue("@NumeroPersone", DBNull.Value);
                    command.Parameters.AddWithValue("@OraUltimoOrdine", DBNull.Value);
                }
                else if (p.GetType() == typeof(AlTavolo))
                {
                    command.Parameters.AddWithValue("@NumeroPersone", ((AlTavolo)p).NumeroPersone);
                    command.Parameters.AddWithValue("@OraUltimoOrdine", ((AlTavolo)p).OraUltimoOrdine);
                    command.Parameters.AddWithValue("@Tipologia", Prenotazione.EnumTipologia.AL_TAVOLO);
                    command.Parameters.AddWithValue("@NumeroTelefono", DBNull.Value);
                    command.Parameters.AddWithValue("@Indirizzo", DBNull.Value);
                }

                // esegue la query
                int result = command.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("Errore inserimento prenotazione nel database: " + p.ToString());
                    return false;
                }
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Errore inserimento prenotazione nel database" + e.Message);
                return false;
            }

        }


        // Elimina la prenotazione a aprtire dall'id 
        public bool DeletePrenotazione(string id)
        {
            string query = "USE [SmartRestaurant] DELETE FROM [Prenotazione] " +
                "WHERE [IDPrenotazione] = @id";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", id);
                // esegue la query
                int result = command.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("Errore eliminazione prenotazione nel database: " + id.ToString());
                    return false;
                }
                // se cancello una prenotazione dalla lista delle prenotazioni, mi cancella
                // anche il tavolo associato ad essa
                LiberaTavolo(id);
                return true;

            }
            catch (Exception e)
            {
                MessageBox.Show("Errore eliminazione prenotazione nel database" + e.Message);
                return false;
            }

        }


        // Prende la lista dei tavoli
        public List<Tavolo> GetTavoli()
        {
            List<Tavolo> tavoli = new List<Tavolo>();
            try
            {
                DataTable table = GetTable("USE[SmartRestaurant] Select * from Tavolo");
                foreach (DataRow row in table.Rows)
                {
                    Tavolo t = new Tavolo();
                    t.IDTavolo = int.Parse(row["IDTavolo"].ToString());
                    t.IDPrenotazione = row["IDPrenotazione"].ToString();
                    t.NumeroPosti = int.Parse(row["NumeroPosti"].ToString());
                    t.Zona = int.Parse(row["Zona"].ToString());
                    tavoli.Add(t);
                }

            }
            catch (Exception e)
            {
                tavoli = null;
                MessageBox.Show("Errore GetTavoli" + e);
            }
            return tavoli;
        }


        // Aggiorna la lista dei tavoli prendendo l'id della prenotazione e del tavolo
        public bool UpdateTavolo(int idTavolo, string idPrenotazione)
        {
            string query = "USE[SmartRestaurant] UPDATE [Tavolo] SET[IDPrenotazione] = @IDPrenotazione WHERE IDTavolo = @IDTavolo";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDPrenotazione", idPrenotazione);
            command.Parameters.AddWithValue("@IDTavolo", idTavolo);

            // esegue la query
            int result = command.ExecuteNonQuery();
            if (result <= 0)
            {
                MessageBox.Show("Errore assegnamento tavolo numero: " + idTavolo +
                    " alla prenotazione: " + idPrenotazione);
                return false;
            }
            else
            {
                return true;
            }

        }


        // Elimina il tavolo dalla lista delle prenotazioni
        public void LiberaTavolo(string idPrenotazione)
        {
            string query = "USE[SmartRestaurant] UPDATE [Tavolo] SET[IDPrenotazione] = NULL WHERE IDPrenotazione = @IDPrenotazione";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@IDPrenotazione", idPrenotazione);

            // esegue la query
            int result = command.ExecuteNonQuery();
        }


        // Legge la lista dei cibi del menu
        public List<Cibo> GetCibi()
        {
            List<Cibo> cibi = new List<Cibo>();
            try
            {
                DataTable table = GetTable("USE [SmartRestaurant] Select * from Cibo");
                foreach (DataRow row in table.Rows)
                {
                    Cibo c = new Cibo();
                    c.IsSelect = bool.Parse(row["Selezionato"].ToString());
                    c.IdCibo = int.Parse(row["IDCibo"].ToString());
                    c.NomeCibo = row["NomeCibo"].ToString();
                    c.PrezzoCibo = float.Parse(row["PrezzoCibo"].ToString());
                    c.TipologiaCibo = row["TipologiaCibo"].ToString();
                    c.Vegetariano = int.Parse(row["Vegetariano"].ToString());
                    cibi.Add(c);
                }
            }
            catch (Exception e)
            {
                cibi = null;
                MessageBox.Show("Errore GetCibi" + e);
            }
            return cibi;
        }


        // Prende la lista dei cibi selezionati per l'ordine
        public List<Ordine> GetOrdine(string idPrenotazione)
        {
            List<Ordine> cibiSelezionati = new List<Ordine>();
            try
            {
                // carico la tabella di tutti i cibi
                List<Cibo> cibi = GetCibi();
                DataTable table = GetTable("Select * from Ordine");
                foreach (DataRow row in table.Rows)
                {
                    if (row["IDPrenotazione"].ToString() == idPrenotazione)
                    {
                        Ordine ordine = new Ordine();
                        // popolo tutti i campi di cibo tranne la quantita
                        Cibo c = cibi.Where(x => x.IdCibo == int.Parse(row["IDCibo"].ToString())).FirstOrDefault();
                        // fa la "copia" dei cibi selezionati dal menu in Ordine
                        c.CopyTo(ordine);
                        // aggiungo la quantita
                        ordine.Quantita = int.Parse(row["Quantita"].ToString());
                        cibiSelezionati.Add(ordine);
                    }
                }
            }
            catch (Exception e)
            {
                cibiSelezionati = null;
                MessageBox.Show("Errore GetOrdine" + e);
            }
            return cibiSelezionati;

        }


        // Scrive l'ordine nel database
        public bool SetOrdine(List<Ordine> cibi, string idPrenotazione)
        {
            string query = "USE[SmartRestaurant] INSERT INTO [dbo].[Ordine]" +
                "([IDPrenotazione]," +
                "[IDCibo]," +
                "[Quantita]) " +
                "VALUES (@IDPrenotazione, @IDCibo, @Quantita)";

            foreach (Ordine c in cibi)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDPrenotazione", idPrenotazione);
                command.Parameters.AddWithValue("@IDCibo", c.IdCibo);
                command.Parameters.AddWithValue("@Quantita", c.Quantita);

                // esegue la query
                int result = command.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("Errore liberamento tavolo della prenotazione: " + idPrenotazione);
                    return false;
                } 
            }
            return true;
        }


        // Elimina l'ordine
        public bool DeleteOrdine(string idPrenotazione, string idCibo)
        {
            string query = "USE [SmartRestaurant] DELETE FROM [Ordine] " +
                "WHERE [IDPrenotazione] = @IDPrenotazione AND IDCibo = @IDCibo";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDPrenotazione", idPrenotazione);
                command.Parameters.AddWithValue("@IDCibo", idCibo);
                // esegue la query
                int result = command.ExecuteNonQuery();
                if (result <= 0)
                {
                    MessageBox.Show("Errore eliminazione ordine nel database con prenotazione: " + idPrenotazione.ToString()
                        +" e id cibo: "+idCibo);
                    return false;
                }
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("Errore eliminazione ordine nel database" + e.Message);
                return false;
            }

        }
    }
}
