using examenDAW.Data;
using examenDAW.Models.Eveniment;
using examenDAW.Repositories.GenericRepository;

namespace examenDAW.Repositories.EvenimentRepository
{
    public class EvenimentRepository : GenericRepository<Eveniment>, IEvenimentRepository
    {
        public EvenimentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
