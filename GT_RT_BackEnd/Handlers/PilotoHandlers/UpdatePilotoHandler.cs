using GT_RT_BackEnd.Commands.PilotoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;


namespace GT_RT_BackEnd.Handlers.PilotoHandlers
{
    public class UpdatePilotoHandler : IRequestHandler<UpdatePilotoCommand, Piloto>
    {
        IDataContext _dataContext;
        public UpdatePilotoHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Piloto> Handle(UpdatePilotoCommand request, CancellationToken cancellationToken)
        {
            var piloto = _dataContext.Pilotos.FirstOrDefault(x => x.Id_piloto == request.Id);
            if (piloto == null)
            {
                return null;
            }
            else
            {
                piloto.Nome = request.Piloto.Nome;
                piloto.Descricao = request.Piloto.Descricao;

                await _dataContext.SaveChangesAsync(cancellationToken);
            }
            return piloto;
        }
    }
}
