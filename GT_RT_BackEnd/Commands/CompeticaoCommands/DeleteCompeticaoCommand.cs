using MediatR;

namespace GT_RT_BackEnd.Commands.CompeticaoCommands
{
    public record DeleteCompeticaoCommand(int Id) : IRequest;
}
