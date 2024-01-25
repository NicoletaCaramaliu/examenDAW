using examenDAW.Data;
using examenDAW.Models.Participant;
using examenDAW.Repositories.GenericRepository;

namespace examenDAW.Repositories.ParticipantRepository
{
    public class ParticipantRepository : GenericRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
    
   }

