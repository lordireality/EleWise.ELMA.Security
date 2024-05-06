// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Actors.ExternalMembershipImportManagerActor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security.Actors
{
  /// <inheritdoc />
  internal class ExternalMembershipImportManagerActor : 
    Actor,
    IExternalMembershipImportManagerActor,
    IActorWithIntegerKey,
    IActor
  {
    private readonly ExternalMembershipImportManager externalMembershipImportManager;
    private IDisposable timerDisposer;
    internal static ExternalMembershipImportManagerActor pufitAwwxbneanYGYYGn;

    /// <summary>ctor</summary>
    /// <param name="externalMembershipImportManager">Менеджер импорта пользователей из внешних провайдеров авторизации</param>
    public ExternalMembershipImportManagerActor(
      ExternalMembershipImportManager externalMembershipImportManager)
    {
      ExternalMembershipImportManagerActor.n5VdmXww3BXrSZjj46FW();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_39f0406a331443edb5b5967663d8c011 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.externalMembershipImportManager = externalMembershipImportManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4af8bed9d7004d7e8ded84171d940cec != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public Task Start() => (Task) ExternalMembershipImportManagerActor.SGZG6jwwZ4AZpwQtMHIA((object) new Task[2]
    {
      this.RegisterOrUpdateReminder(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-272519830 ^ 272596725), ExternalMembershipImportManagerActor.HqGwqhwwjR1JQsQNCVB3(1.0), ExternalMembershipImportManagerActor.HqGwqhwwjR1JQsQNCVB3(1.0)),
      (Task) ExternalMembershipImportManagerActor.HaHTyXww0k4yDY0gSgR0((object) this, ExternalMembershipImportManagerActor.tTx3BTwwNa4WJTLV7DdM(-1536327508 ^ -1536381748))
    });

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.timerDisposer == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            this.timerDisposer = this.RegisterTimer(new Func<object, Task>(this.OnTimer), (object) null, TimeSpan.Zero, ExternalMembershipImportManagerActor.C2KeE0wwAvyGiAvttCi7((double) EleWise.ELMA.SR.GetSetting<int>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1324692970 << 3 ^ -2007532352), 10)));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:
      return (Task) ExternalMembershipImportManagerActor.hdBdHCwws8r1U3TNVZ7F();
    }

    /// <inheritdoc />
    public Task AddUsersToImport(
      ICollection<string> userNames,
      ICollection<long> groupIds,
      Guid authProviderUid)
    {
      this.externalMembershipImportManager.AddUsersToImportInternal((IEnumerable<string>) userNames, (IEnumerable<long>) groupIds, authProviderUid);
      return this.Start();
    }

    /// <inheritdoc />
    public Task ImportComplete()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
          case 3:
            this.timerDisposer = (IDisposable) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0aa4741374084c4c8cf8c0394ae63494 == 0 ? 0 : 0;
            continue;
          case 4:
            IDisposable timerDisposer = this.timerDisposer;
            if (timerDisposer == null)
            {
              num = 3;
              continue;
            }
            ExternalMembershipImportManagerActor.Gjhyhwww7E5bZ4jptE8E((object) timerDisposer);
            num = 2;
            continue;
          default:
            this.DeactivateOnIdle();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1b617a9378984e23826f1b64f3aa64a3 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:
      return (Task) ExternalMembershipImportManagerActor.rp4Jt8wwWbBbNlmIsdRU((object) this, ExternalMembershipImportManagerActor.tTx3BTwwNa4WJTLV7DdM(1458233619 ^ 1458294131));
    }

    private Task OnTimer(object _)
    {
      int num1 = 4;
      // ISSUE: variable of a compiler-generated type
      ExternalMembershipImportManagerActor.\u003COnTimer\u003Ed__8 stateMachine;
      while (true)
      {
        int num2 = num1;
        AsyncTaskMethodBuilder tBuilder;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              tBuilder = stateMachine.\u003C\u003Et__builder;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d2e1195de3f346988720bb39caceb510 != 0 ? 0 : 2;
              continue;
            case 2:
              tBuilder.Start<ExternalMembershipImportManagerActor.\u003COnTimer\u003Ed__8>(ref stateMachine);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_59dc4a11549c4652a311cbdb1f43a385 == 0 ? 0 : 0;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003Et__builder = AsyncTaskMethodBuilder.Create();
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 != 0 ? 1 : 5;
              continue;
            case 4:
              goto label_4;
            case 5:
              // ISSUE: reference to a compiler-generated field
              stateMachine.\u003C\u003E1__state = -1;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_dc2d5035304540058f97b1094b6e897d == 0 ? 1 : 1;
              continue;
            default:
              goto label_8;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated field
        stateMachine.\u003C\u003E4__this = this;
        num1 = 3;
      }
label_8:
      // ISSUE: reference to a compiler-generated field
      return stateMachine.\u003C\u003Et__builder.Task;
    }

    internal static void n5VdmXww3BXrSZjj46FW() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static bool g0FnYSwwCqW5DHoqaEy6() => ExternalMembershipImportManagerActor.pufitAwwxbneanYGYYGn == null;

    internal static ExternalMembershipImportManagerActor eVDLsuwwiZ29vQf5IGDS() => ExternalMembershipImportManagerActor.pufitAwwxbneanYGYYGn;

    internal static TimeSpan HqGwqhwwjR1JQsQNCVB3([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static object tTx3BTwwNa4WJTLV7DdM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object HaHTyXww0k4yDY0gSgR0([In] object obj0, [In] object obj1) => (object) ((Actor) obj0).ReceiveReminder((string) obj1);

    internal static object SGZG6jwwZ4AZpwQtMHIA([In] object obj0) => (object) Task.WhenAll((Task[]) obj0);

    internal static TimeSpan C2KeE0wwAvyGiAvttCi7([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static object hdBdHCwws8r1U3TNVZ7F() => (object) Task.CompletedTask;

    internal static void Gjhyhwww7E5bZ4jptE8E([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object rp4Jt8wwWbBbNlmIsdRU([In] object obj0, [In] object obj1) => (object) ((Actor) obj0).UnregisterReminder((string) obj1);

    internal static void wHSQGKwwr1pTn8yLAENZ([In] object obj0) => ((ExternalMembershipImportManager) obj0).ImportUsersInternal();

    [Component(Type = ComponentType.Server)]
    private sealed class ModuleAutoDeployActorInitHandler : IActorInitHandler
    {
      private static object DElCcHwfatKR74aqcenO;

      /// <inheritdoc />
      public Task Init(IActorModelRuntime actorModelRuntime) => actorModelRuntime.GetActor<IExternalMembershipImportManagerActor>(0L).Start();

      public ModuleAutoDeployActorInitHandler()
      {
        ExternalMembershipImportManagerActor.ModuleAutoDeployActorInitHandler.g40lbOwfivEGweUvTRkr();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool r7ndxowfxva0qHOl2FtJ() => ExternalMembershipImportManagerActor.ModuleAutoDeployActorInitHandler.DElCcHwfatKR74aqcenO == null;

      internal static ExternalMembershipImportManagerActor.ModuleAutoDeployActorInitHandler EDBBfQwfCOgZTtdY4tA7() => (ExternalMembershipImportManagerActor.ModuleAutoDeployActorInitHandler) ExternalMembershipImportManagerActor.ModuleAutoDeployActorInitHandler.DElCcHwfatKR74aqcenO;

      internal static void g40lbOwfivEGweUvTRkr() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
    }
  }
}
