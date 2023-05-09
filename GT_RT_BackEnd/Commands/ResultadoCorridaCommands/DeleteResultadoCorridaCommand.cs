using MediatR;

namespace GT_RT_BackEnd.Commands.ResultadoCorridaCommands
{
    public record DeleteResultadoCorridaCommand(int Id) : IRequest;
}
