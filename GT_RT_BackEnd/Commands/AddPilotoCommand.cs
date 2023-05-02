using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Commands
{
    public record AddPilotoCommand(Piloto Piloto) : IRequest<Piloto>;
}
