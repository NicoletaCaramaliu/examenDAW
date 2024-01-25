using examenDAW.Models.Participant;
using examenDAW.Repositories.ParticipantRepository;

namespace examenDAW.Services.ParticipantServices
{
    public class ParticipantService : IParticipantService
    {
        private readonly IParticipantRepository _participantRepository;

        public ParticipantService(IParticipantRepository participantRepository)
        {
            _participantRepository = participantRepository;
        }

        //get all participants
        public async Task<IEnumerable<Participant>> GetAllParticipants()
        {
            return await _participantRepository.GetAllAsync();
        }

        //create participant
        public async Task CreateParticipant(Participant participant)
        {
            await _participantRepository.CreateAsync(participant);
        }
    }
}
