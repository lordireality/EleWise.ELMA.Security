// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Listeners.UserCacheEventListener
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Runtime.NH.Listeners;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;

namespace EleWise.ELMA.Security.Listeners
{
  [Component]
  public class UserCacheEventListener : PostFlushEventListener
  {
    public static string UserDictionaryUid;
    public static string UserDictionaryTimeStump;
    private static object obj;
    internal static UserCacheEventListener gcpXUsZEugVRS5krx3j;

    public IComplexCacheService CacheService
    {
      get => this.\u003CCacheService\u003Ek__BackingField;
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
              this.\u003CCacheService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abadf9e30945488ea88fa5b350878758 != 0 ? 0 : 0;
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

    public override void OnPostInsert(PostInsertEvent @event)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        EleWise.ELMA.Security.Models.IUser user;
        while (true)
        {
          switch (num2)
          {
            case 1:
              user = UserCacheEventListener.EuBXmOZ93f20jmQ81QG((object) @event) as EleWise.ELMA.Security.Models.IUser;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ba16274d6aa641e095a471d0dfb96b1e != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_7;
            case 3:
              this.UserPhotoCacheUpdate(user);
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_3;
            default:
              if (user != null)
                goto case 3;
              else
                goto label_5;
          }
        }
label_5:
        num1 = 4;
      }
label_7:
      return;
label_3:;
    }

    public override void OnPostUpdate(PostUpdateEvent @event)
    {
      int num = 1;
      EleWise.ELMA.Security.Models.IUser user;
      while (true)
      {
        switch (num)
        {
          case 1:
            user = UserCacheEventListener.EuBXmOZ93f20jmQ81QG((object) @event) as EleWise.ELMA.Security.Models.IUser;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_99a2bc08f0c34d148eb861b4ae3b00cb == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.UserPhotoCacheUpdate(user);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_0a384505148b450dac7d3e159460a0c6 == 0 ? 2 : 2;
            continue;
          default:
            if (user != null)
            {
              num = 3;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    private void UserPhotoCacheUpdate(EleWise.ELMA.Security.Models.IUser user)
    {
      int num1 = 5;
      bool lockTaken;
      object obj;
      Dictionary<long, Guid> orAdd;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
            continue;
          case 2:
            UserCacheEventListener.xu0nIgZBZsFsHgTwyZO((object) this.CacheService, (object) UserCacheEventListener.UserDictionaryTimeStump);
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_19;
          case 4:
            if (orAdd.Any<KeyValuePair<long, Guid>>())
            {
              num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b6b8429927564e7c9b2022a9cd0643ba != 0 ? 0 : 6;
              continue;
            }
            goto case 2;
          case 5:
            IComplexCacheService cacheService = this.CacheService;
            string userDictionaryUid = UserCacheEventListener.UserDictionaryUid;
            string dictionaryTimeStump = UserCacheEventListener.UserDictionaryTimeStump;
            // ISSUE: reference to a compiler-generated field
            Func<Dictionary<long, Guid>> func = UserCacheEventListener.\u003C\u003Ec.\u003C\u003E9__9_0;
            Func<Dictionary<long, Guid>> valueAccessor;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              UserCacheEventListener.\u003C\u003Ec.\u003C\u003E9__9_0 = valueAccessor = (Func<Dictionary<long, Guid>>) (() => new Dictionary<long, Guid>());
            }
            else
              goto label_22;
label_21:
            orAdd = cacheService.GetOrAdd<Dictionary<long, Guid>>(userDictionaryUid, dictionaryTimeStump, valueAccessor);
            num1 = 4;
            continue;
label_22:
            valueAccessor = func;
            goto label_21;
          case 6:
            obj = UserCacheEventListener.obj;
            num1 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_b86da72f1bd5464a910551dd2d005e61 != 0 ? 1 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_19:
      return;
label_3:
      try
      {
        Monitor.Enter(obj, ref lockTaken);
        int num2 = 0;
        if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_335f3fb8cf154386b8cd1be2690ff4a2 != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_11;
            default:
              orAdd[user.Id] = UserCacheEventListener.x7FU3qZ1CBldey3MZMg((object) user) != null ? UserCacheEventListener.J7RU7DZMgJuUMrBpytu(UserCacheEventListener.x7FU3qZ1CBldey3MZMg((object) user)) : Guid.Empty;
              num2 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ec0a515abd3f47d2839d43e72ca0d4c3 == 0 ? 1 : 0;
              continue;
          }
        }
label_11:;
      }
      finally
      {
        int num3;
        if (!lockTaken)
          num3 = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 0 : 0;
        else
          goto label_12;
label_10:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_12:
        UserCacheEventListener.peyskJZhHYvM0URJZGq(obj);
        num3 = 2;
        goto label_10;
      }
    }

    public UserCacheEventListener()
    {
      TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c726ecf980f54024a32bc8936d4ff98e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static UserCacheEventListener()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            UserCacheEventListener.UserDictionaryTimeStump = (string) UserCacheEventListener.z1Iuv7ZpKe3d8ATsJDY(-1751467293 ^ -1751454721);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60ed2167d2634bc2b20d56fcb5a39ea0 != 0 ? 0 : 0;
            continue;
          case 2:
            UserCacheEventListener.UserDictionaryUid = (string) UserCacheEventListener.z1Iuv7ZpKe3d8ATsJDY(334323849 << 5 ^ 2108441046);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_61881587a7b146ada7008e8af1387207 != 0 ? 1 : 1;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d84bfdcaf47444d9e9a8ab763074e39 == 0 ? 2 : 2;
            continue;
          case 4:
            goto label_2;
          default:
            UserCacheEventListener.obj = new object();
            num = 4;
            continue;
        }
      }
label_2:;
    }

    internal static bool RpnCUiZGILbLaoouKX9() => UserCacheEventListener.gcpXUsZEugVRS5krx3j == null;

    internal static UserCacheEventListener RGcUR0ZXX4sZqReOpef() => UserCacheEventListener.gcpXUsZEugVRS5krx3j;

    internal static object EuBXmOZ93f20jmQ81QG([In] object obj0) => ((AbstractPostDatabaseOperationEvent) obj0).Entity;

    internal static object x7FU3qZ1CBldey3MZMg([In] object obj0) => (object) ((EleWise.ELMA.Security.Models.IUser) obj0).Photo;

    internal static Guid J7RU7DZMgJuUMrBpytu([In] object obj0) => ((BinaryFile) obj0).Uid;

    internal static void peyskJZhHYvM0URJZGq([In] object obj0) => Monitor.Exit(obj0);

    internal static void xu0nIgZBZsFsHgTwyZO([In] object obj0, [In] object obj1) => ((IComplexCacheService) obj0).RefreshTimestamp((string) obj1);

    internal static object z1Iuv7ZpKe3d8ATsJDY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
