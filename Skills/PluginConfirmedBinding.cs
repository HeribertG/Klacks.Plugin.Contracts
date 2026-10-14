// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// The facts the user was shown and confirmed for a held plugin action, as the host stored them with the confirmation token:
/// the kind of the facts and the items themselves. A plugin skill compares the items with the facts it computes right before it
/// acts and acts only when they are equal. The host copies it from its own context, set only by the redemption of a confirmation;
/// a plugin never sets it.
/// </summary>
/// <param name="Kind">What the items are (the kind the plugin's preview produced)</param>
/// <param name="Items">The bound items; empty when the host kept none, which no comparison can match</param>

namespace Klacks.Plugin.Contracts.Skills;

public sealed record PluginConfirmedBinding(string Kind, IReadOnlyList<string> Items);
