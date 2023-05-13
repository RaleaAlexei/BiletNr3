using Agentie.Classes;
using System.Data.SQLite;
namespace Prob1.Classes
{
    internal class Database
    {

        public SQLiteConnection? sqlite_conn;
        private static string dbName = "Agentie.db";
        private static string payload = $"Data Source={dbName}";
        private static string dbCreation = @"
            CREATE TABLE Angajat(
	""ID""	INTEGER NOT NULL,
	""Nume""	TEXT NOT NULL,
	""Prenume""	TEXT NOT NULL,
	""Salariul""	INTEGER NOT NULL,
    PRIMARY KEY(ID)
);
        ";
        public bool Open()
        {
            sqlite_conn = CreateConnection();
            SQLiteCommand command = sqlite_conn.CreateCommand();
            command.CommandText = "SELECT Nume FROM Angajat";
            try
            {
                command.ExecuteScalar();
            }
            catch (Exception ex)
            {
                command.CommandText = dbCreation;
                command.ExecuteNonQuery();
            }
            return sqlite_conn != null;
        }
        private SQLiteConnection? CreateConnection()
        {

            SQLiteConnection? sqlite_conn;
            sqlite_conn = new SQLiteConnection(payload);
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                sqlite_conn = null;
            }
            return sqlite_conn;
        }
        public bool scrieAngajat(Agent agent)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO Angajat(ID, Nume, Prenume, Salariul) VALUES(@param1, @param2, @param3, @param4);";
            sqlite_cmd.Parameters.AddWithValue("@param1", agent.ID);
            sqlite_cmd.Parameters.AddWithValue("@param2", agent.Nume);
            sqlite_cmd.Parameters.AddWithValue("@param3", agent.Prenume);
            sqlite_cmd.Parameters.AddWithValue("@param4", agent.Salariul);
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool stergeAngajat(Agent agent)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "DELETE FROM Angajat WHERE ID = @param1;";
            sqlite_cmd.Parameters.AddWithValue("@param1", agent.ID);
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public bool modificaAngajat(Agent agent)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = sqlite_conn.CreateCommand();
            sqlite_cmd.CommandText = "UPDATE Angajat SET Nume = @param1, Prenume = @param2, Salariul = @param3 WHERE ID = @param4;";
            sqlite_cmd.Parameters.AddWithValue("@param1", agent.Nume);
            sqlite_cmd.Parameters.AddWithValue("@param2", agent.Prenume);
            sqlite_cmd.Parameters.AddWithValue("@param3", agent.Salariul);
            sqlite_cmd.Parameters.AddWithValue("@param4", agent.ID);
            try
            {
                sqlite_cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
