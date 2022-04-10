﻿using Elsa.ServiceBus.Abstractions.Contracts;
using MassTransit;

namespace Elsa.Modules.MassTransit.Services;

public class MassTransitServiceBus : IServiceBus
{
    private readonly IBus _bus;
    public MassTransitServiceBus(IBus bus) => _bus = bus;
    public async Task SendAsync(object message, CancellationToken cancellationToken = default) => await _bus.Send(message, cancellationToken);
    public async Task PublishAsync(object message, CancellationToken cancellationToken = default) => await _bus.Publish(message, cancellationToken);
}