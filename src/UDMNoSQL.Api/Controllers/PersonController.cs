using System.Net;
using DnsClient.Internal;
using Microsoft.AspNetCore.Mvc;
using UDMNoSQL.Api.Models.Party;
using UDMNoSQL.Api.Repositories.Interfaces;

namespace UDMNoSQL.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        private readonly IPartyRepository<Person> _partyRepository;
        private readonly ILogger<EmploymentController> _logger;

        public PersonController(IPartyRepository<Person> partyRepository, ILogger<EmploymentController> logger)
        {
            _partyRepository = partyRepository ?? throw new ArgumentNullException(nameof(partyRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet(Name = "GetPersonList")]
        [ProducesResponseType(typeof(IEnumerable<Person>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Person>>> GetPersonList()
        {
            var personList = await _partyRepository.GetPartyList();
            return Ok(personList);
        }

        [HttpGet("{partyId}", Name = "GetPerson")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Person>> GetPerson(string partyId)
        {
            var person = await _partyRepository.GetParty(partyId);

            if (person == null)
            {
                _logger.LogError($"Person not found.");
                return NotFound();
            }

            return Ok(person);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)   ]
        public async Task<ActionResult<Person>> CreatePerson([FromBody] Person person)
        {
            await _partyRepository.CreateParty(person);

            return CreatedAtRoute("GetPerson", new { partyId = person.PartyId }, person);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Person), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdatePerson([FromBody] Person person)
        {
            return Ok(await _partyRepository.UpdateParty(person));
        }

        [HttpDelete("{partyId}", Name = "DeletePerson")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeletePerson(string partyId)
        {
            return Ok(await _partyRepository.DeleteParty(partyId));
        }
    }
}
