// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Actors.IUpdateUserSecuritySetCacheQueueManagerActor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security.Actors
{
  /// <summary>
  /// Актор для службы управления очередью обновления UserSecuritySetCache
  /// </summary>
  [FeatureFlagManaged("Scheduler.Actors.Enabled", true)]
  internal interface IUpdateUserSecuritySetCacheQueueManagerActor : IActorWithIntegerKey, IActor
  {
    /// <summary>Запустить при старте сервера</summary>
    Task Start();

    /// <summary>
    /// Зарегистрировать выполнение через <paramref name="waitTimeSpan" />
    /// </summary>
    /// <param name="waitTimeSpan">Время, через которое нужно выполнить накопившееся обновление UserSecuritySetCache</param>
    Task RegisterExecute(TimeSpan waitTimeSpan);

    /// <summary>Завершение выполнения обнволения</summary>
    /// <param name="reminderName">Имя обновления</param>
    Task TimerComplete(string reminderName);
  }
}
