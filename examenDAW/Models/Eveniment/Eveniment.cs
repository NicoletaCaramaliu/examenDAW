using examenDAW.Models.Base;

namespace examenDAW.Models.Eveniment
{
    public class Eveniment : BaseEntity
    {
        public string Nume { get; set; }

        public string? Location { get; set;}

        public ICollection<ParticipantiEvenimente.ParticipantiEvenimente> ParticipantiEvenimente { get; set; }

    }
}
