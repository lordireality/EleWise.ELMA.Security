// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.DTO.Managers.UserDTOManager
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.DTO.Managers
{
  /// <summary>Менеджер пользователей для работы через Remoting</summary>
  public class UserDTOManager : 
    DTOManager,
    IUserDTOManager,
    IConfigurationService,
    IUserInfoDTOService
  {
    internal static UserDTOManager f7gbIO3Z4QZYO4JvBSQ;

    /// <summary>Менеджер пользователей</summary>
    public UserManager Manager
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
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f753b9aa1dbf4079919dc5734ead130b != 0 ? 0 : 0;
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

    /// <summary>Загрузить пользователя</summary>
    /// <param name="id">Идентификатор</param>
    /// <returns></returns>
    public virtual UserDTO LoadOrNull(long id)
    {
      int num = 2;
      EleWise.ELMA.Security.Models.IUser source;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (source != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            source = this.Manager.LoadOrNull(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_83b6496f51ae4dc89adced962d071899 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return (UserDTO) null;
label_3:
      return Mapper.Map<EleWise.ELMA.Security.Models.IUser, UserDTO>(source, new UserDTO());
    }

    /// <summary>Получить полное имя пользователя</summary>
    /// <param name="id">Идентификатор пользователя</param>
    /// <returns></returns>
    public virtual string GetFullName(long id)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = this.Manager.LoadOrNull(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            if (user == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6ea1094d65243eb96c2cf3bdcabd6cc != 0 ? 2 : 2;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return (string) null;
label_4:
      return user.FullName;
    }

    public UserDTOManager()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool l0e34f3A0DFtpFJNZXd() => UserDTOManager.f7gbIO3Z4QZYO4JvBSQ == null;

    internal static UserDTOManager TtaFt13sk7Xm6GqGlaS() => UserDTOManager.f7gbIO3Z4QZYO4JvBSQ;
  }
}
