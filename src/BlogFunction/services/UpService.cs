using Microsoft.Extensions.Logging;

public class UpService : IUpService
{
    private readonly ILogger<UpService> _logger;

    public UpService(ILogger<UpService> logger)
    {
        _logger = logger;
    }

    public string ToUpperCase(string text)
    {
        _logger.LogInformation($"[UpService] Called ******************* {text}");
        return text.ToUpper();
    }
}