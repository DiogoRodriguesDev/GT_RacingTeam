using AutoMapper;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Data;
using GT_RT_BackEnd.Queries;

using MediatR;

namespace GT_RT_BackEnd.Handlers.PilotoHandlers
{
    public class GetPiloto_CategoriasHandler : IRequestHandler<GetPiloto_CategoriasQuery, List<Piloto_Categorias>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetPiloto_CategoriasHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<Piloto_Categorias>> Handle(GetPiloto_CategoriasQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Piloto_Categorias.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Nome_Piloto_Categoria.Contains(request.Search));
            }

            var handMapped = query.Select(x => new Piloto_Categorias
            {
                Id_Piloto_Categorias = x.Id_Piloto_Categorias,
                Nome_Piloto_Categoria = x.Nome_Piloto_Categoria,
            }).ToList();

            var autoMapped = _mapper.Map<List<Piloto_Categorias>>(query);

            return Task.FromResult(autoMapped);
            //return Task.FromResult(handMapped);
        }
    }
}