namespace PayEZ.Models
{
    public class ProviderGatewayRequest
    {
        public string? Version { get; set; }
        public string? Command { get; set; }
        public string? Amount { get; set; }
        public string? ReturnURL { get; set; }
        public string? BackURL { get; set; }
    }
}
