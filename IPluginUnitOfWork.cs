// Copyright (c) Heribert Gasparoli Private. All rights reserved.

/// <summary>
/// Slim unit of work interface for plugins to commit database changes.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginUnitOfWork
{
    Task CompleteAsync();
}
