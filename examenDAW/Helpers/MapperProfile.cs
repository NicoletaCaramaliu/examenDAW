using AutoMapper;
using examenDAW.Models.Eveniment;
using examenDAW.Models.Eveniment.EvenimentDto;

namespace examenDAW.Helpers
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            // CreateMap<Source, Destination>();
            CreateMap<Eveniment, EvenimentResponse>();
            CreateMap<EvenimentRequest, Eveniment>();

            CreateMap<Models.Participant.Participant, Models.Participant.ParticipantDto.ParticipantResponse>();
            CreateMap<Models.Participant.ParticipantDto.ParticipantRequest, Models.Participant.Participant>();
        }
    }
}
