// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IPropertyInstanceService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Сервис для работы с настройками доступа к полям и свойствам объектов
  /// </summary>
  public interface IPropertyInstanceService
  {
    /// <summary>
    /// Получить список профилей свойств для указанного объекта
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    IEnumerable<IAbstractPropertyProfile> GetPropertyProfiles(
      IPropertyOwnerProfile owner);

    /// <summary>Получить метаданные свойства по профилю свойства</summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    IPropertyMetadata GetPropertyMetadata(IAbstractPropertyProfile profile);

    /// <summary>
    /// Получить метаданные объекта по профилю принадлежащего ему свойства
    /// </summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    [Obsolete("Рекомендуется использовать GetClassMetadata()")]
    IEntityMetadata GetMetadata(IAbstractPropertyProfile profile);

    /// <summary>
    /// Получить список метаданных свойств для типа каталога из CatalogProfile
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    IEnumerable<IPropertyMetadata> GetPropertyMetadataList(
      IPropertyOwnerProfile owner);

    /// <summary>Создать новый профиль свойства, без сохранения в БД</summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <param name="propertyUid">Уникальный идентификатор свойства</param>
    /// <returns></returns>
    IAbstractPropertyProfile CreateProfile(
      IPropertyOwnerProfile owner,
      Guid propertyUid);

    /// <summary>
    /// Сохранить указанный набор профилей свойств для объекта. Сохраненные ранее профили данного объекта, которых нет в указанном списке, удаляются.
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <param name="profiles">Список профилей свойств</param>
    void SaveProfiles(IPropertyOwnerProfile owner, IEnumerable<IAbstractPropertyProfile> profiles);

    /// <summary>
    /// Является ли наименованием сущности свойство с указанным профилем
    /// </summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    bool IsTitleProperty(IAbstractPropertyProfile profile);

    /// <summary>
    /// Получить уникальный идентификатор свойства, являющегося наименованием объекта
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    Guid GetTitlePropertyGuid(IPropertyOwnerProfile owner);

    /// <summary>Получить идентификатор привилегии "Скрыть"</summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    Guid GetHidePermissionId(IPropertyOwnerProfile owner);

    /// <summary>Получить идентификатор привилегии "Просмотр"</summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    Guid GetViewPermissionId(IPropertyOwnerProfile owner);

    /// <summary>Получить идентификатор привилегии "Редактирование"</summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    Guid GetEditPermissionId(IPropertyOwnerProfile owner);

    /// <summary>
    /// Получить метаданные объекта по профилю принадлежащего ему свойства
    /// </summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
    ClassMetadata GetClassMetadata(IAbstractPropertyProfile profile);

    /// <summary>
    /// Получить метаданные объекта по профилю объекта, для которого настраиваются права доступа на свойства
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    ClassMetadata GetClassMetadata(IPropertyOwnerProfile owner);
  }
}
