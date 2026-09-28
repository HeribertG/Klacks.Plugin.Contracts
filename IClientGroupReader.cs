// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Read-only access to client membership of a Klacks group hierarchy for plugins.
/// The implementation automatically includes members of all descendant groups.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IClientGroupReader
{
    /// <summary>
    /// Returns the distinct set of active client identifiers that are members of the
    /// given group or any of its descendant groups.
    /// </summary>
    /// <param name="groupId">The root group whose hierarchy should be traversed</param>
    /// <param name="ct">Cancellation token</param>
    Task<IReadOnlyList<Guid>> GetClientIdsInGroupAsync(Guid groupId, CancellationToken ct = default);
}
