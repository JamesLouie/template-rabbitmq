using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace template.RabbitMq.HostedServices
{
    public class RabbitMqConsumer : IHostedService
    {
        private readonly ILogger _logger;

        public RabbitMqConsumer(ILogger<RabbitMqConsumer> logger)
        {
            _logger = logger;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            _logger.LogDebug($"Starting {nameof(RabbitMqConsumer)}");

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogDebug($"Completed {nameof(RabbitMqConsumer)}");

            return Task.CompletedTask;
        }
    }
}
