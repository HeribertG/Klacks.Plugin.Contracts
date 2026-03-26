// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Abstraction for plugin-to-frontend communication via SignalR.
/// Replaces direct IHubContext references in plugins.
/// </summary>
/// <param name="eventType">Plugin event type identifier (e.g. "messaging.incoming")</param>
/// <param name="payload">Serializable event data</param>

namespace Klacks.Plugin.Contracts;

public interface IPluginEventBus
{
    Task PublishToUserAsync(string userId, string eventType, object payload);
    Task BroadcastAsync(string eventType, object payload);
}
