// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Read-only access to application settings for plugins.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginSettingsReader
{
    Task<string?> GetSettingAsync(string key);
    Task<int> GetSettingIntAsync(string key, int defaultValue);
}
