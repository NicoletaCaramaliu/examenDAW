using examenDAW.Models.Participant;

namespace examenDAW.Services.ParticipantServices
{
    public interface IParticipantService
    {
        Task<IEnumerable<Participant>> GetAllParticipants();

        Task CreateParticipant(Participant participant);
    }
}
