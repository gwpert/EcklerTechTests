using PayEZ.Models;

namespace PayEZ.Services
{
    public interface IEncryptionService
    {
        public string EncryptProviderRequest(ProviderGatewayRequest obj);
    }
}
