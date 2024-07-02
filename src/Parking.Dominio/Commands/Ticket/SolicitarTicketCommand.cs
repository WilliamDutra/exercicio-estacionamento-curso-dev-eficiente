using System;
using Parking.Shared;

namespace Parking.Dominio.Commands.Ticket
{
    public class SolicitarTicketCommand : ICommand
    {
        public Guid VagaId { get; set; }

        public DateTime Entrada { get; set; }
    }
}
