using DJValetingService.Data;
using DJValetingService.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DJValetingService.Controllers
{
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
        [HttpGet("[action]")]
        public ActionResult GetVehicleSizes()
        {
            var sizes = _dbContext.Ref_VehicleSizes.Where(w => w.Removed == false).Select(s => new Ref_VehicleSizeViewModel(s)).ToList();
            return Ok(sizes);
        }
        [HttpGet("[action]")]
        public ActionResult GetFlexibility()
        {
            var ref_Flexibilities = _dbContext.Ref_Flexibilities.Where(w => w.Removed == false).Select(s => new Ref_FlexibilityViewModel(s)).ToList();
            return Ok(ref_Flexibilities);
        }
        [HttpPost("[action]")]
        public ActionResult SubmitClientBookingRequest([FromBody] string Name/*ClientValetingRequestViewModel clientValetingRequestViewModel*/)
        {
            try
            {
                ClientValetingRequestViewModel clientValetingRequestViewModel=new ClientValetingRequestViewModel();
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
        [HttpPatch("[action]")]
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
        [HttpPatch("[action]")]
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
        [HttpGet("[action]")]
        [Authorize]
        public ActionResult GetBookingRequests()
        {
            var bookingRequests = _dbContext.ValetingRequests.Where(w => w.Removed == false).Select(s => new ValetingRequestViewModel(s)).ToList();
            return Ok(bookingRequests);
        }
        [HttpPost("[action]")]
        public ActionResult UpdateClientBookingRequest([FromBody] AdminValetingRequestViewModel adminValetingRequestViewModel)
        {
            try
            {
                var request = new ValetingRequest(adminValetingRequestViewModel);
                if (_dbContext.ValetingRequests.Where(w => w.Id == request.Id).SingleOrDefault() != null)
                {
                    _dbContext.ValetingRequests.Update(request);
                    _dbContext.SaveChanges();
                    return Ok();
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}