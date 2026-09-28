// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// One inbound messenger message whose sender was resolved to a Klacks CLIENT (employee, extern
/// employee or customer) via MessengerContact. Distinct from InboundMessengerMessage, which carries an
/// AppUser resolved via UserMessengerContact for a different purpose (escalation replies) — a message
/// can only ever resolve to one or the other, never both, and mixing the two into one contract would
/// blur that distinction for every future observer.
/// </summary>
/// <param name="MessageId">Identifier of the stored message, so an observer can load the full row</param>
/// <param name="ClientId">Klacks client this messenger identity belongs to (resolved via MessengerContact)</param>
/// <param name="Channel">Messenger channel the message arrived on, e.g. Telegram</param>
/// <param name="Sender">Provider-specific sender identifier (chat id, phone, alias)</param>
/// <param name="SenderDisplayName">Display name the provider reported, when it reported one</param>
/// <param name="Content">Message text as delivered</param>
/// <param name="ReceivedAt">UTC instant the message was stored</param>

namespace Klacks.Plugin.Contracts;

public record InboundClientMessengerMessage(
    Guid MessageId,
    Guid ClientId,
    string Channel,
    string Sender,
    string? SenderDisplayName,
    string Content,
    DateTime ReceivedAt);
