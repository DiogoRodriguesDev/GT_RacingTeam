using GT_RT_BackEnd.Commands.PilotoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;
using System.Drawing;


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
                piloto.Nickname = request.Piloto.Nickname;
                piloto.Descricao = request.Piloto.Descricao;
                piloto.Id_Equipa = request.Piloto.Id_Equipa;
                piloto.PaisRegiao = request.Piloto.PaisRegiao;
                piloto.Valor = request.Piloto.Valor;
                piloto.Id_Piloto_Categoria = request.Piloto.Id_Piloto_Categoria;
                piloto.Foto = request.Piloto.Foto;

                await _dataContext.SaveChangesAsync(cancellationToken);
            }
            return piloto;
        }
    }
}
