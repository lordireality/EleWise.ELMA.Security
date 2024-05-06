// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IClassMetadataPropertyPermissionAdapter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Расширение для адаптера сервисов проверки прав доступа на свойства, позволяющее получить метаданные IMetadata
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IClassMetadataPropertyPermissionAdapter : IPropertyPermissionAdapter
  {
    /// <summary>
    /// Получить метаданные объекта по профилю принадлежащего ему свойства
    /// </summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    IMetadata GetBaseMetadata(IAbstractPropertyProfile profile);

    /// <summary>
    /// Получить метаданные объекта по профилю объекта, для которого настраиваются права доступа на свойства
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    IMetadata GetBaseMetadata(IPropertyOwnerProfile owner);
  }
}
