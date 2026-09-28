// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Read-only interface to check if a plugin is enabled. Used by RequireFeaturePluginAttribute.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginStateChecker
{
    bool IsEnabled(string pluginName);
}
