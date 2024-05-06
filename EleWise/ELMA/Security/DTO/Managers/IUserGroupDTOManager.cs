// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.IUserGroupDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Security.DTO.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>
  /// Менеджер групп пользователей для работы через Remoting
  /// </summary>
  public interface IUserGroupDTOManager : IConfigurationService
  {
    /// <summary>Сохранить группу</summary>
    /// <param name="group">Группа пользователей</param>
    /// <returns>Сохраненная группа</returns>
    UserGroupDTO Save(UserGroupDTO group);

    /// <summary>Загрузить группу пользователей</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns></returns>
    UserGroupDTO Load(long id);

    /// <summary>Загрузить группу пользователей</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns></returns>
    UserGroupDTO LoadOrNull(long id);

    /// <summary>Загрузить группу пользователей</summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns></returns>
    UserGroupDTO Load(Guid uid);

    /// <summary>Загрузить группу пользователей</summary>
    /// <param name="uid">Уникальный идентификатор</param>
    /// <returns></returns>
    UserGroupDTO LoadOrNull(Guid uid);

    /// <summary>Найти все группы</summary>
    /// <returns>Список групп</returns>
    ICollection<UserGroupDTO> FindAll();

    /// <summary>Удалить группу пользователей</summary>
    /// <param name="id">Идентификатор</param>
    void Delete(long id);
  }
}
