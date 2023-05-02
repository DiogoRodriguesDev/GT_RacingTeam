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

        [Post("/pilotos")]
        public Task<Piloto> CreatePiloto([Body] Piloto newPiloto);

        [Put("/piloto-edit/{id}")]
        public Task<Piloto> UpdatePiloto([FromBody] Piloto updatedPiloto, int id);


        [Delete("/pilotos/{id}")]
        public Task DeletePiloto(int id);
    }
}
