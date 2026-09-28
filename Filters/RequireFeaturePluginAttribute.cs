// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Action filter attribute that blocks requests when a feature plugin is not enabled.
/// Returns 404 NotFound if the plugin is disabled or not installed.
/// </summary>
/// <param name="pluginName">The plugin name to check (must match manifest name)</param>

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.DependencyInjection;

namespace Klacks.Plugin.Contracts.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class RequireFeaturePluginAttribute : Attribute, IAsyncActionFilter
{
    private readonly string _pluginName;

    public RequireFeaturePluginAttribute(string pluginName)
    {
        _pluginName = pluginName;
    }

    public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
    {
        var pluginService = context.HttpContext.RequestServices.GetRequiredService<IPluginStateChecker>();

        if (!pluginService.IsEnabled(_pluginName))
        {
            context.Result = new NotFoundResult();
            return;
        }

        await next();
    }
}
