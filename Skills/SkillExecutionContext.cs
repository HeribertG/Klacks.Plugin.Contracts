// Copyright (c) Heribert Gasparoli Private. All rights reserved.

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
}
