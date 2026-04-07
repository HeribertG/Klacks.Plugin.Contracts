// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to the mobile phone number of a Klacks client for messaging plugins.
/// Used as a fallback recipient when a provider (WhatsApp, Signal, SMS, Viber) accepts
/// phone numbers as identifiers and no explicit MessengerContact exists.
/// Priority: PrivateCellPhone &gt; OfficeCellPhone. EmergencyPhone is explicitly excluded.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IClientPhoneReader
{
    /// <summary>
    /// Returns the preferred mobile phone number of the given client or null if none exists.
    /// </summary>
    /// <param name="clientId">Target client</param>
    /// <param name="ct">Cancellation token</param>
    Task<string?> GetMobilePhoneAsync(Guid clientId, CancellationToken ct = default);

    /// <summary>
    /// Batch variant that loads mobile phone numbers for many clients in a single query.
    /// Clients without a mobile phone map to null. Order of the returned dictionary is not guaranteed.
    /// </summary>
    /// <param name="clientIds">Target clients</param>
    /// <param name="ct">Cancellation token</param>
    Task<IReadOnlyDictionary<Guid, string?>> GetMobilePhonesAsync(IReadOnlyCollection<Guid> clientIds, CancellationToken ct = default);
}
