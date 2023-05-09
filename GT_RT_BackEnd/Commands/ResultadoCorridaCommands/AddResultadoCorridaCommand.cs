using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands.ResultadoCorridaCommands
{
    public record AddResultadoCorridaCommand(ResultadoCorrida ResultadoCorrida) : IRequest<ResultadoCorrida>;

}
