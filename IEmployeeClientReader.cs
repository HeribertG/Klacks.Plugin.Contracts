// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to the set of Klacks clients of type Employee for messaging plugins.
/// Returns minimal identity data sufficient to address employees in onboarding or notification flows.
/// </summary>

namespace Klacks.Plugin.Contracts;

public sealed record EmployeeClientInfo(Guid ClientId, string? FirstName);

public interface IEmployeeClientReader
{
    /// <summary>
    /// Returns all non-deleted clients whose EntityType is Employee.
    /// </summary>
    /// <param name="ct">Cancellation token.</param>
    Task<IReadOnlyList<EmployeeClientInfo>> GetAllEmployeesAsync(CancellationToken ct = default);

    /// <summary>
    /// Returns a single client if and only if it exists, is not deleted, and is an Employee.
    /// </summary>
    /// <param name="clientId">Target client id.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<EmployeeClientInfo?> GetEmployeeAsync(Guid clientId, CancellationToken ct = default);
}
