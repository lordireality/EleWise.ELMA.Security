// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.SimpleAuthenticationService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Сервис авторизации для хранения единственного пользователя
  /// </summary>
  [Service(EnableInterceptors = false, InjectProperties = true, Scope = ServiceScope.Application, Type = ComponentType.DesignServer)]
  public class SimpleAuthenticationService : IAuthenticationService
  {
    private IUser user;
    private Dictionary<Guid, AuthenticatedSessionInfo> _currentSessionInfos;
    internal static SimpleAuthenticationService RFI4lhDCHb1m2pq7W85;

    /// <summary>Получить текущего пользователя системы</summary>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    public IUser GetCurrentUser() => this.user;

    /// <inheritdoc />
    public object GetCurrentUserId() => throw new NotImplementedException();

    /// <summary>Получить текущего пользователя системы</summary>
    /// <typeparam name="T">Тип пользователя</typeparam>
    /// <returns>Текущий пользователь, либо <c>null</c></returns>
    public T GetCurrentUser<T>() where T : IUser => (T) this.GetCurrentUser();

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    public void SignIn(IUser user, bool rememberMeSet = false)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.user = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Авторизовать пользователя системы</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="rememberMeSet">Запомнить авторизацию для следующей сессии</param>
    /// <param name="checkRequireChangePassword">Проверять обязательную смену пароля</param>
    public void SignIn(IUser user, bool rememberMeSet, bool checkRequireChangePassword)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.user = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_caa093c27e0c4f12b0f5ec87d7abcd7d != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Убрать авторизацию пользователя</summary>
    public void SignOut()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.user = (IUser) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Установить авторизованного пользователя только в рамках этого запроса
    /// </summary>
    /// <param name="user">Пользователь</param>
    public void SetAuthenticatedUserForRequest(IUser user)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.user = user;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_37446e30434b46d9bd923434ab8fdeb1 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public void SetAuthenticatedUserIdForRequest(object userId) => throw new NotImplementedException();

    public AuthenticatedSessionInfo GetCurrentSession()
    {
      int num1 = 1;
      Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            currentSessionInfos = this._currentSessionInfos;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_16;
          default:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:
      AuthenticatedSessionInfo currentSession;
      try
      {
        Monitor.Enter((object) currentSessionInfos, ref lockTaken);
        int num2 = 3;
        KeyValuePair<Guid, AuthenticatedSessionInfo> keyValuePair;
        object userId;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_16;
            case 2:
              keyValuePair = this._currentSessionInfos.FirstOrDefault<KeyValuePair<Guid, AuthenticatedSessionInfo>>((Func<KeyValuePair<Guid, AuthenticatedSessionInfo>, bool>) (i => i.Value.UserId.Equals(userId)));
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0 ? 0 : 0;
              continue;
            case 3:
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 4 : 3;
              continue;
            case 4:
              userId = this.user.GetId();
              num2 = 2;
              continue;
            default:
              currentSession = keyValuePair.Value;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d9ac34b2ac244b7e9bf4a093e4538971 != 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e == 0 ? 0 : 0;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_11:
        Monitor.Exit((object) currentSessionInfos);
        num3 = 2;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_827bf988d49b49239d138477b0425c72 == 0)
        {
          num3 = 2;
          goto label_10;
        }
        else
          goto label_10;
      }
label_16:
      return currentSession;
    }

    /// <summary>
    /// Получить информацию об активных авторизованных сессиях
    /// </summary>
    /// <returns></returns>
    public IEnumerable<AuthenticatedSessionInfo> GetActiveSessions() => (IEnumerable<AuthenticatedSessionInfo>) this._currentSessionInfos.Values.Cast<AuthenticatedSessionInfo>().ToList<AuthenticatedSessionInfo>().AsReadOnly();

    /// <summary>Получить информацию об авторизованных сессиях</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns></returns>
    public IEnumerable<AuthenticatedSessionInfo> GetSessions(
      AuthenticatedSessionFilter filter)
    {
      return this.GetActiveSessions();
    }

    /// <summary>Удалить авторизованную сессию</summary>
    /// <param name="ticketId"></param>
    public void RemoveSession(Guid ticketId)
    {
      int num1 = 2;
      Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_17;
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 3 : 2;
            continue;
          case 2:
            currentSessionInfos = this._currentSessionInfos;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a447984d1e44ffb710c751b9d1e595 == 0 ? 0 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_14;
        }
      }
label_17:
      return;
label_14:
      return;
