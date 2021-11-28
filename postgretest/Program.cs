using Npgsql;
using System;

namespace postgretest
{
    class Program
    {
        static void Main(string[] args)
        {
            var cs = "Host=localhost;Username=postgres;Password=230101;Database=postgres";

            using var con = new NpgsqlConnection(cs);
            con.Open();

            var sql = "SELECT version()";

            using var cmd = new NpgsqlCommand(sql, con);

            var version = cmd.ExecuteScalar().ToString();
            Console.WriteLine($"PostgreSQL version: {version}");
            Console.Read();
        }
    }
}
