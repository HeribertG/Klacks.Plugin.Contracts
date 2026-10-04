// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Read-only access to the host's group visibility for plugins. A plugin that reads or writes data owned by a
/// client must ask here first: a client the calling user may not see has to be answered exactly like a client
/// that does not exist. Admins and background callers without a user are unrestricted.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IClientVisibilityReader
{
    /// <summary>
    /// True when the calling user may see the client and therefore read or write data it owns.
    /// </summary>
    /// <param name="clientId">Client that owns the data the plugin is about to touch</param>
    /// <param name="ct">Cancellation token</param>
    Task<bool> IsClientVisibleAsync(Guid clientId, CancellationToken ct = default);
}
