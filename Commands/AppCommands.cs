using Cocona;

public class AppCommands
{
    private readonly EmailService _emailService;
    private readonly ReportService _reportService;
    private readonly CleanupService _cleanupService;

    public AppCommands(
        EmailService emailService,
        ReportService reportService,
        CleanupService cleanupService)
    {
        _emailService = emailService;
        _reportService = reportService;
        _cleanupService = cleanupService;
    }

    [Command("send-email")]
    public void SendEmail([Option('r')] string recipient)
    {
        _emailService.Send(recipient);
    }

    [Command("generate-report")]
    public void GenerateReport([Option('d')] string date)
    {
        _reportService.Generate(date);
    }

    [Command("cleanup")]
    public void Cleanup()
    {
        _cleanupService.Run();
    }
}
