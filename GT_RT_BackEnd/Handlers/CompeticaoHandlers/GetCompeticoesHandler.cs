using AutoMapper;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Data;
using GT_RT_BackEnd.Queries.Competicoes;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CompeticaoHandlers
{
    public class GetCompeticaosHandler : IRequestHandler<GetCompeticoesQuery, List<Competicao>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetCompeticaosHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<Competicao>> Handle(GetCompeticoesQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Competicoes.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Nome.Contains(request.Search));
            }

            var handMapped = query.Select(x => new Competicao
            {
                Id = x.Id,
                Descricao = x.Descricao,
                Foto = x.Foto,
                Id_Piloto_Categoria = x.Id_Piloto_Categoria,
                Nome = x.Nome,
                IsDeleted = x.IsDeleted,
            }).ToList();

            var autoMapped = _mapper.Map<List<Competicao>>(query);

            return Task.FromResult(autoMapped);
            //return Task.FromResult(handMapped);
        }
    }
}
