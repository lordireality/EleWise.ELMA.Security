// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Models.IAbstractPropertyAccess
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System;

namespace EleWise.ELMA.Security.Models
{
  /// <summary>
  /// Базовый интерфейс элемента настройки доступа для свойства
  /// </summary>
  public interface IAbstractPropertyAccess
  {
    /// <summary>
    /// Получить Uid свойства, для которого предназначена данная настройка доступа
    /// </summary>
    Guid GetPropertyGuid();

    /// <summary>Получить тип привилегии</summary>
    /// <returns></returns>
    PropertyPermissionType GetPermissionType();

    /// <summary>Пользователь</summary>
    IUser User { get; set; }

    /// <summary>Группа пользователей</summary>
    IUserGroup Group { get; set; }

    /// <summary>Должность</summary>
    IOrganizationItem OrganizationItemPosition { get; set; }

    /// <summary>Элемент оргструктуры</summary>
    IOrganizationItem OrganizationItem { get; set; }

    /// <summary>Uid свойства</summary>
    /// <remarks>Uid свойства-обладателя привилегии</remarks>
    Guid? AssignedPropertyUid { get; set; }

    /// <summary>Uid метаданных свойства</summary>
    /// <remarks>Uid метаданных свойства-обладателя привилегии</remarks>
    Guid? AssignedPropertyEntityUid { get; set; }
  }
}
