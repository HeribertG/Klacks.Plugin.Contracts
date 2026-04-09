// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to the set of Klacks clients of type Employee for messaging plugins.
/// Returns minimal identity data plus the strict private contact channels required for
/// onboarding flows. Private means PrivateCellPhone and PrivateMail only — office and
/// emergency channels are explicitly excluded.
/// </summary>

namespace Klacks.Plugin.Contracts;

public sealed record EmployeeClientInfo(
    Guid ClientId,
    string? FirstName,
    string? PrivateCellPhone,
    string? PrivateEmail);

public interface IEmployeeClientReader
{
    /// <summary>
    /// Returns all non-deleted clients whose EntityType is Employee, including their
    /// private cell phone and private email when present.
    /// </summary>
    /// <param name="ct">Cancellation token.</param>
    Task<IReadOnlyList<EmployeeClientInfo>> GetAllEmployeesAsync(CancellationToken ct = default);

    /// <summary>
    /// Returns a single employee if and only if it exists, is not deleted, and is of EntityType Employee.
    /// </summary>
    /// <param name="clientId">Target client id.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<EmployeeClientInfo?> GetEmployeeAsync(Guid clientId, CancellationToken ct = default);
}
