using PayEZ.Models;

namespace PayEZ.Services
{
    public class DataService : IDataService
    {
        private readonly IPayEZAPIService _payEZAPIService;
        private readonly IEncryptionService _encryptionService;

        public DataService(IPayEZAPIService payEZAPIService, IEncryptionService encryptionService)
        {
            _payEZAPIService = payEZAPIService;
            _encryptionService = encryptionService;
        }

        public async Task<RedirectResponse> ProcessAndSendDataAsync(ProviderGatewayRequest request)
        {
            var encryptedData = _encryptionService.EncryptProviderRequest(request);

            return await _payEZAPIService.SendDataAsync(encryptedData);
        }
    }

}
