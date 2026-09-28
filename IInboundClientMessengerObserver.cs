// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Lets the core react when a known CLIENT (not an app user) sends a messenger message. Lives here
/// rather than in the core because the dependency runs Klacks.Api -> Klacks.Plugin.Messaging, so the
/// plugin cannot name a core-owned interface at all — same reasoning as IInboundMessengerObserver.
/// Implementations are resolved as a collection; an installation that registers none simply has no
/// observer and the inbound path is unchanged.
/// </summary>
/// <param name="message">The stored inbound message together with the client it was resolved to</param>

namespace Klacks.Plugin.Contracts;

public interface IInboundClientMessengerObserver
{
    Task OnInboundMessageAsync(InboundClientMessengerMessage message, CancellationToken cancellationToken = default);
}
