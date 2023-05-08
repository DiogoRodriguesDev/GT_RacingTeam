using MediatR;

namespace GT_RT_BackEnd.Commands.CorridaCommands
{
    public record DeleteCorridaCommand(int Id) : IRequest;
}
