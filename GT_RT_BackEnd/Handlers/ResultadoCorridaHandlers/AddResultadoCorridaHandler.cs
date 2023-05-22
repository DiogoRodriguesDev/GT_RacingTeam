using GT_RT_BackEnd.Commands.ResultadoCorridaCommands;
using GT_RT_BackEnd.Data;
using ClassLibrary_GT_RT;
using MediatR;

namespace GT_RT_BackEnd.Handlers.ResultadoCorridaHandlers
{
    public class AddResultadoCorridaHandler : IRequestHandler<AddResultadoCorridaCommand, ResultadoCorrida>
    {
        IDataContext _dataContext;

        public AddResultadoCorridaHandler(IDataContext dataContext)
        {
            _dataContext = dataContext;
        }


        public async Task<ResultadoCorrida> Handle(AddResultadoCorridaCommand request, CancellationToken cancellationToken)
        {
            var ResultadoCorrida = _dataContext.ResultadoCorrida;
            var tabelaposicoesAntiga = _dataContext.Posicao.ToList();
            var tabelaposicoesNovaPRO = _dataContext.PosicaoNovosPontos_PRO.ToList();
            var tabelaposicoesNovaPROAM = _dataContext.PosicaoNovosPontos_PROAM.ToList();

            if (ResultadoCorrida == null)
            {
                return null;
            }
            else
            {
                try
                {
                    if (request.ResultadoCorrida.TipoDePontuacao == 1)//Se o tipo de pontuação for igual a 1 vai buscar os pontos da tabela antiga
                    {
                        var pontos = tabelaposicoesAntiga.Where(c => c.Numero_Posicao == request.ResultadoCorrida.PosicaoFinal).FirstOrDefault().Pontos_Da_Posicao;
                        request.ResultadoCorrida.Pontos = pontos;
                        if (request.ResultadoCorrida.VoltaRapida == true)
                        {
                            request.ResultadoCorrida.Pontos++;
                        }
                    }
                    else if (request.ResultadoCorrida.TipoDePontuacao == 2)//Se o tipo de pontuação for igual a 2 vai buscar os pontos da tabela nova da PRO.
                    {
                        var pontos = tabelaposicoesNovaPRO.Where(c => c.Numero_Posicao == request.ResultadoCorrida.PosicaoFinal).FirstOrDefault().Pontos_Da_Posicao;
                        request.ResultadoCorrida.Pontos = pontos;
                        if (request.ResultadoCorrida.VoltaRapida == true)
                        {
                            request.ResultadoCorrida.Pontos = request.ResultadoCorrida.Pontos + 2; //São dados 2 pontos ao pilotos que tem a volta mais rapida.
                        }
                    }
                    else if (request.ResultadoCorrida.TipoDePontuacao == 3) //Se o tipo de pontuação for igual a 3 vai buscar os pontos da tabela nova da PRO AM.)
                    {
                        var pontos = tabelaposicoesNovaPROAM.Where(c => c.Numero_Posicao == request.ResultadoCorrida.PosicaoFinal).FirstOrDefault().Pontos_Da_Posicao;
                        request.ResultadoCorrida.Pontos = pontos;
                        if (request.ResultadoCorrida.VoltaRapida == true)
                        {
                            request.ResultadoCorrida.Pontos = request.ResultadoCorrida.Pontos + 2; //São dados 2 pontos ao pilotos que tem a volta mais rapida.
                        }
                    }



                    await ResultadoCorrida.AddAsync(request.ResultadoCorrida);
                    await _dataContext.SaveChangesAsync(cancellationToken);

                    return request.ResultadoCorrida;
                }
                catch (Exception e)
                {

                    throw;
                }
            }


        }
    }
}
