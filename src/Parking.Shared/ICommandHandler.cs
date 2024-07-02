using System;

namespace Parking.Shared
{
    public interface ICommandHandler<TCommand, TCommandResult> where TCommand : ICommand
    {
        TCommandResult Handle(TCommand command);
    }
}
