// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Model-facing refusal texts of a skill whose confirmation is bound to the facts of its server preview. The host re-exports
/// them in its own message catalogue, so a plugin skill and a host skill refuse in the same words. BindingRequired takes the
/// skill name; both texts tell the model that nothing was changed and that a fresh preview and a fresh confirmation are needed.
/// </summary>

namespace Klacks.Plugin.Contracts.Skills;

public static class PluginConfirmationTexts
{
    public const string BindingRequired =
        "'{0}' only runs as the confirmed replay of its own server preview. Call it without a token to get the "
        + "preview, show it to the user and ask for confirmation.";

    public const string ScopeChanged =
        "What this confirmation was given for has changed since the preview. Nothing was changed and this "
        + "confirmation is void. Repeat the call without a confirmation token to get a fresh preview, show it to the "
        + "user and ask for a new confirmation.";
}
