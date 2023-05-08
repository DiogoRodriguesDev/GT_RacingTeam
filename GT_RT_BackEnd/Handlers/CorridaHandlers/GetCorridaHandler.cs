using GT_RT_BackEnd.Queries.Corridas;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CorridaHandlers
{
    public class GetCorridaHandle : IRequestHandler<GetCorridaQuery, Corrida>
    {
        IDataContext _dataContext;

        public GetCorridaHandle(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<Corrida> Handle(GetCorridaQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Corridas.Where(x => x.Id_corrida == request.CorridaRequest.Id_corrida).FirstOrDefault();

            return Task.FromResult(query);
        }
    }
}
