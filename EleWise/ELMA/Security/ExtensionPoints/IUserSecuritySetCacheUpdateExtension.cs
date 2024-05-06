// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ExtensionPoints.IUserSecuritySetCacheUpdateExtension
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Security.Listeners;
using EleWise.ELMA.Security.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки событий обновления UserSecuritySetCache
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IUserSecuritySetCacheUpdateExtension : IEventHandler
  {
    /// <summary>Обновление</summary>
    /// <param name="users">Обновленные пользователи</param>
    /// <param name="userGroups">Обновленные группы</param>
    /// <param name="organizationItems">Обновленные элементы оргструктуры</param>
    void OnUpdate(
      Dictionary<EleWise.ELMA.Security.Models.IUser, byte> users,
      Dictionary<IUserGroup, GroupUpdate> userGroups,
      Dictionary<IOrganizationItem, OrganizationItemUpdate> organizationItems);
  }
}
