// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Extensions.IDigitalSignatureType
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Extensions
{
  /// <summary>Интерфейс типа электронной подписи</summary>
  [ExtensionPoint(ServiceScope.Application, ComponentType.All)]
  public interface IDigitalSignatureType
  {
    /// <summary>Uid типа</summary>
    Guid Uid { get; }

    /// <summary>Отображаемое имя типа</summary>
    string DisplayName { get; }

    /// <summary>Код</summary>
    string Code { get; }

    /// <summary>
    /// Список провайдеров поддерживающих этот тип электронной подписи
    /// </summary>
    IEnumerable<Guid> Providers { get; }
  }
}
