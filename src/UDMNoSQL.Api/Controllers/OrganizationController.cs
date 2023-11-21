using System.Net;
using DnsClient.Internal;
using Microsoft.AspNetCore.Mvc;
using UDMNoSQL.Api.Models.Party;
using UDMNoSQL.Api.Repositories.Interfaces;

namespace UDMNoSQL.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]/[action]")]
    public class OrganizationController : ControllerBase
    {
        private readonly IPartyRepository<Organization> _partyRepository;
        private readonly ILogger<EmploymentController> _logger;

        public OrganizationController(IPartyRepository<Organization> partyRepository, ILogger<EmploymentController> logger)
        {
            _partyRepository = partyRepository ?? throw new ArgumentNullException(nameof(partyRepository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet(Name = "GetOrganizationList")]
        [ProducesResponseType(typeof(IEnumerable<Organization>), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<IEnumerable<Organization>>> GetOrganizationList()
        {
            var OrganizationList = await _partyRepository.GetPartyList();
            return Ok(OrganizationList);
        }

        [HttpGet("{partyId}", Name = "GetOrganization")]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        [ProducesResponseType(typeof(Organization), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<Organization>> GetOrganization(string partyId)
        {
            var Organization = await _partyRepository.GetParty(partyId);

            if (Organization == null)
            {
                _logger.LogError($"Organization not found.");
                return NotFound();
            }

            return Ok(Organization);
        }

        [HttpPost]
        [ProducesResponseType(typeof(Organization), (int)HttpStatusCode.OK)   ]
        public async Task<ActionResult<Organization>> CreateOrganization([FromBody] Organization organization)
        {
            await _partyRepository.CreateParty(organization);

            return CreatedAtRoute("GetOrganization", new { partyId = organization.PartyId }, organization);
        }

        [HttpPut]
        [ProducesResponseType(typeof(Organization), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> UpdateOrganization([FromBody] Organization person)
        {
            return Ok(await _partyRepository.UpdateParty(person));
        }

        [HttpDelete("{partyId}", Name = "DeleteOrganization")]
        [ProducesResponseType(typeof(Employee), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> DeleteOrganization(string partyId)
        {
            return Ok(await _partyRepository.DeleteParty(partyId));
        }
    }
}
