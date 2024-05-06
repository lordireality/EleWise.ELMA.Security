// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.IOrganizationItemDTOManager
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
  /// Менеджер элементов оргструктуры для работы через Remoting
  /// </summary>
  public interface IOrganizationItemDTOManager : IConfigurationService
  {
    /// <summary>
    /// Загрузить корневой элемент оргструктуры (вместе со всеми подъэлементами)
    /// </summary>
    /// <returns></returns>
    OrganizationItemDTO LoadRoot();

    /// <summary>
    /// Загрузить элемент оргструктуры по уникальному идентификатору
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    OrganizationItemDTO LoadOrNull(Guid uid);

    /// <summary>Загрузить элемент оргструктуры по идентификатору</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    OrganizationItemDTO LoadOrNull(long id);

    /// <summary>
    /// Вернуть список пользователей назначенных на должность
    /// Для должности будет 1 для группы пользователей несколько
    /// </summary>
    List<UserDTO> UsersToOrganizationItem(long id);
  }
}
