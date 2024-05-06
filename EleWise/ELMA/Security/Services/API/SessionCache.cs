// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.API.SessionCache
// Assembly: EleWise.ELMA.Security, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 174EB52E-9502-4D28-8701-E6B2A3980C83
// Assembly location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.dll
// XML documentation location: C:\Users\g.zykin\Desktop\рандомные краши\AppCrash_w3wp.exe_33f63356c7b9f86fab2e305b114b93c128e7a2_98baeb8b_cab_eea24b14\Web\EleWise.ELMA.Security.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models.API;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Security.Services.API
{
  internal sealed class SessionCache
  {
    private readonly PublicClientSessionManager sessionManager;
    private readonly ICacheService cacheService;
    private readonly SessionCache.MultiKeyCache cachedData;
    private static SessionCache md89g1ll2VbgVMvIVM7;

    /// <summary>Ctor</summary>
    /// <param name="sessionManager">Менеджер сессий NHibernate</param>
    /// <param name="cacheService">Сервис работы с кэшем</param>
    public SessionCache(PublicClientSessionManager sessionManager, ICacheService cacheService)
    {
      SessionCache.YXikgXlcg5RpooKTSxX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.cacheService = cacheService;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4d64c4376f8d4b7d8c6e24d007567c4a != 0 ? 0 : 2;
            continue;
          case 2:
            this.cachedData = new SessionCache.MultiKeyCache(cacheService, (string) SessionCache.gxQIkElPWd7R0qVhea5(-1527733619 - 442652394 ^ -1970391143), new Func<object, string>(this.Keygen));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_c868c5943c34496bb3a65dfc0738c7a1 != 0 ? 0 : 0;
            continue;
          case 3:
            this.sessionManager = sessionManager;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 == 0 ? 1 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    private static long SerializeSession(object session) => ((IEntity<long>) session).Id;

    private IPublicClientSession RecreateSession(long id) => this.sessionManager.LoadOrNull(id);

    public IPublicClientSession GetOrAdd(
      Guid authToken,
      [NotNull] Func<IPublicClientSession> valueFunc)
    {
      if (valueFunc == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1257514304 ^ -1257527632));
      long id;
      if (this.cachedData.TryGetValue((object) authToken, out id))
        return this.RecreateSession(id);
      IPublicClientSession session = valueFunc();
      if (session != null)
        this.Add(session);
      return session;
    }

    public IPublicClientSession GetOrAdd(
      string sessionToken,
      Func<IPublicClientSession> valueFunc)
    {
      if (valueFunc == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-192923496 ^ 192920343));
      long id;
      if (this.cachedData.TryGetValue((object) sessionToken, out id))
        return this.RecreateSession(id);
      IPublicClientSession session = valueFunc();
      if (session != null)
        this.Add(session);
      return session;
    }

    public bool Remove(string sessionToken)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.cachedData.ContainsKey((object) sessionToken))
            {
              SessionCache.RH2KnWlQpyrMlxIaBVG((object) this.cachedData, (object) sessionToken);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 != 0 ? 0 : 2;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return true;
label_3:
      return false;
    }

    public bool Remove(Guid authToken)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            this.cachedData.Remove((object) authToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_650b3a15bce64605817f0d6f88381b7d != 0 ? 0 : 0;
            continue;
          case 3:
            if (SessionCache.UfRIepl86wcm2e3yMtU((object) this.cachedData, (object) authToken))
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f300da8cef0a4ee7a556c100996750bc != 0 ? 2 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return false;
label_6:
      return true;
    }

    public void Add([NotNull] IPublicClientSession session)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (session != null)
            {
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3c59818f3dda4e928131e5a0f093a078 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            goto label_2;
          case 3:
            SessionCache.EamLlTlEkOR5DvW0AKQ((object) this.cachedData, SessionCache.dZr3url5YhCgJiypYtK((object) session), (object) session.SessionToken, SessionCache.SPIN8OldYgd0g4rudkB((object) session));
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_3055be96434840f1b7b7868bc280f0af != 0 ? 2 : 2;
            continue;
          case 4:
            goto label_6;
          default:
            this.Remove(session.AuthToken);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f916ac620a1444f79cb017d2cacc18a0 != 0 ? 0 : 3;
            continue;
        }
      }
label_2:
      return;
