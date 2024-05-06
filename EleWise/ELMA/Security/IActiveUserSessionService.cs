// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.IActiveUserSessionService
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using System;
using System.Collections.Generic;
using System.Web;

namespace EleWise.ELMA.Security
{
  /// <summary>Сервис для работы с активными сессиями пользователей</summary>
  public interface IActiveUserSessionService
  {
    /// <summary>Получить список сессий</summary>
    /// <param name="filter">Фильтр</param>
    /// <returns></returns>
    IEnumerable<AuthenticatedSessionInfo> GetSessions(
      AuthenticatedSessionFilter filter);

    /// <summary>
    /// Получить список идентификаторов привилегированных пользователей
    /// </summary>
    /// <returns></returns>
    IEnumerable<long> GetPrivilegeUserIds();

    /// <summary>
    /// Получить список идентификаторов привилегированных пользователей
    /// </summary>
    /// <param name="includeAdmin">Включать ли администратора ELMA в результат</param>
    /// <returns></returns>
    IEnumerable<long> GetPrivilegeUserIds(bool includeAdmin);

    /// <summary>Получить сессию по идентификатору тиккета</summary>
    /// <param name="ticketId"></param>
    /// <returns></returns>
    AuthenticatedSessionInfo Get(Guid ticketId);

    /// <summary>Найти сессию по идентификатору сессии</summary>
    /// <param name="sessionId"></param>
    /// <returns></returns>
    AuthenticatedSessionInfo FindBySessionId(string sessionId);

    /// <summary>Попытаться добавить новую сессию</summary>
    /// <param name="sessionInfo"></param>
    /// <param name="user"></param>
    void Insert(AuthenticatedSessionInfo sessionInfo, EleWise.ELMA.Security.Models.IUser user);

    /// <summary>Обновить параметры в информации о сессии</summary>
    /// <param name="sessionInfo"></param>
    /// <param name="httpContext"></param>
    void SetUpdated(AuthenticatedSessionInfo sessionInfo, HttpContextBase httpContext);

    /// <summary>Удалить авторизованную сессию</summary>
    /// <param name="ticketId"></param>
    void RemoveSession(Guid ticketId);

    /// <summary>
    /// Удалить все авторизованные сессии указанного пользователя
    /// </summary>
    /// <param name="userId">Идентификатор пользователя</param>
    void RemoveAllUserSessions(object userId);
  }
}
