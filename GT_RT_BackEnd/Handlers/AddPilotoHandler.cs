using GT_RT_BackEnd.Commands.PilotoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace DotNet001API.Handlers
{
    public class AddpilotoHandler : IRequestHandler<AddPilotoCommand, Piloto>
    {
        IDataContext _dataContext;

        public AddpilotoHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<Piloto> Handle(AddPilotoCommand request, CancellationToken cancellationToken)
        {
            var piloto = _dataContext.Pilotos;

            if (piloto == null)
            {
                return null;
            }
            else
            {
                try
                {
                    await piloto.AddAsync(request.piloto);
                    await _dataContext.SaveChangesAsync(cancellationToken);

                    return request.piloto;
                }
                catch (Exception e)
                {

                    throw;
                }
            }


        }
    }
}