label_6:
      throw new ArgumentNullException((string) SessionCache.gxQIkElPWd7R0qVhea5(150349507 - 521039768 ^ -370680543));
    }

    public bool TryGet(Guid authToken, out IPublicClientSession session)
    {
      int num = 4;
      long id;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            session = this.RecreateSession(id);
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_adabd41cfd6641418560af6ef964d38e == 0 ? 1 : 1;
            continue;
          case 3:
            session = (IPublicClientSession) null;
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_af0bf1093ecb44c7ae05ec43f0f1e093 != 0 ? 0 : 0;
            continue;
          case 4:
            if (!this.cachedData.TryGetValue((object) authToken, out id))
            {
              num = 3;
              continue;
            }
            goto case 2;
          default:
            goto label_7;
        }
      }
label_3:
      return true;
label_7:
      return false;
    }

    public bool TryGet(string sessionToken, out IPublicClientSession session)
    {
      int num = 2;
      long id;
      while (true)
      {
        switch (num)
        {
          case 1:
            session = this.RecreateSession(id);
            num = 3;
            continue;
          case 2:
            if (!this.cachedData.TryGetValue((object) sessionToken, out id))
            {
              session = (IPublicClientSession) null;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_046f9c87cb0f488d98843bddddeac014 == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_eed3e1b2c04e496382c72450f1d46536 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_4;
          default:
            goto label_3;
        }
      }
label_3:
      return false;
label_4:
      return true;
    }

    private string Keygen(object key) => (string) SessionCache.JHqoeqlGGKkIvGU8gPs(SessionCache.gxQIkElPWd7R0qVhea5(--180540780 ^ 180536090), (object) new object[2]
    {
      SessionCache.gxQIkElPWd7R0qVhea5(1841261835 ^ 1841238413),
      key
    });

    internal static void YXikgXlcg5RpooKTSxX() => TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();

    internal static object gxQIkElPWd7R0qVhea5(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool PBq65ylfRuEAIicwbV6() => SessionCache.md89g1ll2VbgVMvIVM7 == null;

    internal static SessionCache nMlQlMl4dyfd9vtd7w0() => SessionCache.md89g1ll2VbgVMvIVM7;

    internal static void RH2KnWlQpyrMlxIaBVG([In] object obj0, [In] object obj1) => ((SessionCache.MultiKeyCache) obj0).Remove(obj1);

    internal static bool UfRIepl86wcm2e3yMtU([In] object obj0, [In] object obj1) => ((SessionCache.MultiKeyCache) obj0).ContainsKey(obj1);

    internal static Guid dZr3url5YhCgJiypYtK([In] object obj0) => ((IPublicClientSession) obj0).AuthToken;

    internal static long SPIN8OldYgd0g4rudkB([In] object obj0) => SessionCache.SerializeSession(obj0);

    internal static void EamLlTlEkOR5DvW0AKQ([In] object obj0, Guid authToken, [In] object obj2, long val) => ((SessionCache.MultiKeyCache) obj0).Add(authToken, (string) obj2, val);

    internal static object JHqoeqlGGKkIvGU8gPs([In] object obj0, [In] object obj1) => (object) string.Join((string) obj0, (object[]) obj1);

    private class MultiKeyCache
    {
      private readonly object cacheService;
      private readonly object region;
      private readonly Func<object, string> Keygen;
      internal static object TnMcrNw02QELrZxXuVQC;

      public MultiKeyCache(ICacheService cacheService, string region, Func<object, string> keygen)
      {
        TKW1L3mlUyvXmg29jA.nXAwQxeC0Y9();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.cacheService = (object) cacheService;
        this.region = (object) region;
        this.Keygen = keygen;
      }

      public bool TryGetValue(object key, out long id) => ((ICacheService) this.cacheService).TryGetValue<long>(this.Keygen(key), (string) this.region, out id);

      public bool ContainsKey(object key) => SessionCache.MultiKeyCache.LtImlLwZuSdIjPIcyDTI(this.cacheService, (object) this.Keygen(key), this.region);

      public void Add(Guid authToken, string sessionToken, long val)
      {
        int num = 5;
        long val1;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.CreateKeyRef((object) authToken, (object) sessionToken);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_f6882759fe954178a3d06ac3ec113535 == 0 ? 1 : 1;
              continue;
            case 3:
              ((ICacheService) this.cacheService).GetOrAdd<long>(this.Keygen((object) authToken), (Func<long>) (() => val1), (string) this.region);
              num = 2;
              continue;
            case 4:
              val1 = val;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_4abbe677c5fc4d5db62139f0258d76b0 != 0 ? 0 : 0;
              continue;
            case 5:
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_84c69ba29af74d4d98eb1c6eff57f206 == 0 ? 0 : 4;
              continue;
            default:
              ((ICacheService) this.cacheService).GetOrAdd<long>(this.Keygen((object) authToken), (Func<long>) (() => val1), (string) this.region);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_5fdc7bb2de6a46e3aee161fb4ca1f9af != 0 ? 3 : 3;
              continue;
          }
        }
label_2:;
      }

      public void Remove(object key)
      {
        int num = 4;
        string key1;
        object key2;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.RemoveKeyRef(key, key2);
              num = 5;
              continue;
            case 2:
              if (((ICacheService) this.cacheService).TryGetValue<object>(this.GenKeyRefKey(key), (string) this.region, out key2))
              {
                num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_7db465c05b814758b288a693c21a0469 == 0 ? 0 : 0;
                continue;
              }
              goto label_9;
            case 3:
              ((ICacheService) this.cacheService).Remove(key1, (string) this.region);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_544e4a020f954720b2558a347b6847ed == 0 ? 2 : 2;
              continue;
            case 4:
              key1 = this.Keygen(key);
              num = 3;
              continue;
            case 5:
              goto label_2;
            default:
              SessionCache.MultiKeyCache.ArIKd0wZw2PUXqNnfLtU(this.cacheService, (object) this.Keygen(key2), this.region);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 1 : 0;
              continue;
          }
        }
