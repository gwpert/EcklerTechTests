using PayEZ.Models;

namespace PayEZ.Services
{
    public class PayEZAPIService : IPayEZAPIService
    {
        private readonly IConfiguration _configuration;

        public PayEZAPIService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<RedirectResponse> SendDataAsync(string request)
        {
            RedirectResponse redirectResponse = new RedirectResponse()
            {
                Success = false,
                Error = string.Empty
            };

            using (var httpClient = new HttpClient())
            {
                if (request == _configuration["checkSumAnswer"])
                    redirectResponse.Success = true;
                else
                    redirectResponse.Success = false;
            }

            return redirectResponse;
        }
    }
}