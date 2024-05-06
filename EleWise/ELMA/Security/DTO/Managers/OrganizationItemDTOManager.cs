// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.OrganizationItemDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>
  /// Менеджер элементов оргструктуры для работы через Remoting
  /// </summary>
  public class OrganizationItemDTOManager : 
    DTOManager,
    IOrganizationItemDTOManager,
    IConfigurationService
  {
    internal static OrganizationItemDTOManager vr9GuV33QlIS9DIdluR;

    /// <summary>Менеджер модели оргструктуры</summary>
    public OrganizationItemManager Manager
    {
      get => this.\u003CManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6b5cf56938644be9ac50bca14fe3ce8c != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Загрузить корневой элемент оргструктуры (вместе со всеми подъэлементами)
    /// </summary>
    /// <returns></returns>
    public virtual OrganizationItemDTO LoadRoot() => (OrganizationItemDTO) OrganizationItemDTOManager.dHE2OU30ModhAlZO02F((object) this.Manager);

    /// <summary>
    /// Загрузить элемент оргструктуры по уникальному идентификатору
    /// </summary>
    /// <param name="uid"></param>
    /// <returns></returns>
    public virtual OrganizationItemDTO LoadOrNull(Guid uid)
    {
      int num = 3;
      IOrganizationItem source;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (source != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a7fb6731cf25476e857aaa2b54d293a6 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 3:
            source = this.Manager.LoadOrNull(uid);
            num = 2;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return (OrganizationItemDTO) null;
label_6:
      return Mapper.Map<IOrganizationItem, OrganizationItemDTO>(source, new OrganizationItemDTO());
    }

    /// <summary>Загрузить элемент оргструктуры по идентификатору</summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public virtual OrganizationItemDTO LoadOrNull(long id)
    {
      int num = 1;
      IOrganizationItem source;
      while (true)
      {
        switch (num)
        {
          case 1:
            source = this.Manager.LoadOrNull(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            goto label_4;
          default:
            if (source != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_18188ea91cb44de7a0c0bf969e02b40a == 0 ? 2 : 1;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return (OrganizationItemDTO) null;
label_5:
      return Mapper.Map<IOrganizationItem, OrganizationItemDTO>(source, new OrganizationItemDTO());
    }

    /// <summary>
    /// Вернуть список пользователей назначенных на должность
    /// Для должности будет 1 для группы пользователей несколько
    /// </summary>
    public virtual List<UserDTO> UsersToOrganizationItem(long id)
    {
      IOrganizationItem organizationItem1 = this.Manager.LoadOrNull(id);
      EleWise.ELMA.Security.Models.IUser user = organizationItem1.User;
      if (user != null)
        return new List<UserDTO>()
        {
          Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(user, new UserDTO())
        };
      ISet<EleWise.ELMA.Security.Models.IUser> users = organizationItem1.Users;
      if (users == null || users.Count <= 0)
        return (List<UserDTO>) null;
      List<UserDTO> organizationItem2 = new List<UserDTO>();
      foreach (EleWise.ELMA.Security.Models.IUser source in (IEnumerable<EleWise.ELMA.Security.Models.IUser>) users)
        organizationItem2.Add(Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(source, new UserDTO()));
      return organizationItem2;
    }

    public OrganizationItemDTOManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool zU0uEl3jdKD4hxvekTQ() => OrganizationItemDTOManager.vr9GuV33QlIS9DIdluR == null;

    internal static OrganizationItemDTOManager N6iGva3NHElT5mgYGag() => OrganizationItemDTOManager.vr9GuV33QlIS9DIdluR;

    internal static object dHE2OU30ModhAlZO02F([In] object obj0) => (object) ((OrganizationItemManager) obj0).LoadRoot();
  }
}
