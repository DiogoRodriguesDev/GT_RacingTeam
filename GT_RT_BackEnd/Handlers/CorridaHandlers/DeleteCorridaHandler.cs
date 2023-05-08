using GT_RT_BackEnd.Commands.CorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CorridaHandlers
{
    public class DeleteCorridaHandler : IRequestHandler<DeleteCorridaCommand>
    {
        IDataContext _dataContext;
        public DeleteCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Handle(DeleteCorridaCommand request, CancellationToken cancellationToken)
        {
            var Corridas = _dataContext.Corridas;

            var Corrida = Corridas.FirstOrDefault(x => x.Id_corrida == request.Id);

            if (Corrida is not null)
            {
                Corrida.IsDeleted = true;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
