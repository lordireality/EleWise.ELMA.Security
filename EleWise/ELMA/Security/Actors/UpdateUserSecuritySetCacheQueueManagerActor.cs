// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Actors.UpdateUserSecuritySetCacheQueueManagerActor
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security.Actors
{
  /// <inheritdoc />
  internal class UpdateUserSecuritySetCacheQueueManagerActor : 
    Actor,
    IUpdateUserSecuritySetCacheQueueManagerActor,
    IActorWithIntegerKey,
    IActor
  {
    private readonly IActorModelRuntime actorModelRuntime;
    private readonly UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager;
    private IDisposable timerDisposable;
    private string reminderName;
    private int executing;
    internal static UpdateUserSecuritySetCacheQueueManagerActor DsFLvhww4virJfWk49tR;

    /// <summary>ctor</summary>
    /// <param name="actorModelRuntime">Интерфейс Модели Акторов</param>
    /// <param name="updateUserSecuritySetCacheQueueManager">Служба для управления очередью обновления UserSecuritySetCache</param>
    public UpdateUserSecuritySetCacheQueueManagerActor(
      IActorModelRuntime actorModelRuntime,
      UpdateUserSecuritySetCacheQueueManager updateUserSecuritySetCacheQueueManager)
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      this.reminderName = UpdateUserSecuritySetCacheQueueManagerActor.UXcM4iwwQ9T6PGZgyf4N().ToString();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.actorModelRuntime = actorModelRuntime;
            num = 2;
            continue;
          case 2:
            this.updateUserSecuritySetCacheQueueManager = updateUserSecuritySetCacheQueueManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <inheritdoc />
    public Task Start()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.timerDisposable == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_24e30588dbae4ccda9e884fddec51508 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return Task.CompletedTask;
label_3:
      return this.RegisterExecute(TimeSpan.Zero);
    }

    /// <inheritdoc />
    public Task RegisterExecute(TimeSpan waitTimeSpan)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 4:
            IDisposable timerDisposable = this.timerDisposable;
            if (timerDisposable == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 != 0 ? 0 : 0;
              continue;
            }
            UpdateUserSecuritySetCacheQueueManagerActor.Mb6g9Mww80rh7FfB1qXN((object) timerDisposable);
            num = 6;
            continue;
          case 2:
            this.reminderName = Guid.NewGuid().ToString();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b76fcdb574014280a7be648da5787a5c != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_6;
          case 5:
            if (this.reminderName != null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          default:
            this.timerDisposable = this.RegisterTimer(this.reminderName, waitTimeSpan);
            num = 3;
            continue;
        }
      }
label_6:
      return this.RegisterOrUpdateReminder(this.reminderName, waitTimeSpan, UpdateUserSecuritySetCacheQueueManagerActor.KDLIDWww5V2YM9WcATLn(1.0));
    }

    /// <inheritdoc />
    public override Task ReceiveReminder(string reminderName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.timerDisposable = this.RegisterTimer(reminderName, TimeSpan.Zero);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_43343b822e364ed6a20142161ebd5905 != 0 ? 4 : 0;
            continue;
          case 2:
            if (this.timerDisposable == null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d376f847d0fa47e18791634727b6b8af == 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            if (!(reminderName != this.reminderName))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_1f85fc020bfb421ea00bde3d885227ed == 0 ? 5 : 2;
              continue;
            }
            goto label_5;
          case 4:
          case 5:
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      return (Task) UpdateUserSecuritySetCacheQueueManagerActor.i472xTwwdseDPW0dXSiL((object) this, (object) reminderName);
label_6:
      return Task.CompletedTask;
    }

    /// <inheritdoc />
    public Task TimerComplete(string reminderName)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (this.reminderName == null)
              {
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a277e78c439f43e68608ee7ede2cfe14 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
            case 3:
              goto label_3;
            default:
              IDisposable timerDisposable = this.timerDisposable;
              if (timerDisposable != null)
              {
                UpdateUserSecuritySetCacheQueueManagerActor.Mb6g9Mww80rh7FfB1qXN((object) timerDisposable);
                num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 0 : 2;
                continue;
              }
              goto label_7;
          }
        }
label_7:
        num1 = 3;
      }
