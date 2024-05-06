﻿// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.ISystemRolePermissions
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using System;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>
  /// Точка расширения для получения системных (не удаляемых прав на объект).
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface ISystemRolePermissions
  {
    /// <summary>
    /// Тип, для которого применяется данная точка расширения.
    /// </summary>
    Type EntityType { get; }

    /// <summary>Возвращает, является ли проверяемые права системными.</summary>
    bool IsSystem(
      Guid permissionRoleTypeId,
      IEntity permissionRole,
      object target,
      Type entityType,
      Permission permissionToCheck);

    /// <summary>Является системной ролью. Нельзя удалять.</summary>
    /// <returns></returns>
    bool IsSystemRole(
      Guid permissionRoleTypeId,
      IEntity permissionRole,
      object target,
      Type entityType);
  }
}