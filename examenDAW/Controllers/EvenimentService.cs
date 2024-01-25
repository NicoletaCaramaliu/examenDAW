using AutoMapper;
using examenDAW.Models.Eveniment;
using examenDAW.Models.Eveniment.EvenimentDto;
using examenDAW.Services.EvenimentServices;
using Microsoft.AspNetCore.Mvc;

namespace examenDAW.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EvenimentService : ControllerBase
    {
        private readonly IEvenimentService _evenimentService;
        private readonly IMapper _mapper;

        public EvenimentService(IEvenimentService evenimentService, IMapper mapper)
        {
            _evenimentService = evenimentService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAllEvenimente()
        {
            var evenimente = _evenimentService.GetAllEvenimente();
            var evenimenteDto = _mapper.Map<IEnumerable<EvenimentResponse>>(evenimente);
            return Ok(evenimenteDto);
        }

        [HttpPost]
        public IActionResult CreateEveniment([FromBody] EvenimentRequest evenimentRequest)
        {
            var eveniment = _mapper.Map<Eveniment>(evenimentRequest);
            _evenimentService.CreateEveniment(eveniment);
            return Ok(eveniment);
        }

        //get by id
        [HttpGet("{id:guid}")]
        public IActionResult GetEvenimentById(Guid id)
        {
            var eveniment = _evenimentService.GetEvenimentById(id);
            var evenimentDto = _mapper.Map<EvenimentResponse>(eveniment);
            return Ok(evenimentDto);
        }
    }
}
