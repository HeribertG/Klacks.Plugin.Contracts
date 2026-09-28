// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Transactional plain-text email sender exposed to messaging plugins.
/// Wraps the host's email service so plugins do not take a direct dependency on Klacks.Api.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginEmailSender
{
    /// <summary>
    /// Sends a single transactional email. Returns true when the host accepted the send request.
    /// </summary>
    /// <param name="toAddress">Recipient email address.</param>
    /// <param name="subject">Email subject.</param>
    /// <param name="body">Plain-text body.</param>
    /// <param name="ct">Cancellation token.</param>
    Task<bool> SendEmailAsync(string toAddress, string subject, string body, CancellationToken ct = default);
}
