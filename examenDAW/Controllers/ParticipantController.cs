using AutoMapper;
using examenDAW.Models.Participant;
using examenDAW.Models.Participant.ParticipantDto;
using examenDAW.Services.ParticipantServices;
using Microsoft.AspNetCore.Mvc;

namespace examenDAW.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ParticipantController : ControllerBase
    {
        private readonly IParticipantService _participantService;
        private readonly IMapper _mapper;
        public ParticipantController(IParticipantService participantService, IMapper mapper)
        {
            _participantService = participantService;
            _mapper = mapper;
        }

        

        [HttpGet]
        public IActionResult GetAllParicipants()
        {
            var participants = _participantService.GetAllParticipants();
            var participantsDto = _mapper.Map<IEnumerable<ParticipantResponse>>(participants);
            return Ok(participantsDto);
        }

        [HttpPost]
        public IActionResult CreateParticipant([FromBody] ParticipantRequest participantRequest)
        {
            var participant = _mapper.Map<Participant>(participantRequest);
            _participantService.CreateParticipant(participant);
            return Ok(participant);
        }

    }
}
