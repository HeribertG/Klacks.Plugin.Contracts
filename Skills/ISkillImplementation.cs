// Copyright (c) Heribert Gasparoli Private. All rights reserved.

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
