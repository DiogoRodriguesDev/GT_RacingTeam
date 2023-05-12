using GT_RT_BackEnd.Commands.CorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;
using System.Drawing;
using Microsoft.AspNetCore.Components.Server.Circuits;


namespace GT_RT_BackEnd.Handlers.CorridaHandlers
{
    public class UpdateCorridaHandler : IRequestHandler<UpdateCorridaCommand, Corrida>
    {
        IDataContext _dataContext;
        public UpdateCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Corrida> Handle(UpdateCorridaCommand request, CancellationToken cancellationToken)
        {
            var Corrida = _dataContext.Corridas.FirstOrDefault(x => x.Id_corrida == request.Id);
            if (Corrida == null)
            {
                return null;
            }
            else
            {
                Corrida.Circuito = request.Corrida.Circuito;
                Corrida.Nome_Corrida = request.Corrida.Nome_Corrida;
                Corrida.Data = request.Corrida.Data;
                Corrida.Id_competicao = request.Corrida.Id_competicao;
                Corrida.CarrosPermitidos = request.Corrida.CarrosPermitidos;
                Corrida.Tipo_Pneus = request.Corrida.Tipo_Pneus;
                Corrida.NumeroVoltas = request.Corrida.NumeroVoltas;
                Corrida.NumeroMinutos = request.Corrida.NumeroMinutos;
                Corrida.Id_Resultado = request.Corrida.Id_Resultado;
                Corrida.IsDeleted = request.Corrida.IsDeleted;
                Corrida.VideoYoutube = request.Corrida.VideoYoutube;

                await _dataContext.SaveChangesAsync(cancellationToken);
            }
            return Corrida;
        }
    }
}
