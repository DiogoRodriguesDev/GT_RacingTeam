using GT_RT_BackEnd.Commands.CompeticaoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CompeticaoHandlers
{
    public class DeleteCompeticaoHandler : IRequestHandler<DeleteCompeticaoCommand>
    {
        IDataContext _dataContext;
        public DeleteCompeticaoHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Handle(DeleteCompeticaoCommand request, CancellationToken cancellationToken)
        {
            var Competicoes = _dataContext.Competicoes;

            var Competicao = Competicoes.FirstOrDefault(x => x.Id == request.Id);

            if (Competicao is not null)
            {
                Competicao.IsDeleted = true;
                await _dataContext.SaveChangesAsync();
            }
        }
    }
}
