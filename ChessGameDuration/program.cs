using System;
using System.Data.SQLite;
using System.IO;

namespace chessGameDuration
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=chess_games.db";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM games";

                using (var command = new SQLiteCommand(query, connection))
                using (var reader = command.ExecuteReader())
                {
                    using (StreamWriter writer = new StreamWriter("output.txt"))
                    {
                        writer.WriteLine("Núm. Partida | Início | Término | Tempo Total");

                        while (reader.Read())
                        {
                            int gameNumber = reader.GetInt32(0);
                            string start = reader.GetString(1);
                            string end = reader.GetString(2);

                            TimeSpan duration = CalculateGameDuration(start, end);

                            string durationString = duration.TotalHours > 12 ? "Jogo considerado empatado" : duration.ToString();
                            writer.WriteLine($"{gameNumber}          {start}       {end}       {durationString}");
                        }
                    }
                }
            }
        }

        static TimeSpan CalculateGameDuration(string start, string end)
        {
            TimeSpan startTime = TimeSpan.Parse(start);
            TimeSpan endTime = TimeSpan.Parse(end);
            TimeSpan duration = endTime - startTime;

            if (duration < TimeSpan.Zero)
            {
                duration += TimeSpan.FromHours(24);
            }

            return duration;
        }
    }
}
