// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExtensionPoints.ISyncPermissionHolderExtensionPoint
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.Security.ExtensionPoints
{
  /// <summary>
  /// Точка расширения дополнительных правил для синхронизации прав
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface ISyncPermissionHolderExtensionPoint
  {
    /// <summary>Применима ли точка расширения</summary>
    /// <param name="entity">Сущность</param>
    bool CanUse(object entity);

    /// <summary>Пропустить удаление привилегии</summary>
    /// <param name="holder">Держатель привилегии</param>
    bool SkipRemove(IInstanceSettingsPermissionHolder holder);
  }
}
