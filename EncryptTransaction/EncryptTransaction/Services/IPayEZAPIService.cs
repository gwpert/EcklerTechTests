using PayEZ.Models;

namespace PayEZ.Services
{
    public interface IPayEZAPIService
    {
        public Task<RedirectResponse> SendDataAsync(string request);
    }
}