label_3:
      return (Task) UpdateUserSecuritySetCacheQueueManagerActor.i472xTwwdseDPW0dXSiL((object) this, (object) reminderName);
    }

    private IDisposable RegisterTimer(string reminderName, TimeSpan dueTime) => this.RegisterTimer(new Func<object, Task>(this.OnTimer), (object) reminderName, dueTime, UpdateUserSecuritySetCacheQueueManagerActor.fpRxhMwwEgQs5wvv2PVy(5.0));

    private Task OnTimer(object state)
    {
      int num1 = 6;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.reminderName = (string) null;
            num1 = 4;
            continue;
          case 2:
            UpdateUserSecuritySetCacheQueueManagerActor queueManagerActor = this;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b8aa191ce4994a319d4f14dda73ebb72 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_6;
          case 4:
            string reminderName = (string) state;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 0 : 0;
            continue;
          case 5:
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 2 : 0;
            continue;
          case 6:
            if (Interlocked.Exchange(ref this.executing, 1) == 0)
            {
              num1 = 5;
              continue;
            }
            goto label_6;
          default:
            this.RunExternalTask((Func<Task>) (() =>
            {
              int num2 = 2;
              // ISSUE: variable of a compiler-generated type
              UpdateUserSecuritySetCacheQueueManagerActor.\u003C\u003Ec__DisplayClass11_0.\u003C\u003COnTimer\u003Eb__0\u003Ed stateMachine;
              AsyncTaskMethodBuilder tBuilder;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: reference to a compiler-generated method
                    stateMachine.\u003C\u003Et__builder = UpdateUserSecuritySetCacheQueueManagerActor.\u003C\u003Ec__DisplayClass11_0.KqtrskwfyDsFE3uEHmXt();
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d77bc9d1e368420fb4cd47ab5f6620af == 0 ? 0 : 3;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated field
                    stateMachine.\u003C\u003E4__this = (object) this;
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_66c6204d393048a98aac88b74e42e4ec != 0 ? 1 : 1;
                    continue;
                  case 3:
                    // ISSUE: reference to a compiler-generated field
                    stateMachine.\u003C\u003E1__state = -1;
                    num2 = 4;
                    continue;
                  case 4:
                    // ISSUE: reference to a compiler-generated field
                    tBuilder = stateMachine.\u003C\u003Et__builder;
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_03e5d631664d4a348c746bbc982a82c3 != 0 ? 0 : 0;
                    continue;
                  case 5:
                    goto label_3;
                  default:
                    tBuilder.Start<UpdateUserSecuritySetCacheQueueManagerActor.\u003C\u003Ec__DisplayClass11_0.\u003C\u003COnTimer\u003Eb__0\u003Ed>(ref stateMachine);
                    num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_d025aa4ca2dc4fdaa67fb2d8346a6540 != 0 ? 5 : 3;
                    continue;
                }
              }
label_3:
              // ISSUE: reference to a compiler-generated field
              return stateMachine.\u003C\u003Et__builder.Task;
            }));
            num1 = 3;
            continue;
        }
      }
label_6:
      return (Task) UpdateUserSecuritySetCacheQueueManagerActor.TQHLLlwwGkyyBtOA8k2p();
    }

    internal static Guid UXcM4iwwQ9T6PGZgyf4N() => Guid.NewGuid();

    internal static bool wPxcI9wwcg9hXoZUERrg() => UpdateUserSecuritySetCacheQueueManagerActor.DsFLvhww4virJfWk49tR == null;

    internal static UpdateUserSecuritySetCacheQueueManagerActor UPIRhNwwP4Dvt3oJxTSC() => UpdateUserSecuritySetCacheQueueManagerActor.DsFLvhww4virJfWk49tR;

    internal static void Mb6g9Mww80rh7FfB1qXN([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static TimeSpan KDLIDWww5V2YM9WcATLn([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static object i472xTwwdseDPW0dXSiL([In] object obj0, [In] object obj1) => (object) ((Actor) obj0).UnregisterReminder((string) obj1);

    internal static TimeSpan fpRxhMwwEgQs5wvv2PVy([In] double obj0) => TimeSpan.FromSeconds(obj0);

    internal static object TQHLLlwwGkyyBtOA8k2p() => (object) Task.CompletedTask;

    [Component(Type = ComponentType.Server)]
    private sealed class ModuleAutoDeployActorInitHandler : IActorInitHandler
    {
      internal static object qRROt9wfZGjKIsLdVg9a;

      /// <inheritdoc />
      public Task Init(IActorModelRuntime actorModelRuntime) => (Task) UpdateUserSecuritySetCacheQueueManagerActor.ModuleAutoDeployActorInitHandler.qIE3adwf7mdjg86xmiBk((object) actorModelRuntime.GetActor<IUpdateUserSecuritySetCacheQueueManagerActor>(0L));

      public ModuleAutoDeployActorInitHandler()
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object qIE3adwf7mdjg86xmiBk([In] object obj0) => (object) ((IUpdateUserSecuritySetCacheQueueManagerActor) obj0).Start();

      internal static bool ltPpFIwfAKdDdaC40k9b() => UpdateUserSecuritySetCacheQueueManagerActor.ModuleAutoDeployActorInitHandler.qRROt9wfZGjKIsLdVg9a == null;

      internal static UpdateUserSecuritySetCacheQueueManagerActor.ModuleAutoDeployActorInitHandler UK4GXXwfsFKQWYuHQToh() => (UpdateUserSecuritySetCacheQueueManagerActor.ModuleAutoDeployActorInitHandler) UpdateUserSecuritySetCacheQueueManagerActor.ModuleAutoDeployActorInitHandler.qRROt9wfZGjKIsLdVg9a;
    }
  }
}
