// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Interface for skill execution logic only. Metadata comes from the database.
/// </summary>

namespace Klacks.Plugin.Contracts.Skills;

public interface ISkillImplementation
{
    Task<SkillResult> ExecuteAsync(
        SkillExecutionContext context,
        Dictionary<string, object> parameters,
        CancellationToken cancellationToken = default);
}
