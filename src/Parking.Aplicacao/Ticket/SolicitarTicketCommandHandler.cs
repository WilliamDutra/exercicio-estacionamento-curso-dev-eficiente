using System;
using Parking.Shared;
using Entidade = Parking.Dominio;
using Parking.Dominio.Repositorios;
using Parking.Dominio.Commands.Ticket;

namespace Parking.Aplicacao.Ticket
{
    public class SolicitarTicketCommandHandler : ICommandHandler<SolicitarTicketCommand, CommandResult>
    {
        private IParkingRepositorio _parkingRepositorio;

        public SolicitarTicketCommandHandler(IParkingRepositorio parkingRepositorio)
        {
            _parkingRepositorio = parkingRepositorio;
        }

        public CommandResult Handle(SolicitarTicketCommand command)
        {
            var periodo = new Entidade.Periodo(DateTime.Now);

            var vaga = _parkingRepositorio.ObterVagaPorId(command.VagaId);

            if (vaga == null)
                return new CommandResult(false, "Vaga não encontrada!");

            var ticket = Entidade.Ticket.Criar(vaga, periodo);

            return new CommandResult(true, "ticket emitido com sucesso!");
        }
    }
}
