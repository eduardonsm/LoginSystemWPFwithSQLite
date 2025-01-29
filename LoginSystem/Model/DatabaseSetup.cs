using System;
using System.Data.SQLite;
using System.IO;

public class DatabaseSetup
{
    public string? ConnectionString { get; private set; }

    public string CreateDatabase()
    {
        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
        string dbDirectory = Path.Combine(projectDirectory, @"..\..\..\Model\Data");

        dbDirectory = Path.GetFullPath(dbDirectory);

        if (!Directory.Exists(dbDirectory))
        {
            Directory.CreateDirectory(dbDirectory);
        }

        string dbPath = Path.Combine(dbDirectory, "LoginSystem.db");
        ConnectionString = $"Data Source={dbPath}";


        try
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS users (
                        id INTEGER PRIMARY KEY AUTOINCREMENT,
                        username TEXT NOT NULL UNIQUE,
                        password TEXT NOT NULL,
                        email TEXT NOT NULL UNIQUE,
                        role TEXT DEFAULT 'user',
                        created_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP
                    );
                ";

                using (var command = new SQLiteCommand(createTableQuery, connection))
                {
                    command.ExecuteNonQuery();
                }

                return ("Banco de dados e tabela criados com sucesso!");
            }
        }
        catch (Exception ex)
        {
            return ("Erro ao criar o banco de dados: " + ex.Message);
        }
    }
}
