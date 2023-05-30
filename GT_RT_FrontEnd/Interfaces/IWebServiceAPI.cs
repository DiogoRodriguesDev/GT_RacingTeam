using ClassLibrary_GT_RT;
using Refit;
using Microsoft.AspNetCore.Mvc;

namespace GT_RT_FrontEnd.Interfaces
{
    public interface IWebServiceAPI
    {
        [Get("/pilotos")]
        public Task<List<Piloto>> GetPilotos();

        [Get("/piloto-details/{id}")]
        public Task<Piloto> GetPiloto(int id);

        [Get("/Piloto_Categorias")]
        public Task<List<Piloto_Categorias>> GetCategorias();

        [Get("/Piloto_Equipas")]
        public Task<List<Equipa>> GetEquipas();

        [Post("/pilotoS")]
        public Task<Piloto> CreatePiloto([Body] Piloto newPiloto);

        [Put("/piloto-edit/{id}")]
        public Task<Piloto> UpdatePiloto([FromBody] Piloto updatedPiloto, int id);

        [Delete("/pilotos/{id}")]
        public Task DeletePiloto(int id);




        [Get("/Corridas")]
        public Task<List<Corrida>> GetCorridas();

        [Get("/Corrida-details/{id}")]
        public Task<Corrida> GetCorrida(int id);

        [Post("/CorridaS")]
        public Task<Corrida> CreateCorrida([Body] Corrida newCorrida);

        [Put("/Corrida-edit/{id}")]
        public Task<Corrida> UpdateCorrida([FromBody] Corrida updatedCorrida, int id);

        [Delete("/Corridas/{id}")]
        public Task DeleteCorrida(int id);



        [Get("/ResultadoCorrida")]
        public Task<List<ResultadoCorrida>> GetResultadoCorrida();

        [Get("/ResultadoCorrida-details/{id}")]
        public Task<ResultadoCorrida> GetResultadoCorrida(int id);

        [Post("/ResultadoCorrida-Add")]
        public Task<ResultadoCorrida> CreateResultadoCorrida([Body] ResultadoCorrida newResultadoCorrida);

        [Put("/ResultadoCorrida-edit/{id}")]
        public Task<ResultadoCorrida> UpdateResultadoCorrida([FromBody] Corrida updatedResultadoCorrida, int id);

        [Delete("/ResultadoCorrida/{id}")]
        public Task DeleteResultadoCorrida(int id);



        [Get("/Competicoes")]
        public Task<List<Competicao>> GetCompeticoes();

        [Get("/Competicao-details/{id}")]
        public Task<Competicao> GetCompeticao(int id);

        [Post("/Competicao")]
        public Task<Competicao> CreateCompeticao([Body] Competicao newCompeticao);

        [Put("/Competicao-edit/{id}")]
        public Task<Competicao> UpdateCompeticao([FromBody] Competicao updatedCompeticao, int id);

        [Delete("/Competicao/{id}")]
        public Task DeleteCompeticao(int id);
    }
}
