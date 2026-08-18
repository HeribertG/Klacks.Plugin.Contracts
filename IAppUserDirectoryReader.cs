// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to a single application user (login account) for messaging plugins.
/// Distinct from IEmployeeClientReader: an AppUser is a login/identity account, not a Client -
/// there is no relation between the two, and this contract exists so a plugin can resolve who to
/// email an admin-initiated invite to without depending on Klacks.Api directly.
/// </summary>

namespace Klacks.Plugin.Contracts;

public sealed record AppUserDirectoryInfo(
    string UserId,
    string? FirstName,
    string? Email);

public interface IAppUserDirectoryReader
{
    /// <summary>
    /// Returns the user if and only if the account exists and is not deactivated.
    /// </summary>
    /// <param name="userId">Target AppUser id.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<AppUserDirectoryInfo?> GetUserAsync(string userId, CancellationToken ct = default);
}
