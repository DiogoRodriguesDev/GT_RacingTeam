using GT_RT_BackEnd.Commands.ResultadoCorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;
using System.Drawing;


namespace GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers
{
    public class UpdateResultadoCorridaHandler : IRequestHandler<UpdateResultadoCorridaCommand, ResultadoCorrida>
    {
        IDataContext _dataContext;
        public UpdateResultadoCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ResultadoCorrida> Handle(UpdateResultadoCorridaCommand request, CancellationToken cancellationToken)
        {
            var ResultadoCorrida = _dataContext.ResultadoCorrida.FirstOrDefault(x => x.Id_ResultadoCorrida == request.Id);
            if (ResultadoCorrida == null)
            {
                return null;
            }
            else
            {
                ResultadoCorrida.Id_ResultadoCorrida = request.ResultadoCorrida.Id_ResultadoCorrida;
                ResultadoCorrida.IsDeleted = request.ResultadoCorrida.IsDeleted;
                ResultadoCorrida.Id_piloto = request.ResultadoCorrida.Id_piloto;
                ResultadoCorrida.Id_corrida = request.ResultadoCorrida.Id_corrida;
                ResultadoCorrida.Tempo_total = request.ResultadoCorrida.Tempo_total;
                ResultadoCorrida.Pontos = request.ResultadoCorrida.Pontos;
                ResultadoCorrida.PosicaoFinal = request.ResultadoCorrida.PosicaoFinal;

                await _dataContext.SaveChangesAsync(cancellationToken);
            }
            return ResultadoCorrida;
        }
    }
}
