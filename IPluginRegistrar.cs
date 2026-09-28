// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Main interface for feature plugins to register with the host application.
/// Implementations are discovered via assembly scan at startup.
/// </summary>

using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Klacks.Plugin.Contracts;

public interface IPluginRegistrar
{
    string PluginName { get; }
    void RegisterServices(IServiceCollection services, IConfiguration configuration);
    void ConfigureDbModel(ModelBuilder modelBuilder);
    IEnumerable<Assembly> GetControllerAssemblies();
    IEnumerable<Assembly> GetSkillAssemblies();
}
