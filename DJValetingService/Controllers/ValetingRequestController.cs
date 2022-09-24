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
        public ValetingRequestController(ILogger<ValetingRequestController> logger,ApplicationDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
        [HttpGet]
        public List<Ref_VehicleSizeViewModel> GetVehichleSizes()
        {
            var sizes = _dbContext.Ref_VehicleSizes.Where(w => w.Removed == false).Select(s => new Ref_VehicleSizeViewModel(s)).ToList();
            return sizes;
        }
        [HttpGet]
        public List<Ref_FlexibilityViewModel> GetFlexibility()
        {
            var ref_Flexibilities = _dbContext.Ref_Flexibilities.Where(w => w.Removed == false).Select(s => new Ref_FlexibilityViewModel(s)).ToList();
            return ref_Flexibilities;
        }
        
    }
}