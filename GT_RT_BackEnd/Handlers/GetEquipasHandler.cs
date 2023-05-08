using AutoMapper;
using ClassLibrary_GT_RT;
using GT_RT_BackEnd.Data;
using GT_RT_BackEnd.Queries;

using MediatR;

namespace GT_RT_BackEnd.Handlers.PilotoHandlers
{
    public class GetEquipasHandler : IRequestHandler<GetEquipasQuery, List<Equipa>>
    {
        IDataContext _dataContext;

        IMapper _mapper;
        public GetEquipasHandler(IDataContext dataContext, IMapper mapper)
        {
            _dataContext = dataContext;
            _mapper = mapper;
        }
        public Task<List<Equipa>> Handle(GetEquipasQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Equipas.AsQueryable();

            if (!string.IsNullOrEmpty(request.Search))
            {
                query = query.Where(x => x.Nome.Contains(request.Search));
            }

            var handMapped = query.Select(x => new Equipa
            {
                Id = x.Id,
                Nome = x.Nome,
            }).ToList();

            var autoMapped = _mapper.Map<List<Equipa>>(query);

            return Task.FromResult(autoMapped);
            //return Task.FromResult(handMapped);
        }
    }
}