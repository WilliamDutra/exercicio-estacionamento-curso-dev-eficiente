using System;
using Parking.Shared;
using Parking.Dominio.Repositorios;
using Parking.Dominio.Commands.Vaga;

namespace Parking.Aplicacao.Vaga
{
    public class CadastrarVagaCommandHandler : ICommandHandler<CadastrarVagaCommand, CommandResult>
    {
        private IParkingRepositorio _parkingRepositorio;

        public CadastrarVagaCommandHandler(IParkingRepositorio parkingRepositorio)
        {
            _parkingRepositorio = parkingRepositorio;
        }

        public CommandResult Handle(CadastrarVagaCommand command)
        {

            return new CommandResult(true, "vaga cadastrada com sucesso!");
        }
    }
}
