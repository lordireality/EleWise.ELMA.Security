﻿// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IRoleTypeSelectorGroupsCategory
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Security
{
  /// <summary>Категории для вывода дополнительных групп</summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IRoleTypeSelectorGroupsCategory
  {
    /// <summary>
    /// Наименование категории для вывода дополнительных групп.
    /// </summary>
    string Name { get; }

    /// <summary>Идентификатор категории.</summary>
    string Id { get; }

    /// <summary>Уникальный идентификатор категории.</summary>
    Guid Uid { get; }
  }
}