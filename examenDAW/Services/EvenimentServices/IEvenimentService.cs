using examenDAW.Models.Eveniment;

namespace examenDAW.Services.EvenimentServices
{
    public interface IEvenimentService
    {
        Task<IEnumerable<Eveniment>> GetAllEvenimente();

        Task CreateEveniment(Eveniment eveniment);

        //get by id
        Task<Eveniment> GetEvenimentById(Guid id);
    }
}
