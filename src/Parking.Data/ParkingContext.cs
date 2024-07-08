using Npgsql;
using System;

namespace Parking.Data
{
    public class ParkingContext : IDisposable
    {
        public NpgsqlConnection Conexao;

        public ParkingContext(string connectionString)
        {
            Conexao = new NpgsqlConnection(connectionString);
            Conexao.Open();
        }

        public void Dispose()
        {
            Conexao?.Dispose();
        }
    }
}
