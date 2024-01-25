using examenDAW.Models.Base;
using examenDAW.Models;

namespace examenDAW.Models.ParticipantiEvenimente
{
    public class ParticipantiEvenimente : BaseEntity
    {
        //many to many relationship
        public Guid ParticipantId { get; set; }
        public Participant.Participant Participant { get; set; }

        public Guid EvenimentId { get; set; }
        public Eveniment.Eveniment Eveniment { get; set; }


    }
}
