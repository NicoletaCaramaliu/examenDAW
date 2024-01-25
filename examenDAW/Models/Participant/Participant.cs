using examenDAW.Models.Base;
using examenDAW.Models.Enums;

namespace examenDAW.Models.Participant
{
    public class Participant : BaseEntity
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public int Varsta { get; set; }

        public Roluri Roluri { get; set; }

        public ICollection<ParticipantiEvenimente.ParticipantiEvenimente> ParticipantiEvenimente { get; set; }

        
    }
}
