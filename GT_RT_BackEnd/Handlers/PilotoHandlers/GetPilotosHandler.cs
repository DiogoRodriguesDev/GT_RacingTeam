using AutoMapper;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Data;
using GT_RT_BackEnd.Queries;
using MediatR;

namespace GT_RT_BackEnd.Handlers.PilotoHandlers
{
    public class GetPilotosHandler : IRequestHandler<GetPilotosQuery, List<Piloto>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetPilotosHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<Piloto>> Handle(GetPilotosQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Pilotos.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Nome.Contains(request.Search) || x.Descricao.Contains(request.Search));
            }

            var handMapped = query.Select(x => new Piloto
            {
                Id_piloto = x.Id_piloto,
                Nome = x.Nome,
                Nickname = x.Nickname,
                Descricao = x.Descricao,
                IsDeleted = x.IsDeleted,
                //Categoria = x.Categoria,
            }).ToList();

            var autoMapped = _mapper.Map<List<Piloto>>(query);

            return Task.FromResult(autoMapped);
            //return Task.FromResult(handMapped);
        }
    }
}
