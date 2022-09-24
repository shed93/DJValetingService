using DJValetingService.Data;
using DJValetingService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DJValetingService.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ValetingRequestController : ControllerBase
    {

        private readonly ILogger<ValetingRequestController> _logger;
        private ApplicationDbContext _dbContext;
        public ValetingRequestController(ILogger<ValetingRequestController> logger, ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        [HttpGet]
        public ActionResult GetVehichleSizes()
        {
            var sizes = _dbContext.Ref_VehicleSizes.Where(w => w.Removed == false).Select(s => new Ref_VehicleSizeViewModel(s)).ToList();
            return Ok(sizes);
        }
        [HttpGet]
        public ActionResult GetFlexibility()
        {
            var ref_Flexibilities = _dbContext.Ref_Flexibilities.Where(w => w.Removed == false).Select(s => new Ref_FlexibilityViewModel(s)).ToList();
            return Ok(ref_Flexibilities);
        }
        [HttpPost]
        public ActionResult SubmitClientBookingRequest([FromBody] ClientValetingRequestViewModel clientValetingRequestViewModel)
        {
            try
            {
                var request = new ValetingRequest(clientValetingRequestViewModel);
                _dbContext.ValetingRequests.Add(request);
                _dbContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
        [HttpPatch]
        [Authorize]
        public ActionResult DeleteBookingRequest(int bookingRequestId)
        {
            var request = _dbContext.ValetingRequests.Where(w => w.Id == bookingRequestId).SingleOrDefault();
            if (request != null)
            {
                request.Removed = true;
                _dbContext.Update(request);
                _dbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
        [HttpPatch]
        [Authorize]
        public ActionResult ApproveBookingRequest(int bookingRequestId)
        {
            var request = _dbContext.ValetingRequests.Where(w => w.Id == bookingRequestId && w.Removed==false).SingleOrDefault();
            if (request != null)
            {
                request.Approved = true;
                _dbContext.Update(request);
                _dbContext.SaveChanges();
                return Ok();
            }
            return BadRequest();
        }
    }
}