label_4:
      try
      {
        Monitor.Enter((object) currentSessionInfos, ref lockTaken);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_10;
            case 2:
              if (!this._currentSessionInfos.ContainsKey(ticketId))
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_71be6f50a09e4a85bffdfa6d10e598fa != 0 ? 1 : 0;
                continue;
              }
              break;
            case 3:
              goto label_8;
          }
          this._currentSessionInfos.Remove(ticketId);
          num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 == 0 ? 3 : 2;
        }
label_10:
        return;
label_8:;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 == 0 ? 0 : 1;
        else
          goto label_15;
label_13:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_15:
        SimpleAuthenticationService.VUg34iDjmP7oQyQk675((object) currentSessionInfos);
        num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0)
        {
          num3 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    /// <summary>
    /// Удалить все авторизованные сессии указанного пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    public void RemoveAllUserSessions(object userId)
    {
      int num1 = 3;
      Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos1;
      bool lockTaken;
      object userId1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_29;
            case 2:
              userId1 = userId;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 0 : 0;
              continue;
            case 3:
              num2 = 2;
              continue;
            case 4:
              goto label_26;
            case 5:
              goto label_6;
            default:
              currentSessionInfos1 = this._currentSessionInfos;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_2dffaf3935794377b240a82e9ecaee8a == 0 ? 1 : 1;
              continue;
          }
        }
label_29:
        lockTaken = false;
        num1 = 5;
      }
label_26:
      return;
label_6:
      try
      {
        Monitor.Enter((object) currentSessionInfos1, ref lockTaken);
        int num3 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03ef001666654692ab50cf50e0d9b8f4 == 0)
          num3 = 1;
        List<KeyValuePair<Guid, AuthenticatedSessionInfo>>.Enumerator enumerator;
        while (true)
        {
          switch (num3)
          {
            case 1:
              Dictionary<Guid, AuthenticatedSessionInfo> currentSessionInfos2 = this._currentSessionInfos;
              Func<KeyValuePair<Guid, AuthenticatedSessionInfo>, bool> func;
              Func<KeyValuePair<Guid, AuthenticatedSessionInfo>, bool> func1 = func;
              Func<KeyValuePair<Guid, AuthenticatedSessionInfo>, bool> predicate = func1 == null ? (func = (Func<KeyValuePair<Guid, AuthenticatedSessionInfo>, bool>) (i => i.Value.UserId == userId1)) : func1;
              enumerator = currentSessionInfos2.Where<KeyValuePair<Guid, AuthenticatedSessionInfo>>(predicate).ToList<KeyValuePair<Guid, AuthenticatedSessionInfo>>().GetEnumerator();
              num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 == 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_10:
        try
        {
label_15:
          if (enumerator.MoveNext())
            goto label_14;
          else
            goto label_16;
label_12:
          KeyValuePair<Guid, AuthenticatedSessionInfo> current;
          int num4;
          while (true)
          {
            switch (num4)
            {
              case 1:
                goto label_14;
              case 2:
                this._currentSessionInfos.Remove(current.Key);
                num4 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dba7033a6cfc46b597db657cca7f4656 == 0 ? 0 : 0;
                continue;
              case 3:
                goto label_20;
              default:
                goto label_15;
            }
          }
label_20:
          return;
label_14:
          current = enumerator.Current;
          num4 = 2;
          goto label_12;
label_16:
          num4 = 3;
          goto label_12;
        }
        finally
        {
          enumerator.Dispose();
          int num5 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0)
            num5 = 0;
          switch (num5)
          {
            default:
          }
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num6 = 0;
          if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7efd7c17e95848f2854efd8c7b830f4a == 0)
            num6 = 0;
          while (true)
          {
            switch (num6)
            {
              case 1:
                goto label_28;
              default:
                SimpleAuthenticationService.VUg34iDjmP7oQyQk675((object) currentSessionInfos1);
                num6 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5d082e6aa2f341d3a6d6ef8af192bb70 == 0 ? 1 : 0;
                continue;
            }
          }
        }
label_28:;
      }
    }

    public SimpleAuthenticationService()
    {
      SimpleAuthenticationService.pUO2bjDNUWaUlcvQmqa();
      this._currentSessionInfos = new Dictionary<Guid, AuthenticatedSessionInfo>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_6cdd2f1b1dfa427fb926267830056720 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool M3sowQDiaBbTBIdnbTF() => SimpleAuthenticationService.RFI4lhDCHb1m2pq7W85 == null;

    internal static SimpleAuthenticationService VTF15QD3weUVkvSalWQ() => SimpleAuthenticationService.RFI4lhDCHb1m2pq7W85;

    internal static void VUg34iDjmP7oQyQk675([In] object obj0) => Monitor.Exit(obj0);

    internal static void pUO2bjDNUWaUlcvQmqa() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
  }
}
