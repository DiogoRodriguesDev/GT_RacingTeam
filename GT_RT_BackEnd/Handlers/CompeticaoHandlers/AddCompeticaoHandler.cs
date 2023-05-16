using GT_RT_BackEnd.Commands.CompeticaoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CompeticaoHandlers
{
    public class AddCompeticaoHandler : IRequestHandler<AddCompeticaoCommand, Competicao>
    {
        IDataContext _dataContext;

        public AddCompeticaoHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<Competicao> Handle(AddCompeticaoCommand request, CancellationToken cancellationToken)
        {
            var Competicao = _dataContext.Competicoes;

            if (Competicao == null)
            {
                return null;
            }
            else
            {
                try
                {
                    await Competicao.AddAsync(request.Competicao);
                    await _dataContext.SaveChangesAsync(cancellationToken);

                    return request.Competicao;
                }
                catch (Exception e)
                {

                    throw;
                }
            }


        }
    }
}
