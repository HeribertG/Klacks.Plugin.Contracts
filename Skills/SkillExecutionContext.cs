// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Execution context passed to skills containing user info and permissions.
/// </summary>

namespace Klacks.Plugin.Contracts.Skills;

public record SkillExecutionContext
{
    public required Guid UserId { get; init; }
    public required Guid TenantId { get; init; }
    public required string UserName { get; init; }
    public required IReadOnlyList<string> UserPermissions { get; init; }
    public string? CurrentPage { get; init; }
    public IReadOnlyList<Guid>? SelectedEntityIds { get; init; }
    public string? UserTimezone { get; init; }

    /// <summary>
    /// The facts the user was shown and confirmed, copied by the host from its own context; null when the call is not the
    /// confirmed replay of a preview. A skill that shows a server preview refuses to act without it and never sets it.
    /// </summary>
    public PluginConfirmedBinding? ConfirmedBinding { get; init; }
}
