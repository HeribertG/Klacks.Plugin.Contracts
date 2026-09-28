// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Slim unit of work interface for plugins to commit database changes.
/// </summary>

namespace Klacks.Plugin.Contracts;

public interface IPluginUnitOfWork
{
    Task CompleteAsync();
}
