using PayEZ.Models;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace PayEZ.Services
{

    public class EncryptionService : IEncryptionService
    {
        private readonly IConfiguration _configuration;

        public EncryptionService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string EncryptProviderRequest(ProviderGatewayRequest request)
        {
            return string.Empty;
        }

        private string calculateSHA256Checksum(string data)
        {
            return string.Empty;
        }


    }
}