label_2:
        return;
label_9:;
      }

      private void CreateKeyRef(object key1, object key2)
      {
        int num = 1;
        object key2_1;
        object key1_1;
        while (true)
        {
          switch (num)
          {
            case 1:
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_60b9832b9a784d58bf9142db4a464180 != 0 ? 0 : 0;
              continue;
            case 2:
              key1_1 = key1;
              num = 3;
              continue;
            case 3:
              ((ICacheService) this.cacheService).GetOrAdd<object>(this.GenKeyRefKey(key1_1), (Func<object>) (() => key2_1), (string) this.region);
              num = 5;
              continue;
            case 4:
              goto label_2;
            case 5:
              ((ICacheService) this.cacheService).GetOrAdd<object>(this.GenKeyRefKey(key2_1), (Func<object>) (() => key1_1), (string) this.region);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_abd98844de8649e4a87ffa6ca485aee9 == 0 ? 3 : 4;
              continue;
            default:
              key2_1 = key2;
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_873b31ff0e2a4151b870a0522c508a4f != 0 ? 1 : 2;
              continue;
          }
        }
label_2:;
      }

      private void RemoveKeyRef(object key1, object key2)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              SessionCache.MultiKeyCache.ArIKd0wZw2PUXqNnfLtU(this.cacheService, (object) this.GenKeyRefKey(key2), this.region);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_ab16ea38c4b04f6790571039007ac0b8 != 0 ? 0 : 0;
              continue;
            case 2:
              SessionCache.MultiKeyCache.ArIKd0wZw2PUXqNnfLtU(this.cacheService, (object) this.GenKeyRefKey(key1), this.region);
              num = \u003CModule\u003E\u007Bb43de956\u002D07de\u002D4797\u002D8c8e\u002D245f9d9092b3\u007D.m_a336a3997b6b4820b3411de15dcaec7d != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      private string GenKeyRefKey(object key1) => string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(658384612 ^ 658387090), key1, SessionCache.MultiKeyCache.TLHo1pwZbsdMSpgPd7wr(-624171910 - 757669187 ^ -1381764731));

      internal static bool zrYT3Kw0HXa3937kp1Ng() => SessionCache.MultiKeyCache.TnMcrNw02QELrZxXuVQC == null;

      internal static SessionCache.MultiKeyCache lB9b3kw0zpLIB2gTwlKP() => (SessionCache.MultiKeyCache) SessionCache.MultiKeyCache.TnMcrNw02QELrZxXuVQC;

      internal static bool LtImlLwZuSdIjPIcyDTI([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Contains((string) obj1, (string) obj2);

      internal static void ArIKd0wZw2PUXqNnfLtU([In] object obj0, [In] object obj1, [In] object obj2) => ((ICacheService) obj0).Remove((string) obj1, (string) obj2);

      internal static object TLHo1pwZbsdMSpgPd7wr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }
  }
}
