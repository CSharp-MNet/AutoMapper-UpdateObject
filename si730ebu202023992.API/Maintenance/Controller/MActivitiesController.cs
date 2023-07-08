using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using si730ebu202023992.API.Maintenance.Dto.Request;
using si730ebu202023992.Domain.Maintenance.Interface;
using si730ebu202023992.Infraestructure.Maintenance.Model;

namespace si730ebu202023992.API.Maintenance.Controller
{
    [Route("api/v1")]
    [ApiController]
    public class MActivitiesController : ControllerBase
    {
        private IMapper _mapper;
        private IMActivitiesDomain _imActivitiesDomain;
        
        public MActivitiesController(IMActivitiesDomain imActivitiesDomain, IMapper mapper)
        {
            _mapper = mapper;
            _imActivitiesDomain = imActivitiesDomain;
        }

        [HttpPost("maintenance-activities")]
        public async Task<IActionResult> PostMActivitiesAsync([FromBody] MActivitiesRequest mActivitiesRequest)
        {
            if (ModelState.IsValid)
            {
                var mActivities = _mapper.Map<MActivitiesRequest, MaintenanceActivities>(mActivitiesRequest);
                _imActivitiesDomain.ValidateAndUpdateActivityResult(mActivities);
                var result = await _imActivitiesDomain.SaveAsync(mActivities);
                return result ? Created("maintenance-activities", mActivities) : StatusCode(500);
            }
            return StatusCode(400);
        }
    }
}
