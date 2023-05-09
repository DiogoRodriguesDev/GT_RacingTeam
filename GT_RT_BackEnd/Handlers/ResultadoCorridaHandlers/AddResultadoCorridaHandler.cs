using GT_RT_BackEnd.Commands.ResultadoCorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers
{
    public class AddResultadoCorridaHandler : IRequestHandler<AddResultadoCorridaCommand, ResultadoCorrida>
    {
        IDataContext _dataContext;

        public AddResultadoCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<ResultadoCorrida> Handle(AddResultadoCorridaCommand request, CancellationToken cancellationToken)
        {
            var ResultadoCorrida = _dataContext.ResultadoCorrida;

            if (ResultadoCorrida == null)
            {
                return null;
            }
            else
            {
                try
                {
                    await ResultadoCorrida.AddAsync(request.ResultadoCorrida);
                    await _dataContext.SaveChangesAsync(cancellationToken);

                    return request.ResultadoCorrida;
                }
                catch (Exception e)
                {

                    throw;
                }
            }


        }
    }
}
