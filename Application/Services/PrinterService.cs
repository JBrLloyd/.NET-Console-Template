using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ConsoleTemplate.Application.Services
{

    public class PrinterService : IPrinterService
    {
        private readonly ILogger<PrinterService> _logger;
        private readonly IConfiguration _configuration;

        public PrinterService(ILogger<PrinterService> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        public void ConsoleOut()
        {
            _logger.LogInformation("Running Console Printing");
            Console.WriteLine("Hello World!");
        }
    }
}