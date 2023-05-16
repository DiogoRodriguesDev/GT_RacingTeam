using GT_RT_BackEnd.Commands.CompeticaoCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;
using System.Drawing;
using Microsoft.AspNetCore.Components.Server.Circuits;


namespace GT_RT_BackEnd.Handlers.CompeticaoHandlers
{
    public class UpdateCompeticaoHandler : IRequestHandler<UpdateCompeticaoCommand, Competicao>
    {
        IDataContext _dataContext;
        public UpdateCompeticaoHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Competicao> Handle(UpdateCompeticaoCommand request, CancellationToken cancellationToken)
        {
            var Competicao = _dataContext.Competicoes.FirstOrDefault(x => x.Id == request.Id);
            if (Competicao == null)
            {
                return null;
            }
            else
            {
                Competicao.Id = request.Id;
                Competicao.IsDeleted = request.Competicao.IsDeleted;
                Competicao.Nome = request.Competicao.Nome;
                Competicao.Descricao = request.Competicao.Descricao;
                Competicao.Foto = request.Competicao.Foto;
                Competicao.Id_Piloto_Categoria = request.Competicao.Id_Piloto_Categoria;

                await _dataContext.SaveChangesAsync(cancellationToken);
            }
            return Competicao;
        }
    }
}
