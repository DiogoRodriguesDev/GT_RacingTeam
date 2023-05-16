using GT_RT_BackEnd.Queries.Competicoes;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CompeticaoHandlers
{
    public class GetCompeticaoHandle : IRequestHandler<GetCompeticaoQuery, Competicao>
    {
        IDataContext _dataContext;

        public GetCompeticaoHandle(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Task<Competicao> Handle(GetCompeticaoQuery request, CancellationToken cancellationToken)
        {
            var query = _dataContext.Competicoes.Where(x => x.Id == request.CompeticaoRequest.Id_Competicao).FirstOrDefault();

            return Task.FromResult(query);
        }
    }
}
