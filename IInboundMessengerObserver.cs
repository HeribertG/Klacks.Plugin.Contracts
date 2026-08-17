// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Mirror image of the core's IOfflineMessengerNotifier. That contract lets the core reach a user
/// through the messaging plugin; this one lets the messaging plugin report back that a known user
/// answered. It lives in Klacks.Plugin.Contracts rather than in the core because the dependency runs
/// Klacks.Api -> Klacks.Plugin.Messaging, so the plugin cannot name a core-owned interface at all.
/// IPluginEventBus is not an alternative: it broadcasts towards the frontend and reaches no server
/// component. Implementations are resolved as a collection, so an installation that registers none
/// simply has no observer and the inbound path is unchanged.
/// </summary>
/// <param name="message">The stored inbound message together with the user it was resolved to</param>

namespace Klacks.Plugin.Contracts;

public interface IInboundMessengerObserver
{
    Task OnInboundMessageAsync(InboundMessengerMessage message, CancellationToken cancellationToken = default);
}
