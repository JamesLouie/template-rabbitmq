using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using template.RabbitMq.HostedServices;

namespace template.RabbitMq
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly ILogger _logger;

        public Startup(IConfiguration config, ILogger<Startup> logger)
        {
            _config = config;
            _logger = logger;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            _logger.LogDebug("Calling Configure Services");

            services.AddMediatR();
            services.AddHostedService<RabbitMqConsumer>();

            _logger.LogDebug("Completed Configure Services");
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            _logger.LogDebug("Calling Configure");

            _logger.LogDebug("Completed Configure");
        }
    }
}
