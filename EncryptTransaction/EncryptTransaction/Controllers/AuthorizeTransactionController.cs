using Microsoft.AspNetCore.Mvc;
using PayEZ.Models;
using PayEZ.Services;

namespace PayEZ.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DataController : ControllerBase
    {
        private readonly IDataService _dataService;

        public DataController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] RedirectRequest data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ProviderGatewayRequest gatewayRequest = new ProviderGatewayRequest()
            {
                Version = "2.1",
                Command = "PAY",
                ReturnURL = "https://shop-eckler.azure.net/return.aspx",
                BackURL = "https://shop-eckler.azure.net",
                Amount = data.Amount
            };
            
            return Ok(await _dataService.ProcessAndSendDataAsync(gatewayRequest));
        }
    }

}
