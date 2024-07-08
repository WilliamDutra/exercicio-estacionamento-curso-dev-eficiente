using System;
using Parking.Shared;

namespace Parking.Dominio.Commands.Vaga
{
    public class CadastrarVagaCommand : ICommand
    {
        public Guid AndarId { get; set; }

        public ETipoVaga TipoVaga { get; set; }

    }
}
