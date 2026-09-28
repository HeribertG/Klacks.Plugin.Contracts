// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Base class for plugin skill implementations with parameter extraction helpers.
/// </summary>

namespace Klacks.Plugin.Contracts.Skills;

public abstract class BaseSkillImplementation : ISkillImplementation
{
    public abstract Task<SkillResult> ExecuteAsync(
        SkillExecutionContext context,
        Dictionary<string, object> parameters,
        CancellationToken cancellationToken = default);

    protected static T? GetParameter<T>(Dictionary<string, object> parameters, string name, T? defaultValue = default)
    {
        if (!parameters.TryGetValue(name, out var value))
            return defaultValue;

        if (value is T typedValue)
            return typedValue;

        try
        {
            if (typeof(T) == typeof(string)) return (T)(object)value.ToString()!;
            if (typeof(T) == typeof(int) || typeof(T) == typeof(int?)) return (T)(object)Convert.ToInt32(value);
            if (typeof(T) == typeof(bool) || typeof(T) == typeof(bool?)) return (T)(object)Convert.ToBoolean(value);
            if (typeof(T) == typeof(Guid) || typeof(T) == typeof(Guid?)) return (T)(object)Guid.Parse(value.ToString()!);
            if (typeof(T) == typeof(decimal) || typeof(T) == typeof(decimal?)) return (T)(object)Convert.ToDecimal(value);
            return (T)Convert.ChangeType(value, typeof(T));
        }
        catch
        {
            return defaultValue;
        }
    }

    protected static string GetRequiredString(Dictionary<string, object> parameters, string name)
        => GetParameter<string>(parameters, name) ?? throw new ArgumentException($"Required parameter '{name}' is missing");

    protected static int GetRequiredInt(Dictionary<string, object> parameters, string name)
        => GetParameter<int?>(parameters, name) ?? throw new ArgumentException($"Required parameter '{name}' is missing");

    protected static Guid GetRequiredGuid(Dictionary<string, object> parameters, string name)
    {
        var value = GetParameter<string>(parameters, name);
        if (string.IsNullOrEmpty(value))
            throw new ArgumentException($"Required parameter '{name}' is missing");
        return Guid.Parse(value);
    }
}
