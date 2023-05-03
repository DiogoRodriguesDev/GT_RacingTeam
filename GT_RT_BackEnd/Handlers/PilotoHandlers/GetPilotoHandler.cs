using GT_RT_BackEnd.Queries;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.PilotoHandlers
{
    public class GetPilotoHandle : IRequestHandler<GetPilotoQuery, Piloto>
    {
        IDataContext _dataContext;

        public GetPilotoHandle(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<Piloto> Handle(GetPilotoQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Pilotos.Where(x => x.Id_piloto == request.PilotoRequest.Id_piloto).FirstOrDefault();

            return Task.FromResult(query);
        }
    }
}
