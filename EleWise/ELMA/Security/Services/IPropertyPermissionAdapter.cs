// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IPropertyPermissionAdapter
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>
  /// Адаптер для сервисов проверки прав доступа на свойства
  /// </summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IPropertyPermissionAdapter
  {
    /// <summary>
    /// Проверить, поддерживает ли данный адаптер тип объекта, для которого настраиваются права доступа на свойства
    /// </summary>
    /// <param name="ownerType">Тип экземпляра объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns>True, если поддерживает</returns>
    bool IsSupportedOwnerType(Type ownerType);

    /// <summary>
    /// Проверить, поддерживает ли данный адаптер указанный тип профиля свойства
    /// </summary>
    /// <param name="profileType">Тип профиля свойства</param>
    /// <returns>True, если поддерживает</returns>
    bool IsSupportedProfileType(Type profileType);

    /// <summary>
    /// Проверить, поддерживает ли данный адаптер указанный тип модели
    /// </summary>
    /// <param name="modelType">Тип модели</param>
    /// <returns></returns>
    bool IsSupportedModelType(Type modelType);

    /// <summary>
    /// Получить список профилей свойств для указанного объекта
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    IEnumerable<IAbstractPropertyProfile> GetPropertyProfiles(
      IPropertyOwnerProfile owner);

    /// <summary>
    /// Получить метаданные объекта по профилю объекта, для которого настраиваются права доступа на свойства
    /// </summary>
    /// <param name="owner">Экземпляр объекта, для которого настраиваются права доступа на свойства</param>
    /// <returns></returns>
    IEntityMetadata GetMetadata(IPropertyOwnerProfile owner);

    /// <summary>
    /// Получить метаданные объекта по профилю принадлежащего ему свойства
    /// </summary>
    /// <param name="profile">Профиль свойства</param>
    /// <returns></returns>
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

    /// <summary>Получить настройки прав для указанного типа</summary>
    /// <param name="modelType">Тип модели (сущности)</param>
    /// <returns></returns>
    IEnumerable<IAbstractPropertyAccess> GetAccesses(
      Type modelType);

    /// <summary>Получить метаданные по типу модели</summary>
    /// <param name="modelType">Тип модели</param>
    /// <param name="includeInheritedProperties">Включая унаследованные свойства</param>
    /// <returns></returns>
    IEntityMetadata GetMetadata(Type modelType, bool includeInheritedProperties);

    /// <summary>Получить список типов наследников (рекурсивно)</summary>
    /// <param name="modelType">Тип модели</param>
    /// <returns></returns>
    IEnumerable<Type> GetChildTypes(Type modelType);

    /// <summary>Получить идентификатор привилегии "Скрыть"</summary>
    /// <returns></returns>
    Guid GetHidePermissionId();

    /// <summary>Получить идентификатор привилегии "Просмотр"</summary>
    /// <returns></returns>
    Guid GetViewPermissionId();

    /// <summary>Получить идентификатор привилегии "Редактирование"</summary>
    /// <returns></returns>
    Guid GetEditPermissionId();

    /// <summary>Событие при изменении прав доступа</summary>
    event EventHandler<PropertyPermissionsChangedEventArgs> PermissionsChanged;
  }
}
