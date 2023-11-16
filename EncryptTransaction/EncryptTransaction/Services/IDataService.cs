using PayEZ.Models;

namespace PayEZ.Services
{
    public interface IDataService
    {
        public Task<RedirectResponse> ProcessAndSendDataAsync(ProviderGatewayRequest request);
    }
}
