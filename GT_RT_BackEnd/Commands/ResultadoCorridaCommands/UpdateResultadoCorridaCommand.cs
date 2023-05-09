using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands.ResultadoCorridaCommands
{
    public record UpdateResultadoCorridaCommand(ResultadoCorrida ResultadoCorrida, int Id) : IRequest<ResultadoCorrida>;
}
