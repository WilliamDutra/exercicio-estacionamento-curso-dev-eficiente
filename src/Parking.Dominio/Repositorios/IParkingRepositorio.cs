using System;

namespace Parking.Dominio.Repositorios
{
    public interface IParkingRepositorio
    {
        Vaga ObterVagaPorId(Guid vagaId);

        void SalvarTicket(Ticket ticket);

        void SalvarVaga(Vaga vaga);

    }
}
