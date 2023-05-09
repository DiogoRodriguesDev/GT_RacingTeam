using GT_RT_BackEnd.Commands.ResultadoCorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers
{
    public class DeleteResultadoCorridaHandler : IRequestHandler<DeleteResultadoCorridaCommand>
    {
        IDataContext _dataContext;
        public DeleteResultadoCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Handle(DeleteResultadoCorridaCommand request, CancellationToken cancellationToken)
        {
            var ResultadoCorridas = _dataContext.ResultadoCorrida;

            var ResultadoCorrida = ResultadoCorridas.FirstOrDefault(x => x.Id_ResultadoCorrida == request.Id);

            if (ResultadoCorrida is not null)
            {
                ResultadoCorrida.IsDeleted = true;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
