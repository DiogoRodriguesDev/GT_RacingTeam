using AutoMapper;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Data;
using GT_RT_BackEnd.Queries.Corridas;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CorridaHandlers
{
    public class GetCorridasHandler : IRequestHandler<GetCorridasQuery, List<Corrida>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetCorridasHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<Corrida>> Handle(GetCorridasQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Corridas.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Circuito.Contains(request.Search));
            }

            var handMapped = query.Select(x => new Corrida
            {
                Id_corrida = x.Id_corrida,
                Nome_Corrida = x.Nome_Corrida,
                Circuito = x.Circuito,
                Data = x.Data,
                CarrosPermitidos = x.CarrosPermitidos,
                IsDeleted = x.IsDeleted,
            }).ToList();

        var autoMapped = _mapper.Map<List<Corrida>>(query);

            return Task.FromResult(autoMapped);
            //return Task.FromResult(handMapped);
        }
    }
}
