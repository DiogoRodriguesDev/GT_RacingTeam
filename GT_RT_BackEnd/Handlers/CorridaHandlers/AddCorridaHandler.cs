using GT_RT_BackEnd.Commands.CorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.CorridaHandlers
{
    public class AddCorridaHandler : IRequestHandler<AddCorridaCommand, Corrida>
    {
        IDataContext _dataContext;

        public AddCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<Corrida> Handle(AddCorridaCommand request, CancellationToken cancellationToken)
        {
            var Corrida = _dataContext.Corridas;

            if (Corrida == null)
            {
                return null;
            }
            else
            {
                try
                {
                    await Corrida.AddAsync(request.Corrida);
                    await _dataContext.SaveChangesAsync(cancellationToken);

                    return request.Corrida;
                }
                catch (Exception e)
                {

                    throw;
                }
            }


        }
    }
}
