using Npgsql;
using Parking.Dominio;
using Parking.Dominio.Repositorios;

namespace Parking.Data
{
    public class ParkingRepositorio : IParkingRepositorio
    {
        private ParkingContext _DbContext;

        public ParkingRepositorio(ParkingContext dbContext)
        {
            _DbContext = dbContext;
        }

        public Vaga ObterVagaPorId(Guid vagaId)
        {
            Vaga vaga = null;

            string select = @$"select 
	                            codigo, 
	                            andar, 
	                            tipoVaga, 
	                            disponivel 
                            from 
	                            vaga where disponivel = 0 and codigo LIKE ('%' || @codigo || '%')";

            NpgsqlCommand command = new NpgsqlCommand(select, _DbContext.Conexao);
            command.Parameters.Add(new NpgsqlParameter("@codigo", vagaId));
            var reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                var andar = Andar.Restaurar(reader["andar"].ToString());
                vaga = Vaga.Restaurar(Guid.Parse(reader["codigo"].ToString()), andar, Enum.Parse<ETipoVaga>(reader["tipoVaga"].ToString()), reader["disponivel"].ToString() == "1" ? true : false);
            }

            reader.Close();

            return vaga;
        }

        public void SalvarTicket(Ticket ticket)
        {
            string insert = @"INSERT INTO ticket
                            (
	                            codigo,
	                            vagaId,
	                            entrada,
	                            statusId
                            )
                            VALUES
                            (
	                            @codigo,
	                            @vaga,
	                            @entrada,
	                            @status
                            )";

            var command = new NpgsqlCommand(insert, _DbContext.Conexao);
            command.Parameters.Add(new NpgsqlParameter("@codigo", ticket.Codigo));
            command.Parameters.Add(new NpgsqlParameter("@vaga", ticket.Vaga.Codigo));
            command.Parameters.Add(new NpgsqlParameter("@entrada", ticket.Periodo.HorarioEntrada));
            command.Parameters.Add(new NpgsqlParameter("@status", (int)ticket.Status));
            command.ExecuteNonQuery();
        }

        public void SalvarVaga(Vaga vaga)
        {
            string insert = @"INSERT INTO vaga
                            (
	                            codigo,
	                            andar,
	                            tipoVaga,
	                            disponivel
                            )
                            VALUES
                            (
	                            @codigo,
	                            @andar,
	                            @tipoVaga,
	                            @disponivel
                            )";

            NpgsqlCommand command = new NpgsqlCommand(insert, _DbContext.Conexao);
            command.Parameters.Add(new NpgsqlParameter("@codigo", vaga.Codigo));
            command.Parameters.Add(new NpgsqlParameter("@andar", vaga.Andar.Numero));
            command.Parameters.Add(new NpgsqlParameter("@tipoVaga", vaga.TipoVaga.ToString()));
            command.Parameters.Add(new NpgsqlParameter("@disponivel", vaga.EstaOcupada ? 1 : 0));
            command.ExecuteNonQuery();
        }
    }
}