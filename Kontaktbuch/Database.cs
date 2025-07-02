using System;
using Npgsql;

namespace Kontaktbuch
{
    internal static class Database
    {
        private const string ConnectionString = "Host=localhost;Port=5432;Username=postgres;Password=Gymnasium!;Database=Kontaktbuch";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(ConnectionString);
        }

        public static int InsertKontakt(Kontakt kontakt)   // inserts kontakt into sql database
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = "INSERT INTO kontakte (name, lastname, phone, email) " +
                        "VALUES (@name, @lastname, @phone, @email) " +
                        "Returning id";


            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("name", kontakt.Name);
            cmd.Parameters.AddWithValue("lastname", (object?)kontakt.LastName ?? DBNull.Value);
            cmd.Parameters.AddWithValue("phone", (object?)kontakt.Phone ?? DBNull.Value);
            cmd.Parameters.AddWithValue("email", (object?)kontakt.Email ?? DBNull.Value);

            return (int)cmd.ExecuteScalar(); // returns first row (id)

        }

        public static void DeleteKontakt(int id)
        {
            using var conn = GetConnection();
            conn.Open();

            string sql = "DELETE FROM kontakte WHERE id = @id ";


            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            cmd.ExecuteNonQuery();
        }

        public static List<Kontakt> LoadKontakte()
        {
            var kontakte = new List<Kontakt>();

            using var conn = GetConnection();   // get connection to sql database
                                                // closes after using because of "using"
            conn.Open(); // opens connection for sql querys

            string sql = "SELECT id, name, lastname, phone, email FROM kontakte";   // sql query

            using var cmd = new NpgsqlCommand(sql, conn);   // WRITE new sql command with query and connection

            using var reader = cmd.ExecuteReader(); // execute command

            while (reader.Read())
            {
                var kontakt = new Kontakt()
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    LastName = reader.IsDBNull(2) ? null: reader.GetString(2),
                    Phone = reader.IsDBNull(3) ? null : reader.GetString(3),
                    Email = reader.IsDBNull(4) ? null : reader.GetString(4)
                };
                kontakte.Add(kontakt);  // Adds kontakt to list kontakte
            }
            return kontakte;
        }




    }
}
