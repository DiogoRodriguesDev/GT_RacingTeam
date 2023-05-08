using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands.CorridaCommands
{
    public record UpdateCorridaCommand(Corrida Corrida, int Id) :IRequest<Corrida>;
}
