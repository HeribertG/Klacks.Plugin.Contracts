// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// One inbound messenger message whose sender was resolved to a Klacks application user. Carries only
/// what an observer needs to react; the message itself is already persisted by the messaging plugin,
/// so this is a notification and never the storage path.
/// </summary>
/// <param name="MessageId">Identifier of the stored message, so an observer can load the full row</param>
/// <param name="UserId">AppUser the sending messenger identity belongs to</param>
/// <param name="Channel">Messenger channel the message arrived on, e.g. Telegram</param>
/// <param name="Sender">Provider-specific sender identifier (chat id, phone, alias)</param>
/// <param name="SenderDisplayName">Display name the provider reported, when it reported one</param>
/// <param name="Content">Message text as delivered</param>
/// <param name="ReceivedAt">UTC instant the message was stored</param>

namespace Klacks.Plugin.Contracts;

public record InboundMessengerMessage(
    Guid MessageId,
    string UserId,
    string Channel,
    string Sender,
    string? SenderDisplayName,
    string Content,
    DateTime ReceivedAt);
