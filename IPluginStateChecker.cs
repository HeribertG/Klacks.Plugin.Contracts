// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only interface to check if a plugin is enabled. Used by RequireFeaturePluginAttribute.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginStateChecker
{
    bool IsEnabled(string pluginName);
}
