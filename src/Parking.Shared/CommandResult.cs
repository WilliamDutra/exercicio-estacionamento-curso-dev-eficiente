using System;

namespace Parking.Shared
{
    public class CommandResult : ICommand
    {
        public string Mensagem { get; private set; }

        public bool Sucesso { get; private set; }

        public CommandResult(bool sucesso, string mensagem)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
        }
    }
}
