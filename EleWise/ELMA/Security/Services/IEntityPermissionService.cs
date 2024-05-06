// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.IEntityPermissionService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Web.Mvc.Html.EditableList;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Services
{
  /// <summary>Сервис проверки/выдачи привилегий для объекта</summary>
  public interface IEntityPermissionService
  {
    /// <summary>
    /// Проверка необходимости добавления разрешений пользователям
    /// </summary>
    /// <param name="objectsIds">Массив id объектов</param>
    /// <param name="type">Тип</param>
    /// <param name="usersIds">Массив id пользователей</param>
    /// <param name="prefixedUsersIds">Массив префиксов для пользователей</param>
    /// <param name="permission">Разрешение</param>
    /// <param name="needReplacement">Нужно учитывать замещения</param>
    bool CheckIfPermissionNeededForEntity(
      long[] objectsIds,
      Type type,
      long[] usersIds,
      string[] prefixedUsersIds,
      Guid permission,
      bool needReplacement = false);

    /// <summary>
    /// Проверка возможности выдачи пользователем списка привилегий на объект
    /// </summary>
    /// <param name="type">Тип сущности</param>
    /// <param name="permissionGuids">Guid'ы привилегий на выдачу</param>
    /// <param name="permissionData">Данные о выдаваемых пермишенах (Id объекта, Id пользователя, Guid типа привилегии)</param>
    /// <returns>Возвращает названия привилегий, на выдачу которых отсутствуют права</returns>
    IEnumerable<string> CheckGrantablePermissions(
      Type type,
      string permissionGuids,
      string permissionData);

    /// <summary>Получить информацию для выдачи привилегий</summary>
    /// <param name="id">Массив id объектов</param>
    /// <param name="type">Тип</param>
    /// <param name="usersIds">Массив id пользователей</param>
    /// <param name="prefixedUsersIds">Массив префиксов для пользователей</param>
    /// <param name="permission">Разрешение</param>
    /// <param name="defaultPermissions">Разрешения по умолчанию</param>
    /// <param name="needReplacement">Нужно учитывать замещения</param>
    /// <returns></returns>
    AddPermissionModel EntityAddPermission(
      long[] id,
      Type type,
      long[] usersIds,
      string[] prefixedUsersIds,
      Guid permission,
      Guid[] defaultPermissions = null,
      bool needReplacement = false);

    /// <summary>Добавить привилегии</summary>
    /// <param name="id">Массив id объектов</param>
    /// <param name="type">Тип</param>
    /// <param name="accessBindList">Данные о выдаваемых привилегиях</param>
    /// <returns></returns>
    bool EntityAddPermissionSave(long[] id, Type type, EditableListModel accessBindList);
  }
}
