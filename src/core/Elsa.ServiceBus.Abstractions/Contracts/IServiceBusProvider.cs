using Microsoft.Extensions.DependencyInjection;

namespace Elsa.ServiceBus.Abstractions.Contracts;

public interface IServiceBusProvider
{
    void ConfigureServices(IServiceCollection services);
}