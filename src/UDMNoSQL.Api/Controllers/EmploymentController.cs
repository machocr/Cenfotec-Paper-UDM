using System.Net;
using DnsClient.Internal;
using Microsoft.AspNetCore.Mvc;
using UDMNoSQL.Api.Models.HumanResources;
using UDMNoSQL.Api.Models.Party;
using UDMNoSQL.Api.Repositories.Interfaces;

namespace UDMNoSQL.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class EmploymentController : ControllerBase
    {
        private readonly IPartyRelationshipRepository<Employment> _partyRelationshipRepository;
        private readonly IPartyRepository<Party> _partyRepository;
        private readonly ILogger<EmploymentController> _logger;

        public EmploymentController(IPartyRelationshipRepository<Employment> partyRelationshipRepository, IPartyRepository<Party> partyRepository, ILogger<EmploymentController> logger)
        {
            _partyRelationshipRepository = partyRelationshipRepository ?? throw new ArgumentNullException(nameof(partyRelationshipRepository));
            _partyRepository = partyRepository ?? throw new ArgumentNullException(nameof(partyRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{internalOrganizationId}", Name = "GetEmploymentList")]
        [ProducesResponseType(typeof(IEnumerable<Employment>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Employment>>> GetEmploymentList(string internalOrganizationId)
        {
            var employmentList = await _partyRelationshipRepository.GetPartyRelationshipList(internalOrganizationId);
            employmentList.ToList<Employment>().ForEach(async x => x.FromParty = (Organization)await _partyRepository.GetParty(x.FromPartyId));
            employmentList.ToList<Employment>().ForEach(async x => x.ToParty = (Person)await _partyRepository.GetParty(x.ToPartyId));
            return Ok(employmentList);
        }

        [HttpGet("{internalOrganizationId},{employeeId}", Name = "GetEmployment")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Employment), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Employee>> GetEmployment(string internalOrganizationId, string employeeId)
        {
            var employment = await _partyRelationshipRepository.GetPartyRelationship(internalOrganizationId, employeeId);

            if (employment == null)
            {
                _logger.LogError($"Employment not found.");
                return NotFound();
            }

            employment.FromParty = (Organization)await _partyRepository.GetParty(employment.FromPartyId);
            employment.ToParty = (Person)await _partyRepository.GetParty(employment.ToPartyId);

            return Ok(employment);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Employment), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Employment>> CreateEmployment([FromBody] Employment employment)
        {
            await _partyRelationshipRepository.CreatePartyRelationship(employment);

            return CreatedAtRoute("GetEmployment", new { internalOrganizationId = employment.ToPartyId, employeeId = employment.FromPartyId }, employment);
        }

        [HttpDelete("{internalOrganizationId}/{employeeId}", Name = "DeleteEmployment")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteEmployment(string internalOrganizationId, string employeeId)
        {
            return Ok(await _partyRelationshipRepository.DeletePartyRelationship(internalOrganizationId, employeeId));
        }
    }
}
