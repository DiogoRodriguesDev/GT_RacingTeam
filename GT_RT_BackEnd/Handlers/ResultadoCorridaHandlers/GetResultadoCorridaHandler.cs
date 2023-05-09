using GT_RT_BackEnd.Queries.ResultadoCorridas;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers
{
    public class GetResultadoCorridaHandle : IRequestHandler<GetResultadoCorridaQuery, ResultadoCorrida>
    {
        IDataContext _dataContext;

        public GetResultadoCorridaHandle(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<ResultadoCorrida> Handle(GetResultadoCorridaQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.ResultadoCorrida.Where(x => x.Id_ResultadoCorrida == request.ResultadoCorridaRequest.Id_ResultadoCorridas).FirstOrDefault();

            return Task.FromResult(query);
        }
    }
}
