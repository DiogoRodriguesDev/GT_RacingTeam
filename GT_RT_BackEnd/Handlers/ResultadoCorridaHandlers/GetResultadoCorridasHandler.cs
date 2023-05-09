using AutoMapper;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Data;
using GT_RT_BackEnd.Queries.ResultadoCorridas;
using MediatR;

namespace GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers
{
    public class GetResultadoCorridasHandler : IRequestHandler<GetResultadoCorridasQuery, List<ResultadoCorrida>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetResultadoCorridasHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<ResultadoCorrida>> Handle(GetResultadoCorridasQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.ResultadoCorrida.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Id_ResultadoCorrida == request.Id_ResultadoCorrida || x.Id_corrida == request.Id_corrida); 
            }

            var handMapped = query.Select(x => new ResultadoCorrida
            {
                Id_ResultadoCorrida = x.Id_ResultadoCorrida,
                Id_piloto = x.Id_piloto,
                Id_corrida = x.Id_corrida,
                Tempo_total = x.Tempo_total,
                Pontos = x.Pontos,
                IsDeleted = x.IsDeleted,
                PosicaoFinal = x.PosicaoFinal
            }).ToList();

            var autoMapped = _mapper.Map<List<ResultadoCorrida>>(query);

            return Task.FromResult(autoMapped);
            //return Task.FromResult(handMapped);
        }
    }
}
