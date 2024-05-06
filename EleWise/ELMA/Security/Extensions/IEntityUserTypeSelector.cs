// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.IEntityUserTypeSelector
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>
  /// Перфик сушьности в контроле выбора (если поддерживается контролом)
  /// </summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IEntityUserTypeSelector
  {
    /// <summary>Тип сущности</summary>
    Type EntityType { get; }

    /// <summary>Перфикс</summary>
    string Prefix { get; }

    /// <summary>Имя для отображения</summary>
    string DisplayName { get; }

    /// <summary>Получить сущность</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    IEntity<long> GetEntity(string value);

    /// <summary>Достать списое пользователей по сущности</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    List<EleWise.ELMA.Security.Models.IUser> ExtractUsers(string value);

    /// <summary>Значение с префиксом</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    string PrefixedValue(IEntity<long> entity);
  }
}
