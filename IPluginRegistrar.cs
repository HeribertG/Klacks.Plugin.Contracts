// Copyright (c) Heribert Gasparoli Private. All rights reserved.

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
