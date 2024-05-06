// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Actors.IExternalMembershipImportManagerActor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security.Actors
{
  /// <summary>
  /// Актор для менеджера импорта пользователей из внешних провайдеров авторизации
  /// </summary>
  [FeatureFlagManaged("Scheduler.Actors.Enabled", true)]
  internal interface IExternalMembershipImportManagerActor : IActorWithIntegerKey, IActor
  {
    /// <summary>Запустить при старте сервера</summary>
    Task Start();

    /// <summary>Добавить данные импорта</summary>
    /// <param name="userNames">UserName пользователей для импорта</param>
    /// <param name="groupIds">Id групп</param>
    /// <param name="authProviderUid">Идентификатор провайдера авторизации</param>
    /// <returns></returns>
    Task AddUsersToImport(
      ICollection<string> userNames,
      ICollection<long> groupIds,
      Guid authProviderUid);

    /// <summary>Импорт закончен</summary>
    Task ImportComplete();
  }
}
