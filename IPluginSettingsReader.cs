// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Read-only access to application settings for plugins.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginSettingsReader
{
    Task<string?> GetSettingAsync(string key);
    Task<int> GetSettingIntAsync(string key, int defaultValue);
}

/// <summary>
/// Read-write access to plugin-owned application settings.
/// Plugins should treat this as namespaced - only write keys that belong to the plugin
/// (typically prefixed with the plugin name or owned namespace, e.g. APP_OWNER_MESSENGERS).
/// </summary>
public interface IPluginSettingsWriter
{
    Task SetSettingAsync(string key, string value, CancellationToken ct = default);
    Task DeleteSettingAsync(string key, CancellationToken ct = default);
}
