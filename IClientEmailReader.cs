// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to the private email address of a Klacks client for messaging plugins.
/// Used as a fallback recipient when phone-based messaging is not available.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IClientEmailReader
{
    /// <summary>
    /// Returns the PrivateMail address of the given client or null if none exists.
    /// </summary>
    /// <param name="clientId">Target client.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<string?> GetPrivateEmailAsync(Guid clientId, CancellationToken ct = default);
}
