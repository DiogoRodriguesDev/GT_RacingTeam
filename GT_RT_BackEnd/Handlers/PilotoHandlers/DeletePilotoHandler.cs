using GT_RT_BackEnd.Commands.PilotoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.PilotoHandlers
{
    public class DeletepilotoHandler : IRequestHandler<DeletePilotoCommand>
    {
        IDataContext _dataContext;
        public DeletepilotoHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Handle(DeletePilotoCommand request, CancellationToken cancellationToken)
        {
            var pilotos = _dataContext.Pilotos;

            var piloto = pilotos.FirstOrDefault(x => x.Id_piloto == request.Id);

            if (piloto is not null)
            {
                piloto.IsDeleted = true;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
