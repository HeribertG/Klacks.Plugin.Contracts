// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Resolves client GUIDs from their integer id numbers for cross-plugin access.
/// </summary>
/// <param name="idNumbers">Collection of integer id numbers to resolve</param>

namespace Klacks.Plugin.Contracts;

public interface IClientIdNumberReader
{
    Task<IReadOnlyList<Guid>> GetClientIdsByIdNumbersAsync(IReadOnlyCollection<int> idNumbers, CancellationToken ct = default);
}
