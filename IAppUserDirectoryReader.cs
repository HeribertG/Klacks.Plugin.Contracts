// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to application users (login accounts) for messaging plugins: lookup by id and
/// search by name. Distinct from IEmployeeClientReader: an AppUser is a login/identity account, not
/// a Client - there is no relation between the two, and this contract exists so a plugin can
/// resolve who to email an admin-initiated invite to, or who to message directly, without
/// depending on Klacks.Api directly.
/// </summary>

namespace Klacks.Plugin.Contracts;

public sealed record AppUserDirectoryInfo(
    string UserId,
    string? FirstName,
    string? LastName,
    string? Email);

public interface IAppUserDirectoryReader
{
    /// <summary>
    /// Returns the user if and only if the account exists and is not deactivated.
    /// </summary>
    /// <param name="userId">Target AppUser id.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<AppUserDirectoryInfo?> GetUserAsync(string userId, CancellationToken ct = default);

    /// <summary>
    /// Case-insensitive name search over active (non-deactivated) accounts. A keyword matches if it
    /// is a substring of the user's first name, last name, username, or email. At most 5 results,
    /// ordered by last name then first name, so a caller can tell "one match" from "ambiguous"
    /// without inventing its own ranking.
    /// </summary>
    /// <param name="nameQuery">Free-text name query, e.g. a first and/or last name.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<IReadOnlyList<AppUserDirectoryInfo>> SearchByNameAsync(string nameQuery, CancellationToken ct = default);
}
