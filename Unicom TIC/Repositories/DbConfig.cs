using System.Data.SQLite;

public static class DbConfig
{
    // Define the connection string to SQLite database
    private static readonly string connectionString = @"Data Source=unicom.db;Version=3;";

    // Method to get the SQLite connection object
    public static SQLiteConnection GetConnection()
    {
        return new SQLiteConnection(connectionString);
    }
}
