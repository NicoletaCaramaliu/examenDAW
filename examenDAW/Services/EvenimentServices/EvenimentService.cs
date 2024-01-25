using examenDAW.Models.Eveniment;
using examenDAW.Repositories.EvenimentRepository;

namespace examenDAW.Services.EvenimentServices
{
    public class EvenimentService : IEvenimentService
    {
        private readonly IEvenimentRepository _evenimentRepository;

        public EvenimentService(IEvenimentRepository evenimentRepository)
        {
            _evenimentRepository = evenimentRepository;
        }

        public async Task<IEnumerable<Eveniment>> GetAllEvenimente()
        {
            return await _evenimentRepository.GetAllAsync();
        }

        public async Task CreateEveniment(Eveniment eveniment)
        {
            await _evenimentRepository.CreateAsync(eveniment);
        }

        //get  by id
        public async Task<Eveniment> GetEvenimentById(Guid id)
        {
            return await _evenimentRepository.FindByIdAsync(id);
        }
    }
}
