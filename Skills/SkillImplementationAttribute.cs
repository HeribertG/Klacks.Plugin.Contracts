// Copyright (c) Heribert Gasparoli. SPDX-License-Identifier: AGPL-3.0-only

/// <summary>
/// Marks a class as the implementation for a specific skill.
/// The SkillName must match the skill name in the AgentSkill database table.
/// </summary>
/// <param name="skillName">The unique skill identifier (snake_case)</param>

namespace Klacks.Plugin.Contracts.Skills;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class SkillImplementationAttribute : Attribute
{
    public string SkillName { get; }

    public SkillImplementationAttribute(string skillName)
    {
        SkillName = skillName ?? throw new ArgumentNullException(nameof(skillName));
    }
}
