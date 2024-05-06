// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExtensionPoints.IReplacementRuleExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Security.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для фильтрации объектов замещений в правилах замещений.
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IReplacementRuleExtension
  {
    /// <summary>Поддерживает ли точка расширения данный тип</summary>
    /// <param name="metadata">Метаданные объекта</param>
    bool Can(EntityMetadata metadata);

    /// <summary>Разрешено ли применение правил замещения к объекту</summary>
    bool CanRule(EntityMetadata metadata);
  }
}
