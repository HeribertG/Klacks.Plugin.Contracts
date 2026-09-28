// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Interface for plugins to report their operational readiness.
/// A plugin is operational when its required external configuration is in place (e.g. providers configured).
/// </summary>
/// <param name="pluginName">The plugin name to check</param>

namespace Klacks.Plugin.Contracts;

public interface IPluginOperationalCheck
{
    string PluginName { get; }
    Task<bool> IsOperationalAsync();
}
