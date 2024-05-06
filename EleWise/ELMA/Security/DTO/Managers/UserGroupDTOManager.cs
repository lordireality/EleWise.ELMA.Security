// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.UserGroupDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>
  /// Менеджер групп пользователей для работы через Remoting
  /// </summary>
  public class UserGroupDTOManager : DTOManager, IUserGroupDTOManager, IConfigurationService
  {
    internal static UserGroupDTOManager njUDvx3lP2fKjWGpy1p;

    /// <summary>Менеджер групп пользователей</summary>
    public UserGroupManager Manager
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
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

    public virtual UserGroupDTO Save(UserGroupDTO group)
    {
      int num = 3;
      IUserGroup destination;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (destination == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 3:
            destination = this.Manager.LoadOrNull(group.Id);
            num = 2;
            continue;
          case 4:
            Mapper.Map<UserGroupDTO, IUserGroup>(group, destination);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e != 0 ? 0 : 0;
            continue;
          case 5:
            destination = InterfaceActivator.Create<IUserGroup>();
            num = 4;
            continue;
          case 6:
            group.Id = destination.Id;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 1 : 1;
            continue;
          default:
            this.Manager.Save(destination);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb != 0 ? 4 : 6;
            continue;
        }
      }
label_5:
      return group;
    }

    public virtual UserGroupDTO Load(long id) => Mapper.Map<IUserGroup, UserGroupDTO>(this.Manager.Load(id), new UserGroupDTO());

    public virtual UserGroupDTO LoadOrNull(long id)
    {
      int num = 2;
      IUserGroup source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source != null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 2:
            source = this.Manager.LoadOrNull(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (UserGroupDTO) null;
label_3:
      return Mapper.Map<IUserGroup, UserGroupDTO>(source, new UserGroupDTO());
    }

    public virtual UserGroupDTO Load(Guid uid) => Mapper.Map<IUserGroup, UserGroupDTO>(this.Manager.Load(uid), new UserGroupDTO());

    public virtual UserGroupDTO LoadOrNull(Guid uid)
    {
      int num = 3;
      IUserGroup source;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (source != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            source = this.Manager.LoadOrNull(uid);
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      return (UserGroupDTO) null;
label_3:
      return Mapper.Map<IUserGroup, UserGroupDTO>(source, new UserGroupDTO());
    }

    public virtual ICollection<UserGroupDTO> FindAll() => (ICollection<UserGroupDTO>) this.Manager.FindAll().Select<IUserGroup, UserGroupDTO>((Func<IUserGroup, UserGroupDTO>) (entity => Mapper.Map<IUserGroup, UserGroupDTO>(entity, new UserGroupDTO()))).ToList<UserGroupDTO>();

    public virtual void Delete(long id)
    {
      int num = 4;
      while (true)
      {
        IUserGroup userGroup;
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            goto label_2;
          case 3:
            if (userGroup == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 == 0 ? 1 : 1;
              continue;
            }
            break;
          case 4:
            userGroup = this.Manager.LoadOrNull(id);
            num = 3;
            continue;
        }
        this.Manager.Delete(userGroup);
        num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 2 : 2;
      }
label_5:
      return;
label_2:;
    }

    public UserGroupDTOManager()
    {
      UserGroupDTOManager.cpkItR3cr8xuO29OFCw();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool VrW2GT3fH9uAlI8oxqX() => UserGroupDTOManager.njUDvx3lP2fKjWGpy1p == null;

    internal static UserGroupDTOManager pDLjHb347JWJNENK4Iq() => UserGroupDTOManager.njUDvx3lP2fKjWGpy1p;

    internal static void cpkItR3cr8xuO29OFCw() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
